using P03AplikacjaZawodnicy.Core.Core.Domain;
using P03AplikacjaZawodnicy.Core.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy.Views
{
    public partial class FrmTrenerzy : Form
    {
        FrmSzczegoly frmSzczegoly; // rodzic 
        Trener dodanyTrener;
        public FrmTrenerzy()
        {
            InitializeComponent();
            Odswiez();


        }
        private void Odswiez()
        {
            // rozwiązanie 1: 
            // bezposrednio do datasrouce wrzucamy trenerow 
            // ograniczenie: nie mozna dodawac ani usuwac elementow 
            //TrenerzyRepository zr = new TrenerzyRepository();
            //Trener[] trenerzy = zr.WczytajTrenerow();
            //dgvDane.DataSource = trenerzy;

            //rozwiazanie 2: 
            // trzeba uzyc warstwy posredniej pomiedzy danymi a datagrid view 
            // ta warstwa to obiekt BindingSource 

            TrenerzyRepository tr = new TrenerzyRepository();

            BindingSource bs = new BindingSource();
            bs.AllowNew = true;
            bs.DataSource = tr.WczytajTrenerow().ToList();

            dgvDane.DataSource = bs;
            dgvDane.Refresh();
        }

        public FrmTrenerzy(FrmSzczegoly frmSzczegoly) : this()
        {
            this.frmSzczegoly = frmSzczegoly;
        }

        private void dgvDane_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int edtytowanyWiersz = e.RowIndex;
            dodanyTrener = (Trener)dgvDane.Rows[edtytowanyWiersz].DataBoundItem;
            TrenerzyRepository tr = new TrenerzyRepository();

            try
            {
                if (dodanyTrener.Id > 0)
                    tr.Edytuj(dodanyTrener);
                else
                    dodanyTrener.Id = tr.DodajTrenera(dodanyTrener);
            }
            catch (Exception)
            {
                MessageBox.Show("Operacja się niepowiodła", "Błąd baza danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Odswiez();
            }
            
           
        }

        private void dgvDane_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void FrmTrenerzy_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dodanyTrener != null && frmSzczegoly != null)
                frmSzczegoly.Odswiez(dodanyTrener);
            
        }

        private void dgvDane_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Trener t = (Trener)e.Row.DataBoundItem;
            TrenerzyRepository tr = new TrenerzyRepository();

            try
            {
                tr.Usun(t);
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Nie możesz usunać trenera, który kogoś trenuje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Błąd w bazie danych. Operacja przerwana", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Cancel = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Bład programu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }

           
               

        }
    }
}
