using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;



Console.WriteLine("Welcome to the Movie Libary");
Console.WriteLine("Enter 1 to view moive libary");
Console.WriteLine("Enter 2 to add to moive Libary");
Console.WriteLine("Enter anything else to exit");


string? resp = Console.ReadLine();
string MovieID = " ";
string type = " ";

string moiveTxt = " ";


if (resp == "1")
{

    // string FilePath = @"C:\Users\Quinn\Downloads\MoiveLibrary\movies.csv";
    string FilePath = @"C:\Users\Quinn\Downloads\MovieLibary2.1\movies.csv";
    try
    {
        using (StreamReader moives = new StreamReader(FilePath))
        {


           
            while ((moiveTxt = moives.ReadLine()) != null)
            {
                 string[] moiveArray = moiveTxt.Split(',');
                 MovieID = moiveArray[0];
                Console.WriteLine(moiveTxt);
                
                
             
            }
        }
       
          
    }
    catch
    {
        Console.WriteLine("wrong input");
    }
}
else
{
    string file =  @"C:\Users\Quinn\Downloads\MovieLibary2.1\movies.csv";
    try
    {
        using (System.IO.StreamWriter moivesLibary = new System.IO.StreamWriter(@file, true))
        {

            Console.WriteLine("What is the title of your moive");
            string Title = Console.ReadLine();
            Console.WriteLine("When did your moive come out");
            string year = Console.ReadLine();
            Console.WriteLine("What is the genre of your moive");
            string Genre = Console.ReadLine();

            // string addGenre = Console.ReadLine();
            bool keeplooping = true;
            while (keeplooping)
            {
                Console.WriteLine("Do you want to add more genres");
                Console.WriteLine("Enter 1 to add more genre");
                Console.WriteLine("Enter 2 to add moive to libary");
                 type = Console.ReadLine();

                // if (Genre == " ")
                // {
                //     Genre = Console.ReadLine();
                    if (type == "1")
                    {
                        Console.WriteLine("Enter New Genre");
                        Genre += "|" + Console.ReadLine();
                    }
                    else
                    {
                        keeplooping = false;
                    }


                // }


            }
          if(type == "2"){

            //   for(int i = 0; i < MovieID.Length; i++){
                // int i;
                //   int.Parse(MovieID);
                  
            //    string[] moiveArray = moiveTxt.Split(',');
            //     MovieID = moiveArray[0];
            string fullMovie = MovieID + "," + Title + "," + year + "," + Genre;
            // Console.WriteLine(fullMovie); 
            // Console.WriteLine(MovieID);
             moivesLibary.WriteLine(fullMovie);
            //   }
          }
        } 
        
    }
    catch
    {
      Console.WriteLine("wrong input");

    }
}


