namespace Exo_biblioteque
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
            this.Livres = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonSup = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Titre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonSupAbo = new System.Windows.Forms.Button();
            this.richTextMdp = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextEmail = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextMatricule = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextTel = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextNaissance = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextAdresse = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextNom = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonEditAbo = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextPrenom = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonSaveAbo = new System.Windows.Forms.Button();
            this.Sauvegarder = new System.Windows.Forms.Button();
            this.Livres.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Livres
            // 
            this.Livres.Controls.Add(this.tabPage1);
            this.Livres.Controls.Add(this.tabPage2);
            this.Livres.Location = new System.Drawing.Point(12, 2);
            this.Livres.Name = "Livres";
            this.Livres.SelectedIndex = 0;
            this.Livres.Size = new System.Drawing.Size(1145, 593);
            this.Livres.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonSup);
            this.tabPage1.Controls.Add(this.ButtonEdit);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1137, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Livres";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonSup
            // 
            this.ButtonSup.Location = new System.Drawing.Point(168, 186);
            this.ButtonSup.Name = "ButtonSup";
            this.ButtonSup.Size = new System.Drawing.Size(75, 23);
            this.ButtonSup.TabIndex = 7;
            this.ButtonSup.Text = "Supprimer";
            this.ButtonSup.UseVisualStyleBackColor = true;
            this.ButtonSup.Click += new System.EventHandler(this.ButtonSup_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(87, 186);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titre,
            this.isbn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(354, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(777, 547);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Titre
            // 
            this.Titre.Text = "Titre";
            this.Titre.Width = 141;
            // 
            // isbn
            // 
            this.isbn.Text = "isbn";
            this.isbn.Width = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "isbn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(21, 122);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(206, 43);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 47);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Sauvegarder);
            this.tabPage2.Controls.Add(this.ButtonSupAbo);
            this.tabPage2.Controls.Add(this.richTextMdp);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.richTextEmail);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.richTextMatricule);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.richTextTel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.richTextNaissance);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.richTextAdresse);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.richTextNom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ButtonEditAbo);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.richTextPrenom);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ButtonSaveAbo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1137, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abonné(e)s";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonSupAbo
            // 
            this.ButtonSupAbo.Location = new System.Drawing.Point(226, 366);
            this.ButtonSupAbo.Name = "ButtonSupAbo";
            this.ButtonSupAbo.Size = new System.Drawing.Size(75, 23);
            this.ButtonSupAbo.TabIndex = 28;
            this.ButtonSupAbo.Text = "Supprimer";
            this.ButtonSupAbo.UseVisualStyleBackColor = true;
            this.ButtonSupAbo.Click += new System.EventHandler(this.ButtonSupAbo_Click);
            // 
            // richTextMdp
            // 
            this.richTextMdp.Location = new System.Drawing.Point(80, 287);
            this.richTextMdp.Name = "richTextMdp";
            this.richTextMdp.Size = new System.Drawing.Size(206, 32);
            this.richTextMdp.TabIndex = 26;
            this.richTextMdp.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mdp";
            // 
            // richTextEmail
            // 
            this.richTextEmail.Location = new System.Drawing.Point(80, 249);
            this.richTextEmail.Name = "richTextEmail";
            this.richTextEmail.Size = new System.Drawing.Size(206, 32);
            this.richTextEmail.TabIndex = 24;
            this.richTextEmail.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email";
            // 
            // richTextMatricule
            // 
            this.richTextMatricule.Location = new System.Drawing.Point(80, 211);
            this.richTextMatricule.Name = "richTextMatricule";
            this.richTextMatricule.Size = new System.Drawing.Size(206, 32);
            this.richTextMatricule.TabIndex = 22;
            this.richTextMatricule.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Matricule";
            // 
            // richTextTel
            // 
            this.richTextTel.Location = new System.Drawing.Point(80, 173);
            this.richTextTel.Name = "richTextTel";
            this.richTextTel.Size = new System.Drawing.Size(206, 32);
            this.richTextTel.TabIndex = 20;
            this.richTextTel.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Téléphone";
            // 
            // richTextNaissance
            // 
            this.richTextNaissance.Location = new System.Drawing.Point(80, 135);
            this.richTextNaissance.Name = "richTextNaissance";
            this.richTextNaissance.Size = new System.Drawing.Size(206, 32);
            this.richTextNaissance.TabIndex = 18;
            this.richTextNaissance.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Naissance";
            // 
            // richTextAdresse
            // 
            this.richTextAdresse.Location = new System.Drawing.Point(80, 97);
            this.richTextAdresse.Name = "richTextAdresse";
            this.richTextAdresse.Size = new System.Drawing.Size(206, 32);
            this.richTextAdresse.TabIndex = 16;
            this.richTextAdresse.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adresse";
            // 
            // richTextNom
            // 
            this.richTextNom.Location = new System.Drawing.Point(80, 18);
            this.richTextNom.Name = "richTextNom";
            this.richTextNom.Size = new System.Drawing.Size(206, 32);
            this.richTextNom.TabIndex = 14;
            this.richTextNom.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom";
            // 
            // ButtonEditAbo
            // 
            this.ButtonEditAbo.Location = new System.Drawing.Point(145, 366);
            this.ButtonEditAbo.Name = "ButtonEditAbo";
            this.ButtonEditAbo.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditAbo.TabIndex = 13;
            this.ButtonEditAbo.Text = "Edit";
            this.ButtonEditAbo.UseVisualStyleBackColor = true;
            this.ButtonEditAbo.Click += new System.EventHandler(this.ButtonEditAbo_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(411, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(730, 571);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenom";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresse";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naissance";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telephone";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Matricule";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mdp";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date d\'adhésion";
            this.columnHeader9.Width = 99;
            // 
            // richTextPrenom
            // 
            this.richTextPrenom.Location = new System.Drawing.Point(80, 56);
            this.richTextPrenom.Name = "richTextPrenom";
            this.richTextPrenom.Size = new System.Drawing.Size(206, 32);
            this.richTextPrenom.TabIndex = 7;
            this.richTextPrenom.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nom";
            // 
            // ButtonSaveAbo
            // 
            this.ButtonSaveAbo.Location = new System.Drawing.Point(64, 366);
            this.ButtonSaveAbo.Name = "ButtonSaveAbo";
            this.ButtonSaveAbo.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveAbo.TabIndex = 9;
            this.ButtonSaveAbo.Text = "Enregistrer";
            this.ButtonSaveAbo.UseVisualStyleBackColor = true;
            this.ButtonSaveAbo.Click += new System.EventHandler(this.ButtonSaveAbo_Click);
            // 
            // Sauvegarder
            // 
            this.Sauvegarder.Location = new System.Drawing.Point(64, 458);
            this.Sauvegarder.Name = "Sauvegarder";
            this.Sauvegarder.Size = new System.Drawing.Size(237, 23);
            this.Sauvegarder.TabIndex = 29;
            this.Sauvegarder.Text = "Sauvegarder";
            this.Sauvegarder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Livres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Livres.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Livres;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Titre;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonEditAbo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RichTextBox richTextPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonSaveAbo;
        private System.Windows.Forms.Button ButtonSup;
        private System.Windows.Forms.RichTextBox richTextMdp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextMatricule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextNaissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonSupAbo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button Sauvegarder;
    }
}

