using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showfolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Geef het pad van de startfolder als argument.");
                return;
            }

            string startFolder = args[0];

            try
            {
                ShowFolders(startFolder);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Er is een fout opgetreden: {e.Message}");
            }
        }

        static void ShowFolders(string folder)
        {
            foreach (string subFolder in Directory.GetDirectories(folder))
            {
                Console.WriteLine(subFolder);
                ShowFolders(subFolder);
            }

        }
    }
}
