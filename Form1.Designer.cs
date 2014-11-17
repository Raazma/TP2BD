namespace TP2BD
{
    partial class Form1
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
            this.Tb_Numemp = new System.Windows.Forms.TextBox();
            this.Tb_Nom = new System.Windows.Forms.TextBox();
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
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_Recherche = new System.Windows.Forms.Button();
            this.LB_RechercheNom = new System.Windows.Forms.Label();
            this.TB_RechercheNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_TypeRecherche = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_Suivant = new System.Windows.Forms.Button();
            this.BT_Precedent = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.bt_fin = new System.Windows.Forms.Button();
            this.bt_debut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Numemp
            // 
            this.Tb_Numemp.Location = new System.Drawing.Point(127, 25);
            this.Tb_Numemp.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Numemp.Name = "Tb_Numemp";
            this.Tb_Numemp.Size = new System.Drawing.Size(132, 22);
            this.Tb_Numemp.TabIndex = 2;
            this.Tb_Numemp.TextChanged += new System.EventHandler(this.Tb_Numemp_TextChanged);
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Location = new System.Drawing.Point(127, 65);
            this.Tb_Nom.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(132, 22);
            this.Tb_Nom.TabIndex = 3;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Location = new System.Drawing.Point(127, 108);
            this.Tb_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(132, 22);
            this.Tb_Prenom.TabIndex = 4;
            // 
            // Tb_salaire
            // 
            this.Tb_salaire.Location = new System.Drawing.Point(127, 153);
            this.Tb_salaire.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_salaire.Name = "Tb_salaire";
            this.Tb_salaire.Size = new System.Drawing.Size(132, 22);
            this.Tb_salaire.TabIndex = 5;
            // 
            // Tb_Echelon
            // 
            this.Tb_Echelon.Location = new System.Drawing.Point(127, 199);
            this.Tb_Echelon.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Echelon.Name = "Tb_Echelon";
            this.Tb_Echelon.Size = new System.Drawing.Size(132, 22);
            this.Tb_Echelon.TabIndex = 6;
            // 
            // Tb_Adresse
            // 
            this.Tb_Adresse.Location = new System.Drawing.Point(127, 242);
            this.Tb_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Adresse.Name = "Tb_Adresse";
            this.Tb_Adresse.Size = new System.Drawing.Size(132, 22);
            this.Tb_Adresse.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Num Emp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Echelon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "CodeDep";
            // 
            // TB_Code
            // 
            this.TB_Code.Location = new System.Drawing.Point(127, 288);
            this.TB_Code.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(132, 22);
            this.TB_Code.TabIndex = 15;
            // 
            // DGV_Emp
            // 
            this.DGV_Emp.AllowUserToAddRows = false;
            this.DGV_Emp.AllowUserToDeleteRows = false;
            this.DGV_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emp.Location = new System.Drawing.Point(280, 33);
            this.DGV_Emp.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Emp.MultiSelect = false;
            this.DGV_Emp.Name = "DGV_Emp";
            this.DGV_Emp.ReadOnly = true;
            this.DGV_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Emp.Size = new System.Drawing.Size(525, 481);
            this.DGV_Emp.TabIndex = 16;
            this.DGV_Emp.SelectionChanged += new System.EventHandler(this.DGV_Emp_SelectionChanged);
            // 
            // lb_programmes
            // 
            this.lb_programmes.FormattingEnabled = true;
            this.lb_programmes.ItemHeight = 16;
            this.lb_programmes.Location = new System.Drawing.Point(9, 22);
            this.lb_programmes.Margin = new System.Windows.Forms.Padding(4);
            this.lb_programmes.Name = "lb_programmes";
            this.lb_programmes.Size = new System.Drawing.Size(208, 100);
            this.lb_programmes.TabIndex = 17;
            this.lb_programmes.SelectedIndexChanged += new System.EventHandler(this.lb_programmes_SelectedIndexChanged);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(839, 393);
            this.Btn_Insert.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(100, 28);
            this.Btn_Insert.TabIndex = 19;
            this.Btn_Insert.Text = "Inserer";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(175, 329);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(100, 28);
            this.Btn_Update.TabIndex = 20;
            this.Btn_Update.Text = "Mise à jour";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_clear);
            this.groupBox1.Controls.Add(this.Tb_Numemp);
            this.groupBox1.Controls.Add(this.Tb_Nom);
            this.groupBox1.Controls.Add(this.Tb_Prenom);
            this.groupBox1.Controls.Add(this.Tb_salaire);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Tb_Echelon);
            this.groupBox1.Controls.Add(this.Tb_Adresse);
            this.groupBox1.Controls.Add(this.TB_Code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(812, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 374);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion";
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(27, 329);
            this.Btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(100, 28);
            this.Btn_clear.TabIndex = 21;
            this.Btn_clear.Text = "Vider";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_Recherche);
            this.groupBox2.Controls.Add(this.LB_RechercheNom);
            this.groupBox2.Controls.Add(this.TB_RechercheNom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CB_TypeRecherche);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(260, 188);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // BT_Recherche
            // 
            this.BT_Recherche.Location = new System.Drawing.Point(79, 122);
            this.BT_Recherche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Recherche.Name = "BT_Recherche";
            this.BT_Recherche.Size = new System.Drawing.Size(101, 23);
            this.BT_Recherche.TabIndex = 5;
            this.BT_Recherche.Text = "Rechercher";
            this.BT_Recherche.UseVisualStyleBackColor = true;
            this.BT_Recherche.Visible = false;
            this.BT_Recherche.Click += new System.EventHandler(this.BT_Recherche_Click);
            // 
            // LB_RechercheNom
            // 
            this.LB_RechercheNom.AutoSize = true;
            this.LB_RechercheNom.Location = new System.Drawing.Point(76, 66);
            this.LB_RechercheNom.Name = "LB_RechercheNom";
            this.LB_RechercheNom.Size = new System.Drawing.Size(41, 17);
            this.LB_RechercheNom.TabIndex = 4;
            this.LB_RechercheNom.Text = "Nom:";
            this.LB_RechercheNom.Visible = false;
            // 
            // TB_RechercheNom
            // 
            this.TB_RechercheNom.Location = new System.Drawing.Point(123, 63);
            this.TB_RechercheNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_RechercheNom.Name = "TB_RechercheNom";
            this.TB_RechercheNom.Size = new System.Drawing.Size(131, 22);
            this.TB_RechercheNom.TabIndex = 3;
            this.TB_RechercheNom.Visible = false;
            this.TB_RechercheNom.TextChanged += new System.EventHandler(this.TB_RechercheNom_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Par :";
            // 
            // CB_TypeRecherche
            // 
            this.CB_TypeRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TypeRecherche.FormattingEnabled = true;
            this.CB_TypeRecherche.Items.AddRange(new object[] {
            "Tous les employés",
            "Le nom",
            "Le nom du département"});
            this.CB_TypeRecherche.Location = new System.Drawing.Point(51, 20);
            this.CB_TypeRecherche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_TypeRecherche.Name = "CB_TypeRecherche";
            this.CB_TypeRecherche.Size = new System.Drawing.Size(204, 24);
            this.CB_TypeRecherche.TabIndex = 0;
            this.CB_TypeRecherche.SelectedIndexChanged += new System.EventHandler(this.CB_TypeRecherche_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_programmes);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(260, 130);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Departement";
            // 
            // BT_Suivant
            // 
            this.BT_Suivant.Location = new System.Drawing.Point(983, 450);
            this.BT_Suivant.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Suivant.Name = "BT_Suivant";
            this.BT_Suivant.Size = new System.Drawing.Size(127, 28);
            this.BT_Suivant.TabIndex = 25;
            this.BT_Suivant.Text = "Suivant";
            this.BT_Suivant.UseVisualStyleBackColor = true;
            this.BT_Suivant.Click += new System.EventHandler(this.BT_Suivant_Click);
            // 
            // BT_Precedent
            // 
            this.BT_Precedent.Location = new System.Drawing.Point(812, 450);
            this.BT_Precedent.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Precedent.Name = "BT_Precedent";
            this.BT_Precedent.Size = new System.Drawing.Size(127, 28);
            this.BT_Precedent.TabIndex = 24;
            this.BT_Precedent.Text = "Précédent";
            this.BT_Precedent.UseVisualStyleBackColor = true;
            this.BT_Precedent.Click += new System.EventHandler(this.BT_Precedent_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(983, 393);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(100, 28);
            this.Btn_Delete.TabIndex = 26;
            this.Btn_Delete.Text = "Supprimer";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // bt_fin
            // 
            this.bt_fin.Location = new System.Drawing.Point(983, 486);
            this.bt_fin.Margin = new System.Windows.Forms.Padding(4);
            this.bt_fin.Name = "bt_fin";
            this.bt_fin.Size = new System.Drawing.Size(127, 28);
            this.bt_fin.TabIndex = 28;
            this.bt_fin.Text = "Fin";
            this.bt_fin.UseVisualStyleBackColor = true;
            this.bt_fin.Click += new System.EventHandler(this.bt_fin_Click);
            // 
            // bt_debut
            // 
            this.bt_debut.Location = new System.Drawing.Point(812, 486);
            this.bt_debut.Margin = new System.Windows.Forms.Padding(4);
            this.bt_debut.Name = "bt_debut";
            this.bt_debut.Size = new System.Drawing.Size(127, 28);
            this.bt_debut.TabIndex = 27;
            this.bt_debut.Text = "Début";
            this.bt_debut.UseVisualStyleBackColor = true;
            this.bt_debut.Click += new System.EventHandler(this.bt_debut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 527);
            this.Controls.Add(this.bt_fin);
            this.Controls.Add(this.bt_debut);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.BT_Suivant);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.BT_Precedent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGV_Emp);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Numemp;
        private System.Windows.Forms.TextBox Tb_Nom;
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
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CB_TypeRecherche;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_Recherche;
        private System.Windows.Forms.Label LB_RechercheNom;
        private System.Windows.Forms.TextBox TB_RechercheNom;
        private System.Windows.Forms.Button BT_Suivant;
        private System.Windows.Forms.Button BT_Precedent;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button bt_fin;
        private System.Windows.Forms.Button bt_debut;
    }
}

