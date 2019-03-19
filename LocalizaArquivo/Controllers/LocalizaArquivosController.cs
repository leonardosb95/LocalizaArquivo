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
         public void LocalizaArquivos(string textoValor, FileInfo[] arquivos, List<String> listaDeArquivos)
        {                
            foreach (var arq in arquivos)
            {
                StreamReader abrirArquivo = File.OpenText(arq.FullName);//Abrir arquivo txt
                string lerArquivo = abrirArquivo.ReadToEnd();//ler todo arquivo txt

                if (lerArquivo.ToUpper().IndexOf(textoValor.ToUpper()) > -1)//Encontra o caractere dentro do arquivo e le com a letra maiuscula
                {                  
                    listaDeArquivos.Add(Convert.ToString(arq));//Adicionando a lista no Dictionary
                 
                    
                }
                else
                {
                    abrirArquivo.Close();
                }
            }

        }


    }
}
