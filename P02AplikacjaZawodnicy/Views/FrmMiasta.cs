using P02AplikacjaZawodnicy.Operations;
using P02AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using P02AplikacjaZawodnicy.ViewModels;

namespace P02AplikacjaZawodnicy.Views
{
    public partial class FrmMiasta : Form
    {
        public FrmMiasta()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            MiastaOperation mo = new MiastaOperation();
            var miasta = mo.PodajMiastaZBazy();

            for (int i = 0; i < miasta.Length; i++)
            {
                Button b = new Button();
                b.Name = "btnMiasto_" + i;
                b.Left = 20;
                b.Top = 100 + 30*i;
                b.Text = miasta[i].Nazwa;
                b.Click += btnMiato_Click;
                b.Tag = miasta[i];

                this.Controls.Add(b);
            }
          
        }

        private void btnMiato_Click(object sender, EventArgs e)
        {
            //     int id = ((MiastoVM)((Button)sender).Tag).Id;

            //  Button przyciskKlikniety = (Button)sender;
            //  MiastoVM miasto= (MiastoVM)przyciskKlikniety.Tag;

            Button przyciskKlikniety = sender as Button;
            MiastoVM miasto = (MiastoVM)przyciskKlikniety.Tag;

            MessageBox.Show(miasto.Id.ToString());


        }
    }
}
