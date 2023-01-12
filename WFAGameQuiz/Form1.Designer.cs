namespace WFAGameQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qPB1 = new System.Windows.Forms.PictureBox();
            this.qPB2 = new System.Windows.Forms.PictureBox();
            this.qPB3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPB3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(664, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Где логика?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 90);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фильм по кадру";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 136);
            this.label3.TabIndex = 12;
            this.label3.Text = "Угадай корпус по фото";
            this.label3.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::WFAGameQuiz.Properties.Resources.game_preview;
            this.pictureBox1.Location = new System.Drawing.Point(2, -152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1429, 794);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(981, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // qPB1
            // 
            this.qPB1.Location = new System.Drawing.Point(123, 65);
            this.qPB1.Name = "qPB1";
            this.qPB1.Size = new System.Drawing.Size(245, 190);
            this.qPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qPB1.TabIndex = 14;
            this.qPB1.TabStop = false;
            // 
            // qPB2
            // 
            this.qPB2.Location = new System.Drawing.Point(427, 65);
            this.qPB2.Name = "qPB2";
            this.qPB2.Size = new System.Drawing.Size(245, 190);
            this.qPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qPB2.TabIndex = 15;
            this.qPB2.TabStop = false;
            // 
            // qPB3
            // 
            this.qPB3.Location = new System.Drawing.Point(699, 65);
            this.qPB3.Name = "qPB3";
            this.qPB3.Size = new System.Drawing.Size(245, 190);
            this.qPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qPB3.TabIndex = 16;
            this.qPB3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.qPB3);
            this.Controls.Add(this.qPB2);
            this.Controls.Add(this.qPB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qPB3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox qPB1;
        private System.Windows.Forms.PictureBox qPB2;
        private System.Windows.Forms.PictureBox qPB3;
    }
}

