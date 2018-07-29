using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafizIslamiBank.Views
{
    public partial class SearchAccountInfoUi : Form
    {
        public SearchAccountInfoUi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchAccountInfoUi_FormClosed(object sender, FormClosedEventArgs e)
        {
            IndexPageUi indexForm = new IndexPageUi();
            this.Hide();
            indexForm.Show();
        }
    }
}
