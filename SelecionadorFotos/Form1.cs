using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SelecionadorFotos
{
    public partial class FotoPicker : Form
    {
        string _path;
        public FotoPicker()
        {
            InitializeComponent();
        }

        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            folderBrowserDialog1.Description = "Selecione uma pasta";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtBox_Path_TextChanged(object sender, EventArgs e)
        {
            _path = txtBox_Path.Text;

        }
        private void lbl_Files_Click(object sender, EventArgs e)
        {

        }

        private void FotoPicker_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_Arquivos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPath_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Arquivos.Text))
            {
                string[] arquivosFiltrados = txtBox_Arquivos.Text
                    .Split(new[] { " OR " }, StringSplitOptions.RemoveEmptyEntries);

                if (arquivosFiltrados.Length == 0)
                {
                    MessageBox.Show("Insira pelo menos um nome de arquivo no formato especificado.");
                    return;
                }

                List<string> arquivosSelecionados = new List<string>();

                foreach (string nomeArquivo in arquivosFiltrados)
                {
                    string caminhoCompleto = _path + "/" + nomeArquivo.Replace("\"", "").Trim(); 
                    if (File.Exists(caminhoCompleto)) 
                    {
                        arquivosSelecionados.Add(caminhoCompleto); 
                    }
                    else
                    {
                        MessageBox.Show($"O arquivo \"{nomeArquivo}\" não foi encontrado.");
                    }
                }

                if (arquivosSelecionados.Any())
                {
                    foreach (string arquivo in arquivosSelecionados)
                    {
                        MessageBox.Show(arquivo);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum arquivo correspondente aos nomes especificados foi encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Insira pelo menos um nome de arquivo no formato especificado.");
            }
        }

    }
}
