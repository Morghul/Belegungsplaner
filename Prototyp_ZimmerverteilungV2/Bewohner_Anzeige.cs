using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototyp_ZimmerverteilungV2
{
    public partial class Bewohner_Anzeige : Form
    {
        private Zimmer _local_zimmer;
        public Bewohner_Anzeige(Zimmer zimmer)
        {
            _local_zimmer = zimmer;
            
            InitializeComponent();
            _local_zimmer.Zimmer_Changed += Daten_Aktualisieren;
        }

        public void Daten_Laden(string[][] daten)
        {
            daten.ToList().ForEach(a => dataGridView1.Rows.Add(a));
        }

        private void Daten_Aktualisieren(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _local_zimmer.Bewohnerliste_Ausgeben().ToList().ForEach(a => dataGridView1.Rows.Add(a));

        }

        private void Hinzufuegen_Button_Click(object sender, EventArgs e)
        {
            _local_zimmer.Hinzufügen_Bewohner();
        }

        private void Schließen_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_All_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _local_zimmer.Entfernen_Alle();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Entfernen_Dialog entfernen = new Entfernen_Dialog(_local_zimmer);
            entfernen.ShowDialog();
        }

        private void Datum_Update_Button_Click(object sender, EventArgs e)
        {
            _local_zimmer.Datum_Update();
        }

        private void Bemerkungen_Button_Click(object sender, EventArgs e)
        {
            Bemerkung_Dialog bemerkung = new Bemerkung_Dialog(_local_zimmer);
            bemerkung.ShowDialog();
        }

        private void Einzel_Bemerkung_loeschen_Button_Click(object sender, EventArgs e)
        {
            Bemerkung_Entfernen_Dialog bemerkung_entfernen = new Bemerkung_Entfernen_Dialog(_local_zimmer);
            bemerkung_entfernen.ShowDialog();
        }

        private void Bewohner_Anzeige_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.Bemerkungen.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
    }
}
