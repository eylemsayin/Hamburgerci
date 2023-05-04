using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }
        void ChilForm(Form ChildForm)
        {
            this.Width = ChildForm.Width +25;  
            this.Height=ChildForm.Height +70;
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == ChildForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                ChildForm.MdiParent = this;
                ChildForm.Show();
            }
        }
        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChilForm(new Form1());
        }

        private void tsmTumSiparisleriGor_Click(object sender, EventArgs e)
        {
            ChilForm(new Form4());
        }

        private void tsmMenuEkleme_Click(object sender, EventArgs e)
        {
            ChilForm(new Form2());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChilForm(new Form3());
        }
    }
}
