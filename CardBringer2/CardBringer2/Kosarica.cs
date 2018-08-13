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
    public partial class Kosarica : Form
    {
        public Kosarica()
        {
            InitializeComponent();
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.medjuspremnikKosarica' table. You can move, or remove it, as needed.
            this.medjuspremnikKosaricaTableAdapter.FillByKorisnik(this.database2DataSet.medjuspremnikKosarica);
            Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter medjuspremnik;
            medjuspremnik = new Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter();

        }
    }
}
