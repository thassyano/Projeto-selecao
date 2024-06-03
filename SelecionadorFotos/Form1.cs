using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SelecionadorFotos
{
    public partial class FotoPicker : Form
    {
        string Path;
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
            Path = txtBox_Path.Text;

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
    }
}
