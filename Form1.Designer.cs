﻿namespace TP2BD
{
    partial class Tb_CodeDep
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Conec = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Tb_Numemp = new System.Windows.Forms.TextBox();
            this.Tn_Nom = new System.Windows.Forms.TextBox();
            this.Tb_Prenom = new System.Windows.Forms.TextBox();
            this.Tb_salaire = new System.Windows.Forms.TextBox();
            this.Tb_Echelon = new System.Windows.Forms.TextBox();
            this.Tb_Adresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Code = new System.Windows.Forms.TextBox();
            this.DGV_Emp = new System.Windows.Forms.DataGridView();
            this.lb_programmes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_liste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Conec
            // 
            this.Btn_Conec.Location = new System.Drawing.Point(123, 394);
            this.Btn_Conec.Name = "Btn_Conec";
            this.Btn_Conec.Size = new System.Drawing.Size(95, 25);
            this.Btn_Conec.TabIndex = 0;
            this.Btn_Conec.Text = "Connexion";
            this.Btn_Conec.UseVisualStyleBackColor = true;
            this.Btn_Conec.Click += new System.EventHandler(this.Btn_Conec_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(255, 396);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(89, 23);
            this.Btn_cancel.TabIndex = 1;
            this.Btn_cancel.Text = "Deconnection";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Tb_Numemp
            // 
            this.Tb_Numemp.Location = new System.Drawing.Point(402, 12);
            this.Tb_Numemp.Name = "Tb_Numemp";
            this.Tb_Numemp.Size = new System.Drawing.Size(100, 20);
            this.Tb_Numemp.TabIndex = 2;
            // 
            // Tn_Nom
            // 
            this.Tn_Nom.Location = new System.Drawing.Point(402, 62);
            this.Tn_Nom.Name = "Tn_Nom";
            this.Tn_Nom.Size = new System.Drawing.Size(100, 20);
            this.Tn_Nom.TabIndex = 3;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Location = new System.Drawing.Point(402, 111);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(100, 20);
            this.Tb_Prenom.TabIndex = 4;
            // 
            // Tb_salaire
            // 
            this.Tb_salaire.Location = new System.Drawing.Point(402, 170);
            this.Tb_salaire.Name = "Tb_salaire";
            this.Tb_salaire.Size = new System.Drawing.Size(100, 20);
            this.Tb_salaire.TabIndex = 5;
            // 
            // Tb_Echelon
            // 
            this.Tb_Echelon.Location = new System.Drawing.Point(402, 229);
            this.Tb_Echelon.Name = "Tb_Echelon";
            this.Tb_Echelon.Size = new System.Drawing.Size(100, 20);
            this.Tb_Echelon.TabIndex = 6;
            // 
            // Tb_Adresse
            // 
            this.Tb_Adresse.Location = new System.Drawing.Point(402, 281);
            this.Tb_Adresse.Name = "Tb_Adresse";
            this.Tb_Adresse.Size = new System.Drawing.Size(100, 20);
            this.Tb_Adresse.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Num Emp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Echalon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CodeDep";
            // 
            // TB_Code
            // 
            this.TB_Code.Location = new System.Drawing.Point(402, 327);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(100, 20);
            this.TB_Code.TabIndex = 15;
            // 
            // DGV_Emp
            // 
            this.DGV_Emp.AllowUserToAddRows = false;
            this.DGV_Emp.AllowUserToDeleteRows = false;
            this.DGV_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emp.Location = new System.Drawing.Point(2, 15);
            this.DGV_Emp.Name = "DGV_Emp";
            this.DGV_Emp.ReadOnly = true;
            this.DGV_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Emp.Size = new System.Drawing.Size(319, 196);
            this.DGV_Emp.TabIndex = 16;
            // 
            // lb_programmes
            // 
            this.lb_programmes.FormattingEnabled = true;
            this.lb_programmes.Items.AddRange(new object[] {
            "CTP",
            "RSH",
            "SCT",
            "MTN",
            "TCN"});
            this.lb_programmes.Location = new System.Drawing.Point(2, 288);
            this.lb_programmes.Name = "lb_programmes";
            this.lb_programmes.Size = new System.Drawing.Size(77, 82);
            this.lb_programmes.TabIndex = 17;
            this.lb_programmes.SelectedIndexChanged += new System.EventHandler(this.lb_programmes_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Departements\r\n";
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(402, 380);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.Btn_Insert.TabIndex = 19;
            this.Btn_Insert.Text = "Inserer";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_liste
            // 
            this.Btn_liste.Location = new System.Drawing.Point(123, 218);
            this.Btn_liste.Name = "Btn_liste";
            this.Btn_liste.Size = new System.Drawing.Size(75, 23);
            this.Btn_liste.TabIndex = 20;
            this.Btn_liste.Text = "Lister";
            this.Btn_liste.UseVisualStyleBackColor = true;
            this.Btn_liste.Click += new System.EventHandler(this.Btn_liste_Click);
            // 
            // Tb_CodeDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 431);
            this.Controls.Add(this.Btn_liste);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_programmes);
            this.Controls.Add(this.DGV_Emp);
            this.Controls.Add(this.TB_Code);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Adresse);
            this.Controls.Add(this.Tb_Echelon);
            this.Controls.Add(this.Tb_salaire);
            this.Controls.Add(this.Tb_Prenom);
            this.Controls.Add(this.Tn_Nom);
            this.Controls.Add(this.Tb_Numemp);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_Conec);
            this.Name = "Tb_CodeDep";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Conec;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.TextBox Tb_Numemp;
        private System.Windows.Forms.TextBox Tn_Nom;
        private System.Windows.Forms.TextBox Tb_Prenom;
        private System.Windows.Forms.TextBox Tb_salaire;
        private System.Windows.Forms.TextBox Tb_Echelon;
        private System.Windows.Forms.TextBox Tb_Adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Code;
        private System.Windows.Forms.DataGridView DGV_Emp;
        private System.Windows.Forms.ListBox lb_programmes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_liste;
    }
}
