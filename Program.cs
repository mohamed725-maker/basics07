namespace basics07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            Book book = new Book();

            //Console.WriteLine(book.Password);
            /* the program will not run because the field password  is private so  can't use it out side the class */

            #endregion
        }
    }
}