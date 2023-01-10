namespace wfaTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buUp = new System.Windows.Forms.Button();
            this.buUpPause = new System.Windows.Forms.Button();
            this.pbUp = new System.Windows.Forms.ProgressBar();
            this.pbUpMs = new System.Windows.Forms.ProgressBar();
            this.laUpStatus = new System.Windows.Forms.Label();
            this.laDownStatus = new System.Windows.Forms.Label();
            this.pbDownMs = new System.Windows.Forms.ProgressBar();
            this.pbDown = new System.Windows.Forms.ProgressBar();
            this.buDownPause = new System.Windows.Forms.Button();
            this.buDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buUp
            // 
            this.buUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUp.Location = new System.Drawing.Point(157, 54);
            this.buUp.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(257, 88);
            this.buUp.TabIndex = 0;
            this.buUp.Text = "00:00:000";
            this.buUp.UseVisualStyleBackColor = true;
            // 
            // buUpPause
            // 
            this.buUpPause.Location = new System.Drawing.Point(434, 54);
            this.buUpPause.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buUpPause.Name = "buUpPause";
            this.buUpPause.Size = new System.Drawing.Size(125, 88);
            this.buUpPause.TabIndex = 1;
            this.buUpPause.Text = "⏸";
            this.buUpPause.UseVisualStyleBackColor = true;
            // 
            // pbUp
            // 
            this.pbUp.Location = new System.Drawing.Point(572, 54);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(125, 29);
            this.pbUp.TabIndex = 2;
            // 
            // pbUpMs
            // 
            this.pbUpMs.Location = new System.Drawing.Point(572, 113);
            this.pbUpMs.Name = "pbUpMs";
            this.pbUpMs.Size = new System.Drawing.Size(125, 29);
            this.pbUpMs.TabIndex = 3;
            // 
            // laUpStatus
            // 
            this.laUpStatus.AutoSize = true;
            this.laUpStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laUpStatus.Location = new System.Drawing.Point(703, 63);
            this.laUpStatus.Name = "laUpStatus";
            this.laUpStatus.Size = new System.Drawing.Size(49, 20);
            this.laUpStatus.TabIndex = 4;
            this.laUpStatus.Text = "100 %";
            // 
            // laDownStatus
            // 
            this.laDownStatus.AutoSize = true;
            this.laDownStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laDownStatus.Location = new System.Drawing.Point(703, 171);
            this.laDownStatus.Name = "laDownStatus";
            this.laDownStatus.Size = new System.Drawing.Size(49, 20);
            this.laDownStatus.TabIndex = 10;
            this.laDownStatus.Text = "100 %";
            // 
            // pbDownMs
            // 
            this.pbDownMs.Location = new System.Drawing.Point(572, 221);
            this.pbDownMs.Name = "pbDownMs";
            this.pbDownMs.Size = new System.Drawing.Size(125, 29);
            this.pbDownMs.TabIndex = 9;
            // 
            // pbDown
            // 
            this.pbDown.Location = new System.Drawing.Point(572, 162);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(125, 29);
            this.pbDown.TabIndex = 8;
            // 
            // buDownPause
            // 
            this.buDownPause.Location = new System.Drawing.Point(434, 162);
            this.buDownPause.Margin = new System.Windows.Forms.Padding(10);
            this.buDownPause.Name = "buDownPause";
            this.buDownPause.Size = new System.Drawing.Size(125, 88);
            this.buDownPause.TabIndex = 7;
            this.buDownPause.Text = "⏸";
            this.buDownPause.UseVisualStyleBackColor = true;
            // 
            // buDown
            // 
            this.buDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buDown.Location = new System.Drawing.Point(157, 162);
            this.buDown.Margin = new System.Windows.Forms.Padding(10);
            this.buDown.Name = "buDown";
            this.buDown.Size = new System.Drawing.Size(257, 88);
            this.buDown.TabIndex = 6;
            this.buDown.Text = "00:00:000";
            this.buDown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 67F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 351);
            this.Controls.Add(this.laDownStatus);
            this.Controls.Add(this.pbDownMs);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.buDownPause);
            this.Controls.Add(this.buDown);
            this.Controls.Add(this.laUpStatus);
            this.Controls.Add(this.pbUpMs);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.buUpPause);
            this.Controls.Add(this.buUp);
            this.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buUp;
        private Button buUpPause;
        private ProgressBar pbUp;
        private ProgressBar pbUpMs;
        private Label laUpStatus;
        private Label laDownStatus;
        private ProgressBar pbDownMs;
        private ProgressBar pbDown;
        private Button buDownPause;
        private Button buDown;
    }
}