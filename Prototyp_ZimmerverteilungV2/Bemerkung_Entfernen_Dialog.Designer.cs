namespace Prototyp_ZimmerverteilungV2
{
    partial class Bemerkung_Entfernen_Dialog
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
            this.Abbrechen_Button = new System.Windows.Forms.Button();
            this.Bestaetigen_Button = new System.Windows.Forms.Button();
            this.Namen_combobox = new System.Windows.Forms.ComboBox();
            this.Bemerkungen_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Abbrechen_Button
            // 
            this.Abbrechen_Button.Location = new System.Drawing.Point(12, 228);
            this.Abbrechen_Button.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.Abbrechen_Button.Name = "Abbrechen_Button";
            this.Abbrechen_Button.Size = new System.Drawing.Size(75, 23);
            this.Abbrechen_Button.TabIndex = 6;
            this.Abbrechen_Button.Text = "Abbrechen";
            this.Abbrechen_Button.UseVisualStyleBackColor = true;
            this.Abbrechen_Button.Click += new System.EventHandler(this.Abbrechen_Button_Click);
            // 
            // Bestaetigen_Button
            // 
            this.Bestaetigen_Button.Location = new System.Drawing.Point(347, 228);
            this.Bestaetigen_Button.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Bestaetigen_Button.Name = "Bestaetigen_Button";
            this.Bestaetigen_Button.Size = new System.Drawing.Size(75, 23);
            this.Bestaetigen_Button.TabIndex = 5;
            this.Bestaetigen_Button.Text = "Bestätigen";
            this.Bestaetigen_Button.UseVisualStyleBackColor = true;
            this.Bestaetigen_Button.Click += new System.EventHandler(this.Bestaetigen_Button_Click);
            // 
            // Namen_combobox
            // 
            this.Namen_combobox.FormattingEnabled = true;
            this.Namen_combobox.Location = new System.Drawing.Point(12, 12);
            this.Namen_combobox.Name = "Namen_combobox";
            this.Namen_combobox.Size = new System.Drawing.Size(121, 23);
            this.Namen_combobox.TabIndex = 7;
            this.Namen_combobox.SelectedIndexChanged += new System.EventHandler(this.Namen_combobox_SelectedIndexChanged);
            // 
            // Bemerkungen_listbox
            // 
            this.Bemerkungen_listbox.FormattingEnabled = true;
            this.Bemerkungen_listbox.ItemHeight = 15;
            this.Bemerkungen_listbox.Location = new System.Drawing.Point(12, 41);
            this.Bemerkungen_listbox.Name = "Bemerkungen_listbox";
            this.Bemerkungen_listbox.Size = new System.Drawing.Size(410, 184);
            this.Bemerkungen_listbox.TabIndex = 9;
            // 
            // Bemerkung_Entfernen_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Bemerkungen_listbox);
            this.Controls.Add(this.Namen_combobox);
            this.Controls.Add(this.Abbrechen_Button);
            this.Controls.Add(this.Bestaetigen_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bemerkung_Entfernen_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auswahl_Dialog";
            this.ResumeLayout(false);

        }

        #endregion
        private Button Abbrechen_Button;
        private Button Bestaetigen_Button;
        private ComboBox Namen_combobox;
        private ListBox Bemerkungen_listbox;
    }
}