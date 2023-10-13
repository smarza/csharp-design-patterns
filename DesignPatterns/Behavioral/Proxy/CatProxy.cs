namespace DesignPatterns.Behavioral.Proxy
{
    public class CatProxy : ICat
    {
        private RealCat _realCat;
        private string _name;

        public CatProxy(string name)
        {
            _name = name;
            Console.WriteLine($"\nCreating a Cache Proxy for {name}.");
        }

        public void ShowData()
        {
            if (_realCat == null)
            {
                _realCat = new RealCat(_name);
            }

            _realCat.ShowData();
        }
    }
}