using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            string path = @"C:\programs\file.txt"; //**

            //get file name
            string filename = Path.GetFileName(path);
            Console.WriteLine("PATH:    {0}", path);
            Console.WriteLine("FILENAME:    {0}", filename);

            string filename2 = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("PATH:    {0}", path);
            Console.WriteLine("FILENAME:    {0}", filename2);

            //get extensions
            string value1 = @"C:\perls\word.txt";
            string value2 = @"C:\file.excel.dots.xlsx";
            string ex1 = Path.GetExtension(value1);
            string ex2 = Path.GetExtension(value2);
            Console.WriteLine(ex1);
            Console.WriteLine(ex2);
            Console.WriteLine("--------------------");

            //initialise directories
            string directory1 = @"C:\Users\vlogg\Downloads\";
            string directory2 = @"C:\Users\vlogg\Documents\Capita\Wk 1 soft skills\";

            //check directories exist
            if (Directory.Exists(directory1))
            {
                Console.WriteLine("Downloads directory exists!");
            }
            if (Directory.Exists(directory2))
            {
                Console.WriteLine("Wk 1 soft skills directory exists!");
            }

            //	Checking if path is absolute:
            if (Path.IsPathFullyQualified(directory1))
            {
                Console.WriteLine("Downloads directory path absolute!");
            }

            if (Path.IsPathFullyQualified(directory2))
            {
                Console.WriteLine("Downloads directory path absolute!");
            }

            //finding parents of directories
            string root_Directory1 = new DirectoryInfo(directory1).Parent.FullName;
            Console.WriteLine("root_Directory1 = {0}", root_Directory1);

            string root_Directory2 = new DirectoryInfo(directory2).Parent.FullName;
            Console.WriteLine("root_Directory2 = {0}", root_Directory2);

            //put all file names in root directory into array
            string[] array1 = Directory.GetFiles(directory1);
            string[] array2 = Directory.GetFiles(directory2);

            //printing download files

            //display all files in downloads
            Console.WriteLine("-------FILES:-------");
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }

            //display all files for week 1 capita
            Console.WriteLine("-------CAPITA:-------");
            foreach (string name in array2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------");
            Console.ReadLine();

        }
    }
}
