
namespace WindowsFormsProject
{
    partial class RectangleScene
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
            this.ColorButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ColorLabel1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AreaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(58, 53);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(314, 101);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(251, 219);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(90, 22);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(348, 219);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 22);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ColorLabel1
            // 
            this.ColorLabel1.AutoSize = true;
            this.ColorLabel1.Location = new System.Drawing.Point(155, 23);
            this.ColorLabel1.Name = "ColorLabel1";
            this.ColorLabel1.Size = new System.Drawing.Size(94, 17);
            this.ColorLabel1.TabIndex = 3;
            this.ColorLabel1.Text = "Change Color";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 254);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AreaToolStripLabel
            // 
            this.AreaToolStripLabel.Name = "AreaToolStripLabel";
            this.AreaToolStripLabel.Size = new System.Drawing.Size(40, 28);
            this.AreaToolStripLabel.Text = "Area";
            // 
            // RectangleScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 285);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ColorLabel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ColorButton);
            this.Name = "RectangleScene";
            this.Text = "RectangleScene";
            this.Load += new System.EventHandler(this.RectangleScene_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ColorLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel AreaToolStripLabel;
    }
}