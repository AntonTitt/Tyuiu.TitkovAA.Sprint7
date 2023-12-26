using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TitkovAA.Sprint7.Project.V10
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                if (textBox2.Text == "secretsallaround")
                {
                    FormAboutMe4Real fr = new FormAboutMe4Real();
                    fr.Show();
                }
            }
        }
    }
}
