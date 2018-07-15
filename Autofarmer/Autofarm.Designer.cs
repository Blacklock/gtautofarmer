namespace Autofarmer {
	partial class Autofarm {
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.fileSelectDialog = new System.Windows.Forms.OpenFileDialog();
			this.fileSelectButton = new System.Windows.Forms.Button();
			this.fileNameDisplayer = new System.Windows.Forms.TextBox();
			this.openGTButton = new System.Windows.Forms.Button();
			this.toggleAutofarmer = new System.Windows.Forms.Button();
			this.statusMessage = new System.Windows.Forms.Label();
			this.numberInput = new System.Windows.Forms.NumericUpDown();
			this.processList = new System.Windows.Forms.DataGridView();
			this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Multibox = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.settingsLabel1 = new System.Windows.Forms.Label();
			this.autoFarmerType = new System.Windows.Forms.ComboBox();
			this.autoFarmerTypeOK = new System.Windows.Forms.Button();
			this.settingsLabel2 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.multiboxToggle = new System.Windows.Forms.ComboBox();
			this.multiboxOK = new System.Windows.Forms.Button();
			this.toggleMultibox = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
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
			// toggleAutofarmer
			// 
			this.toggleAutofarmer.Location = new System.Drawing.Point(15, 181);
			this.toggleAutofarmer.Name = "toggleAutofarmer";
			this.toggleAutofarmer.Size = new System.Drawing.Size(185, 23);
			this.toggleAutofarmer.TabIndex = 1;
			this.toggleAutofarmer.Text = "Autofarmers: Off";
			this.toggleAutofarmer.UseVisualStyleBackColor = true;
			this.toggleAutofarmer.Click += new System.EventHandler(this.ToggleAutofarmers);
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
			// processList
			// 
			this.processList.AllowUserToAddRows = false;
			this.processList.AllowUserToDeleteRows = false;
			this.processList.AllowUserToResizeColumns = false;
			this.processList.AllowUserToResizeRows = false;
			this.processList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.processList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.processList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.processList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Checkbox,
			this.Number,
			this.Active,
			this.Multibox,
			this.PID});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.processList.DefaultCellStyle = dataGridViewCellStyle2;
			this.processList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.processList.Location = new System.Drawing.Point(206, 83);
			this.processList.Name = "processList";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.processList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.processList.RowHeadersVisible = false;
			this.processList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.processList.Size = new System.Drawing.Size(279, 150);
			this.processList.TabIndex = 4;
			// 
			// Checkbox
			// 
			this.Checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Checkbox.FillWeight = 40F;
			this.Checkbox.HeaderText = "";
			this.Checkbox.Name = "Checkbox";
			// 
			// Number
			// 
			this.Number.HeaderText = "#";
			this.Number.Name = "Number";
			this.Number.Width = 35;
			// 
			// Active
			// 
			this.Active.HeaderText = "Active Autofarmer";
			this.Active.Name = "Active";
			this.Active.Width = 80;
			// 
			// Multibox
			// 
			this.Multibox.HeaderText = "Multibox";
			this.Multibox.Name = "Multibox";
			this.Multibox.Width = 65;
			// 
			// PID
			// 
			this.PID.HeaderText = "Process ID";
			this.PID.Name = "PID";
			this.PID.Width = 60;
			// 
			// settingsLabel1
			// 
			this.settingsLabel1.AutoSize = true;
			this.settingsLabel1.Location = new System.Drawing.Point(12, 83);
			this.settingsLabel1.Name = "settingsLabel1";
			this.settingsLabel1.Size = new System.Drawing.Size(85, 13);
			this.settingsLabel1.TabIndex = 5;
			this.settingsLabel1.Text = "Autofarmer Type";
			this.toolTip.SetToolTip(this.settingsLabel1, "What autofarming script should be used");
			// 
			// autoFarmerType
			// 
			this.autoFarmerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.autoFarmerType.FormattingEnabled = true;
			this.autoFarmerType.Items.AddRange(new object[] {
			"None",
			"PortalRows",
			"Magplant",
			"PlaceTake",
			"Plant",
			"Drop"});
			this.autoFarmerType.Location = new System.Drawing.Point(15, 100);
			this.autoFarmerType.Name = "autoFarmerType";
			this.autoFarmerType.Size = new System.Drawing.Size(134, 21);
			this.autoFarmerType.TabIndex = 6;
			// 
			// autoFarmerTypeOK
			// 
			this.autoFarmerTypeOK.Location = new System.Drawing.Point(154, 100);
			this.autoFarmerTypeOK.Name = "autoFarmerTypeOK";
			this.autoFarmerTypeOK.Size = new System.Drawing.Size(46, 21);
			this.autoFarmerTypeOK.TabIndex = 7;
			this.autoFarmerTypeOK.Text = "OK";
			this.autoFarmerTypeOK.UseVisualStyleBackColor = true;
			this.autoFarmerTypeOK.Click += new System.EventHandler(this.changeAutofarmer);
			// 
			// settingsLabel2
			// 
			this.settingsLabel2.AutoSize = true;
			this.settingsLabel2.Location = new System.Drawing.Point(12, 124);
			this.settingsLabel2.Name = "settingsLabel2";
			this.settingsLabel2.Size = new System.Drawing.Size(46, 13);
			this.settingsLabel2.TabIndex = 8;
			this.settingsLabel2.Text = "Multibox";
			this.toolTip.SetToolTip(this.settingsLabel2, "All keypresses and clicks are mirrored to other multibox instances");
			// 
			// multiboxToggle
			// 
			this.multiboxToggle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.multiboxToggle.FormattingEnabled = true;
			this.multiboxToggle.Items.AddRange(new object[] {
			"Enabled",
			"Disabled"});
			this.multiboxToggle.Location = new System.Drawing.Point(15, 140);
			this.multiboxToggle.Name = "multiboxToggle";
			this.multiboxToggle.Size = new System.Drawing.Size(134, 21);
			this.multiboxToggle.TabIndex = 9;
			// 
			// multiboxOK
			// 
			this.multiboxOK.Location = new System.Drawing.Point(154, 140);
			this.multiboxOK.Name = "multiboxOK";
			this.multiboxOK.Size = new System.Drawing.Size(46, 21);
			this.multiboxOK.TabIndex = 10;
			this.multiboxOK.Text = "OK";
			this.multiboxOK.UseVisualStyleBackColor = true;
			this.multiboxOK.Click += new System.EventHandler(this.changeMultibox);
			// 
			// toggleMultibox
			// 
			this.toggleMultibox.Location = new System.Drawing.Point(15, 210);
			this.toggleMultibox.Name = "toggleMultibox";
			this.toggleMultibox.Size = new System.Drawing.Size(185, 23);
			this.toggleMultibox.TabIndex = 11;
			this.toggleMultibox.Text = "Multibox: Off";
			this.toggleMultibox.UseVisualStyleBackColor = true;
			this.toggleMultibox.Click += new System.EventHandler(this.ToggleMultiboxes);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(206, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(279, 11);
			this.button1.TabIndex = 12;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Autofarmer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 246);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.toggleMultibox);
			this.Controls.Add(this.multiboxOK);
			this.Controls.Add(this.multiboxToggle);
			this.Controls.Add(this.settingsLabel2);
			this.Controls.Add(this.autoFarmerTypeOK);
			this.Controls.Add(this.autoFarmerType);
			this.Controls.Add(this.settingsLabel1);
			this.Controls.Add(this.processList);
			this.Controls.Add(this.numberInput);
			this.Controls.Add(this.statusMessage);
			this.Controls.Add(this.toggleAutofarmer);
			this.Controls.Add(this.openGTButton);
			this.Controls.Add(this.fileNameDisplayer);
			this.Controls.Add(this.fileSelectButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Autofarmer";
			this.Text = "Autofarmer by Just Another Channel";
			this.Load += new System.EventHandler(this.Autofarmer_Load);
			((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog fileSelectDialog;
		private System.Windows.Forms.Button fileSelectButton;
		private System.Windows.Forms.TextBox fileNameDisplayer;
		private System.Windows.Forms.Button openGTButton;
		private System.Windows.Forms.Button toggleAutofarmer;
		private System.Windows.Forms.Label statusMessage;
		private System.Windows.Forms.NumericUpDown numberInput;
		private System.Windows.Forms.DataGridView processList;
		private System.Windows.Forms.Label settingsLabel1;
		private System.Windows.Forms.ComboBox autoFarmerType;
		private System.Windows.Forms.Button autoFarmerTypeOK;
		private System.Windows.Forms.Label settingsLabel2;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ComboBox multiboxToggle;
		private System.Windows.Forms.Button multiboxOK;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Active;
		private System.Windows.Forms.DataGridViewTextBoxColumn Multibox;
		private System.Windows.Forms.DataGridViewTextBoxColumn PID;
		private System.Windows.Forms.Button toggleMultibox;
		private System.Windows.Forms.Button button1;
	}
}

