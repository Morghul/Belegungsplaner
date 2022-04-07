using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp_ZimmerverteilungV2
{
    public class Zimmer
    {
        private List<Bewohner> _bewohner_List = new List<Bewohner>();
        private bool _allert = false;

        public void Hinzufügen_Bewohner()
        {
            Bewohner bewohner = new Bewohner();
            if (bewohner.Info_Ausgabe()[3].Equals("1.1.2000"))
            {
                return;
            }
            _bewohner_List.Add(bewohner);
            Zimmer_Changed?.Invoke(this, EventArgs.Empty);
        }

        public string[][] Bewohnerliste_Ausgeben()
        {
            int listenlaenge = _bewohner_List.Count;
            int counter = 0;
            string[][] bewohner_infos = new string[listenlaenge][];
            foreach (Bewohner b in _bewohner_List) 
            {
                bewohner_infos[counter] = b.Info_Ausgabe();
                counter++;
            }
            return bewohner_infos;
        }

        public void Entfernen_Bewohner(string name)
        {
            if (Bewohner_Ermitteln(name) == null)
            {
                return;
            }
            _bewohner_List.Remove(Bewohner_Ermitteln(name));
            Zimmer_Changed?.Invoke(this, EventArgs.Empty);
        }

        public Bewohner Bewohner_Ermitteln(string name)
        {
            foreach (Bewohner b in _bewohner_List)
            {
                string[] temp = b.Info_Ausgabe();
                if (temp.Any(name.Contains))
                {
                    return b;
                }
            }
            return null;
        }

        public void Entfernen_Alle()
        {
            _bewohner_List.Clear();
        }

        public void Anzeigen_Bewohner()
        {
            Bewohner_Anzeige Anzeige = new Bewohner_Anzeige(this);
            Anzeige.Daten_Laden(this.Bewohnerliste_Ausgeben());
            Anzeige.ShowDialog();
        }

        public void Datum_Update()
        {
            foreach (Bewohner b in _bewohner_List)
            {
                b.Datum_Update();
            }
            Zimmer_Changed?.Invoke(this, EventArgs.Empty);
        }

        public void Zimmer_Geandert()
        {
            Zimmer_Changed?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? Zimmer_Changed;
    }
}
