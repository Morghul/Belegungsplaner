namespace Prototyp_ZimmerverteilungV2
{
    partial class Bewohner_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fixlabel_vorname = new System.Windows.Forms.Label();
            this.textBox_vorname = new System.Windows.Forms.TextBox();
            this.textBox_bemerkung = new System.Windows.Forms.TextBox();
            this.fixlabel_bemerkung = new System.Windows.Forms.Label();
            this.button_bestaetigen = new System.Windows.Forms.Button();
            this.textBox_nachname = new System.Windows.Forms.TextBox();
            this.fixlabel_nachname = new System.Windows.Forms.Label();
            this.fixlabel_anreise = new System.Windows.Forms.Label();
            this.fixlabel_abreise = new System.Windows.Forms.Label();
            this.anreisekalender = new System.Windows.Forms.DateTimePicker();
            this.abreisekalender = new System.Windows.Forms.DateTimePicker();
            this.Abbrechen_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fixlabel_vorname
            // 
            this.fixlabel_vorname.AutoSize = true;
            this.fixlabel_vorname.Location = new System.Drawing.Point(12, 9);
            this.fixlabel_vorname.Name = "fixlabel_vorname";
            this.fixlabel_vorname.Size = new System.Drawing.Size(54, 15);
            this.fixlabel_vorname.TabIndex = 1;
            this.fixlabel_vorname.Text = "Vorname";
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Location = new System.Drawing.Point(12, 27);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(200, 23);
            this.textBox_vorname.TabIndex = 2;
            // 
            // textBox_bemerkung
            // 
            this.textBox_bemerkung.Location = new System.Drawing.Point(228, 27);
            this.textBox_bemerkung.Multiline = true;
            this.textBox_bemerkung.Name = "textBox_bemerkung";
            this.textBox_bemerkung.Size = new System.Drawing.Size(200, 99);
            this.textBox_bemerkung.TabIndex = 5;
            // 
            // fixlabel_bemerkung
            // 
            this.fixlabel_bemerkung.AutoSize = true;
            this.fixlabel_bemerkung.Location = new System.Drawing.Point(228, 9);
            this.fixlabel_bemerkung.Name = "fixlabel_bemerkung";
            this.fixlabel_bemerkung.Size = new System.Drawing.Size(81, 15);
            this.fixlabel_bemerkung.TabIndex = 4;
            this.fixlabel_bemerkung.Text = "Bemerkungen";
            // 
            // button_bestaetigen
            // 
            this.button_bestaetigen.Location = new System.Drawing.Point(353, 185);
            this.button_bestaetigen.Name = "button_bestaetigen";
            this.button_bestaetigen.Size = new System.Drawing.Size(75, 23);
            this.button_bestaetigen.TabIndex = 6;
            this.button_bestaetigen.Text = "Bestätigen";
            this.button_bestaetigen.UseVisualStyleBackColor = true;
            this.button_bestaetigen.Click += new System.EventHandler(this.button_bestaetigen_Click);
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Location = new System.Drawing.Point(12, 71);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(200, 23);
            this.textBox_nachname.TabIndex = 8;
            // 
            // fixlabel_nachname
            // 
            this.fixlabel_nachname.AutoSize = true;
            this.fixlabel_nachname.Location = new System.Drawing.Point(12, 53);
            this.fixlabel_nachname.Name = "fixlabel_nachname";
            this.fixlabel_nachname.Size = new System.Drawing.Size(65, 15);
            this.fixlabel_nachname.TabIndex = 7;
            this.fixlabel_nachname.Text = "Nachname";
            // 
            // fixlabel_anreise
            // 
            this.fixlabel_anreise.AutoSize = true;
            this.fixlabel_anreise.Location = new System.Drawing.Point(12, 129);
            this.fixlabel_anreise.Name = "fixlabel_anreise";
            this.fixlabel_anreise.Size = new System.Drawing.Size(46, 15);
            this.fixlabel_anreise.TabIndex = 9;
            this.fixlabel_anreise.Text = "Anreise";
            // 
            // fixlabel_abreise
            // 
            this.fixlabel_abreise.AutoSize = true;
            this.fixlabel_abreise.Location = new System.Drawing.Point(228, 129);
            this.fixlabel_abreise.Name = "fixlabel_abreise";
            this.fixlabel_abreise.Size = new System.Drawing.Size(46, 15);
            this.fixlabel_abreise.TabIndex = 10;
            this.fixlabel_abreise.Text = "Abreise";
            // 
            // anreisekalender
            // 
            this.anreisekalender.Location = new System.Drawing.Point(12, 147);
            this.anreisekalender.Name = "anreisekalender";
            this.anreisekalender.Size = new System.Drawing.Size(200, 23);
            this.anreisekalender.TabIndex = 11;
            this.anreisekalender.CloseUp += new System.EventHandler(this.anreisekalender_CloseUp);
            // 
            // abreisekalender
            // 
            this.abreisekalender.Location = new System.Drawing.Point(228, 147);
            this.abreisekalender.Name = "abreisekalender";
            this.abreisekalender.Size = new System.Drawing.Size(200, 23);
            this.abreisekalender.TabIndex = 12;
            this.abreisekalender.CloseUp += new System.EventHandler(this.abreisekalender_CloseUp);
            // 
            // Abbrechen_Button
            // 
            this.Abbrechen_Button.Location = new System.Drawing.Point(12, 185);
            this.Abbrechen_Button.Name = "Abbrechen_Button";
            this.Abbrechen_Button.Size = new System.Drawing.Size(75, 23);
            this.Abbrechen_Button.TabIndex = 13;
            this.Abbrechen_Button.Text = "Abbrechen";
            this.Abbrechen_Button.UseVisualStyleBackColor = true;
            this.Abbrechen_Button.Click += new System.EventHandler(this.Abbrechen_Button_Click);
            // 
            // Bewohner_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 225);
            this.ControlBox = false;
            this.Controls.Add(this.Abbrechen_Button);
            this.Controls.Add(this.abreisekalender);
            this.Controls.Add(this.anreisekalender);
            this.Controls.Add(this.fixlabel_abreise);
            this.Controls.Add(this.fixlabel_anreise);
            this.Controls.Add(this.textBox_nachname);
            this.Controls.Add(this.fixlabel_nachname);
            this.Controls.Add(this.button_bestaetigen);
            this.Controls.Add(this.textBox_bemerkung);
            this.Controls.Add(this.fixlabel_bemerkung);
            this.Controls.Add(this.textBox_vorname);
            this.Controls.Add(this.fixlabel_vorname);
            this.Name = "Bewohner_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bewohner Hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label fixlabel_vorname;
        private TextBox textBox_vorname;
        private TextBox textBox_bemerkung;
        private Label fixlabel_bemerkung;
        private Button button_bestaetigen;
        private TextBox textBox_nachname;
        private Label fixlabel_nachname;
        private Label fixlabel_anreise;
        private Label fixlabel_abreise;
        private DateTimePicker anreisekalender;
        private DateTimePicker abreisekalender;
        private Button Abbrechen_Button;
    }
}