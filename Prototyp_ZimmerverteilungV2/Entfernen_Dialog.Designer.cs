namespace Prototyp_ZimmerverteilungV2
{
    partial class Entfernen_Dialog
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
            this.Bestaetigen_Button = new System.Windows.Forms.Button();
            this.Abbrechen_Button = new System.Windows.Forms.Button();
            this.Info_Label = new System.Windows.Forms.Label();
            this.Voller_Name_Liste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Bestaetigen_Button
            // 
            this.Bestaetigen_Button.Location = new System.Drawing.Point(235, 149);
            this.Bestaetigen_Button.Name = "Bestaetigen_Button";
            this.Bestaetigen_Button.Size = new System.Drawing.Size(75, 23);
            this.Bestaetigen_Button.TabIndex = 0;
            this.Bestaetigen_Button.Text = "Bestätigen";
            this.Bestaetigen_Button.UseVisualStyleBackColor = true;
            this.Bestaetigen_Button.Click += new System.EventHandler(this.Bestaetigen_Button_Click);
            // 
            // Abbrechen_Button
            // 
            this.Abbrechen_Button.Location = new System.Drawing.Point(12, 149);
            this.Abbrechen_Button.Name = "Abbrechen_Button";
            this.Abbrechen_Button.Size = new System.Drawing.Size(75, 23);
            this.Abbrechen_Button.TabIndex = 1;
            this.Abbrechen_Button.Text = "Abbrechen";
            this.Abbrechen_Button.UseVisualStyleBackColor = true;
            this.Abbrechen_Button.Click += new System.EventHandler(this.Abbrechen_Button_Click);
            // 
            // Info_Label
            // 
            this.Info_Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info_Label.Location = new System.Drawing.Point(12, 9);
            this.Info_Label.Name = "Info_Label";
            this.Info_Label.Size = new System.Drawing.Size(298, 37);
            this.Info_Label.TabIndex = 2;
            this.Info_Label.Text = "Bitte Namen auswählen";
            // 
            // Voller_Name_Liste
            // 
            this.Voller_Name_Liste.FormattingEnabled = true;
            this.Voller_Name_Liste.ItemHeight = 15;
            this.Voller_Name_Liste.Location = new System.Drawing.Point(12, 49);
            this.Voller_Name_Liste.Name = "Voller_Name_Liste";
            this.Voller_Name_Liste.Size = new System.Drawing.Size(298, 94);
            this.Voller_Name_Liste.TabIndex = 4;
            // 
            // Entfernen_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(322, 186);
            this.ControlBox = false;
            this.Controls.Add(this.Voller_Name_Liste);
            this.Controls.Add(this.Info_Label);
            this.Controls.Add(this.Abbrechen_Button);
            this.Controls.Add(this.Bestaetigen_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entfernen_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entfernen_Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Bestaetigen_Button;
        private Button Abbrechen_Button;
        private Label Info_Label;
        private ListBox Voller_Name_Liste;
    }
}