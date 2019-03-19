using LocalizaArquivo.Controllers;
using LocalizaArquivo.Model;
using LocalizaArquivo.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LocalizaArquivo
{
    public partial class Form1 : Form
    {

        private readonly Arquivos arquivo;
        private LocalizaArquivosController localizaArquivos= new LocalizaArquivosController();
        private LocalizaPastasController localizaPastas= new LocalizaPastasController();
        private Arquivos atributo= new Arquivos();
        private AbriDiretorios diretorio= new AbriDiretorios();
        private Caminho caminho= new Caminho();
        private OrdenaArquivosController ordena = new OrdenaArquivosController();
        private List<String> list = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atributo.listaDeArquivos.Clear();
            string acessoApasta = caminho.Inicio + caminho.Diretorio + caminho.Pasta;
            var arquivo=diretorio.getArquivo(acessoApasta);
            localizaArquivos.LocalizaArquivos("",arquivo,atributo.listaDeArquivos);

            foreach (var item in ordena.OrdernaPalavras(atributo.listaDeArquivos))
            {
                listResultado.Items.Add(item.ToUpper());
            }

            labelTotalDeArquivos.Text = Convert.ToString(atributo.listaDeArquivos.Count());



           //DIRETORIOS 
            string acessoDiretorios = caminho.Inicio + caminho.Diretorio + caminho.Pasta;
            localizaPastas.LocalizaPastas(acessoDiretorios, atributo.listaDePastas);
            foreach (var item in ordena.OrdernaPalavras(atributo.listaDePastas))
            {
                comboPastas.Items.Add(item.ToUpper());
            }

        }





        private void botaoLocaliza_Click(object sender, EventArgs e)
        {
            atributo.listaDeArquivos.Clear();
            listResultado.Items.Clear();
            string texto = textoArquivo.Text;
            string acessoApasta = caminho.Inicio + caminho.Diretorio + caminho.Pasta;
            var arquivo = diretorio.getArquivo(acessoApasta);
            localizaArquivos.LocalizaArquivos(texto, arquivo, atributo.listaDeArquivos);

            foreach (var item in ordena.OrdernaPalavras(atributo.listaDeArquivos))
            {
                listResultado.Items.Add(item.ToUpper());

            }

            labelTotalDeArquivos.Text = Convert.ToString(atributo.listaDeArquivos.Count());


        }

        private void textoArquivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // aqui ele reconhece que foi apertado o ENTER, isso sei que está funcionando
            {
                botaoLocaliza_Click(sender, e);
            }
        }

        private void listResultado_DoubleClick(object sender, EventArgs e)
        {
            string acessoApasta = caminho.Inicio + caminho.Diretorio + caminho.Pasta;
            var arquivo = diretorio.getArquivo(acessoApasta);
            


            if (listResultado.SelectedItem != null)
             {
                //System.Diagnostics.Process.Start(arquivo[0].FullName);
                string indiceSelecionado = listResultado.SelectedItem.ToString();
                foreach (var item in arquivo)
                {
                    if (item.ToString().ToLower().Equals(indiceSelecionado.ToLower()) && item.ToString().Length== indiceSelecionado.ToLower().Length)
                    {
                        Process myProcess = new Process();
                        myProcess=Process.Start(item.FullName);
                        myProcess.Close();


                    }
                    
                }



            }
             

            }

        

        

        private void comboPastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            atributo.listaDeArquivos.Clear();
            listResultado.Items.Clear();
            string pastaSelecionada = comboPastas.Text;
            string acessoApasta = caminho.Inicio + caminho.Diretorio + caminho.Pasta+"\\"+pastaSelecionada;
            var arquivo = diretorio.getArquivo(acessoApasta);
           

            foreach (var item in ordena.OrdernaPalavras(arquivo))
            {
                listResultado.Items.Add(item.ToString().ToUpper());
            }

            labelTotalDeArquivos.Text = Convert.ToString(arquivo.Count());

        }
    }
}
