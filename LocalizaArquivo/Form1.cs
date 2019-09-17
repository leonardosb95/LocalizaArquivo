using LocalizaArquivo.Controllers;
using LocalizaArquivo.Model;
using LocalizaArquivo.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LocalizaArquivo
{
    public partial class Form1 : Form
    {


        private List<String> list = new List<string>();
        private OrdenaArquivosController ordena = new OrdenaArquivosController();

        private String Inicio = ConfigurationManager.AppSettings["CaminhoInicio"];
        private String Diretorio = ConfigurationManager.AppSettings["CaminhoDiretorio"];
        private String Pasta = ConfigurationManager.AppSettings["CaminhoPasta"];

        private char[] spearator = { '\\' };


        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            labelTotalDeArquivos.Text = Convert.ToString(0);

            //DIRETORIOS 
            string acessoDiretorios = Inicio + Diretorio + Pasta;
            LocalizaPastasController.LocalizaPastas(acessoDiretorios);



            //Carrega arquivos

            getFileUtil.getArquivo(acessoDiretorios);




            foreach (var item in ordena.OrdernaPalavras(filesModel.listaDePastas))
            {
                comboPastas.Items.Add(item.ToUpper());
            }

        }





        private async void botaoLocaliza_Click(object sender, EventArgs e)
        {
            //VARIAVEIS
            filesModel.listaArquivosEncontrados.Clear();
            listViewResultado.Items.Clear();
            string texto = textoArquivo.Text;

            string acessoApasta = Inicio + Diretorio + Pasta;



            string[] linguagem = null;


            if (!String.IsNullOrEmpty(texto))
            {

                LocalizaArquivosController.LocalizaArquivos(texto, filesModel.listaDeArquivos);

                if (filesModel.encontrouArquivo)
                {
                    mensagemLabel.ForeColor = Color.Green;
                    mensagemLabel.Text = "Encontrado!";




                    foreach (var item in filesModel.listaArquivosEncontrados)
                    {


                        if (item.FullName.Contains("Linguagens".ToLower()))
                        {
                            linguagem = item.FullName.Substring(1).Split(spearator);
                            ListViewItem list = new ListViewItem(linguagem[5]);
                            list.SubItems.Add(item.Name);
                            listViewResultado.Items.Add(list);
                        }


                    }
                }
                else
                {

                    mensagemLabel.ForeColor = Color.Red;
                    mensagemLabel.Text = "Palavra não localizada em nenhum arquivo txt!";
                }

            }
            else
            {
                mensagemLabel.ForeColor = Color.Red;
                mensagemLabel.Text = "Digite a palavra de que deseja localizar!";
            }

            labelTotalDeArquivos.Text = Convert.ToString(filesModel.listaArquivosEncontrados.Count());


        }

        private void textoArquivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // aqui ele reconhece que foi apertado o ENTER, isso sei que está funcionando
            {
                botaoLocaliza_Click(sender, e);
            }
        }

        private void listViewResultado_DoubleClick(object sender, EventArgs e)
        {
            string acessoApasta = Inicio + Diretorio + Pasta;

            if (listViewResultado.SelectedItems.Count > 0)
            {
                var arquivoSelecionado = listViewResultado.SelectedItems[0].SubItems[1].Text;
                foreach (var item in filesModel.listaDeArquivos)
                {
                    if (item.Name.ToLower().Equals(arquivoSelecionado.ToLower()) && item.Name.Length == arquivoSelecionado.Length)
                    {
                        Process myProcess = new Process();
                        myProcess = Process.Start(item.FullName);
                        myProcess.Close();


                    }

                }



            }
        }

        private void comboPastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            textoArquivo.Text = "";
            filesModel.listaArquivosEncontrados.Clear();
            filesModel.listaDeArquivosSelecionados.Clear();
            listViewResultado.Items.Clear();
            string pastaSelecionada = comboPastas.Text;
            string acessoApasta = Inicio + Diretorio + Pasta + "\\" + pastaSelecionada;

            string[] linguagem = null;

            foreach (var item in filesModel.listaDeArquivos)
            {
                var arquivo = item.FullName.ToLower().Substring(1);
                var pasta = acessoApasta.ToLower();
                linguagem = pasta.Split(spearator);
                if (arquivo.Contains(linguagem[8]))
                {
                    filesModel.listaDeArquivosSelecionados.Add(item);
                }

            }

            if (filesModel.listaDeArquivosSelecionados.Count > 0)
            {
                mensagemLabel.ForeColor = Color.Green;
                mensagemLabel.Text = "Encontrado!";
            }
            else
            {
                mensagemLabel.ForeColor = Color.Orange;
                mensagemLabel.Text = "Pasta não possui nenhum arquivo!";
            }

            foreach (var item in ordena.OrdernaPalavras(filesModel.listaDeArquivosSelecionados))
            {
                ListViewItem list = new ListViewItem(linguagem[8].ToLower());
                list.SubItems.Add(item.Name.ToLower());
                listViewResultado.Items.Add(list);

            }

            labelTotalDeArquivos.Text = Convert.ToString(filesModel.listaDeArquivosSelecionados.Count());

        }

        private void textoArquivo_Click(object sender, EventArgs e)
        {
            comboPastas.Text = "";

        }

        private void comboPastas_Click(object sender, EventArgs e)
        {
            textoArquivo.Text = "";
            mensagemLabel.Text = "";
        }


    }
}