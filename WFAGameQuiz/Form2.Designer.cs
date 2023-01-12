namespace WFAGameQuiz
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.qPictBox3 = new System.Windows.Forms.PictureBox();
            this.qPictBox2 = new System.Windows.Forms.PictureBox();
            this.qPictBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qPictBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPictBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPictBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // qPictBox3
            // 
            this.qPictBox3.Location = new System.Drawing.Point(617, 12);
            this.qPictBox3.Name = "qPictBox3";
            this.qPictBox3.Size = new System.Drawing.Size(254, 200);
            this.qPictBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qPictBox3.TabIndex = 3;
            this.qPictBox3.TabStop = false;
            // 
            // qPictBox2
            // 
            this.qPictBox2.Location = new System.Drawing.Point(325, 12);
            this.qPictBox2.Name = "qPictBox2";
            this.qPictBox2.Size = new System.Drawing.Size(254, 200);
            this.qPictBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qPictBox2.TabIndex = 2;
            this.qPictBox2.TabStop = false;
            // 
            // qPictBox1
            // 
            this.qPictBox1.Location = new System.Drawing.Point(12, 12);
            this.qPictBox1.Name = "qPictBox1";
            this.qPictBox1.Size = new System.Drawing.Size(254, 200);
            this.qPictBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qPictBox1.TabIndex = 1;
            this.qPictBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 394);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qPictBox3);
            this.Controls.Add(this.qPictBox2);
            this.Controls.Add(this.qPictBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qPictBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPictBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPictBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox qPictBox1;
        private System.Windows.Forms.PictureBox qPictBox2;
        private System.Windows.Forms.PictureBox qPictBox3;
        private System.Windows.Forms.Label label1;
    }
}