namespace SerialTerminal
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SentListBox = new SerialTerminal.Controls.FormattedListBox();
            this.HistoryToolstrip = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ReceivedListBox = new SerialTerminal.Controls.FormattedListBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.HistoryToolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SentListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HistoryToolstrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReceivedListBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 573);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.SentListBox.Location = new System.Drawing.Point(3, 33);
            this.SentListBox.Name = "SentListBox";
            this.SentListBox.Size = new System.Drawing.Size(445, 537);
            this.SentListBox.TabIndex = 0;
            this.SentListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SentListBox_DrawItem);
            this.SentListBox.SelectedIndexChanged += new System.EventHandler(this.SentListBox_SelectedIndexChanged);
            // 
            // HistoryToolstrip
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.HistoryToolstrip, 2);
            this.HistoryToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseButton,
            this.ExportButton});
            this.HistoryToolstrip.Location = new System.Drawing.Point(0, 0);
            this.HistoryToolstrip.Name = "HistoryToolstrip";
            this.HistoryToolstrip.Size = new System.Drawing.Size(902, 25);
            this.HistoryToolstrip.TabIndex = 2;
            this.HistoryToolstrip.Text = "toolStrip1";
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 22);
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(44, 22);
            this.ExportButton.Text = "Export";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
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
            this.ReceivedListBox.Location = new System.Drawing.Point(454, 33);
            this.ReceivedListBox.Name = "ReceivedListBox";
            this.ReceivedListBox.Size = new System.Drawing.Size(445, 537);
            this.ReceivedListBox.TabIndex = 3;
            this.ReceivedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ReceivedListBox_DrawItem);
            this.ReceivedListBox.SelectedIndexChanged += new System.EventHandler(this.ReceivedListBox_SelectedIndexChanged);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryForm";
            this.Text = "Serial Session History";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HistoryToolstrip.ResumeLayout(false);
            this.HistoryToolstrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip HistoryToolstrip;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private Controls.FormattedListBox ReceivedListBox;
        private Controls.FormattedListBox SentListBox;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}