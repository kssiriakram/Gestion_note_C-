
namespace application_gestion_etudiant
{
    partial class Bilan_annuel
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
            this.labelFiliere = new System.Windows.Forms.Label();
            this.labelEtudiant = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.labelMoyenne = new System.Windows.Forms.Label();
            this.Filiere = new System.Windows.Forms.ComboBox();
            this.Etudiant = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Code_matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moyenne = new System.Windows.Forms.TextBox();
            this.EXEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Location = new System.Drawing.Point(110, 54);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(49, 20);
            this.labelFiliere.TabIndex = 0;
            this.labelFiliere.Text = "Filiere";
            // 
            // labelEtudiant
            // 
            this.labelEtudiant.AutoSize = true;
            this.labelEtudiant.Location = new System.Drawing.Point(110, 132);
            this.labelEtudiant.Name = "labelEtudiant";
            this.labelEtudiant.Size = new System.Drawing.Size(64, 20);
            this.labelEtudiant.TabIndex = 1;
            this.labelEtudiant.Text = "Etudiant";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(484, 55);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(55, 20);
            this.labelNiveau.TabIndex = 2;
            this.labelNiveau.Text = "Niveau";
            // 
            // labelMoyenne
            // 
            this.labelMoyenne.AutoSize = true;
            this.labelMoyenne.Location = new System.Drawing.Point(213, 488);
            this.labelMoyenne.Name = "labelMoyenne";
            this.labelMoyenne.Size = new System.Drawing.Size(118, 20);
            this.labelMoyenne.TabIndex = 3;
            this.labelMoyenne.Text = "Moyenne annuel";
            // 
            // Filiere
            // 
            this.Filiere.FormattingEnabled = true;
            this.Filiere.Location = new System.Drawing.Point(231, 51);
            this.Filiere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(121, 28);
            this.Filiere.TabIndex = 4;
            this.Filiere.SelectedIndexChanged += new System.EventHandler(this.Filiere_SelectedIndexChanged);
            // 
            // Etudiant
            // 
            this.Etudiant.FormattingEnabled = true;
            this.Etudiant.Location = new System.Drawing.Point(231, 132);
            this.Etudiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Etudiant.Name = "Etudiant";
            this.Etudiant.Size = new System.Drawing.Size(121, 28);
            this.Etudiant.TabIndex = 5;
            // 
            // Niveau
            // 
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Location = new System.Drawing.Point(582, 46);
            this.Niveau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(121, 28);
            this.Niveau.TabIndex = 6;
            this.Niveau.SelectedIndexChanged += new System.EventHandler(this.Niveau_SelectedIndexChanged);
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(582, 132);
            this.Recherche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(121, 29);
            this.Recherche.TabIndex = 7;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = true;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_matiere,
            this.Designation,
            this.Semestre,
            this.Note});
            this.Table.Location = new System.Drawing.Point(63, 241);
            this.Table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(661, 188);
            this.Table.TabIndex = 8;
            this.Table.Resize += new System.EventHandler(this.Table_Resize);
            // 
            // Code_matiere
            // 
            this.Code_matiere.HeaderText = "Code matiere";
            this.Code_matiere.MinimumWidth = 6;
            this.Code_matiere.Name = "Code_matiere";
            this.Code_matiere.Width = 125;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.Width = 125;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.MinimumWidth = 6;
            this.Semestre.Name = "Semestre";
            this.Semestre.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // Moyenne
            // 
            this.Moyenne.Location = new System.Drawing.Point(383, 481);
            this.Moyenne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.Size = new System.Drawing.Size(100, 27);
            this.Moyenne.TabIndex = 9;
            // 
            // EXEL
            // 
            this.EXEL.Location = new System.Drawing.Point(653, 479);
            this.EXEL.Name = "EXEL";
            this.EXEL.Size = new System.Drawing.Size(94, 29);
            this.EXEL.TabIndex = 10;
            this.EXEL.Text = "EXEL";
            this.EXEL.UseVisualStyleBackColor = true;
            this.EXEL.Click += new System.EventHandler(this.EXEL_Click);
            // 
            // Bilan_annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.EXEL);
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Etudiant);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.labelMoyenne);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelEtudiant);
            this.Controls.Add(this.labelFiliere);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bilan_annuel";
            this.Text = "Bilan annuel";
            this.Load += new System.EventHandler(this.Bilan_annuel_Load);
            this.Resize += new System.EventHandler(this.Bilan_annuel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiliere;
        private System.Windows.Forms.Label labelEtudiant;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.Label labelMoyenne;
        private System.Windows.Forms.ComboBox Filiere;
        private System.Windows.Forms.ComboBox Etudiant;
        private System.Windows.Forms.ComboBox Niveau;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox Moyenne;
        private System.Windows.Forms.Button EXEL;
    }
}