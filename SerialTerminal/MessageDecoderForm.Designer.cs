namespace SerialTerminal
{
    partial class MessageDecoderForm
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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.ayloadHeaderLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PayloadLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TimestampHeaderLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TimestampLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.FlagsHeaderLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FlagsLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TypeHeaderLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TypeLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IdHeaderLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ayloadHeaderLabel
            // 
            this.ayloadHeaderLabel.AutoSize = true;
            this.ayloadHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ayloadHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayloadHeaderLabel.Location = new System.Drawing.Point(3, 120);
            this.ayloadHeaderLabel.Name = "ayloadHeaderLabel";
            this.ayloadHeaderLabel.Size = new System.Drawing.Size(111, 32);
            this.ayloadHeaderLabel.TabIndex = 8;
            this.ayloadHeaderLabel.Text = "Payload";
            this.ayloadHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayloadLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.PayloadLabel.Location = new System.Drawing.Point(120, 120);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new System.Drawing.Size(212, 32);
            this.PayloadLabel.TabIndex = 9;
            this.PayloadLabel.Text = " ";
            // 
            // TimestampHeaderLabel
            // 
            this.TimestampHeaderLabel.AutoSize = true;
            this.TimestampHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimestampHeaderLabel.Location = new System.Drawing.Point(3, 90);
            this.TimestampHeaderLabel.Name = "TimestampHeaderLabel";
            this.TimestampHeaderLabel.Size = new System.Drawing.Size(111, 30);
            this.TimestampHeaderLabel.TabIndex = 6;
            this.TimestampHeaderLabel.Text = "Timestamp";
            this.TimestampHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.AutoSize = true;
            this.TimestampLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.TimestampLabel.Location = new System.Drawing.Point(120, 90);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(212, 30);
            this.TimestampLabel.TabIndex = 7;
            this.TimestampLabel.Text = " ";
            // 
            // FlagsHeaderLabel
            // 
            this.FlagsHeaderLabel.AutoSize = true;
            this.FlagsHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlagsHeaderLabel.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagsHeaderLabel.Location = new System.Drawing.Point(3, 60);
            this.FlagsHeaderLabel.Name = "FlagsHeaderLabel";
            this.FlagsHeaderLabel.Size = new System.Drawing.Size(111, 30);
            this.FlagsHeaderLabel.TabIndex = 4;
            this.FlagsHeaderLabel.Text = "Flags";
            this.FlagsHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FlagsLabel
            // 
            this.FlagsLabel.AutoSize = true;
            this.FlagsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlagsLabel.Font = new System.Drawing.Font("Droid Sans Mono", 10F);
            this.FlagsLabel.Location = new System.Drawing.Point(120, 60);
            this.FlagsLabel.Name = "FlagsLabel";
            this.FlagsLabel.Size = new System.Drawing.Size(212, 30);
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
            this.TypeLabel.Size = new System.Drawing.Size(212, 30);
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
            this.IdLabel.Size = new System.Drawing.Size(212, 30);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = " ";
            // 
            // MessageDecoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageDecoderForm";
            this.Text = "Message Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}