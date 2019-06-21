namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.kwadrat = new System.Windows.Forms.RadioButton();
            this.okrag = new System.Windows.Forms.RadioButton();
            this.szesc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.srednica = new System.Windows.Forms.Label();
            this.wysokosc = new System.Windows.Forms.Label();
            this.okno1 = new System.Windows.Forms.TextBox();
            this.okno2 = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wartosc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kwadrat
            // 
            this.kwadrat.AutoSize = true;
            this.kwadrat.Location = new System.Drawing.Point(119, 105);
            this.kwadrat.Name = "kwadrat";
            this.kwadrat.Size = new System.Drawing.Size(64, 17);
            this.kwadrat.TabIndex = 0;
            this.kwadrat.Text = "Kwadrat";
            this.kwadrat.UseVisualStyleBackColor = true;
            // 
            // okrag
            // 
            this.okrag.AutoSize = true;
            this.okrag.Location = new System.Drawing.Point(119, 156);
            this.okrag.Name = "okrag";
            this.okrag.Size = new System.Drawing.Size(54, 17);
            this.okrag.TabIndex = 1;
            this.okrag.TabStop = true;
            this.okrag.Text = "Okrąg";
            this.okrag.UseVisualStyleBackColor = true;
            // 
            // szesc
            // 
            this.szesc.AutoSize = true;
            this.szesc.Location = new System.Drawing.Point(119, 209);
            this.szesc.Name = "szesc";
            this.szesc.Size = new System.Drawing.Size(68, 17);
            this.szesc.TabIndex = 2;
            this.szesc.TabStop = true;
            this.szesc.Text = "Sześcian";
            this.szesc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zatwierdź przekrój";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Location = new System.Drawing.Point(305, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 67);
            this.button2.TabIndex = 4;
            this.button2.Text = "Oblicz masę!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // srednica
            // 
            this.srednica.AutoSize = true;
            this.srednica.Location = new System.Drawing.Point(257, 248);
            this.srednica.Name = "srednica";
            this.srednica.Size = new System.Drawing.Size(0, 13);
            this.srednica.TabIndex = 5;
            // 
            // wysokosc
            // 
            this.wysokosc.AutoSize = true;
            this.wysokosc.Location = new System.Drawing.Point(257, 287);
            this.wysokosc.Name = "wysokosc";
            this.wysokosc.Size = new System.Drawing.Size(57, 13);
            this.wysokosc.TabIndex = 6;
            this.wysokosc.Text = "Wysokość";
            // 
            // okno1
            // 
            this.okno1.Location = new System.Drawing.Point(334, 245);
            this.okno1.Name = "okno1";
            this.okno1.Size = new System.Drawing.Size(100, 20);
            this.okno1.TabIndex = 7;
            // 
            // okno2
            // 
            this.okno2.Location = new System.Drawing.Point(334, 284);
            this.okno2.Name = "okno2";
            this.okno2.Size = new System.Drawing.Size(100, 20);
            this.okno2.TabIndex = 8;

            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.wynik.Location = new System.Drawing.Point(262, 411);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(0, 20);
            this.wynik.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybierz interesujący Cię przekrój pręta";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "7.86",
            "8.6",
            "2..8"});
            this.lista.Location = new System.Drawing.Point(624, 172);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(121, 21);
            this.lista.TabIndex = 11;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(620, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wybierz gęstość";
            // 
            // wartosc
            // 
            this.wartosc.AutoSize = true;
            this.wartosc.Location = new System.Drawing.Point(621, 213);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(0, 13);
            this.wartosc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wybrana gęstość:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.okno2);
            this.Controls.Add(this.okno1);
            this.Controls.Add(this.wysokosc);
            this.Controls.Add(this.srednica);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szesc);
            this.Controls.Add(this.okrag);
            this.Controls.Add(this.kwadrat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton kwadrat;
        private System.Windows.Forms.RadioButton okrag;
        private System.Windows.Forms.RadioButton szesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label srednica;
        private System.Windows.Forms.Label wysokosc;
        private System.Windows.Forms.TextBox okno1;
        private System.Windows.Forms.TextBox okno2;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wartosc;
        private System.Windows.Forms.Label label3;
    }
}

