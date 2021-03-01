using System;
using System.IO;
using System.Collections.Generic;

namespace movieLibrary2
{
  public class MenuSelection
  {
      
        public void Questions(){
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. View");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Exit");
        }
       public void format(){
            Console.WriteLine("Choose media\n");
            Console.WriteLine("1. Movies ");
            Console.WriteLine("2. Series ");
            Console.WriteLine("3. Videos");
            Console.WriteLine("4. Exit\n");
 
        }
        public void Menu()
        {
            int selection = 0;
            string option;

            //view menu

            do
            {
                format();
                selection = Int32.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:

                    do
                    {
                        Questions();
                        selection = Int32.Parse(Console.ReadLine());

                        if (selection == 1)
                        {
                            Movie readMovies = new Movie();
                        }
                        
                        do
                        {
                            readMovies.Read();
                            Console.WriteLine("Do you want to view more movies? (Y/N)");
                            option = Console.ReadLine().ToUpper();
                        }
                         while (option == "Y");
                    }

                    else if (Menu == 2)
                    {
                       Movie addMovie = new Movie(); 
                       do
                       {
                           addMovie.Add();
                           System.Console.WriteLine("Do you want to add another movie? (Y/N)");
                           option = Console.ReadLine().ToUpper();
                       } 
                       while (option == "Y");
                    }
                    else
                    {
                        Console.WriteLine("Return to menu...");
                    }
                    while (selection != 3);
                        break;

                    case 2: 
                    
                    do
                    {
                        Questions();
                        selection = Int32.Parse(Console.ReadLine());

                        if (selection == 2)
                        {
                            Series readSeries = new Series();
                        }
                        
                        do
                        {
                            readSeries.Read();
                            Console.WriteLine("Do you want to view series? (Y/N)");
                            option = Console.ReadLine().ToUpper();
                        }
                         while (option == "Y");
                    }

                    else if (Menu == 2)
                    {
                       Series addMovie = new Series(); 
                       do
                       {
                           addSeries.Add();
                           System.Console.WriteLine("Do you want to add another series? (Y/N)");
                           option = Console.ReadLine().ToUpper();
                       } 
                       while (option == "Y");
                    }
                    else
                    {
                        Console.WriteLine("Return to menu...");
                    }
                    while (selection != 3);
                        break; 

                    case 3:

                    do
                    {
                        Questions();
                        selection = Int32.Parse(Console.ReadLine());

                        if (selection == 3)
                        {
                            Video readVideos = new Video();
                        }
                        
                        do
                        {
                            readVideos.Read();
                            Console.WriteLine("Do you want to view videos? (Y/N)");
                            option = Console.ReadLine().ToUpper();
                        }
                         while (option == "Y");
                    }

                    else if (Menu == 3)
                    {
                       Video addVideos = new Videos(); 
                       do
                       {
                           addVideos.Add();
                           System.Console.WriteLine("Do you want to add another video? (Y/N)");
                           option = Console.ReadLine().ToUpper();
                       } 
                       while (option == "Y");
                    }
                    else
                    {
                        Console.WriteLine("Return to menu...");
                    }
                    while (selection != 3);
                    break;      
                }
                while (selection != 4);
                }
                
            }    
        }
  }  
}