namespace Solution.PetParade
{
    public class ParadeHewan
    {
        private List<Hewan> _listHewan = new List<Hewan>();

        public List<Hewan> ListHewan
        {
            get { return _listHewan; }
        }

        public void TambahHewan(Hewan hewan)
        {
            _listHewan.Add(hewan);
        }

        public void HapusHewan(Hewan hewan)
        {
            _listHewan.Remove(hewan);
        }

        public void MulaiParade(int putaran)
        {
            for (int i = 0; i < putaran; i++)
            {
                foreach (var hewan in _listHewan)
                {
                    Console.WriteLine($"{hewan.Nama} bersuara: {hewan.Bersuara()}");
                }
            }
        }
    }
}