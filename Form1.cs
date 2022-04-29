using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAdicionarElementos_Click(object sender, EventArgs e)
        {
            Telas.TelaAdicionar frmAdicionar = new Telas.TelaAdicionar();
            frmAdicionar.ShowDialog();
        }

        private void btnRemoverElementos_Click(object sender, EventArgs e)
        {
            Telas.TelaRemover frmRemover = new Telas.TelaRemover();
            frmRemover.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnirListas_Click(object sender, EventArgs e)
        {
            Telas.TelaUnirListas frmUnir = new Telas.TelaUnirListas();
            frmUnir.ShowDialog();
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            Telas.TelaOrganizar frmOrganizar = new Telas.TelaOrganizar();
            frmOrganizar.ShowDialog();
        }
    }
}
