using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskTop
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new AddQuote());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewQuotes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new SearchQuotes());
        }

        private void OpenForm(Form form)
        {
            if (!IsFormOpen(form))
            {
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }

        private bool IsFormOpen(Form form)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == form.GetType())
                {
                    return true;
                }
            }
            return false;
        }

       
    }
}
