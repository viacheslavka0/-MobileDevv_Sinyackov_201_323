using Microsoft.VisualBasic.Logging;
using SQLite;

namespace wfaToDo;

public partial class Form1 : Form
{
    private SQLiteConnection db;

    private Note? selectedNote;

    public Form1()
    {
        InitializeComponent();

        db = new SQLiteConnection("myDB.db");
        db.CreateTable<Note>();

        LvNotes.View = View.Details;
        LvNotes.Columns.Add("ID", 30);
        LvNotes.Columns.Add("Время создания", 100);
        LvNotes.Columns.Add("Текст", 200);

        RefreshNotesListView();
    }

    private void BtnAddNote_Click(object sender, EventArgs e)
    {
        var noteText = TbNoteAdd.Text;

        var note = new Note()
        {
            Text = noteText,
            CreatedAt = DateTime.Now
        };

        db.Insert(note);

        RefreshNotesListView();
    }

    private void BtnEditNote_Click(object sender, EventArgs e)
    {
        if (selectedNote == null)
            return;

        selectedNote.Text = TbNoteEdit.Text;

        db.Update(selectedNote);

        RefreshNotesListView();
    }

    private void BtnSearchNote_Click(object sender, EventArgs e)
    {
        var q = db.Table<Note>()
            .Where(n => n.CreatedAt >= DtpSearch.Value.Date);

        if (!string.IsNullOrEmpty(TbNoteSearch.Text))
            q = q.Where(x => x.Text != null && x.Text.Contains(TbNoteSearch.Text));


        RefreshNotesListView(q.ToList());
    }

    private void BtnDeleteNote_Click(object sender, EventArgs e)
    {
        if (selectedNote == null)
            return;

        db.Delete(selectedNote);

        RefreshNotesListView();
    }

    private void LvNotes_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedNote ??= new();

        selectedNote.Id = int.Parse(LvNotes.FocusedItem.SubItems[0].Text);
        selectedNote.Text = LvNotes.FocusedItem.SubItems[2].Text;
        selectedNote.CreatedAt = DateTime.Parse(LvNotes.FocusedItem.SubItems[1].Text);

        TbNoteEdit.Text = selectedNote.Text;
    }

    private void RefreshNotesListView(List<Note>? notes = null)
    {
        LvNotes.Items.Clear(); 

        foreach (var item in (notes ?? db.Table<Note>().ToList()))
        {
            LvNotes.Items.Add(new ListViewItem(new string[] 
            {
                item.Id.ToString(),
                item.CreatedAt.ToString(),
                item.Text ?? "Нет текста"
            }));
        }
    }
}


[Table("Notes")]
public class Note
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string? Text { get; set; }

    public DateTime CreatedAt { get; set; }
}