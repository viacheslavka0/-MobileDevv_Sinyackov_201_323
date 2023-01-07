namespace wfaFormTransparency
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
            this.buClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buClose
            // 
            this.buClose.Location = new System.Drawing.Point(339, 272);
            this.buClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(82, 22);
            this.buClose.TabIndex = 0;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wfaFormTransparency.Properties.Resources.rabbit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(837, 686);
            this.Controls.Add(this.buClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buClose;
    }
}