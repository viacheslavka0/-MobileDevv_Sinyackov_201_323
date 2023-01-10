namespace wfaPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buCutOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckFillMode = new System.Windows.Forms.CheckBox();
            this.buDrawTrianlge = new System.Windows.Forms.Button();
            this.buDrawRectangle = new System.Windows.Forms.Button();
            this.buDrawEllipse = new System.Windows.Forms.Button();
            this.buDrawLine = new System.Windows.Forms.Button();
            this.buDrawPencil = new System.Windows.Forms.Button();
            this.buImageSaveToClipboard = new System.Windows.Forms.Button();
            this.buImageSaveToFile = new System.Windows.Forms.Button();
            this.buImgeLoadFile = new System.Windows.Forms.Button();
            this.buImageClear = new System.Windows.Forms.Button();
            this.trPenWidth = new System.Windows.Forms.TrackBar();
            this.pxBlack = new System.Windows.Forms.PictureBox();
            this.pxGreen = new System.Windows.Forms.PictureBox();
            this.pxYellow = new System.Windows.Forms.PictureBox();
            this.pxRed = new System.Windows.Forms.PictureBox();
            this.pxBlue = new System.Windows.Forms.PictureBox();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.buDrawHexagon = new System.Windows.Forms.Button();
            this.buDrawArrow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buDrawHexagon);
            this.panel1.Controls.Add(this.buDrawArrow);
            this.panel1.Controls.Add(this.buCutOut);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ckFillMode);
            this.panel1.Controls.Add(this.buDrawTrianlge);
            this.panel1.Controls.Add(this.buDrawRectangle);
            this.panel1.Controls.Add(this.buDrawEllipse);
            this.panel1.Controls.Add(this.buDrawLine);
            this.panel1.Controls.Add(this.buDrawPencil);
            this.panel1.Controls.Add(this.buImageSaveToClipboard);
            this.panel1.Controls.Add(this.buImageSaveToFile);
            this.panel1.Controls.Add(this.buImgeLoadFile);
            this.panel1.Controls.Add(this.buImageClear);
            this.panel1.Controls.Add(this.trPenWidth);
            this.panel1.Controls.Add(this.pxBlack);
            this.panel1.Controls.Add(this.pxGreen);
            this.panel1.Controls.Add(this.pxYellow);
            this.panel1.Controls.Add(this.pxRed);
            this.panel1.Controls.Add(this.pxBlue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 601);
            this.panel1.TabIndex = 0;
            // 
            // buCutOut
            // 
            this.buCutOut.Location = new System.Drawing.Point(12, 265);
            this.buCutOut.Name = "buCutOut";
            this.buCutOut.Size = new System.Drawing.Size(154, 29);
            this.buCutOut.TabIndex = 17;
            this.buCutOut.Text = "Вырезать";
            this.buCutOut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Пипетка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ckFillMode
            // 
            this.ckFillMode.AutoSize = true;
            this.ckFillMode.Location = new System.Drawing.Point(31, 506);
            this.ckFillMode.Name = "ckFillMode";
            this.ckFillMode.Size = new System.Drawing.Size(143, 24);
            this.ckFillMode.TabIndex = 15;
            this.ckFillMode.Text = "Заливка фигуры";
            this.ckFillMode.UseVisualStyleBackColor = true;
            // 
            // buDrawTrianlge
            // 
            this.buDrawTrianlge.Location = new System.Drawing.Point(153, 352);
            this.buDrawTrianlge.Name = "buDrawTrianlge";
            this.buDrawTrianlge.Size = new System.Drawing.Size(135, 29);
            this.buDrawTrianlge.TabIndex = 14;
            this.buDrawTrianlge.Text = "Треугольник";
            this.buDrawTrianlge.UseVisualStyleBackColor = true;
            // 
            // buDrawRectangle
            // 
            this.buDrawRectangle.Location = new System.Drawing.Point(12, 422);
            this.buDrawRectangle.Name = "buDrawRectangle";
            this.buDrawRectangle.Size = new System.Drawing.Size(135, 29);
            this.buDrawRectangle.TabIndex = 13;
            this.buDrawRectangle.Text = "Прямоугольник";
            this.buDrawRectangle.UseVisualStyleBackColor = true;
            // 
            // buDrawEllipse
            // 
            this.buDrawEllipse.Location = new System.Drawing.Point(12, 387);
            this.buDrawEllipse.Name = "buDrawEllipse";
            this.buDrawEllipse.Size = new System.Drawing.Size(135, 29);
            this.buDrawEllipse.TabIndex = 12;
            this.buDrawEllipse.Text = "Эллипс";
            this.buDrawEllipse.UseVisualStyleBackColor = true;
            // 
            // buDrawLine
            // 
            this.buDrawLine.Location = new System.Drawing.Point(12, 352);
            this.buDrawLine.Name = "buDrawLine";
            this.buDrawLine.Size = new System.Drawing.Size(135, 29);
            this.buDrawLine.TabIndex = 11;
            this.buDrawLine.Text = "Линия";
            this.buDrawLine.UseVisualStyleBackColor = true;
            // 
            // buDrawPencil
            // 
            this.buDrawPencil.Location = new System.Drawing.Point(85, 317);
            this.buDrawPencil.Name = "buDrawPencil";
            this.buDrawPencil.Size = new System.Drawing.Size(135, 29);
            this.buDrawPencil.TabIndex = 10;
            this.buDrawPencil.Text = "Карандаш";
            this.buDrawPencil.UseVisualStyleBackColor = true;
            // 
            // buImageSaveToClipboard
            // 
            this.buImageSaveToClipboard.Location = new System.Drawing.Point(12, 211);
            this.buImageSaveToClipboard.Name = "buImageSaveToClipboard";
            this.buImageSaveToClipboard.Size = new System.Drawing.Size(154, 48);
            this.buImageSaveToClipboard.TabIndex = 9;
            this.buImageSaveToClipboard.Text = "Сохранить в буфер обмена";
            this.buImageSaveToClipboard.UseVisualStyleBackColor = true;
            // 
            // buImageSaveToFile
            // 
            this.buImageSaveToFile.Location = new System.Drawing.Point(12, 176);
            this.buImageSaveToFile.Name = "buImageSaveToFile";
            this.buImageSaveToFile.Size = new System.Drawing.Size(154, 29);
            this.buImageSaveToFile.TabIndex = 8;
            this.buImageSaveToFile.Text = "Сохранить";
            this.buImageSaveToFile.UseVisualStyleBackColor = true;
            // 
            // buImgeLoadFile
            // 
            this.buImgeLoadFile.Location = new System.Drawing.Point(12, 141);
            this.buImgeLoadFile.Name = "buImgeLoadFile";
            this.buImgeLoadFile.Size = new System.Drawing.Size(154, 29);
            this.buImgeLoadFile.TabIndex = 7;
            this.buImgeLoadFile.Text = "Загрузить из файла";
            this.buImgeLoadFile.UseVisualStyleBackColor = true;
            // 
            // buImageClear
            // 
            this.buImageClear.Location = new System.Drawing.Point(12, 106);
            this.buImageClear.Name = "buImageClear";
            this.buImageClear.Size = new System.Drawing.Size(154, 29);
            this.buImageClear.TabIndex = 6;
            this.buImageClear.Text = "Очистить";
            this.buImageClear.UseVisualStyleBackColor = true;
            // 
            // trPenWidth
            // 
            this.trPenWidth.Location = new System.Drawing.Point(12, 44);
            this.trPenWidth.Maximum = 100;
            this.trPenWidth.Minimum = 1;
            this.trPenWidth.Name = "trPenWidth";
            this.trPenWidth.Size = new System.Drawing.Size(154, 56);
            this.trPenWidth.TabIndex = 5;
            this.trPenWidth.Value = 1;
            // 
            // pxBlack
            // 
            this.pxBlack.BackColor = System.Drawing.Color.Black;
            this.pxBlack.Location = new System.Drawing.Point(140, 12);
            this.pxBlack.Name = "pxBlack";
            this.pxBlack.Size = new System.Drawing.Size(26, 26);
            this.pxBlack.TabIndex = 4;
            this.pxBlack.TabStop = false;
            // 
            // pxGreen
            // 
            this.pxGreen.BackColor = System.Drawing.Color.Lime;
            this.pxGreen.Location = new System.Drawing.Point(108, 12);
            this.pxGreen.Name = "pxGreen";
            this.pxGreen.Size = new System.Drawing.Size(26, 26);
            this.pxGreen.TabIndex = 3;
            this.pxGreen.TabStop = false;
            // 
            // pxYellow
            // 
            this.pxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pxYellow.Location = new System.Drawing.Point(76, 12);
            this.pxYellow.Name = "pxYellow";
            this.pxYellow.Size = new System.Drawing.Size(26, 26);
            this.pxYellow.TabIndex = 2;
            this.pxYellow.TabStop = false;
            // 
            // pxRed
            // 
            this.pxRed.BackColor = System.Drawing.Color.Red;
            this.pxRed.Location = new System.Drawing.Point(44, 12);
            this.pxRed.Name = "pxRed";
            this.pxRed.Size = new System.Drawing.Size(26, 26);
            this.pxRed.TabIndex = 1;
            this.pxRed.TabStop = false;
            // 
            // pxBlue
            // 
            this.pxBlue.BackColor = System.Drawing.Color.Blue;
            this.pxBlue.Location = new System.Drawing.Point(12, 12);
            this.pxBlue.Name = "pxBlue";
            this.pxBlue.Size = new System.Drawing.Size(26, 26);
            this.pxBlue.TabIndex = 0;
            this.pxBlue.TabStop = false;
            // 
            // pxImage
            // 
            this.pxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxImage.Location = new System.Drawing.Point(290, 0);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(681, 601);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // buDrawHexagon
            // 
            this.buDrawHexagon.Location = new System.Drawing.Point(152, 422);
            this.buDrawHexagon.Name = "buDrawHexagon";
            this.buDrawHexagon.Size = new System.Drawing.Size(135, 29);
            this.buDrawHexagon.TabIndex = 19;
            this.buDrawHexagon.Text = "Шестиугольник";
            this.buDrawHexagon.UseVisualStyleBackColor = true;
            // 
            // buDrawArrow
            // 
            this.buDrawArrow.Location = new System.Drawing.Point(152, 387);
            this.buDrawArrow.Name = "buDrawArrow";
            this.buDrawArrow.Size = new System.Drawing.Size(135, 29);
            this.buDrawArrow.TabIndex = 18;
            this.buDrawArrow.Text = "Стрелочка";
            this.buDrawArrow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 601);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pxImage;
        private PictureBox pxBlack;
        private PictureBox pxGreen;
        private PictureBox pxYellow;
        private PictureBox pxRed;
        private PictureBox pxBlue;
        private TrackBar trPenWidth;
        private Button buImageSaveToClipboard;
        private Button buImgeLoadFile;
        private Button buImageClear;
        private CheckBox ckFillMode;
        private Button buDrawTrianlge;
        private Button buDrawRectangle;
        private Button buDrawEllipse;
        private Button buDrawLine;
        private Button buDrawPencil;
        private Button button1;
        private Button buCutOut;
        private Button buImageSaveToFile;
        private Button buDrawHexagon;
        private Button buDrawArrow;
    }
}