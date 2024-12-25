using Solution.Books;

public class BukuPelajaran : Buku
{
    private string _subjek;

    public BukuPelajaran(string judul, string pengarang, string subjek)
        : base(judul, pengarang)
    {
        _subjek = subjek;
    }

    public string Subjek
    {
        get { return _subjek; }
        set { _subjek = value; }
    }
}