namespace Solution.PetParade
{
    public abstract class Hewan
    {
        private string _nama;

        public Hewan(string nama)
        {
            _nama = nama;
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public abstract string Bersuara();
    }

    public class Kucing : Hewan
    {
        public Kucing(string nama) : base(nama) { }

        public override string Bersuara()
        {
            return "Meong";
        }
    }

    public class Anjing : Hewan
    {
        public Anjing(string nama) : base(nama) { }

        public override string Bersuara()
        {
            return "Guk";
        }
    }
}