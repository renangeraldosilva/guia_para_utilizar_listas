using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula33.Telas
{
    public partial class TelaAdicionar : Form
    {
        List<string> listaNomes = new List<string>();
        List<string> listaNome2 = new List<string>() { "Jon", "Rafa","Aegon" };
        
        public TelaAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            listaNomes.Add(txtNomeDigitado.Text);
            txtBoxLista.Items.Add(txtNomeDigitado.Text);
            txtNomeDigitado.Clear();
            txtBoxLista.Show();
        }

        private void txtBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TelaAdicionar_Load(object sender, EventArgs e)
        {
            foreach (var item in listaNome2)
            {
                txtBoxLista.Items.Add(item);
            }
        }

        private void txtNomeDigitado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
