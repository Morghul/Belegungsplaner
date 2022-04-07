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
    public partial class Entfernen_Dialog : Form
    {
        private Zimmer _local;
        public Entfernen_Dialog(Zimmer zimmer)
        {
            InitializeComponent();
            _local = zimmer;
            foreach (string[] name in _local.Bewohnerliste_Ausgeben())
            {
                string temp_voller_name = $"{name[0]} {name[1]}";
                Voller_Name_Liste.Items.Add(temp_voller_name);
            }
        }

        private void Abbrechen_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bestaetigen_Button_Click(object sender, EventArgs e)
        {
            var item = Voller_Name_Liste.SelectedItem;
            if (item is not null)
            {
                string? voller_name = item.ToString();
                string checked_voller_name = voller_name is null ? "" : voller_name; 
                _local.Entfernen_Bewohner(checked_voller_name);
                Close();
                return;
            }
            MessageBox.Show("Kein Name ausgewählt");
        }
    }
}
