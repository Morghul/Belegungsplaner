namespace Prototyp_ZimmerverteilungV2
{
    partial class Bewohner_Anzeige
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Datum_Update_Button = new System.Windows.Forms.Button();
            this.Hinzufuegen_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Delete_All_Button = new System.Windows.Forms.Button();
            this.Bemerkungen_Button = new System.Windows.Forms.Button();
            this.Schließen_Button = new System.Windows.Forms.Button();
            this.Einzel_Bemerkung_loeschen_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anreise_Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreise_Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bemerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datum_Update_Button
            // 
            this.Datum_Update_Button.Location = new System.Drawing.Point(637, 126);
            this.Datum_Update_Button.Name = "Datum_Update_Button";
            this.Datum_Update_Button.Size = new System.Drawing.Size(94, 44);
            this.Datum_Update_Button.TabIndex = 4;
            this.Datum_Update_Button.Text = "Datum aktuallisieren";
            this.Datum_Update_Button.UseVisualStyleBackColor = true;
            this.Datum_Update_Button.Click += new System.EventHandler(this.Datum_Update_Button_Click);
            // 
            // Hinzufuegen_Button
            // 
            this.Hinzufuegen_Button.Location = new System.Drawing.Point(637, 12);
            this.Hinzufuegen_Button.Name = "Hinzufuegen_Button";
            this.Hinzufuegen_Button.Size = new System.Drawing.Size(94, 32);
            this.Hinzufuegen_Button.TabIndex = 5;
            this.Hinzufuegen_Button.Text = "Hinzufügen";
            this.Hinzufuegen_Button.UseVisualStyleBackColor = true;
            this.Hinzufuegen_Button.Click += new System.EventHandler(this.Hinzufuegen_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(637, 50);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(94, 32);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Löschen";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Delete_All_Button
            // 
            this.Delete_All_Button.Location = new System.Drawing.Point(637, 88);
            this.Delete_All_Button.Name = "Delete_All_Button";
            this.Delete_All_Button.Size = new System.Drawing.Size(94, 32);
            this.Delete_All_Button.TabIndex = 7;
            this.Delete_All_Button.Text = "Alles Löschen";
            this.Delete_All_Button.UseVisualStyleBackColor = true;
            this.Delete_All_Button.Click += new System.EventHandler(this.Delete_All_Button_Click);
            // 
            // Bemerkungen_Button
            // 
            this.Bemerkungen_Button.Location = new System.Drawing.Point(637, 176);
            this.Bemerkungen_Button.Name = "Bemerkungen_Button";
            this.Bemerkungen_Button.Size = new System.Drawing.Size(94, 44);
            this.Bemerkungen_Button.TabIndex = 8;
            this.Bemerkungen_Button.Text = "Bemerkung Hinzufügen";
            this.Bemerkungen_Button.UseVisualStyleBackColor = true;
            this.Bemerkungen_Button.Click += new System.EventHandler(this.Bemerkungen_Button_Click);
            // 
            // Schließen_Button
            // 
            this.Schließen_Button.Location = new System.Drawing.Point(637, 406);
            this.Schließen_Button.Name = "Schließen_Button";
            this.Schließen_Button.Size = new System.Drawing.Size(94, 32);
            this.Schließen_Button.TabIndex = 9;
            this.Schließen_Button.Text = "Schließen";
            this.Schließen_Button.UseVisualStyleBackColor = true;
            this.Schließen_Button.Click += new System.EventHandler(this.Schließen_Button_Click);
            // 
            // Einzel_Bemerkung_loeschen_Button
            // 
            this.Einzel_Bemerkung_loeschen_Button.Location = new System.Drawing.Point(637, 226);
            this.Einzel_Bemerkung_loeschen_Button.Name = "Einzel_Bemerkung_loeschen_Button";
            this.Einzel_Bemerkung_loeschen_Button.Size = new System.Drawing.Size(94, 56);
            this.Einzel_Bemerkung_loeschen_Button.TabIndex = 10;
            this.Einzel_Bemerkung_loeschen_Button.Text = "Einlzelne Bemerkung Löschen";
            this.Einzel_Bemerkung_loeschen_Button.UseVisualStyleBackColor = true;
            this.Einzel_Bemerkung_loeschen_Button.Click += new System.EventHandler(this.Einzel_Bemerkung_loeschen_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vorname,
            this.Nachname,
            this.Anreise_Datum,
            this.Abreise_Datum,
            this.Bemerkungen});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(619, 426);
            this.dataGridView1.TabIndex = 11;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            // 
            // Anreise_Datum
            // 
            this.Anreise_Datum.HeaderText = "Anreise Datum";
            this.Anreise_Datum.Name = "Anreise_Datum";
            // 
            // Abreise_Datum
            // 
            this.Abreise_Datum.HeaderText = "Abreise Datum";
            this.Abreise_Datum.Name = "Abreise_Datum";
            // 
            // Bemerkungen
            // 
            this.Bemerkungen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bemerkungen.DefaultCellStyle = dataGridViewCellStyle1;
            this.Bemerkungen.HeaderText = "Bemerkungen";
            this.Bemerkungen.Name = "Bemerkungen";
            this.Bemerkungen.Width = 106;
            // 
            // Bewohner_Anzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Einzel_Bemerkung_loeschen_Button);
            this.Controls.Add(this.Schließen_Button);
            this.Controls.Add(this.Bemerkungen_Button);
            this.Controls.Add(this.Delete_All_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Hinzufuegen_Button);
            this.Controls.Add(this.Datum_Update_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bewohner_Anzeige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bewohner_Anzeige";
            this.Load += new System.EventHandler(this.Bewohner_Anzeige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Datum_Update_Button;
        private Button Hinzufuegen_Button;
        private Button Delete_Button;
        private Button Delete_All_Button;
        private Button Bemerkungen_Button;
        private Button Schließen_Button;
        private Button Einzel_Bemerkung_loeschen_Button;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Vorname;
        private DataGridViewTextBoxColumn Nachname;
        private DataGridViewTextBoxColumn Anreise_Datum;
        private DataGridViewTextBoxColumn Abreise_Datum;
        private DataGridViewTextBoxColumn Bemerkungen;
    }
}