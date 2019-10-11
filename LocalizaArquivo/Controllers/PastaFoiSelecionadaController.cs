using LocalizaArquivo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Controllers
{
    public class PastaFoiSelecionadaController
    {

        public bool pastaFoiSelecionada()
        {
            bool resultado = false;
            if (PastaModel.pastaFoiSelecionada && PastaModel.nomeDaPasta.Length > 0)
            {
                resultado = true;
            }
            return resultado;
        }


    }
}
