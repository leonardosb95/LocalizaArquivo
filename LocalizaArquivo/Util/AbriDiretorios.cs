using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Util
{
    public class AbriDiretorios
    {
        public FileInfo[] getArquivo(String caminho)
        {
            DirectoryInfo diretorio = new DirectoryInfo(caminho);
            FileInfo[] arquivos = diretorio.GetFiles("*.txt", SearchOption.AllDirectories);

            return arquivos;
        }

        public DirectoryInfo getDiretorio(String caminho)
        {
            DirectoryInfo diretorios = new DirectoryInfo(caminho);
            return diretorios;
        }





    }
}
