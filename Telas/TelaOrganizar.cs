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
    public partial class TelaOrganizar : Form
    {
        List<string> listaNome = new List<string>() { "Rafael", "Carina", "Carla","Ane", "Lucas", "Otavio" };
        public TelaOrganizar()
        {
            InitializeComponent();
        }

        private void TelaOrganizar_Load(object sender, EventArgs e)
        {
            foreach (var item in listaNome)
            {
                listBoxOrganizar.Items.Add(item);
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            listaNome.Sort();
            listBoxOrganizar.Items.Clear();

            foreach (var item in listaNome)
            {
                listBoxOrganizar.Items.Add(item);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            listaNome.Reverse();
            listBoxOrganizar.Items.Clear();

            foreach (var item in listaNome)
            {
                listBoxOrganizar.Items.Add(item);
            }
        }
    }
}
