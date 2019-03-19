using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Controllers
{
    public class OrdenaArquivosController
    {
        public IEnumerable<string> OrdernaPalavras(List<string> listaArquivos)
        {
            var ordernar = from c in listaArquivos orderby c.Substring(0, 1)  select c;
            var listar = ordernar.Distinct().ToList();

            return listar;

        }

        public IEnumerable<FileInfo> OrdernaPalavras(FileInfo[] listaArquivos)
        {
            var ordernar = from c in listaArquivos orderby c.ToString().Substring(0,1) select c;
            var listar = ordernar.Distinct().ToList();

            return listar;

        }

    }
}
