using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Util
{
    public class Caminho
    {
        public String Inicio= ConfigurationManager.AppSettings["CaminhoInicio"];
        public String Diretorio= ConfigurationManager.AppSettings["CaminhoDiretorio"];
        public String Pasta= ConfigurationManager.AppSettings["CaminhoPasta"];




    }
}
