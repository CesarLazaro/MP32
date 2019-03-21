using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void b_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Video (.wmv)|*.wmv|Music (.mp3)|*.mp3";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    String[] filtro = filePath.Split('.');
                    if(filtro[filtro.Length - 1].Equals("mp3") || filtro[filtro.Length - 1].Equals("wmv"))
                    {
                        String[] canciones = filePath.Split('\\');
                        Lista_Canciones.Items.Add(canciones[canciones.Length - 1]);
                    }
                    else
                    {
                        MessageBox.Show("SOLO SE PUEDEN SELECCIONAR CANCIONES");
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
