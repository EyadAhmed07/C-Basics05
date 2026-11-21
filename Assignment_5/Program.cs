using System.ComponentModel;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            #region Question01
            //book.Password = "secret"; 
            //Console.WriteLine(book.password); 
            //compilation error -> because password is private so we can't reach it out side his class 
            #endregion

            #region  Question02
            //book.copiesInStock=5;
            //Console.WriteLine(book.copiesInStock);
            // yes,because we are in the same assembly
            #endregion

            #region Question03
            //book.title = "book1";
            //Console.WriteLine(book.title);
            #endregion

            #region Question04
            //book.genre = Genre.Science;
            //Console.WriteLine(book.genre);
            #endregion

            #region Question05
            //int fic = (int)Genre.Fiction;
            //int nonFic = (int)Genre.NonFiction;
            //int science = (int)Genre.Science;
            //Console.WriteLine(fic);
            //Console.WriteLine(nonFic);
            //Console.WriteLine(science);
            #endregion

            #region Question06
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);
            #endregion

            #region Question07
            //Genre genre = Genre.Fiction;
            //string _genre = genre.ToString();
            //Console.WriteLine(_genre );
            #endregion

            #region Question08
            //string genreText = "Science";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre);

            #endregion

            #region Question09
            string genreText = "mystery";
            Genre genre;
            bool isGenre = Enum.TryParse<Genre>(genreText,out genre);
            if (!isGenre)
                Console.WriteLine("Unkown genre");
            else
                Console.WriteLine("Known genre");
            #endregion


        }
    }
}
