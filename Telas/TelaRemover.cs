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
    public partial class TelaRemover : Form
    {
        List<string> listaNome2 = new List<string>() { "Jon", "Rafa", "Aegon","Ane" };

        public TelaRemover()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {    
            listBox1Remover.Items.Remove(txtNDigitado.Text);
            txtNDigitado.Clear();
            listBox1Remover.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void TelaRemover_Load(object sender, EventArgs e)
        {
            foreach (var item in listaNome2)
            {
                listBox1Remover.Items.Add(item);
            }
        }
    }
}
