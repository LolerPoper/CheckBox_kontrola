using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        {
            // poziv metode Clear() za brisanje sadrzaja text box-a

            TxtNarudzba.Clear();

            // poziv metode AppendText() za dodavanje sadrzaja u text box

            TxtNarudzba.AppendText("Odabrali ste :" + Environment.NewLine);

            if (CheckDorucak.Checked)

                TxtNarudzba.AppendText("dorucak" + Environment.NewLine);

            if (CheckRucak.Checked)

                TxtNarudzba.AppendText("rucak" + Environment.NewLine);

            if (CheckVecera.Checked)

                TxtNarudzba.AppendText("vecera" + Environment.NewLine);
        }

        private void CheckSakrij_CheckedChanged(object sender, EventArgs e)
        {

{
                if (TxtNarudzba.Visible == false)

                    TxtNarudzba.Visible = true;

                else

                    TxtNarudzba.Visible = false;

            }
        }
    }
}
