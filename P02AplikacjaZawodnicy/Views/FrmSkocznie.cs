using P02AplikacjaZawodnicy.Operations;
using P02AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy.Views
{
    public partial class FrmSkocznie : Form
    {
        public FrmSkocznie()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            SkocznieOperation so = new SkocznieOperation();
            var skocznie=  so.PodajSkocznieZBazy();

            lvDane.Items.Clear();

            ImageList listaObrazow = new ImageList();

            string[] kraje = skocznie.Select(x => x.Kraj.ToLower()).Distinct().ToArray();
            foreach (var k in kraje)
            {
                if(File.Exists($@"flagi\{k}.png"))
                    listaObrazow.Images.Add(k, Image.FromFile($@"flagi\{k}.png"));
            }
            lvDane.LargeImageList = listaObrazow;

            foreach (var s in skocznie)
            {
                lvDane.Items.Add(new ListViewItem()
                {
                    Text = s.Nazwa,
                    ImageKey = s.Kraj.ToLower(), 
                    Tag = s
                }) ;
            }    
        }

        private void lvDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDane.SelectedItems.Count>0)
            {
                SkoczniaVM skocznia = (SkoczniaVM)lvDane.SelectedItems[0].Tag;
                txtKraj.Text = skocznia.Kraj;
                txtNazwa.Text = skocznia.Nazwa;
            }
           
        }
    }
}
