namespace SerialTerminal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AppendNewlineCheckbox = new System.Windows.Forms.CheckBox();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateTextBox = new System.Windows.Forms.TextBox();
            this.SentListBox = new SerialTerminal.Controls.FormattedListBox();
            this.ReceivedListBox = new SerialTerminal.Controls.FormattedListBox();
            this.ExportSessionButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SentListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReceivedListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ConnectButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SendButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.InputTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AppendNewlineCheckbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComPortComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BaudRateTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExportSessionButton, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 724);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.ConnectButton, 2);
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectButton.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(753, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(194, 24);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.Control;
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(753, 33);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(94, 24);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendHexButton_Click);
            // 
            // InputTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.InputTextBox, 2);
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(3, 33);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(594, 23);
            this.InputTextBox.TabIndex = 4;
            this.InputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
            // 
            // AppendNewlineCheckbox
            // 
            this.AppendNewlineCheckbox.AutoSize = true;
            this.AppendNewlineCheckbox.Checked = true;
            this.AppendNewlineCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendNewlineCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppendNewlineCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppendNewlineCheckbox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppendNewlineCheckbox.Location = new System.Drawing.Point(603, 33);
            this.AppendNewlineCheckbox.Name = "AppendNewlineCheckbox";
            this.AppendNewlineCheckbox.Size = new System.Drawing.Size(144, 24);
            this.AppendNewlineCheckbox.TabIndex = 5;
            this.AppendNewlineCheckbox.Text = "Append Newline";
            this.AppendNewlineCheckbox.UseVisualStyleBackColor = true;
            this.AppendNewlineCheckbox.CheckedChanged += new System.EventHandler(this.AppendNewlineCheckbox_CheckedChanged);
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(3, 3);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(444, 23);
            this.ComPortComboBox.TabIndex = 6;
            // 
            // BaudRateTextBox
            // 
            this.BaudRateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaudRateTextBox.Enabled = false;
            this.BaudRateTextBox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateTextBox.Location = new System.Drawing.Point(453, 3);
            this.BaudRateTextBox.Name = "BaudRateTextBox";
            this.BaudRateTextBox.Size = new System.Drawing.Size(144, 23);
            this.BaudRateTextBox.TabIndex = 7;
            this.BaudRateTextBox.Text = "57600";
            this.BaudRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SentListBox
            // 
            this.SentListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SentListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SentListBox.Font = new System.Drawing.Font("Droid Sans Mono", 9F);
            this.SentListBox.FormattingEnabled = true;
            this.SentListBox.ItemHeight = 22;
            this.SentListBox.Items.AddRange(new object[] {
            "Sent Messages"});
            this.SentListBox.Location = new System.Drawing.Point(3, 63);
            this.SentListBox.Name = "SentListBox";
            this.SentListBox.Size = new System.Drawing.Size(444, 658);
            this.SentListBox.TabIndex = 11;
            this.SentListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SentListBox_DrawItem);
            this.SentListBox.SelectedIndexChanged += new System.EventHandler(this.SentListBox_SelectedIndexChanged);
            // 
            // ReceivedListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ReceivedListBox, 4);
            this.ReceivedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceivedListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReceivedListBox.Font = new System.Drawing.Font("Droid Sans Mono", 9F);
            this.ReceivedListBox.FormattingEnabled = true;
            this.ReceivedListBox.ItemHeight = 22;
            this.ReceivedListBox.Items.AddRange(new object[] {
            "Received Messages"});
            this.ReceivedListBox.Location = new System.Drawing.Point(453, 63);
            this.ReceivedListBox.Name = "ReceivedListBox";
            this.ReceivedListBox.Size = new System.Drawing.Size(494, 658);
            this.ReceivedListBox.TabIndex = 12;
            this.ReceivedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ReceivedListBox_DrawItem);
            this.ReceivedListBox.SelectedIndexChanged += new System.EventHandler(this.ReceivedListBox_SelectedIndexChanged);
            // 
            // ExportSessionButton
            // 
            this.ExportSessionButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExportSessionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportSessionButton.Font = new System.Drawing.Font("Droid Sans", 10F);
            this.ExportSessionButton.Location = new System.Drawing.Point(853, 33);
            this.ExportSessionButton.Name = "ExportSessionButton";
            this.ExportSessionButton.Size = new System.Drawing.Size(94, 24);
            this.ExportSessionButton.TabIndex = 13;
            this.ExportSessionButton.Text = "Export";
            this.ExportSessionButton.UseVisualStyleBackColor = false;
            this.ExportSessionButton.Click += new System.EventHandler(this.ExportSessionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 724);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Blitz Serial Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.CheckBox AppendNewlineCheckbox;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.TextBox BaudRateTextBox;
        private Controls.FormattedListBox SentListBox;
        private Controls.FormattedListBox ReceivedListBox;
        private System.Windows.Forms.Button ExportSessionButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}