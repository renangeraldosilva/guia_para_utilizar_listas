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
    public partial class TelaUnirListas : Form
    {
        List<string> listaNomeUnir1 = new List<string>() { "João", "Maria", "José" };
        List<string> listaNomeUnir2 = new List<string>() { "Rafael", "Carina", "Carla" };
        List<string> listaNomeUnir3 = new List<string>();


        public TelaUnirListas()
        {
            InitializeComponent();
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void list2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void TelaUnirListas_Load(object sender, EventArgs e)
        {
            foreach (var item in listaNomeUnir1)
            {
                list1.Items.Add(item);
            }

            foreach (var item in listaNomeUnir2)
            {
                list2.Items.Add(item);
            }


        }

        private void bntUnirListas_Click(object sender, EventArgs e)
        {
            listaNomeUnir3.AddRange(listaNomeUnir1);
            listaNomeUnir3.AddRange(listaNomeUnir2);

            foreach (var item in listaNomeUnir3)
            {
                list3.Items.Add(item);
            }
        }
    }
}
