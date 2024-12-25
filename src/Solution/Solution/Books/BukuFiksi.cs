using Solution.Books;

public class BukuFiksi : Buku
{
    private string _genre;

    public BukuFiksi(string judul, string pengarang, string genre)
        : base(judul, pengarang)
    {
        _genre = genre;
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }
}