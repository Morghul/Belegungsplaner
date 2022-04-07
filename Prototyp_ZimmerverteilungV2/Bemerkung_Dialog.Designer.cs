namespace Prototyp_ZimmerverteilungV2
{
    partial class Bemerkung_Dialog
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
            this.Button_Abbrechen = new System.Windows.Forms.Button();
            this.Bestaetigen_Button = new System.Windows.Forms.Button();
            this.Name_Combobox = new System.Windows.Forms.ComboBox();
            this.Bemerkungen_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Abbrechen
            // 
            this.Button_Abbrechen.Location = new System.Drawing.Point(12, 296);
            this.Button_Abbrechen.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.Button_Abbrechen.Name = "Button_Abbrechen";
            this.Button_Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.Button_Abbrechen.TabIndex = 1;
            this.Button_Abbrechen.Text = "Abbrechen";
            this.Button_Abbrechen.UseVisualStyleBackColor = true;
            this.Button_Abbrechen.Click += new System.EventHandler(this.Button_Abbrechen_Click);
            // 
            // Bestaetigen_Button
            // 
            this.Bestaetigen_Button.Location = new System.Drawing.Point(348, 296);
            this.Bestaetigen_Button.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Bestaetigen_Button.Name = "Bestaetigen_Button";
            this.Bestaetigen_Button.Size = new System.Drawing.Size(75, 23);
            this.Bestaetigen_Button.TabIndex = 2;
            this.Bestaetigen_Button.Text = "Bestätigen";
            this.Bestaetigen_Button.UseVisualStyleBackColor = true;
            this.Bestaetigen_Button.Click += new System.EventHandler(this.Bestaetigen_Button_Click);
            // 
            // Name_Combobox
            // 
            this.Name_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Name_Combobox.FormattingEnabled = true;
            this.Name_Combobox.Location = new System.Drawing.Point(12, 12);
            this.Name_Combobox.Name = "Name_Combobox";
            this.Name_Combobox.Size = new System.Drawing.Size(121, 23);
            this.Name_Combobox.TabIndex = 4;
            // 
            // Bemerkungen_textbox
            // 
            this.Bemerkungen_textbox.Location = new System.Drawing.Point(12, 41);
            this.Bemerkungen_textbox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Bemerkungen_textbox.Multiline = true;
            this.Bemerkungen_textbox.Name = "Bemerkungen_textbox";
            this.Bemerkungen_textbox.Size = new System.Drawing.Size(411, 252);
            this.Bemerkungen_textbox.TabIndex = 5;
            // 
            // Bemerkung_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Bemerkungen_textbox);
            this.Controls.Add(this.Name_Combobox);
            this.Controls.Add(this.Bestaetigen_Button);
            this.Controls.Add(this.Button_Abbrechen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bemerkung_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bemerkungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Button_Abbrechen;
        private Button Bestaetigen_Button;
        private ComboBox Name_Combobox;
        private TextBox Bemerkungen_textbox;
    }
}