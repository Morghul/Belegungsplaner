using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp_ZimmerverteilungV2
{
    public class Bewohner
    {
        private string _vorname, _nachname, _anreise_datum, _abreise_datum;
        private List<string> _bemerkungen = new List<string>();

        public Bewohner()
        {
            _vorname = "Max";
            _nachname = "Mustermann";
            _anreise_datum = "1.1.2000";
            _abreise_datum = "1.1.2000";
            Bewohner_Add eingabe = new Bewohner_Add(this);
            eingabe.ShowDialog();
        }

        public string[] Info_Ausgabe()
        {
            string temp_bemerkungen = string.Empty;
            string nl = Environment.NewLine;
            foreach (string b in _bemerkungen)
            {
                temp_bemerkungen = temp_bemerkungen + nl + b;
            }
            return new string[] { _vorname, _nachname, _anreise_datum, _abreise_datum, temp_bemerkungen };
        }

        public void Info_Eingabe(string[] daten_eingabe)
        {
            _vorname = daten_eingabe[0];
            _nachname = daten_eingabe[1];
            _anreise_datum = daten_eingabe[2];
            _abreise_datum= daten_eingabe[3];
        }

        public void Bemerkung_Hinzufügen(string bemerkung)
        {
            _bemerkungen.Add(bemerkung);
        }

        public void Bemerkung_Entfernen(string bemerkung)
        {
            //int local_index = _bemerkungen.FindIndex(a => a.Contains(bemerkung));
            //_bemerkungen.RemoveAt(local_index);
            _bemerkungen.Remove(bemerkung);
        }

        public string Vorname
        {
            get { return _vorname; }
        }

        public string Nachname
        {
            get { return _nachname; }
        }

        public string Anreise_Datum
        {
            get { return _anreise_datum;}
        }

        public string Abreise_Datum
        {
            get { return _abreise_datum;}
        }

        public void Datum_Update()
        {
            _anreise_datum = DateTime.Today.ToString("d");
            DateTime abreise = DateTime.Today;
            while (!abreise.ToString("ddd").Equals("Fr"))
            {
                abreise = abreise.AddDays(1);
            }
            _abreise_datum = abreise.ToString("d");
        }

        public List<string> Bemerkungen_Ausgabe()
        {
            return _bemerkungen;
        }
    }
}
