namespace Solution.Computers
{
    public class Processor
    {
        private string _brand;
        private double _speed;

        public Processor(string brand, double speed)
        {
            _brand = brand;
            _speed = speed;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
    }

    public class Memory
    {
        private int _capacity;
        private string _memoryType;

        public Memory(int capacity, string memoryType)
        {
            _capacity = capacity;
            _memoryType = memoryType;
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public string MemoryType
        {
            get { return _memoryType; }
            set { _memoryType = value; }
        }
    }

    public class Computer
    {
        public Processor Processor { get; set; }
        public Memory Memory { get; set; }

        public Computer(Processor processor, Memory memory)
        {
            Processor = processor;
            Memory = memory;
        }

        public string GetInfo()
        {
            return $"Processor Brand: {Processor.Brand}, Kecepatan: {Processor.Speed.ToString("F1", System.Globalization.CultureInfo.InvariantCulture)} GHz, Memory Kapasitas: {Memory.Capacity} GB, Tipe: {Memory.MemoryType}";
        }
    }
}