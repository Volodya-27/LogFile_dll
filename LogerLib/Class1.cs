using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LogerLib
{
    // длл який зберігає це у файл 
    public static class Loger
    {
        static public void WriteStream(string text)
        {
            string path = "LogFile.log";

            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file, Encoding.Default))
                {
                    writer.Write("\n" + DateTime.Now + "\t");
                    writer.Write(text + "\t");
                    writer.Write("Tamogochi" + "\t");
                }
            }
        }
    }
}
