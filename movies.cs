using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace movieLibrary2

{
    public class Movies : mediaType
    {
        public int MovieId { get; set; }
        
        public string MovieTitle { get; set; }
        public List<string> MovieGenre = new List<string>();
        private static string File = "movies.csv";

        //view movie list

        public override void View();
        {
            Console.WriteLine("How many movies do you want displayed?");
            int numberOfMovies = Int32.Parse(Console.ReadLine());

            StreamReader sr = new StreamReader(File);

            
            for
            (int i = 0; i < numberOfMovies + 1 ; i++)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);    
            }
            sr.Close();
        }

        // add into movie list
        public override void Add();
        {
            
        }
    }
}