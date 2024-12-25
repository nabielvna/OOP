namespace Solution.ObjectSorter
{
    public interface ISortable
    {
        int Compare(ISortable other);
    }

    public abstract class Item
    {
        protected string _nama;
        public string Nama => _nama;

        protected Item(string nama)
        {
            _nama = nama;
        }
    }

    public class Buku : Item, ISortable
    {
        private int _jumlahHalaman;

        public Buku(string nama, int jumlahHalaman) : base(nama)
        {
            _jumlahHalaman = jumlahHalaman;
        }

        public int Compare(ISortable other)
        {
            if (other is Buku otherBuku)
            {
                return _jumlahHalaman.CompareTo(otherBuku._jumlahHalaman);
            }
            throw new ArgumentException("Cannot compare Buku with non-Buku object");
        }
    }

    public class Sepatu : Item, ISortable
    {
        private int _ukuran;

        public Sepatu(string nama, int ukuran) : base(nama)
        {
            _ukuran = ukuran;
        }

        public int Compare(ISortable other)
        {
            if (other is Sepatu otherSepatu)
            {
                return _ukuran.CompareTo(otherSepatu._ukuran);
            }
            throw new ArgumentException("Cannot compare Sepatu with non-Sepatu object");
        }
    }

    public class Makanan : Item
    {
        public Makanan(string nama) : base(nama) { }
    }

    public static class Sorter
    {
        public static ISortable[] SortItems(ISortable[] items)
        {
            var groupedItems = items.GroupBy(item => item.GetType()).ToList();

            var sortedGroups = groupedItems.Select(group =>
                group.ToArray().OrderBy(item => item, Comparer<ISortable>.Create((a, b) => a.Compare(b))).ToArray()
            ).ToList();

            return sortedGroups.SelectMany(group => group).ToArray();
        }
    }
}