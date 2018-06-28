namespace Autofarmer {
	partial class Autofarmer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.fileSelectDialog = new System.Windows.Forms.OpenFileDialog();
			this.fileSelectButton = new System.Windows.Forms.Button();
			this.fileNameDisplayer = new System.Windows.Forms.TextBox();
			this.openGTButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.statusMessage = new System.Windows.Forms.Label();
			this.numberInput = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
			this.SuspendLayout();
			// 
			// fileSelectDialog
			// 
			this.fileSelectDialog.FileName = "Growtopia.exe";
			// 
			// fileSelectButton
			// 
			this.fileSelectButton.Location = new System.Drawing.Point(12, 9);
			this.fileSelectButton.Name = "fileSelectButton";
			this.fileSelectButton.Size = new System.Drawing.Size(136, 23);
			this.fileSelectButton.TabIndex = 0;
			this.fileSelectButton.TabStop = false;
			this.fileSelectButton.Text = "Select Growtopia...";
			this.fileSelectButton.UseVisualStyleBackColor = true;
			this.fileSelectButton.Click += new System.EventHandler(this.SelectFile);
			// 
			// fileNameDisplayer
			// 
			this.fileNameDisplayer.Enabled = false;
			this.fileNameDisplayer.Location = new System.Drawing.Point(154, 11);
			this.fileNameDisplayer.Name = "fileNameDisplayer";
			this.fileNameDisplayer.ReadOnly = true;
			this.fileNameDisplayer.Size = new System.Drawing.Size(331, 20);
			this.fileNameDisplayer.TabIndex = 0;
			this.fileNameDisplayer.TabStop = false;
			this.fileNameDisplayer.Text = "Please select Growtopia.exe";
			// 
			// openGTButton
			// 
			this.openGTButton.Location = new System.Drawing.Point(12, 38);
			this.openGTButton.Name = "openGTButton";
			this.openGTButton.Size = new System.Drawing.Size(136, 39);
			this.openGTButton.TabIndex = 0;
			this.openGTButton.TabStop = false;
			this.openGTButton.Text = "Open GT (0 open)";
			this.openGTButton.UseVisualStyleBackColor = true;
			this.openGTButton.Click += new System.EventHandler(this.OpenGrowtopia);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(349, 356);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Debug: Close mutant";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.debugCloseMutant);
			// 
			// statusMessage
			// 
			this.statusMessage.AutoSize = true;
			this.statusMessage.Location = new System.Drawing.Point(213, 42);
			this.statusMessage.MaximumSize = new System.Drawing.Size(280, 0);
			this.statusMessage.Name = "statusMessage";
			this.statusMessage.Size = new System.Drawing.Size(187, 13);
			this.statusMessage.TabIndex = 2;
			this.statusMessage.Text = "Select amount of Growtopia\'s to open.";
			// 
			// numberInput
			// 
			this.numberInput.Location = new System.Drawing.Point(154, 40);
			this.numberInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberInput.Name = "numberInput";
			this.numberInput.Size = new System.Drawing.Size(53, 20);
			this.numberInput.TabIndex = 3;
			this.numberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Autofarmer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 391);
			this.Controls.Add(this.numberInput);
			this.Controls.Add(this.statusMessage);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.openGTButton);
			this.Controls.Add(this.fileNameDisplayer);
			this.Controls.Add(this.fileSelectButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Autofarmer";
			this.Text = "Autofarmer by Just Another Channel";
			this.Load += new System.EventHandler(this.Autofarmer_Load);
			((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog fileSelectDialog;
		private System.Windows.Forms.Button fileSelectButton;
		private System.Windows.Forms.TextBox fileNameDisplayer;
		private System.Windows.Forms.Button openGTButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label statusMessage;
		private System.Windows.Forms.NumericUpDown numberInput;
	}
}

