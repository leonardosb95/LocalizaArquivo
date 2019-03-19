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
        public void LocalizaPastas(string caminho, List<string> Pastas)
        {
            DirectoryInfo diretorios = new DirectoryInfo(caminho);
            DirectoryInfo[] subPastas = diretorios.GetDirectories();

            foreach (var item in subPastas)
            {
                Pastas.Add(Convert.ToString(item));
            }

        }

    }
}
