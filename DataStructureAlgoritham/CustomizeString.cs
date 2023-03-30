using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSrtuctureAlgoritham
{
    internal class CustomizeString
    { 
        public void customize()
        {
            string line = "Hello <<name>>, we have your full name as <<full name>> in our system";
            line=line.Replace("<<name>>", "Amol");
            line = line.Replace("<<full name>>", "Amol Jadhav");
            line = line.Replace("91-xxxxxxxxx", "91-9881234568");
            Console.WriteLine(line);
        }
    }
}
