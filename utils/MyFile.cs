using System.Collections.Generic;
using System.IO;

namespace WindowsFormsGestionCommandes.utils
{
    public class MyFile
    {
        private static readonly string PATH_FILE = @"C:\Users\Admin\Documents\c#\WindowsFormsGestionCommandes\utils\panier.txt";

        public static string[] getProductFromFile()
        {
            return File.ReadAllLines(PATH_FILE);
        }
        public static void clearFile()
        {
            StreamWriter stream = new StreamWriter(PATH_FILE);
            stream.Write("");
            stream.Close();
        }

        public static void addIdProductToFile(int id)
        {
            StreamWriter stream = new StreamWriter(PATH_FILE, append: true);
            stream.WriteLine(id);
            stream.Close();
        }
    }
}
