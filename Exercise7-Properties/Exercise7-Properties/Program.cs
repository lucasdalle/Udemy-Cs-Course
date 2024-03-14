namespace Exercise7_Properties
{
    internal class Program
    {
        private string _title;
        private int _pages;

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == "" || value == null)
                    _title = "Unknown";
                else
                    _title = value;
            }
        }

        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value < 1)
                    _pages = 1;
                else
                    _pages = value;
            }

        }
    }
}