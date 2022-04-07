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
    public partial class Bewohner_Add : Form
    {
        private string _vorname, _nachname, _anreise_datum, _abreise_datum;
        private Bewohner _temp_bewohner;

        public Bewohner_Add(Bewohner temp)
        {
            _vorname = "Max";
            _nachname = "Mustermann";
            _anreise_datum = "1.1.2000";
            _abreise_datum = "1.1.2000";
            _temp_bewohner = temp;
            InitializeComponent();          
        }

        private void Abbrechen_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_bestaetigen_Click(object sender, EventArgs e)
        {
            if (textBox_vorname.Text.Equals("") || textBox_nachname.Text.Equals(""))
            {
                MessageBox.Show("Keine Eingabe getätigt");
                return ;
            }
            _vorname = textBox_vorname.Text;
            _nachname = textBox_nachname.Text;
            _anreise_datum = anreisekalender.Value.ToString("d");
            _abreise_datum = abreisekalender.Value.ToString("d");
            string[] _bewohner_daten = { _vorname, _nachname, _anreise_datum, _abreise_datum };
            _temp_bewohner.Info_Eingabe(_bewohner_daten);
            Close();
        }

        private void abreisekalender_CloseUp(object sender, EventArgs e)
        {
            fixlabel_abreise.Focus();
        }

        private void anreisekalender_CloseUp(object sender, EventArgs e)
        {
            fixlabel_anreise.Focus();
        }
    }
}
