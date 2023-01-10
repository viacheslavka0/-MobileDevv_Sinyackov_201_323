namespace wfaToDo;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbNoteAdd = new System.Windows.Forms.TextBox();
            this.BtnAddNote = new System.Windows.Forms.Button();
            this.LvNotes = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbNoteEdit = new System.Windows.Forms.TextBox();
            this.BtnEditNote = new System.Windows.Forms.Button();
            this.BtnDeleteNote = new System.Windows.Forms.Button();
            this.BtnSearchNote = new System.Windows.Forms.Button();
            this.TbNoteSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtpSearch = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbNoteAdd);
            this.groupBox1.Controls.Add(this.BtnAddNote);
            this.groupBox1.Location = new System.Drawing.Point(560, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить заметку";
            // 
            // TbNoteAdd
            // 
            this.TbNoteAdd.Location = new System.Drawing.Point(6, 26);
            this.TbNoteAdd.Multiline = true;
            this.TbNoteAdd.Name = "TbNoteAdd";
            this.TbNoteAdd.Size = new System.Drawing.Size(253, 92);
            this.TbNoteAdd.TabIndex = 1;
            // 
            // BtnAddNote
            // 
            this.BtnAddNote.Location = new System.Drawing.Point(92, 124);
            this.BtnAddNote.Name = "BtnAddNote";
            this.BtnAddNote.Size = new System.Drawing.Size(94, 29);
            this.BtnAddNote.TabIndex = 0;
            this.BtnAddNote.Text = "Добавить";
            this.BtnAddNote.UseVisualStyleBackColor = true;
            this.BtnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // LvNotes
            // 
            this.LvNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LvNotes.Location = new System.Drawing.Point(12, 45);
            this.LvNotes.Name = "LvNotes";
            this.LvNotes.Size = new System.Drawing.Size(401, 503);
            this.LvNotes.TabIndex = 2;
            this.LvNotes.UseCompatibleStateImageBehavior = false;
            this.LvNotes.SelectedIndexChanged += new System.EventHandler(this.LvNotes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbNoteEdit);
            this.groupBox2.Controls.Add(this.BtnEditNote);
            this.groupBox2.Location = new System.Drawing.Point(560, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать заметку";
            // 
            // TbNoteEdit
            // 
            this.TbNoteEdit.Location = new System.Drawing.Point(6, 26);
            this.TbNoteEdit.Multiline = true;
            this.TbNoteEdit.Name = "TbNoteEdit";
            this.TbNoteEdit.Size = new System.Drawing.Size(253, 92);
            this.TbNoteEdit.TabIndex = 1;
            // 
            // BtnEditNote
            // 
            this.BtnEditNote.Location = new System.Drawing.Point(92, 124);
            this.BtnEditNote.Name = "BtnEditNote";
            this.BtnEditNote.Size = new System.Drawing.Size(94, 29);
            this.BtnEditNote.TabIndex = 0;
            this.BtnEditNote.Text = "Сохранить";
            this.BtnEditNote.UseVisualStyleBackColor = true;
            this.BtnEditNote.Click += new System.EventHandler(this.BtnEditNote_Click);
            // 
            // BtnDeleteNote
            // 
            this.BtnDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeleteNote.Location = new System.Drawing.Point(319, 554);
            this.BtnDeleteNote.Name = "BtnDeleteNote";
            this.BtnDeleteNote.Size = new System.Drawing.Size(94, 29);
            this.BtnDeleteNote.TabIndex = 4;
            this.BtnDeleteNote.Text = "Удалить";
            this.BtnDeleteNote.UseVisualStyleBackColor = true;
            this.BtnDeleteNote.Click += new System.EventHandler(this.BtnDeleteNote_Click);
            // 
            // BtnSearchNote
            // 
            this.BtnSearchNote.Location = new System.Drawing.Point(92, 157);
            this.BtnSearchNote.Name = "BtnSearchNote";
            this.BtnSearchNote.Size = new System.Drawing.Size(94, 29);
            this.BtnSearchNote.TabIndex = 0;
            this.BtnSearchNote.Text = "Найти";
            this.BtnSearchNote.UseVisualStyleBackColor = true;
            this.BtnSearchNote.Click += new System.EventHandler(this.BtnSearchNote_Click);
            // 
            // TbNoteSearch
            // 
            this.TbNoteSearch.Location = new System.Drawing.Point(6, 26);
            this.TbNoteSearch.Multiline = true;
            this.TbNoteSearch.Name = "TbNoteSearch";
            this.TbNoteSearch.Size = new System.Drawing.Size(253, 92);
            this.TbNoteSearch.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtpSearch);
            this.groupBox3.Controls.Add(this.TbNoteSearch);
            this.groupBox3.Controls.Add(this.BtnSearchNote);
            this.groupBox3.Location = new System.Drawing.Point(560, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Найти заметку";
            // 
            // DtpSearch
            // 
            this.DtpSearch.Location = new System.Drawing.Point(9, 124);
            this.DtpSearch.Name = "DtpSearch";
            this.DtpSearch.Size = new System.Drawing.Size(250, 27);
            this.DtpSearch.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnDeleteNote);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LvNotes);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private GroupBox groupBox1;
    private TextBox TbNoteAdd;
    private Button BtnAddNote;
    private ListView LvNotes;
    private GroupBox groupBox2;
    private TextBox TbNoteEdit;
    private Button BtnEditNote;
    private Button BtnDeleteNote;
    private Button BtnSearchNote;
    private TextBox TbNoteSearch;
    private GroupBox groupBox3;
    private DateTimePicker DtpSearch;
}
