using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;

namespace Autofarmer {
	public partial class Autofarm {

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		[StructLayout(LayoutKind.Sequential)]
		private struct RECT {
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
		}

		IKeyboardMouseEvents kmEvents = Hook.GlobalEvents(); // GlobalEvents() or AppEvents() ?

		private void HookListener() {
			Console.WriteLine("HOOKING");
			kmEvents.KeyDown += HookKeyDown;
			kmEvents.KeyUp += HookKeyUp;
			kmEvents.MouseDownExt += HookMouseDown;
			kmEvents.MouseUpExt += HookMouseUp;
		}

		private void UnhookListener() {
			Console.WriteLine("UNHOOKING");
			if (kmEvents == null) return;
			kmEvents.KeyDown -= HookKeyDown;
			kmEvents.KeyUp -= HookKeyUp;
			kmEvents.MouseDownExt -= HookMouseDown;
			kmEvents.MouseUpExt -= HookMouseUp;

			kmEvents.Dispose();
		}

		private void HookKeyDown(object sender, KeyEventArgs e) {
			e.Handled = true;
			IntPtr hWnd;
			IntPtr active = GetForegroundWindow();

			// The way I'm doing it right now is kind of awful
			// It's low-level, even though I don't need it to be
			// And it's global, even though I don't need it to be
			if (GetHandleProcessName(active) == "Growtopia") {
				foreach (Process process in processes) {
					Console.WriteLine("KeyDown: \t{0}", e.KeyCode);
					hWnd = process.MainWindowHandle;
					// WM_KEYDOWN = 0x100
					PostMessage(hWnd, 0x100, (IntPtr)e.KeyCode, IntPtr.Zero);
				}
			}
				
		}

		private void HookKeyUp(object sender, KeyEventArgs e) {
			e.Handled = true;
			IntPtr hWnd;
			IntPtr active = GetForegroundWindow();

			if (GetHandleProcessName(active) == "Growtopia") {
				foreach (Process process in processes) {
					Console.WriteLine("KeyUp: \t{0}", e.KeyCode);
					hWnd = process.MainWindowHandle;
					// WM_KEYUP = 0x101
					PostMessage(hWnd, 0x101, (IntPtr)e.KeyCode, IntPtr.Zero);
				}
			} 
		}

		private void HookMouseDown(object sender, MouseEventExtArgs e) {
			IntPtr hWnd;
			IntPtr active = GetForegroundWindow();

			if (GetHandleProcessName(active) == "Growtopia") {
				e.Handled = true; // Prevent further processing of the event in other applications
				int relativeX;
				int relativeY;

				foreach (Process process in processes) {
					hWnd = process.MainWindowHandle;

					RECT relativeBox = new RECT();
					GetWindowRect(active, ref relativeBox);

					relativeX = e.Point.X - relativeBox.Left;
					relativeY = e.Point.Y - relativeBox.Top;

					//Console.WriteLine("X: " + e.Point.X + " Y: " + e.Point.Y);
					PostMessage(hWnd, 0x201, new IntPtr(0x1), (IntPtr)((relativeY << 16) | (relativeX & 0xffff)));
				}
			}	
		}

		private void HookMouseUp(object sender, MouseEventExtArgs e) {
			IntPtr hWnd;
			IntPtr active = GetForegroundWindow();
			if (GetHandleProcessName(active) == "Growtopia") {
				e.Handled = true;
				int relativeX;
				int relativeY;

				foreach (Process process in processes) {
					hWnd = process.MainWindowHandle;

					RECT relativeBox = new RECT();
					GetWindowRect(active, ref relativeBox);

					relativeX = e.Point.X - relativeBox.Left;
					relativeY = e.Point.Y - relativeBox.Top;

					PostMessage(hWnd, 0x202, new IntPtr(0x1), (IntPtr)((relativeY << 16) | (relativeX & 0xffff)));
				}
			}	
		}

		private string GetHandleProcessName(IntPtr hWnd) {
			//IntPtr hWnd = GetForegroundWindow();

			if (hWnd == null)
				return "Unknown";

			uint pid;
			GetWindowThreadProcessId(hWnd, out pid);

			foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses()) {
				if (p.Id == pid)
					return p.ProcessName;
			}

			return "Unknown";
		}
	}
}
