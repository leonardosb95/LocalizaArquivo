using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Util
{
    public class AbriDiretoriosUtil
    {
      

        public static DirectoryInfo getDiretorio(String caminho)
        {
            DirectoryInfo diretorios = new DirectoryInfo(caminho);
            return diretorios;
        }





    }
}
