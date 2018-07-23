using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBringer2
{
    public partial class MojProfil : Form
    {
        Database2DataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        
        int korisnikIme;
        public MojProfil(int ime)
        {
            InitializeComponent();
            korisnikIme = ime;
            korisnikTableAdapter = new Database2DataSetTableAdapters.korisnikTableAdapter();
        }

        private void MojProfil_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            int IDkorisnika = korisnikIme;
            MojProfilLabelID.Text = IDkorisnika.ToString() ;
            
            
            MojProfilLabelNickname.Text = korisnikTableAdapter.ImeReturn(korisnikIme);
            MojProfilLabelAdresa.Text = korisnikTableAdapter.adresaReturn(korisnikIme).ToString();
            MojProfilLabelEmail.Text = korisnikTableAdapter.emailReturn(korisnikIme).ToString();
            int uloga = (int)korisnikTableAdapter.ulogaReturn(korisnikIme);
            if(uloga == 1)
            {
                MojProfilLabelTipKorisnika.Text = "Kupac";
            }
            else
            {
                MojProfilLabelTipKorisnika.Text = "Prodavač";
            }
            // TODO: This line of code loads data into the 'database2DataSet.korisnikKarta' table. You can move, or remove it, as needed.
            korisnikKartaTableAdapter.FillBykarteKorisnika(database2DataSet.korisnikKarta, IDkorisnika);
        }
    }
}
