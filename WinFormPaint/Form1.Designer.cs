namespace WinFormPaint
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
            this.buDrawTriangle = new System.Windows.Forms.Button();
            this.buDrawRectangle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buDrawEllipse = new System.Windows.Forms.Button();
            this.buDrawLine = new System.Windows.Forms.Button();
            this.buDrawPencil = new System.Windows.Forms.Button();
            this.buImageSaveBuffer = new System.Windows.Forms.Button();
            this.buImageSaveTo = new System.Windows.Forms.Button();
            this.buImageLoadFromFile = new System.Windows.Forms.Button();
            this.buImageClear = new System.Windows.Forms.Button();
            this.trPenWidth = new System.Windows.Forms.TrackBar();
            this.pxBlack = new System.Windows.Forms.PictureBox();
            this.pxGreen = new System.Windows.Forms.PictureBox();
            this.pxYellow = new System.Windows.Forms.PictureBox();
            this.pxRed = new System.Windows.Forms.PictureBox();
            this.pxBlue = new System.Windows.Forms.PictureBox();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.ckFillMode = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.ckFillMode);
            this.panel1.Controls.Add(this.buDrawTriangle);
            this.panel1.Controls.Add(this.buDrawRectangle);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buDrawEllipse);
            this.panel1.Controls.Add(this.buDrawLine);
            this.panel1.Controls.Add(this.buDrawPencil);
            this.panel1.Controls.Add(this.buImageSaveBuffer);
            this.panel1.Controls.Add(this.buImageSaveTo);
            this.panel1.Controls.Add(this.buImageLoadFromFile);
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
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // buDrawTriangle
            // 
            this.buDrawTriangle.Location = new System.Drawing.Point(90, 301);
            this.buDrawTriangle.Name = "buDrawTriangle";
            this.buDrawTriangle.Size = new System.Drawing.Size(104, 23);
            this.buDrawTriangle.TabIndex = 15;
            this.buDrawTriangle.Text = "Треугольник";
            this.buDrawTriangle.UseVisualStyleBackColor = true;
            // 
            // buDrawRectangle
            // 
            this.buDrawRectangle.Location = new System.Drawing.Point(90, 272);
            this.buDrawRectangle.Name = "buDrawRectangle";
            this.buDrawRectangle.Size = new System.Drawing.Size(104, 23);
            this.buDrawRectangle.TabIndex = 14;
            this.buDrawRectangle.Text = "Прямоугольник";
            this.buDrawRectangle.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(980, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buDrawEllipse
            // 
            this.buDrawEllipse.Location = new System.Drawing.Point(6, 329);
            this.buDrawEllipse.Name = "buDrawEllipse";
            this.buDrawEllipse.Size = new System.Drawing.Size(78, 24);
            this.buDrawEllipse.TabIndex = 12;
            this.buDrawEllipse.Text = "Эллипс";
            this.buDrawEllipse.UseVisualStyleBackColor = true;
            // 
            // buDrawLine
            // 
            this.buDrawLine.Location = new System.Drawing.Point(6, 301);
            this.buDrawLine.Name = "buDrawLine";
            this.buDrawLine.Size = new System.Drawing.Size(78, 23);
            this.buDrawLine.TabIndex = 11;
            this.buDrawLine.Text = "Линия";
            this.buDrawLine.UseVisualStyleBackColor = true;
            // 
            // buDrawPencil
            // 
            this.buDrawPencil.Location = new System.Drawing.Point(6, 271);
            this.buDrawPencil.Name = "buDrawPencil";
            this.buDrawPencil.Size = new System.Drawing.Size(78, 23);
            this.buDrawPencil.TabIndex = 10;
            this.buDrawPencil.Text = "Карандаш";
            this.buDrawPencil.UseVisualStyleBackColor = true;
            // 
            // buImageSaveBuffer
            // 
            this.buImageSaveBuffer.Location = new System.Drawing.Point(6, 205);
            this.buImageSaveBuffer.Name = "buImageSaveBuffer";
            this.buImageSaveBuffer.Size = new System.Drawing.Size(188, 23);
            this.buImageSaveBuffer.TabIndex = 9;
            this.buImageSaveBuffer.Text = "Сохранить в буфер обмена";
            this.buImageSaveBuffer.UseVisualStyleBackColor = true;
            // 
            // buImageSaveTo
            // 
            this.buImageSaveTo.Location = new System.Drawing.Point(6, 176);
            this.buImageSaveTo.Name = "buImageSaveTo";
            this.buImageSaveTo.Size = new System.Drawing.Size(188, 23);
            this.buImageSaveTo.TabIndex = 8;
            this.buImageSaveTo.Text = "Сохранить";
            this.buImageSaveTo.UseVisualStyleBackColor = true;
            // 
            // buImageLoadFromFile
            // 
            this.buImageLoadFromFile.Location = new System.Drawing.Point(6, 147);
            this.buImageLoadFromFile.Name = "buImageLoadFromFile";
            this.buImageLoadFromFile.Size = new System.Drawing.Size(188, 23);
            this.buImageLoadFromFile.TabIndex = 7;
            this.buImageLoadFromFile.Text = "Загрузить из файла";
            this.buImageLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // buImageClear
            // 
            this.buImageClear.Location = new System.Drawing.Point(55, 118);
            this.buImageClear.Name = "buImageClear";
            this.buImageClear.Size = new System.Drawing.Size(81, 23);
            this.buImageClear.TabIndex = 6;
            this.buImageClear.Text = "Очистить";
            this.buImageClear.UseVisualStyleBackColor = true;
            // 
            // trPenWidth
            // 
            this.trPenWidth.Location = new System.Drawing.Point(6, 67);
            this.trPenWidth.Minimum = 1;
            this.trPenWidth.Name = "trPenWidth";
            this.trPenWidth.Size = new System.Drawing.Size(104, 45);
            this.trPenWidth.TabIndex = 5;
            this.trPenWidth.Value = 1;
            // 
            // pxBlack
            // 
            this.pxBlack.BackColor = System.Drawing.Color.Black;
            this.pxBlack.Location = new System.Drawing.Point(116, 26);
            this.pxBlack.Name = "pxBlack";
            this.pxBlack.Size = new System.Drawing.Size(20, 19);
            this.pxBlack.TabIndex = 4;
            this.pxBlack.TabStop = false;
            // 
            // pxGreen
            // 
            this.pxGreen.BackColor = System.Drawing.Color.Lime;
            this.pxGreen.Location = new System.Drawing.Point(90, 26);
            this.pxGreen.Name = "pxGreen";
            this.pxGreen.Size = new System.Drawing.Size(20, 19);
            this.pxGreen.TabIndex = 3;
            this.pxGreen.TabStop = false;
            // 
            // pxYellow
            // 
            this.pxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pxYellow.Location = new System.Drawing.Point(64, 26);
            this.pxYellow.Name = "pxYellow";
            this.pxYellow.Size = new System.Drawing.Size(20, 19);
            this.pxYellow.TabIndex = 2;
            this.pxYellow.TabStop = false;
            // 
            // pxRed
            // 
            this.pxRed.BackColor = System.Drawing.Color.Red;
            this.pxRed.Location = new System.Drawing.Point(38, 26);
            this.pxRed.Name = "pxRed";
            this.pxRed.Size = new System.Drawing.Size(20, 19);
            this.pxRed.TabIndex = 1;
            this.pxRed.TabStop = false;
            // 
            // pxBlue
            // 
            this.pxBlue.BackColor = System.Drawing.Color.Blue;
            this.pxBlue.Location = new System.Drawing.Point(12, 26);
            this.pxBlue.Name = "pxBlue";
            this.pxBlue.Size = new System.Drawing.Size(20, 19);
            this.pxBlue.TabIndex = 0;
            this.pxBlue.TabStop = false;
            // 
            // pxImage
            // 
            this.pxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxImage.Location = new System.Drawing.Point(200, 0);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(600, 450);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // checkBox1
            // 
            this.ckFillMode.AutoSize = true;
            this.ckFillMode.Location = new System.Drawing.Point(13, 377);
            this.ckFillMode.Name = "checkBox1";
            this.ckFillMode.Size = new System.Drawing.Size(71, 19);
            this.ckFillMode.TabIndex = 16;
            this.ckFillMode.Text = "Заливка";
            this.ckFillMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private TrackBar trPenWidth;
        private PictureBox pxBlack;
        private PictureBox pxGreen;
        private PictureBox pxYellow;
        private PictureBox pxRed;
        private PictureBox pxBlue;
        private PictureBox pxImage;
        private Button buImageSaveBuffer;
        private Button buImageSaveTo;
        private Button buImageLoadFromFile;
        private Button buImageClear;
        private Button buDrawTriangle;
        private Button buDrawRectangle;
        private Button button4;
        private Button buDrawEllipse;
        private Button buDrawLine;
        private Button buDrawPencil;
        private CheckBox ckFillMode;
    }
}