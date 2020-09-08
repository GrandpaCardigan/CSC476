namespace Dummy
{
    internal class Dummy
    {
        private string name;

        public string Name
        {
            get
            {
                return name != null ? name : "NA";
            }
            set
            {
                name = value;
            }
        }
    }

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Dummy d = new Dummy();
            System.Console.WriteLine(d.Name);
            d.Name = "Nick";
            System.Console.WriteLine(d.Name);
        }
    }
}
