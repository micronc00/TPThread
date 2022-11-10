
namespace MyThreads
{
    partial class frmTrackThread
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
            this.lbl_Thread = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Thread
            // 
            this.lbl_Thread.AutoSize = true;
            this.lbl_Thread.Location = new System.Drawing.Point(128, 56);
            this.lbl_Thread.Name = "lbl_Thread";
            this.lbl_Thread.Size = new System.Drawing.Size(77, 13);
            this.lbl_Thread.TabIndex = 0;
            this.lbl_Thread.Text = "-Thread Starts-";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(96, 157);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(144, 67);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lbl_Thread);
            this.Name = "frmTrackThread";
            this.Text = "frmTrackThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Thread;
        private System.Windows.Forms.Button btnRun;
    }
}

