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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLogSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SentListBox = new SerialTerminal.Controls.FormattedListBox();
            this.ReceivedListBox = new SerialTerminal.Controls.FormattedListBox();
            this.MenuTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ResetOnConnectCheckbox = new System.Windows.Forms.CheckBox();
            this.ExportSessionButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AppendNewlineCheckbox = new System.Windows.Forms.CheckBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.BaudRateTextBox = new System.Windows.Forms.TextBox();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.MessageDataTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ayloadHeaderLabel = new System.Windows.Forms.Label();
            this.PayloadLabel = new System.Windows.Forms.Label();
            this.TimestampHeaderLabel = new System.Windows.Forms.Label();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.FlagsHeaderLabel = new System.Windows.Forms.Label();
            this.FlagsLabel = new System.Windows.Forms.Label();
            this.TypeHeaderLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.IdHeaderLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ApplicationMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitData0x00C0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendID0x0090ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionTypeHeaderLabel = new System.Windows.Forms.Label();
            this.InstructionTypeLabel = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageLogSplitContainer)).BeginInit();
            this.MessageLogSplitContainer.Panel1.SuspendLayout();
            this.MessageLogSplitContainer.Panel2.SuspendLayout();
            this.MessageLogSplitContainer.SuspendLayout();
            this.MenuTableLayout.SuspendLayout();
            this.MessageDataTableLayout.SuspendLayout();
            this.ApplicationMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.BackColor = System.Drawing.Color.White;
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayout.Controls.Add(this.MessageLogSplitContainer, 0, 1);
            this.MainTableLayout.Controls.Add(this.MenuTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.MessageDataTableLayout, 1, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 24);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.Size = new System.Drawing.Size(1370, 700);
            this.MainTableLayout.TabIndex = 0;
            // 
            // MessageLogSplitContainer
            // 
            this.MessageLogSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLogSplitContainer.Location = new System.Drawing.Point(3, 73);
            this.MessageLogSplitContainer.Name = "MessageLogSplitContainer";
            // 
            // MessageLogSplitContainer.Panel1
            // 
            this.MessageLogSplitContainer.Panel1.Controls.Add(this.SentListBox);
            // 
            // MessageLogSplitContainer.Panel2
            // 
            this.MessageLogSplitContainer.Panel2.Controls.Add(this.ReceivedListBox);
            this.MessageLogSplitContainer.Size = new System.Drawing.Size(1021, 634);
            this.MessageLogSplitContainer.SplitterDistance = 523;
            this.MessageLogSplitContainer.TabIndex = 15;
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
            this.SentListBox.Location = new System.Drawing.Point(0, 0);
            this.SentListBox.Name = "SentListBox";
            this.SentListBox.Size = new System.Drawing.Size(523, 634);
            this.SentListBox.TabIndex = 12;
            this.SentListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SentListBox_DrawItem);
            this.SentListBox.SelectedIndexChanged += new System.EventHandler(this.SentListBox_SelectedIndexChanged);
            // 
            // ReceivedListBox
            // 
            this.ReceivedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceivedListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReceivedListBox.Font = new System.Drawing.Font("Droid Sans Mono", 9F);
            this.ReceivedListBox.FormattingEnabled = true;
            this.ReceivedListBox.ItemHeight = 22;
            this.ReceivedListBox.Items.AddRange(new object[] {
            "Received Messages"});
            this.ReceivedListBox.Location = new System.Drawing.Point(0, 0);
            this.ReceivedListBox.Name = "ReceivedListBox";
            this.ReceivedListBox.Size = new System.Drawing.Size(494, 634);
            this.ReceivedListBox.TabIndex = 13;
            this.ReceivedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ReceivedListBox_DrawItem);
            this.ReceivedListBox.SelectedIndexChanged += new System.EventHandler(this.ReceivedListBox_SelectedIndexChanged);
            // 
            // MenuTableLayout
            // 
            this.MenuTableLayout.ColumnCount = 6;
            this.MainTableLayout.SetColumnSpan(this.MenuTableLayout, 2);
            this.MenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.MenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MenuTableLayout.Controls.Add(this.ResetOnConnectCheckbox, 2, 0);
            this.MenuTableLayout.Controls.Add(this.ExportSessionButton, 4, 1);
            this.MenuTableLayout.Controls.Add(this.SendButton, 3, 1);
            this.MenuTableLayout.Controls.Add(this.InputTextBox, 0, 1);
            this.MenuTableLayout.Controls.Add(this.AppendNewlineCheckbox, 2, 1);
            this.MenuTableLayout.Controls.Add(this.ConnectButton, 3, 0);
            this.MenuTableLayout.Controls.Add(this.BaudRateTextBox, 1, 0);
            this.MenuTableLayout.Controls.Add(this.ComPortComboBox, 0, 0);
            this.MenuTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTableLayout.Location = new System.Drawing.Point(3, 3);
            this.MenuTableLayout.Name = "MenuTableLayout";
            this.MenuTableLayout.RowCount = 2;
            this.MenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTableLayout.Size = new System.Drawing.Size(1364, 64);
            this.MenuTableLayout.TabIndex = 16;
            // 
            // ResetOnConnectCheckbox
            // 
            this.ResetOnConnectCheckbox.AutoSize = true;
            this.ResetOnConnectCheckbox.Checked = true;
            this.ResetOnConnectCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResetOnConnectCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetOnConnectCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetOnConnectCheckbox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetOnConnectCheckbox.Location = new System.Drawing.Point(603, 3);
            this.ResetOnConnectCheckbox.Name = "ResetOnConnectCheckbox";
            this.ResetOnConnectCheckbox.Size = new System.Drawing.Size(144, 26);
            this.ResetOnConnectCheckbox.TabIndex = 15;
            this.ResetOnConnectCheckbox.Text = "Reset on Connect";
            this.ResetOnConnectCheckbox.UseVisualStyleBackColor = true;
            this.ResetOnConnectCheckbox.CheckedChanged += new System.EventHandler(this.ResetOnConnectCheckbox_CheckedChanged);
            // 
            // ExportSessionButton
            // 
            this.ExportSessionButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExportSessionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportSessionButton.Font = new System.Drawing.Font("Droid Sans", 10F);
            this.ExportSessionButton.Location = new System.Drawing.Point(853, 35);
            this.ExportSessionButton.Name = "ExportSessionButton";
            this.ExportSessionButton.Size = new System.Drawing.Size(94, 26);
            this.ExportSessionButton.TabIndex = 14;
            this.ExportSessionButton.Text = "Export";
            this.ExportSessionButton.UseVisualStyleBackColor = false;
            this.ExportSessionButton.Click += new System.EventHandler(this.ExportSessionButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.Control;
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(753, 35);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(94, 26);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendHexButton_Click);
            // 
            // InputTextBox
            // 
            this.MenuTableLayout.SetColumnSpan(this.InputTextBox, 2);
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(3, 35);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(594, 23);
            this.InputTextBox.TabIndex = 11;
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
            this.AppendNewlineCheckbox.Location = new System.Drawing.Point(603, 35);
            this.AppendNewlineCheckbox.Name = "AppendNewlineCheckbox";
            this.AppendNewlineCheckbox.Size = new System.Drawing.Size(144, 26);
            this.AppendNewlineCheckbox.TabIndex = 10;
            this.AppendNewlineCheckbox.Text = "Append Newline";
            this.AppendNewlineCheckbox.UseVisualStyleBackColor = true;
            this.AppendNewlineCheckbox.CheckedChanged += new System.EventHandler(this.AppendNewlineCheckbox_CheckedChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.Control;
            this.MenuTableLayout.SetColumnSpan(this.ConnectButton, 2);
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectButton.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(753, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(194, 26);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // BaudRateTextBox
            // 
            this.BaudRateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaudRateTextBox.Enabled = false;
            this.BaudRateTextBox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateTextBox.Location = new System.Drawing.Point(403, 3);
            this.BaudRateTextBox.Name = "BaudRateTextBox";
            this.BaudRateTextBox.Size = new System.Drawing.Size(194, 23);
            this.BaudRateTextBox.TabIndex = 8;
            this.BaudRateTextBox.Text = "57600";
            this.BaudRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(3, 3);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(394, 23);
            this.ComPortComboBox.TabIndex = 7;
            // 
            // MessageDataTableLayout
            // 
            this.MessageDataTableLayout.ColumnCount = 2;
            this.MessageDataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.MessageDataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.MessageDataTableLayout.Controls.Add(this.InstructionTypeLabel, 1, 2);
            this.MessageDataTableLayout.Controls.Add(this.InstructionTypeHeaderLabel, 0, 2);
            this.MessageDataTableLayout.Controls.Add(this.ayloadHeaderLabel, 0, 5);
            this.MessageDataTableLayout.Controls.Add(this.PayloadLabel, 1, 5);
            this.MessageDataTableLayout.Controls.Add(this.TimestampHeaderLabel, 0, 4);
            this.MessageDataTableLayout.Controls.Add(this.TimestampLabel, 1, 4);
            this.MessageDataTableLayout.Controls.Add(this.FlagsHeaderLabel, 0, 3);
            this.MessageDataTableLayout.Controls.Add(this.FlagsLabel, 1, 3);
            this.MessageDataTableLayout.Controls.Add(this.TypeHeaderLabel, 0, 1);
            this.MessageDataTableLayout.Controls.Add(this.TypeLabel, 1, 1);
            this.MessageDataTableLayout.Controls.Add(this.IdHeaderLabel, 0, 0);
            this.MessageDataTableLayout.Controls.Add(this.IdLabel, 1, 0);
            this.MessageDataTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageDataTableLayout.Location = new System.Drawing.Point(1030, 73);
            this.MessageDataTableLayout.Name = "MessageDataTableLayout";
            this.MessageDataTableLayout.RowCount = 6;
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MessageDataTableLayout.Size = new System.Drawing.Size(337, 634);
            this.MessageDataTableLayout.TabIndex = 17;
            // 
            // ayloadHeaderLabel
            // 
            this.ayloadHeaderLabel.AutoSize = true;
            this.ayloadHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ayloadHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayloadHeaderLabel.Location = new System.Drawing.Point(3, 150);
            this.ayloadHeaderLabel.Name = "ayloadHeaderLabel";
            this.ayloadHeaderLabel.Size = new System.Drawing.Size(111, 484);
            this.ayloadHeaderLabel.TabIndex = 8;
            this.ayloadHeaderLabel.Text = "Payload";
            this.ayloadHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayloadLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.PayloadLabel.Location = new System.Drawing.Point(120, 150);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new System.Drawing.Size(214, 484);
            this.PayloadLabel.TabIndex = 9;
            this.PayloadLabel.Text = " ";
            // 
            // TimestampHeaderLabel
            // 
            this.TimestampHeaderLabel.AutoSize = true;
            this.TimestampHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimestampHeaderLabel.Location = new System.Drawing.Point(3, 119);
            this.TimestampHeaderLabel.Name = "TimestampHeaderLabel";
            this.TimestampHeaderLabel.Size = new System.Drawing.Size(111, 31);
            this.TimestampHeaderLabel.TabIndex = 6;
            this.TimestampHeaderLabel.Text = "Timestamp";
            this.TimestampHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.AutoSize = true;
            this.TimestampLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.TimestampLabel.Location = new System.Drawing.Point(120, 119);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(214, 31);
            this.TimestampLabel.TabIndex = 7;
            this.TimestampLabel.Text = " ";
            // 
            // FlagsHeaderLabel
            // 
            this.FlagsHeaderLabel.AutoSize = true;
            this.FlagsHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlagsHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagsHeaderLabel.Location = new System.Drawing.Point(3, 90);
            this.FlagsHeaderLabel.Name = "FlagsHeaderLabel";
            this.FlagsHeaderLabel.Size = new System.Drawing.Size(111, 29);
            this.FlagsHeaderLabel.TabIndex = 4;
            this.FlagsHeaderLabel.Text = "Flags";
            this.FlagsHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FlagsLabel
            // 
            this.FlagsLabel.AutoSize = true;
            this.FlagsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlagsLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.FlagsLabel.Location = new System.Drawing.Point(120, 90);
            this.FlagsLabel.Name = "FlagsLabel";
            this.FlagsLabel.Size = new System.Drawing.Size(214, 29);
            this.FlagsLabel.TabIndex = 5;
            this.FlagsLabel.Text = " ";
            // 
            // TypeHeaderLabel
            // 
            this.TypeHeaderLabel.AutoSize = true;
            this.TypeHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeHeaderLabel.Location = new System.Drawing.Point(3, 30);
            this.TypeHeaderLabel.Name = "TypeHeaderLabel";
            this.TypeHeaderLabel.Size = new System.Drawing.Size(111, 30);
            this.TypeHeaderLabel.TabIndex = 2;
            this.TypeHeaderLabel.Text = "Type";
            this.TypeHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.TypeLabel.Location = new System.Drawing.Point(120, 30);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(214, 30);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = " ";
            // 
            // IdHeaderLabel
            // 
            this.IdHeaderLabel.AutoSize = true;
            this.IdHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.IdHeaderLabel.Name = "IdHeaderLabel";
            this.IdHeaderLabel.Size = new System.Drawing.Size(111, 30);
            this.IdHeaderLabel.TabIndex = 0;
            this.IdHeaderLabel.Text = "ID";
            this.IdHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.IdLabel.Location = new System.Drawing.Point(120, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(214, 30);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = " ";
            // 
            // ApplicationMenuStrip
            // 
            this.ApplicationMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.ApplicationMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ApplicationMenuStrip.Name = "ApplicationMenuStrip";
            this.ApplicationMenuStrip.Size = new System.Drawing.Size(1370, 24);
            this.ApplicationMenuStrip.TabIndex = 1;
            this.ApplicationMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportSessionButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transmitData0x00C0ToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendID0x0090ToolStripMenuItem,
            this.requestStatusToolStripMenuItem});
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.messageToolStripMenuItem.Text = "Message";
            // 
            // transmitData0x00C0ToolStripMenuItem
            // 
            this.transmitData0x00C0ToolStripMenuItem.Name = "transmitData0x00C0ToolStripMenuItem";
            this.transmitData0x00C0ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.transmitData0x00C0ToolStripMenuItem.Tag = "00C0";
            this.transmitData0x00C0ToolStripMenuItem.Text = "&Transmit Data (0x00C0)";
            this.transmitData0x00C0ToolStripMenuItem.Click += new System.EventHandler(this.InsertMessageToolBarItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // sendID0x0090ToolStripMenuItem
            // 
            this.sendID0x0090ToolStripMenuItem.Name = "sendID0x0090ToolStripMenuItem";
            this.sendID0x0090ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sendID0x0090ToolStripMenuItem.Tag = "0090";
            this.sendID0x0090ToolStripMenuItem.Text = "Request &ID (0x0090)";
            this.sendID0x0090ToolStripMenuItem.Click += new System.EventHandler(this.InsertMessageToolBarItem_Click);
            // 
            // requestStatusToolStripMenuItem
            // 
            this.requestStatusToolStripMenuItem.Name = "requestStatusToolStripMenuItem";
            this.requestStatusToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.requestStatusToolStripMenuItem.Tag = "0088";
            this.requestStatusToolStripMenuItem.Text = "Request &Status (0x0088)";
            this.requestStatusToolStripMenuItem.Click += new System.EventHandler(this.InsertMessageToolBarItem_Click);
            // 
            // InstructionTypeHeaderLabel
            // 
            this.InstructionTypeHeaderLabel.AutoSize = true;
            this.InstructionTypeHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionTypeHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionTypeHeaderLabel.Location = new System.Drawing.Point(3, 60);
            this.InstructionTypeHeaderLabel.Name = "InstructionTypeHeaderLabel";
            this.InstructionTypeHeaderLabel.Size = new System.Drawing.Size(111, 30);
            this.InstructionTypeHeaderLabel.TabIndex = 10;
            this.InstructionTypeHeaderLabel.Text = "Instruction";
            this.InstructionTypeHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InstructionTypeLabel
            // 
            this.InstructionTypeLabel.AutoSize = true;
            this.InstructionTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionTypeLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.InstructionTypeLabel.Location = new System.Drawing.Point(120, 60);
            this.InstructionTypeLabel.Name = "InstructionTypeLabel";
            this.InstructionTypeLabel.Size = new System.Drawing.Size(214, 30);
            this.InstructionTypeLabel.TabIndex = 11;
            this.InstructionTypeLabel.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 724);
            this.Controls.Add(this.MainTableLayout);
            this.Controls.Add(this.ApplicationMenuStrip);
            this.MainMenuStrip = this.ApplicationMenuStrip;
            this.Name = "MainForm";
            this.Text = "Blitz Serial Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MessageLogSplitContainer.Panel1.ResumeLayout(false);
            this.MessageLogSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessageLogSplitContainer)).EndInit();
            this.MessageLogSplitContainer.ResumeLayout(false);
            this.MenuTableLayout.ResumeLayout(false);
            this.MenuTableLayout.PerformLayout();
            this.MessageDataTableLayout.ResumeLayout(false);
            this.MessageDataTableLayout.PerformLayout();
            this.ApplicationMenuStrip.ResumeLayout(false);
            this.ApplicationMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.MenuStrip ApplicationMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmitData0x00C0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sendID0x0090ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestStatusToolStripMenuItem;
        private System.Windows.Forms.SplitContainer MessageLogSplitContainer;
        private Controls.FormattedListBox ReceivedListBox;
        private Controls.FormattedListBox SentListBox;
        private System.Windows.Forms.TableLayoutPanel MenuTableLayout;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox BaudRateTextBox;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Button ExportSessionButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.CheckBox AppendNewlineCheckbox;
        private System.Windows.Forms.CheckBox ResetOnConnectCheckbox;
        private System.Windows.Forms.TableLayoutPanel MessageDataTableLayout;
        private System.Windows.Forms.Label ayloadHeaderLabel;
        private System.Windows.Forms.Label PayloadLabel;
        private System.Windows.Forms.Label TimestampHeaderLabel;
        private System.Windows.Forms.Label TimestampLabel;
        private System.Windows.Forms.Label FlagsHeaderLabel;
        private System.Windows.Forms.Label FlagsLabel;
        private System.Windows.Forms.Label TypeHeaderLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label IdHeaderLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label InstructionTypeLabel;
        private System.Windows.Forms.Label InstructionTypeHeaderLabel;
    }
}