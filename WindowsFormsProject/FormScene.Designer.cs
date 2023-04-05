
namespace WindowsFormsProject
{
    partial class FormScene
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
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonMove = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AreaToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Checked = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(13, 13);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(93, 21);
            this.radioButtonRectangle.TabIndex = 0;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(113, 13);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(75, 21);
            this.radioButtonSquare.TabIndex = 1;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(195, 13);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(81, 21);
            this.radioButtonTriangle.TabIndex = 2;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMove
            // 
            this.radioButtonMove.AutoSize = true;
            this.radioButtonMove.Location = new System.Drawing.Point(13, 41);
            this.radioButtonMove.Name = "radioButtonMove";
            this.radioButtonMove.Size = new System.Drawing.Size(63, 21);
            this.radioButtonMove.TabIndex = 3;
            this.radioButtonMove.Text = "Move";
            this.radioButtonMove.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AreaToolStripStatusLabel
            // 
            this.AreaToolStripStatusLabel.Name = "AreaToolStripStatusLabel";
            this.AreaToolStripStatusLabel.Size = new System.Drawing.Size(40, 20);
            this.AreaToolStripStatusLabel.Text = "Area";
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.radioButtonMove);
            this.Controls.Add(this.radioButtonTriangle);
            this.Controls.Add(this.radioButtonSquare);
            this.Controls.Add(this.radioButtonRectangle);
            this.Name = "FormScene";
            this.Text = "FormScene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonMove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AreaToolStripStatusLabel;
    }
}

