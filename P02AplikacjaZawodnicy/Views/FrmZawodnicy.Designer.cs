
namespace P02AplikacjaZawodnicy.Views
{
    partial class FrmZawodnicy
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnTrenerzy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRaportPDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMiasta = new System.Windows.Forms.Button();
            this.btnSkocznie = new System.Windows.Forms.Button();
            this.lbNieaktywni = new System.Windows.Forms.ListBox();
            this.wbPrzegladrka = new System.Windows.Forms.WebBrowser();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSortowanie = new System.Windows.Forms.ComboBox();
            this.btnPrawo = new System.Windows.Forms.Button();
            this.btnLewo = new System.Windows.Forms.Button();
            this.txtStrona = new System.Windows.Forms.TextBox();
            this.chWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(22, 72);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(208, 186);
            this.lbDane.TabIndex = 0;
            this.lbDane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDane_MouseDown);
            this.lbDane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbDane_MouseMove);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(6, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(6, 48);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 2;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(6, 19);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 3;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnTrenerzy
            // 
            this.btnTrenerzy.Location = new System.Drawing.Point(6, 48);
            this.btnTrenerzy.Name = "btnTrenerzy";
            this.btnTrenerzy.Size = new System.Drawing.Size(75, 23);
            this.btnTrenerzy.TabIndex = 4;
            this.btnTrenerzy.Text = "Trenerzy";
            this.btnTrenerzy.UseVisualStyleBackColor = true;
            this.btnTrenerzy.Click += new System.EventHandler(this.btnTrenerzy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRaportPDF);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.btnEdytuj);
            this.groupBox1.Location = new System.Drawing.Point(256, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zawodnik";
            // 
            // btnRaportPDF
            // 
            this.btnRaportPDF.Location = new System.Drawing.Point(6, 77);
            this.btnRaportPDF.Name = "btnRaportPDF";
            this.btnRaportPDF.Size = new System.Drawing.Size(75, 23);
            this.btnRaportPDF.TabIndex = 3;
            this.btnRaportPDF.Text = "RaportPDF";
            this.btnRaportPDF.UseVisualStyleBackColor = true;
            this.btnRaportPDF.Click += new System.EventHandler(this.btnRaportPDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMiasta);
            this.groupBox2.Controls.Add(this.btnSkocznie);
            this.groupBox2.Controls.Add(this.btnWczytaj);
            this.groupBox2.Controls.Add(this.btnTrenerzy);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 133);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program";
            // 
            // btnMiasta
            // 
            this.btnMiasta.Location = new System.Drawing.Point(6, 106);
            this.btnMiasta.Name = "btnMiasta";
            this.btnMiasta.Size = new System.Drawing.Size(75, 23);
            this.btnMiasta.TabIndex = 6;
            this.btnMiasta.Text = "Miasta";
            this.btnMiasta.UseVisualStyleBackColor = true;
            this.btnMiasta.Click += new System.EventHandler(this.btnMiasta_Click);
            // 
            // btnSkocznie
            // 
            this.btnSkocznie.Location = new System.Drawing.Point(6, 77);
            this.btnSkocznie.Name = "btnSkocznie";
            this.btnSkocznie.Size = new System.Drawing.Size(75, 23);
            this.btnSkocznie.TabIndex = 5;
            this.btnSkocznie.Text = "Skocznie";
            this.btnSkocznie.UseVisualStyleBackColor = true;
            this.btnSkocznie.Click += new System.EventHandler(this.btnSkocznie_Click);
            // 
            // lbNieaktywni
            // 
            this.lbNieaktywni.AllowDrop = true;
            this.lbNieaktywni.FormattingEnabled = true;
            this.lbNieaktywni.Location = new System.Drawing.Point(357, 39);
            this.lbNieaktywni.Name = "lbNieaktywni";
            this.lbNieaktywni.Size = new System.Drawing.Size(208, 238);
            this.lbNieaktywni.TabIndex = 7;
            this.lbNieaktywni.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbNieaktywni_DragDrop);
            this.lbNieaktywni.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbNieaktywni_DragEnter);
            // 
            // wbPrzegladrka
            // 
            this.wbPrzegladrka.Location = new System.Drawing.Point(590, 35);
            this.wbPrzegladrka.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPrzegladrka.Name = "wbPrzegladrka";
            this.wbPrzegladrka.Size = new System.Drawing.Size(252, 242);
            this.wbPrzegladrka.TabIndex = 8;
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(51, 12);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(179, 20);
            this.txtFiltr.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sortowanie";
            // 
            // cbSortowanie
            // 
            this.cbSortowanie.FormattingEnabled = true;
            this.cbSortowanie.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Kraj"});
            this.cbSortowanie.Location = new System.Drawing.Point(88, 41);
            this.cbSortowanie.Name = "cbSortowanie";
            this.cbSortowanie.Size = new System.Drawing.Size(142, 21);
            this.cbSortowanie.TabIndex = 13;
            // 
            // btnPrawo
            // 
            this.btnPrawo.Location = new System.Drawing.Point(170, 264);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(60, 23);
            this.btnPrawo.TabIndex = 14;
            this.btnPrawo.Text = "->";
            this.btnPrawo.UseVisualStyleBackColor = true;
            this.btnPrawo.Click += new System.EventHandler(this.btnPrawo_Click);
            // 
            // btnLewo
            // 
            this.btnLewo.Location = new System.Drawing.Point(22, 264);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(60, 23);
            this.btnLewo.TabIndex = 15;
            this.btnLewo.Text = "<-";
            this.btnLewo.UseVisualStyleBackColor = true;
            this.btnLewo.Click += new System.EventHandler(this.btnLewo_Click);
            // 
            // txtStrona
            // 
            this.txtStrona.Location = new System.Drawing.Point(89, 266);
            this.txtStrona.Name = "txtStrona";
            this.txtStrona.Size = new System.Drawing.Size(75, 20);
            this.txtStrona.TabIndex = 16;
            this.txtStrona.Text = "1";
            // 
            // chWykres
            // 
            chartArea1.Name = "ChartArea1";
            this.chWykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chWykres.Legends.Add(legend1);
            this.chWykres.Location = new System.Drawing.Point(859, 39);
            this.chWykres.Name = "chWykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chWykres.Series.Add(series1);
            this.chWykres.Size = new System.Drawing.Size(368, 242);
            this.chWykres.TabIndex = 17;
            this.chWykres.Text = "chart1";
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 293);
            this.Controls.Add(this.chWykres);
            this.Controls.Add(this.txtStrona);
            this.Controls.Add(this.btnLewo);
            this.Controls.Add(this.btnPrawo);
            this.Controls.Add(this.cbSortowanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltr);
            this.Controls.Add(this.wbPrzegladrka);
            this.Controls.Add(this.lbNieaktywni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnTrenerzy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbNieaktywni;
        private System.Windows.Forms.Button btnRaportPDF;
        private System.Windows.Forms.WebBrowser wbPrzegladrka;
        private System.Windows.Forms.Button btnSkocznie;
        private System.Windows.Forms.Button btnMiasta;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSortowanie;
        private System.Windows.Forms.Button btnPrawo;
        private System.Windows.Forms.Button btnLewo;
        private System.Windows.Forms.TextBox txtStrona;
        private System.Windows.Forms.DataVisualization.Charting.Chart chWykres;
    }
}

