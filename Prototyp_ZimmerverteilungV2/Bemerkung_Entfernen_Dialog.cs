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
    public partial class Bemerkung_Entfernen_Dialog : Form
    {
        private Zimmer _local_zimmer;
        public Bemerkung_Entfernen_Dialog(Zimmer zimmer)
        {
            InitializeComponent();
            _local_zimmer = zimmer;
            foreach (string[] name in _local_zimmer.Bewohnerliste_Ausgeben())
            {
                string temp_voller_name = $"{name[0]} {name[1]}";
                Namen_combobox.Items.Add(temp_voller_name);
            }
        }

        private void Bestaetigen_Button_Click(object sender, EventArgs e)
        {
            var item = Namen_combobox.SelectedItem;
            string? voller_name = item.ToString();
            string checked_voller_name = voller_name is null ? "" : voller_name;
            Bewohner local_bewohner = _local_zimmer.Bewohner_Ermitteln(checked_voller_name);
            if (local_bewohner is not null)
            {
                var item_bemerkung = Bemerkungen_listbox.SelectedItem;
                string? bemerkung = item_bemerkung.ToString();
                if (bemerkung is not null)
                {
                    local_bewohner.Bemerkung_Entfernen(bemerkung);
                    _local_zimmer.Zimmer_Geandert();
                    Close();
                    return;
                }
                MessageBox.Show("Unbekannter Fehler aufgetreten");
                return;
            }
            MessageBox.Show("Unbekannter Fehler aufgetreten");
        }

        private void Abbrechen_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Namen_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = Namen_combobox.SelectedItem;
            string? voller_name = item.ToString();
            string checked_voller_name = voller_name is null ? "" : voller_name;
            Bewohner local_bewohner = _local_zimmer.Bewohner_Ermitteln(checked_voller_name);
            if (local_bewohner is not null)
            {
                List<string> local_bemerkungen = local_bewohner.Bemerkungen_Ausgabe();
                local_bemerkungen.ForEach(a => Bemerkungen_listbox.Items.Add(a));
                return;
            }
            MessageBox.Show("Unbekannter Fehler aufgetreten");
        }
    }
}
