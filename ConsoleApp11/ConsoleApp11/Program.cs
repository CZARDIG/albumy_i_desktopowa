using System.Text;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Album> albums = new List<Album>();

            string path = @"C:\Users\TEB\Downloads\pliki2\Data.txt";
            StreamReader stream = new StreamReader(path, Encoding.UTF8, true);

            while(!stream.EndOfStream)
            {
                albums.Add(new Album() { 
                    artist = stream.ReadLine(),
                    album = stream.ReadLine(),
                    songNumber = stream.ReadLine(),
                    year = stream.ReadLine(),
                    downloadNumber = stream.ReadLine(),
                });
                stream.ReadLine();
            }
            stream.Close();

            foreach(Album album in albums)
            {
                Console.WriteLine(album.artist);
                Console.WriteLine(album.album);
                Console.WriteLine(album.songNumber);
                Console.WriteLine(album.year);
                Console.WriteLine(album.downloadNumber);
                Console.WriteLine();
            }
        }

    }
}
