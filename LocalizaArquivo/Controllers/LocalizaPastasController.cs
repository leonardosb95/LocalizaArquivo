using LocalizaArquivo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Controllers
{
    public class LocalizaPastasController
    {
        public static void LocalizaPastas(string caminho)
        {
            filesModel.listaDePastas.Clear();
            DirectoryInfo diretorios = new DirectoryInfo(caminho);
            DirectoryInfo[] subPastas = diretorios.GetDirectories();

            foreach (var item in subPastas)
            {
                filesModel.listaDePastas.Add(Convert.ToString(item));
            }

        }

    }
}
