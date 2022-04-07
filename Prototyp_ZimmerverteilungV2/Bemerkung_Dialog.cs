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
    public partial class Bemerkung_Dialog : Form
    {
        //private Bewohner _local_bewohner;
        private Zimmer _local_zimmer;
        public Bemerkung_Dialog(Zimmer zimmer)
        {
            InitializeComponent();
            _local_zimmer = zimmer;
            foreach (string[] name in _local_zimmer.Bewohnerliste_Ausgeben())
            {
                string temp_voller_name = $"{name[0]} {name[1]}";
                Name_Combobox.Items.Add(temp_voller_name);
            }
        }

        private void Button_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bestaetigen_Button_Click(object sender, EventArgs e)
        {
            var item = Name_Combobox.SelectedItem;
            string? voller_name = item.ToString();
            string checked_voller_name = voller_name is null ? "" : voller_name;
            Bewohner local_bewohner = _local_zimmer.Bewohner_Ermitteln(checked_voller_name);
            if (local_bewohner is not null)
            {
                local_bewohner.Bemerkung_Hinzufügen(Bemerkungen_textbox.Text);
                _local_zimmer.Zimmer_Geandert();
                Close();
                return;
            }
            MessageBox.Show("Die Bemerkung konnte nicht Hinzugefügt werden");
            Close();
        }
    }
}
