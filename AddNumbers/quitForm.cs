using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNumbers
{
    public partial class quitForm : Form
    {
        public quitForm()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            // Informs parent form that yes was selected
            this.DialogResult = DialogResult.OK;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            // Informs parent form that no was selected
            this.DialogResult = DialogResult.Cancel;
        }
    }

}
