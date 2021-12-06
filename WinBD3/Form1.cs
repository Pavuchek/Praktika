using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource sortBindingSourse;
        private void Form1_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            sortBindingSourse = new BindingSource(rbProductDataSet1, "Поставщики");
            FamtextBox.DataBindings.Add("Text", sortBindingSourse, "Поставщик");
            NametextBox.DataBindings.Add("Text", sortBindingSourse, "Адрес поставщика");
            SectiontextBox.DataBindings.Add("Text", sortBindingSourse, "Телефон");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sortBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sortBindingSourse.MoveNext();
        }
    }
}
