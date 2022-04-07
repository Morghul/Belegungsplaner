namespace Prototyp_ZimmerverteilungV2
{
    public partial class Form1 : Form
    {
        Zimmer Z301 = new Zimmer();
        Zimmer Z302 = new Zimmer();
        Zimmer Z303 = new Zimmer();
        Zimmer Z304 = new Zimmer();
        Zimmer Z305 = new Zimmer();
        Zimmer Z306 = new Zimmer();
        Zimmer Z307 = new Zimmer();
        Zimmer Z308 = new Zimmer();
        Zimmer Z309 = new Zimmer();
        Zimmer Z310 = new Zimmer();
        Zimmer Z311 = new Zimmer();
        Zimmer Z312 = new Zimmer();

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test.Hinzufügen_Bewohner();
            //listBox1.Items.Clear();
            //foreach (string[] s in test.Bewohnerliste_Ausgeben())
            //{
            //    foreach (string s2 in s)
            //    {
            //        listBox1.Items.Add(s2);
            //    }
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Z301.Anzeigen_Bewohner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Z302.Anzeigen_Bewohner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Z303.Anzeigen_Bewohner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Z304.Anzeigen_Bewohner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Z305.Anzeigen_Bewohner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        { 
            Z306.Anzeigen_Bewohner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Z307.Anzeigen_Bewohner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Z308.Anzeigen_Bewohner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Z309.Anzeigen_Bewohner();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Z310.Anzeigen_Bewohner();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Z311.Anzeigen_Bewohner();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Z312.Anzeigen_Bewohner();
        }
    }
}