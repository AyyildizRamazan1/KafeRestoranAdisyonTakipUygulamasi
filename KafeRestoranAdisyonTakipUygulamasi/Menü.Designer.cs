
namespace KafeRestoranAdisyonTakipUygulamasi
{
    partial class Menü
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
            this.btnAnaYemekler = new System.Windows.Forms.Button();
            this.btnİçecekler = new System.Windows.Forms.Button();
            this.btnTatlılar = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSec = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btnIslemKapat = new System.Windows.Forms.Button();
            this.btnYanlisSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaYemekler
            // 
            this.btnAnaYemekler.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaYemekler.Location = new System.Drawing.Point(13, 30);
            this.btnAnaYemekler.Name = "btnAnaYemekler";
            this.btnAnaYemekler.Size = new System.Drawing.Size(139, 86);
            this.btnAnaYemekler.TabIndex = 0;
            this.btnAnaYemekler.Text = "Ana Yemekler";
            this.btnAnaYemekler.UseVisualStyleBackColor = true;
            this.btnAnaYemekler.Click += new System.EventHandler(this.btnAnaYemekler_Click);
            // 
            // btnİçecekler
            // 
            this.btnİçecekler.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİçecekler.Location = new System.Drawing.Point(14, 133);
            this.btnİçecekler.Name = "btnİçecekler";
            this.btnİçecekler.Size = new System.Drawing.Size(138, 86);
            this.btnİçecekler.TabIndex = 1;
            this.btnİçecekler.Text = "İçecekler";
            this.btnİçecekler.UseVisualStyleBackColor = true;
            this.btnİçecekler.Click += new System.EventHandler(this.btnİçecekler_Click);
            // 
            // btnTatlılar
            // 
            this.btnTatlılar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTatlılar.Location = new System.Drawing.Point(14, 238);
            this.btnTatlılar.Name = "btnTatlılar";
            this.btnTatlılar.Size = new System.Drawing.Size(138, 86);
            this.btnTatlılar.TabIndex = 2;
            this.btnTatlılar.Text = "Tatlılar";
            this.btnTatlılar.UseVisualStyleBackColor = true;
            this.btnTatlılar.Click += new System.EventHandler(this.btnTatlılar_Click);
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalatalar.Location = new System.Drawing.Point(12, 346);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(140, 86);
            this.btnSalatalar.TabIndex = 3;
            this.btnSalatalar.Text = "Salatalar";
            this.btnSalatalar.UseVisualStyleBackColor = true;
            this.btnSalatalar.Click += new System.EventHandler(this.btnSalatalar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(234, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 189);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 236;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(227, 238);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(339, 209);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün  Adı";
            this.columnHeader2.Width = 189;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(584, 198);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(107, 42);
            this.btnSec.TabIndex = 6;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(632, 165);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 27);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adet:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(632, 125);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 27);
            this.numericUpDown2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(599, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hesap:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(688, 305);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(111, 27);
            this.numericUpDown3.TabIndex = 12;
            // 
            // btnIslemKapat
            // 
            this.btnIslemKapat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemKapat.Location = new System.Drawing.Point(632, 346);
            this.btnIslemKapat.Name = "btnIslemKapat";
            this.btnIslemKapat.Size = new System.Drawing.Size(166, 35);
            this.btnIslemKapat.TabIndex = 13;
            this.btnIslemKapat.Text = "İşlem Kapat";
            this.btnIslemKapat.UseVisualStyleBackColor = true;
            this.btnIslemKapat.Click += new System.EventHandler(this.btnIslemKapat_Click);
            // 
            // btnYanlisSil
            // 
            this.btnYanlisSil.Location = new System.Drawing.Point(288, 453);
            this.btnYanlisSil.Name = "btnYanlisSil";
            this.btnYanlisSil.Size = new System.Drawing.Size(192, 38);
            this.btnYanlisSil.TabIndex = 14;
            this.btnYanlisSil.Text = "YanlisÜrünüSil";
            this.btnYanlisSil.UseVisualStyleBackColor = true;
            this.btnYanlisSil.Click += new System.EventHandler(this.btnYanlisSil_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btnYanlisSil);
            this.Controls.Add(this.btnIslemKapat);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSalatalar);
            this.Controls.Add(this.btnTatlılar);
            this.Controls.Add(this.btnİçecekler);
            this.Controls.Add(this.btnAnaYemekler);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menü";
            this.Text = "Menü";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.Button btnİçecekler;
        private System.Windows.Forms.Button btnTatlılar;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button btnIslemKapat;
        private System.Windows.Forms.Button btnYanlisSil;
    }
}