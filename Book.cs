

namespace basics07
{
    internal class Book
    {
        private string Password = "Secret";
        internal int copiesInStock = 5;
        public string title;

        public Genre genre { get; set; }
    }
}