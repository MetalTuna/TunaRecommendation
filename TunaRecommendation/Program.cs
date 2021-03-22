using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunaRecommendation
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileAddressString = @"F:\WebDisk\Live\OneDrive\바탕 화면\YouTube CoH2 Metadata.txt";
            FileInfo fileInfo = new FileInfo(FileAddressString);

            Console.WriteLine(fileInfo.ToString());
        }
    }
}
