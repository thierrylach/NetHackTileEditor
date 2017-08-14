namespace NetHackTileEditor
{
    partial class Form1
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
            this.colorGroup = new System.Windows.Forms.GroupBox();
            this.drawGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageGroup = new System.Windows.Forms.GroupBox();
            this.thumbnail2 = new System.Windows.Forms.PictureBox();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.normalBackgroundCheckbox = new System.Windows.Forms.CheckBox();
            this.lockedCheckbox = new System.Windows.Forms.CheckBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.drawGroup.SuspendLayout();
            this.imageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.outputGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroup
            // 
            this.colorGroup.BackColor = System.Drawing.Color.White;
            this.colorGroup.Location = new System.Drawing.Point(24, 25);
            this.colorGroup.Name = "colorGroup";
            this.colorGroup.Size = new System.Drawing.Size(212, 123);
            this.colorGroup.TabIndex = 0;
            this.colorGroup.TabStop = false;
            this.colorGroup.Text = "Colors";
            // 
            // drawGroup
            // 
            this.drawGroup.BackColor = System.Drawing.Color.White;
            this.drawGroup.Controls.Add(this.panel1);
            this.drawGroup.Location = new System.Drawing.Point(280, 25);
            this.drawGroup.Name = "drawGroup";
            this.drawGroup.Size = new System.Drawing.Size(337, 351);
            this.drawGroup.TabIndex = 3;
            this.drawGroup.TabStop = false;
            this.drawGroup.Text = "Draw Here";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 321);
            this.panel1.TabIndex = 3;
            // 
            // imageGroup
            // 
            this.imageGroup.Controls.Add(this.thumbnail2);
            this.imageGroup.Controls.Add(this.thumbnail);
            this.imageGroup.Location = new System.Drawing.Point(79, 235);
            this.imageGroup.Name = "imageGroup";
            this.imageGroup.Size = new System.Drawing.Size(75, 135);
            this.imageGroup.TabIndex = 4;
            this.imageGroup.TabStop = false;
            this.imageGroup.Text = "Tile image";
            // 
            // thumbnail2
            // 
            this.thumbnail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.thumbnail2.Location = new System.Drawing.Point(13, 65);
            this.thumbnail2.MaximumSize = new System.Drawing.Size(48, 48);
            this.thumbnail2.MinimumSize = new System.Drawing.Size(48, 48);
            this.thumbnail2.Name = "thumbnail2";
            this.thumbnail2.Size = new System.Drawing.Size(48, 48);
            this.thumbnail2.TabIndex = 1;
            this.thumbnail2.TabStop = false;
            this.thumbnail2.Click += new System.EventHandler(this.thumbnail2_Click);
            // 
            // thumbnail
            // 
            this.thumbnail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.thumbnail.Location = new System.Drawing.Point(29, 29);
            this.thumbnail.MaximumSize = new System.Drawing.Size(16, 16);
            this.thumbnail.MinimumSize = new System.Drawing.Size(16, 16);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(16, 16);
            this.thumbnail.TabIndex = 0;
            this.thumbnail.TabStop = false;
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.textOutput);
            this.outputGroup.Location = new System.Drawing.Point(662, 25);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(235, 351);
            this.outputGroup.TabIndex = 5;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Output";
            // 
            // textOutput
            // 
            this.textOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.Location = new System.Drawing.Point(7, 20);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(219, 325);
            this.textOutput.TabIndex = 0;
            this.textOutput.TabStop = false;
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            this.textOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textOutput_KeyDown);
            this.textOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOutput_KeyPress);
            this.textOutput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textOutput_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(406, 382);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // normalBackgroundCheckbox
            // 
            this.normalBackgroundCheckbox.AutoSize = true;
            this.normalBackgroundCheckbox.Checked = true;
            this.normalBackgroundCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalBackgroundCheckbox.Location = new System.Drawing.Point(48, 174);
            this.normalBackgroundCheckbox.Name = "normalBackgroundCheckbox";
            this.normalBackgroundCheckbox.Size = new System.Drawing.Size(120, 17);
            this.normalBackgroundCheckbox.TabIndex = 8;
            this.normalBackgroundCheckbox.Text = "Normal Background";
            this.normalBackgroundCheckbox.UseVisualStyleBackColor = true;
            this.normalBackgroundCheckbox.CheckedChanged += new System.EventHandler(this.normalBackgroundCheckbox_Changed);
            // 
            // lockedCheckbox
            // 
            this.lockedCheckbox.AutoSize = true;
            this.lockedCheckbox.Checked = true;
            this.lockedCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockedCheckbox.Location = new System.Drawing.Point(697, 389);
            this.lockedCheckbox.Name = "lockedCheckbox";
            this.lockedCheckbox.Size = new System.Drawing.Size(62, 17);
            this.lockedCheckbox.TabIndex = 9;
            this.lockedCheckbox.Text = "Locked";
            this.lockedCheckbox.UseVisualStyleBackColor = true;
            this.lockedCheckbox.CheckedChanged += new System.EventHandler(this.lockedCheckbox_CheckChanged);
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(784, 383);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 10;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 457);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.lockedCheckbox);
            this.Controls.Add(this.normalBackgroundCheckbox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.imageGroup);
            this.Controls.Add(this.drawGroup);
            this.Controls.Add(this.colorGroup);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 496);
            this.MinimumSize = new System.Drawing.Size(950, 496);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pattern Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.form1_OnPaint);
            this.drawGroup.ResumeLayout(false);
            this.imageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.outputGroup.ResumeLayout(false);
            this.outputGroup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox colorGroup;
        private System.Windows.Forms.GroupBox drawGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox imageGroup;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.CheckBox normalBackgroundCheckbox;
        private System.Windows.Forms.PictureBox thumbnail2;
        private System.Windows.Forms.CheckBox lockedCheckbox;
        private System.Windows.Forms.Button buttonImport;
    }
}

