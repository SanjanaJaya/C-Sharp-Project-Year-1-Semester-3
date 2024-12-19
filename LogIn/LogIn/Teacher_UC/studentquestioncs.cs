using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn.Teacher_UC
{
    public partial class studentquestioncs : UserControl
    {
        public studentquestioncs()
        {
            InitializeComponent();
        }

        private void openquestion_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog2.FileName);
            }
        }
    }
}
