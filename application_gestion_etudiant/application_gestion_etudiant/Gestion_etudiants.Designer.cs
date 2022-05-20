
namespace application_gestion_etudiant
{
    partial class Gestion_etudiants
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
            this.labelCode = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelFiliere = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.comboFiliere = new System.Windows.Forms.ComboBox();
            this.comboNiveau = new System.Windows.Forms.ComboBox();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonGestionNotes = new System.Windows.Forms.Button();
            this.checkNiveau = new System.Windows.Forms.CheckBox();
            this.checkCode = new System.Windows.Forms.CheckBox();
            this.checkPrenom = new System.Windows.Forms.CheckBox();
            this.checkNom = new System.Windows.Forms.CheckBox();
            this.checkFiliere = new System.Windows.Forms.CheckBox();
            this.gridEleves = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEleves)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(96, 8);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(44, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(96, 48);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(96, 96);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(60, 20);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Location = new System.Drawing.Point(96, 144);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(49, 20);
            this.labelFiliere.TabIndex = 3;
            this.labelFiliere.Text = "Filiere";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(101, 189);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(55, 20);
            this.labelNiveau.TabIndex = 4;
            this.labelNiveau.Text = "Niveau";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(200, 8);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(217, 27);
            this.textCode.TabIndex = 5;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(200, 48);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(217, 27);
            this.textNom.TabIndex = 6;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(200, 96);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(217, 27);
            this.textPrenom.TabIndex = 7;
            // 
            // comboFiliere
            // 
            this.comboFiliere.FormattingEnabled = true;
            this.comboFiliere.Items.AddRange(new object[] {
            "AP",
            "GIL",
            "GINF",
            "G3EI",
            "GSTR",
            "GSEA"});
            this.comboFiliere.Location = new System.Drawing.Point(200, 136);
            this.comboFiliere.Name = "comboFiliere";
            this.comboFiliere.Size = new System.Drawing.Size(217, 28);
            this.comboFiliere.TabIndex = 9;
            // 
            // comboNiveau
            // 
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboNiveau.Location = new System.Drawing.Point(200, 181);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(217, 28);
            this.comboNiveau.TabIndex = 10;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(665, 12);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(144, 29);
            this.buttonNouveau.TabIndex = 11;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(665, 48);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(144, 27);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(665, 89);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(144, 27);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(665, 122);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(144, 28);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(665, 156);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(144, 29);
            this.buttonRechercher.TabIndex = 15;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonGestionNotes
            // 
            this.buttonGestionNotes.Location = new System.Drawing.Point(665, 191);
            this.buttonGestionNotes.Name = "buttonGestionNotes";
            this.buttonGestionNotes.Size = new System.Drawing.Size(144, 27);
            this.buttonGestionNotes.TabIndex = 16;
            this.buttonGestionNotes.Text = "Gestion notes";
            this.buttonGestionNotes.UseVisualStyleBackColor = true;
            this.buttonGestionNotes.Click += new System.EventHandler(this.buttonGestionNotes_Click);
            // 
            // checkNiveau
            // 
            this.checkNiveau.AutoSize = true;
            this.checkNiveau.Location = new System.Drawing.Point(523, 181);
            this.checkNiveau.Name = "checkNiveau";
            this.checkNiveau.Size = new System.Drawing.Size(18, 17);
            this.checkNiveau.TabIndex = 22;
            this.checkNiveau.UseVisualStyleBackColor = true;
            // 
            // checkCode
            // 
            this.checkCode.AutoSize = true;
            this.checkCode.Location = new System.Drawing.Point(523, 11);
            this.checkCode.Name = "checkCode";
            this.checkCode.Size = new System.Drawing.Size(18, 17);
            this.checkCode.TabIndex = 18;
            this.checkCode.UseVisualStyleBackColor = true;
            // 
            // checkPrenom
            // 
            this.checkPrenom.AutoSize = true;
            this.checkPrenom.Location = new System.Drawing.Point(523, 96);
            this.checkPrenom.Name = "checkPrenom";
            this.checkPrenom.Size = new System.Drawing.Size(18, 17);
            this.checkPrenom.TabIndex = 19;
            this.checkPrenom.UseVisualStyleBackColor = true;
            // 
            // checkNom
            // 
            this.checkNom.AutoSize = true;
            this.checkNom.Location = new System.Drawing.Point(523, 48);
            this.checkNom.Name = "checkNom";
            this.checkNom.Size = new System.Drawing.Size(18, 17);
            this.checkNom.TabIndex = 20;
            this.checkNom.UseVisualStyleBackColor = true;
            // 
            // checkFiliere
            // 
            this.checkFiliere.AutoSize = true;
            this.checkFiliere.Location = new System.Drawing.Point(523, 136);
            this.checkFiliere.Name = "checkFiliere";
            this.checkFiliere.Size = new System.Drawing.Size(18, 17);
            this.checkFiliere.TabIndex = 21;
            this.checkFiliere.UseVisualStyleBackColor = true;
            this.checkFiliere.CheckedChanged += new System.EventHandler(this.checkFiliere_CheckedChanged);
            // 
            // gridEleves
            // 
            this.gridEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEleves.Location = new System.Drawing.Point(12, 240);
            this.gridEleves.Name = "gridEleves";
            this.gridEleves.RowHeadersWidth = 51;
            this.gridEleves.RowTemplate.Height = 29;
            this.gridEleves.Size = new System.Drawing.Size(897, 303);
            this.gridEleves.TabIndex = 17;
            // 
            // Gestion_etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(921, 555);
            this.Controls.Add(this.checkNiveau);
            this.Controls.Add(this.checkFiliere);
            this.Controls.Add(this.checkNom);
            this.Controls.Add(this.checkPrenom);
            this.Controls.Add(this.checkCode);
            this.Controls.Add(this.gridEleves);
            this.Controls.Add(this.buttonGestionNotes);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.comboNiveau);
            this.Controls.Add(this.comboFiliere);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelFiliere);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelCode);
            this.Name = "Gestion_etudiants";
            this.Text = "Gestion_etudiants";
            this.Load += new System.EventHandler(this.Gestion_etudiants_Load);
            this.Resize += new System.EventHandler(this.Gestion_etudiants_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridEleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelFiliere;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.ComboBox comboFiliere;
        private System.Windows.Forms.ComboBox comboNiveau;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonGestionNotes;
        private System.Windows.Forms.CheckBox checkNiveau;
        private System.Windows.Forms.CheckBox checkCode;
        private System.Windows.Forms.CheckBox checkPrenom;
        private System.Windows.Forms.CheckBox checkNom;
        private System.Windows.Forms.CheckBox checkFiliere;
        private System.Windows.Forms.DataGridView gridEleves;
    }
}