using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace _240401_1.Utils
{
    public class ExportToFile
    {

        private const string dir = @"/home/mr-robot/Documentos/Ciencia-da-computação-2024/prog1_24/exercicios/Arquivos";
        public static bool SaveToDelimitedTxt(string fileName, string fileContent){
            
            string filePath = @$"{dir}\{fileName}";

            try{

                if(!System.IO.Directory.Exists(dir))
                Directory.CreateDirectory(dir);

                using(StreamWriter sw = File.CreateText(filePath)){
                sw.Write(fileContent);
                }
            }
            catch{
                return false;
            }
            
            return true;

        }
    }
}