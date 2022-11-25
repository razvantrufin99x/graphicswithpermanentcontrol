namespace graphicswithpermanentcontrol
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(504, 368);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseDown_1);
            this.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseUp_1);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
