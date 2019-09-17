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
        public  IEnumerable<FileInfo> OrdernaPalavras(List<FileInfo> listaArquivos)
        {
            var ordernar = from c in listaArquivos orderby c.FullName.Substring(0, 1)  select c;
            var listar = ordernar.Distinct().ToList();

            return listar;

        }

        public IEnumerable<String> OrdernaPalavras(List<string> listaDePastas)
        {
            var ordernar = from c in listaDePastas orderby c.ToString().Substring(0,1) select c;
            var listar = ordernar.Distinct().ToList();

            return listar;

        }

    }
}
