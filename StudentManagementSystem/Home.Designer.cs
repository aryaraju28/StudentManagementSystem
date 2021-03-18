
namespace StudentManagementSystem
{
    partial class Home
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
            this.lstMark = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMark
            // 
            this.lstMark.FormattingEnabled = true;
            this.lstMark.Location = new System.Drawing.Point(156, 89);
            this.lstMark.Name = "lstMark";
            this.lstMark.Size = new System.Drawing.Size(120, 212);
            this.lstMark.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMark);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Home_GiveFeedback);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMark;
    }
}