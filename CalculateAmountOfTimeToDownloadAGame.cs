using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            string inputOfConversion;
            double hoursToMinutes;
            double timeToDownload100mb;
            double sizeOfFile;
            double result;
            
            //Make sure you get a stopwatch and time the length of downloading 100Megabytes *This gives ultimate precision 
            Console.Write("Enter the how long it took to download 100mb *example 20seconds = .20*: ");
            timeToDownload100mb = Convert.ToDouble(Console.ReadLine());
            //Make sure you convert your Gigabyte file to Megabyte as this will cater for games which are only 200Mbs etc
            Console.Write("Enter the size of the file *IN Mb MAKE SURE IT IS IN Megabytes*: ");
            sizeOfFile = Convert.ToDouble(Console.ReadLine());
            
            result = timeToDownload100mb * sizeOfFile;
            
            Console.Write("Do you want to convert the result to hours? (y/n) ");
            inputOfConversion = (Console.ReadLine());

            inputOfConversion = inputOfConversion.ToLower();

            if (inputOfConversion == "y")
            {
                result = result / 3600;
                Console.WriteLine("It will take " + result + " hours to download your game");
            }
            else 
            {
                Console.WriteLine("It will take " + result + " seconds to download your game");
            }         
                Console.ReadKey();
        }
    }
}
