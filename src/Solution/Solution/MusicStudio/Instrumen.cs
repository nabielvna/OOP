namespace Solution.MusicStudio
{
    public abstract class Instrumen
    {
        private string _nama;

        public Instrumen(string nama)
        {
            _nama = nama;
        }

        public string Nama
        {
            get { return _nama; }
        }

        public abstract string Mainkan();
    }

    public class Gitar : Instrumen
    {
        public Gitar(string nama) : base(nama) { }

        public override string Mainkan()
        {
            return "tring tring";
        }
    }

    public class Piano : Instrumen
    {
        public Piano(string nama) : base(nama) { }

        public override string Mainkan()
        {
            return "tink tink";
        }
    }

    public class StudioMusik
    {
        private List<Instrumen> _listInstrumen = new List<Instrumen>();

        public List<Instrumen> ListInstrumen
        {
            get { return _listInstrumen; }
        }

        public void TambahInstrumen(Instrumen instrumen)
        {
            _listInstrumen.Add(instrumen);
        }

        public string MainkanInstrumen()
        {
            return string.Join(Environment.NewLine, _listInstrumen.Select(instrumen =>
                $"{instrumen.Nama} berbunyi: {instrumen.Mainkan()}")) + Environment.NewLine;
        }
    }
}