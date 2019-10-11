using LocalizaArquivo.Controllers;
using LocalizaArquivo.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Util
{
    public class getFileUtil
    {
        private String Inicio = ConfigurationManager.AppSettings["CaminhoInicio"];
        private String Diretorio = ConfigurationManager.AppSettings["CaminhoDiretorio"];
        private String Pasta = ConfigurationManager.AppSettings["CaminhoPasta"];
        private String acessoDiretorios;


        public getFileUtil()
        {
            acessoDiretorios =Inicio +Diretorio + Pasta;
        }

        public void getArquivo()
        {
            PastaFoiSelecionadaController cltr = new PastaFoiSelecionadaController();
            var selecionouPasta=cltr.pastaFoiSelecionada();
            DirectoryInfo diretorio = null;

            if (selecionouPasta)
            {
                diretorio = new DirectoryInfo(PastaModel.nomeDaPasta);
            }
            else
            {
                diretorio = new DirectoryInfo(acessoDiretorios);
            }


            
            var carregouLista = false;
            try
            {
                filesModel.listaDeArquivos = diretorio.GetFiles("*.txt", SearchOption.AllDirectories);
                carregouLista = true;

                while (carregouLista==false)
                {
                    Console.WriteLine("carregando lista de arquivos!");

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

           
        }




    }



}

