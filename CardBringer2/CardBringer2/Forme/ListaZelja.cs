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

namespace CardBringer2
{
    public partial class ListaZelja : Form
    {

    
        public ListaZelja()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {
            kartaBindingSource.DataSource = karta.DohvatiKarte();
            ListaZeljaDataGrid.DataSource = wishlist.DohvatiWishlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaZeljaGumbMakni_Click(object sender, EventArgs e)
        {
            
        }
        
        private void GumbResetListaZelja_Click(object sender, EventArgs e)
        {
            SveKarteDatagrid.DataSource = karta.DohvatiKarte();
        }

        private void ListaZeljaButtonTrazi_Click(object sender, EventArgs e)
        {
            Trazi();
        }

        private void ListaZeljaTrazi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Trazi();
            }
        }

        private void Trazi()
        {
            var pretrazivaniString = ListaZeljaTraziUSvimKartama.Text;
            SveKarteDatagrid.DataSource = karta.TraziKarte(pretrazivaniString);
        }

        private void SveKarteDatagrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (SveKarteDatagrid.SelectedRows.Count <= 0) return;
            imeKarteSveKarte.Text = SveKarteDatagrid.SelectedRows[0].Cells[1].Value.ToString();
            opisKarteSveKarte.Text = SveKarteDatagrid.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(SveKarteDatagrid.SelectedRows[0].Cells[3].Value.ToString());
            pictureBoxSlikaKarteSveKarte.Image = Image.FromStream(slikaKarte);
            pictureBoxSlikaKarteSveKarte.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ListaZeljaDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaZeljaDataGrid.SelectedRows.Count <= 0) return;
            imeKarteListaZelja.Text = ListaZeljaDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            opisKarteListaZelja.Text = ListaZeljaDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            var slikaKarte = AzureStorageKarata.DohvatiSlikuKarte(ListaZeljaDataGrid.SelectedRows[0].Cells[3].Value.ToString());
            pictureBoxSlikaKarteListaZelja.Image = Image.FromStream(slikaKarte);
            pictureBoxSlikaKarteListaZelja.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
