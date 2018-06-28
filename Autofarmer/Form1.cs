using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; // For the DllImport
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; // Process

namespace Autofarmer {
	public partial class Autofarmer : Form {
		/*
		Sources about process handler management:
		https://stackoverflow.com/questions/6808831/delete-a-mutex-from-another-process
		https://web.archive.org/web/20161104010036/http://forum.sysinternals.com/topic14546.html
		*/
		[DllImport("ntdll.dll")]
		// NtQuerySystemInformation gives us data about all the handlers in the system
		private static extern uint NtQuerySystemInformation(uint SystemInformationClass, IntPtr SystemInformation,
			int SystemInformationLength, ref int nLength);

		[DllImport("user32.dll")]
		private static extern int SetWindowText(IntPtr hWnd, string text);

		//[DllImport("user32.dll")]
		//private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
		//private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		private Process growtopia = new Process();
		private List<Process> processes = new List<Process>(); // List of open Growtopia processes

		private string _growtopiaPath = "";
		private string GrowtopiaPath
		{
			get {
				return _growtopiaPath;
			}
			set {
				if (File.Exists(value)) {
					_growtopiaPath = value;
					fileSelectDialog.InitialDirectory = _growtopiaPath;
					fileNameDisplayer.Text = _growtopiaPath;
				} else {
					MessageBox.Show("Incorrect file specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// LayoutKind.Sequential means that the fields should in the same order in the memory as they are declared
		// Pack=1 means the struct will be organised so that each field can be read a byte at a time
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SYSTEM_HANDLE_INFORMATION { // Returned data from SystemHandleInformation
			public int ProcessID;
			public byte ObjectTypeNumber;
			public byte Flags; // 0x01 = PROTECT_FROM_CLOSE, 0x02 = INHERIT
			public ushort Handle;
			public int Object_Pointer;
			public UInt32 GrantedAccess;
		}

		// Closes a mutant handle in an external process that has a specific name
		private void closeProcessMutex(object sender, EventArgs e) {
			Console.WriteLine("Starting handle magic...");
			int nLength = 0;
			IntPtr handlePointer = IntPtr.Zero;
			int sysInfoLength = 0x10000; // How much to allocate to returned data
			IntPtr infoPointer = Marshal.AllocHGlobal(sysInfoLength);
			// 0x10 = SystemHandleInformation, an undocumented SystemInformationClass
			uint result; // NtQuerySystemInformation won't give us the correct buffer size, so we guess it
						 // Assign result of NtQuerySystemInformation to this variable and check if the buffer size is correct
						 // If it's incorrect, it returns STATUS_INFO_LENGTH_MISMATCH (0xc0000004)
			while ((result = NtQuerySystemInformation(0x10, infoPointer, sysInfoLength, ref nLength)) == 0xc0000004) {
				sysInfoLength = nLength;
				Marshal.FreeHGlobal(infoPointer);
				infoPointer = Marshal.AllocHGlobal(nLength);
			}

			byte[] baTemp = new byte[nLength];
			// Copy the data from unmanaged memory to managed 1-byte uint array
			Marshal.Copy(infoPointer, baTemp, 0, nLength);
			// Do we even need the two statements above??? Look into this later.

			long sysHandleCount = 0; // How many handles there are total
			if (Is64Bits()) {
				sysHandleCount = Marshal.ReadInt64(infoPointer);
				handlePointer = new IntPtr(infoPointer.ToInt64() + 8); // Points in bits at the start of a handle
			} else {
				sysHandleCount = Marshal.ReadInt32(infoPointer);
				handlePointer = new IntPtr(infoPointer.ToInt32() + 4); // Ignores 4 first bits instead of 8
			}

			SYSTEM_HANDLE_INFORMATION handleInfoStruct; // The struct to hold info about a single handler
			List<SYSTEM_HANDLE_INFORMATION> handleStructsList = new List<SYSTEM_HANDLE_INFORMATION>(); // List of handle structs

			for (long i = 0; i < sysHandleCount; i++) { // Iterate over handle structs in the handle struct list
				handleInfoStruct = new SYSTEM_HANDLE_INFORMATION();
				if (Is64Bits()) {
					handleInfoStruct = (SYSTEM_HANDLE_INFORMATION)Marshal.PtrToStructure(handlePointer, handleInfoStruct.GetType()); // Convert to struct
					handlePointer = new IntPtr(handlePointer.ToInt64() + Marshal.SizeOf(handleInfoStruct) + 8); // point 8 bits forward to the next handle
				} else {
					handleInfoStruct = (SYSTEM_HANDLE_INFORMATION)Marshal.PtrToStructure(handlePointer, handleInfoStruct.GetType());
					handlePointer = new IntPtr(handlePointer.ToInt64() + Marshal.SizeOf(handleInfoStruct));
				}

				// TODO: Check if handler PID is from any Growtopia processes!
				if (handleInfoStruct.ProcessID != growtopia.Id) { // Check if current handler is from Growtopia
					continue; // If it's not from Growtopia, just skip it
				}

				// TODO: Get the handle path
				string getHandlePath = @"\Sessions\2\BaseNamedObjects\Growtopia";

				if (@"\Sessions\2\BaseNamedObjects\Growtopia" != getHandlePath) {
					continue; // This is not a handle we're looking for
				}

				// TODO: Check for handle type? I don't think it's needed, but who knows!

				Console.WriteLine("PID {0}\tPointer {1}\t\tType {2}",	handleInfoStruct.ProcessID.ToString(), 
																		handleInfoStruct.Object_Pointer.ToString(),
																		handleInfoStruct.ObjectTypeNumber.ToString());
			}

			Console.WriteLine("Handle closed? Maybe indeed.");
		}

		public Autofarmer() {
			InitializeComponent(); // Set size etc. and run Autofarmer_Load()
		}

		private void Autofarmer_Load(object sender, EventArgs e) {
			GrowtopiaPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Appdata\Local\Growtopia\Growtopia.exe"; // Set as Growtopia's default path
        }

		private void selectFile(object sender, EventArgs e) {
			DialogResult result = fileSelectDialog.ShowDialog();
			if (result == DialogResult.OK) {
				GrowtopiaPath = fileSelectDialog.FileName;
			}
		}

		private void openGrowtopia(object sender, EventArgs e) {
			if (GrowtopiaPath != "") { // Make sure Growtopia's path is set
				fileSelectButton.Enabled = false;
				growtopia.StartInfo.FileName = GrowtopiaPath;
				growtopia.Start();
				Thread.Sleep(500);
				if (growtopia.WaitForInputIdle(15000)) { // Wait for 15 seconds for process to become idle
					SetWindowText(growtopia.MainWindowHandle, "Autofarmer by Just Another Channel");
					// SWP_NOMOVE means that the x/y arguments should be ignored (0x0002)
					//SetWindowPos(growtopia.MainWindowHandle, new IntPtr(1), 0, 0, 1024, 768, 0x0002);
				} else {
					MessageBox.Show("Idle forever", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Please set a file path for Growtopia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private static bool Is64Bits() {
			return Marshal.SizeOf(typeof(IntPtr)) == 8 ? true : false;
		}
	}
}
