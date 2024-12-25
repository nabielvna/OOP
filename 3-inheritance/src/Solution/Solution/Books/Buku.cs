namespace Solution.Books;

public class Buku
{
    private string _judul;
    private string _pengarang;

    public Buku(string judul, string pengarang)
    {
        _judul = judul;
        _pengarang = pengarang;
    }

    public string Judul
    {
        get { return _judul; }
        set { _judul = value; }
    }

    public string Pengarang
    {
        get { return _pengarang; }
        set { _pengarang = value; }
    }
}