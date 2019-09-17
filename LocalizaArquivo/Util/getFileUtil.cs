using LocalizaArquivo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Util
{
    public class getFileUtil
    {


        public static void getArquivo(String caminho)
        {
            DirectoryInfo diretorio = new DirectoryInfo(caminho);
            try
            {
                filesModel.listaDeArquivos = diretorio.GetFiles("*.txt", SearchOption.AllDirectories);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }





        }



    }
}
