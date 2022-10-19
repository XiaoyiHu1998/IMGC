using System;
using System.IO;
using System.Threading.Tasks;
using ImageMagick;

namespace IMGC
{
    class Program
    {
        static string folderPath;
        static string sourceExtension;
        static string targetExtension;

        static DirectoryInfo folderDirectory;
        static FileInfo[] files;

        static void Main(string[] args)
        {
            Console.WriteLine("This program converts all images of source type to images of target type and puts them in a subfolder of given source path");
            while (true)
            {
                try
                {
                    ConversionCycle();
                }
                catch(Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }
        }

        static void ConversionCycle()
        {
            GetInput();

            Directory.CreateDirectory(folderPath + @"\" + folderDirectory.Name + " " + targetExtension);

            Console.WriteLine("Starting Conversion");
            Parallel.For(0, files.Length - 1, i =>
            {
                string imageSourcePath = @folderPath + @"\" + @files[i].Name;
                string imageTargetPath = @folderPath + @"\" + folderDirectory.Name + " " + targetExtension + @"\" + @files[i].Name.Replace(files[i].Name.Split(".")[1], targetExtension);

                Console.WriteLine("Converting: " + imageTargetPath);

                using (var image = new MagickImage(imageSourcePath))
                {
                    try
                    {
                        image.Write(imageTargetPath);
                    }
                    catch (MagickCoderErrorException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            });

            Console.WriteLine("Finished Converting\n");
        }

        static void GetInput()
        {
            do
            {
                Console.Write("Source path, \"help\" or \"exit\": ");
                folderPath = Console.ReadLine();
                folderDirectory = new DirectoryInfo(@folderPath);

                if (folderPath == "exit")
                    Environment.Exit(0);

                if (folderPath == "help")
                    Console.WriteLine(Help.Text);

                if (folderDirectory.Exists)
                    break;

            } while (true);

            Console.Write("Source extension or \"all\" to attempt converting all files in directory: ");
            sourceExtension = Console.ReadLine();

            Console.Write("Target extension: ");
            targetExtension = Console.ReadLine();

            files = (sourceExtension == "all") ?  folderDirectory.GetFiles("*.*") : folderDirectory.GetFiles("*." + sourceExtension);
            Console.WriteLine("Found " + files.Length + " image files");
        }
    }
}
