using LocalizaArquivo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivo.Controllers
{
    public class LocalizaArquivosController
    {
         public static void LocalizaArquivos(string textoValor, FileInfo[] listaArquivos)
        {
            filesModel.encontrouArquivo = false;


            foreach (var arq in listaArquivos)
            {
                StreamReader abrirArquivo = File.OpenText(arq.FullName);//Abrir arquivo txt
                string lerArquivo = abrirArquivo.ReadToEnd();//ler todo arquivo txt

                if (lerArquivo.ToUpper().IndexOf(textoValor.ToUpper()) > -1)//Encontra o caractere dentro do arquivo e le com a letra maiuscula
                {
                    var ignorarArquivo="license";
                    if (arq.Name.ToLower().Contains(ignorarArquivo))
                    {
                        continue;
                    }
                    filesModel.listaArquivosEncontrados.Add(arq);//Adicionando a lista no Dictionary


                    filesModel.encontrouArquivo = true;
                }
                else
                {
                    
                    abrirArquivo.Close();
                }
            }

        }


    }
}
