using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy
{
    public partial class NullableDateTimePicker : UserControl
    {

        public DateTime? Wartosc
        {
            get
            {
                if (txtData.Visible)
                    return null;
                else
                    return dtpData.Value;
            }
            set
            {
                if (value ==null)
                {
                    txtData.Visible = true;
                    dtpData.Visible = false;
                }
                else
                {
                    txtData.Visible = false;
                    dtpData.Visible = true;
                    dtpData.Value = (DateTime)value;
                }

            }
        }


        public NullableDateTimePicker()
        {
            InitializeComponent();
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtData.Visible = true;
                dtpData.Visible = false;
            }
            
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            txtData.Visible = false ;
            dtpData.Visible = true;
        }
    }
}
