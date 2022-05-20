
namespace application_gestion_etudiant
{
    partial class Gestion_notes
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
            this.labelMatiere = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.Code_eleve = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.Button();
            this.Matiere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(78, 54);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(83, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code eleve";
            this.labelCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMatiere
            // 
            this.labelMatiere.AutoSize = true;
            this.labelMatiere.Location = new System.Drawing.Point(78, 111);
            this.labelMatiere.Name = "labelMatiere";
            this.labelMatiere.Size = new System.Drawing.Size(60, 20);
            this.labelMatiere.TabIndex = 1;
            this.labelMatiere.Text = "Matiere";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(78, 176);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(42, 20);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Note";
            // 
            // Code_eleve
            // 
            this.Code_eleve.Location = new System.Drawing.Point(245, 48);
            this.Code_eleve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Code_eleve.Name = "Code_eleve";
            this.Code_eleve.Size = new System.Drawing.Size(100, 27);
            this.Code_eleve.TabIndex = 3;
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(245, 176);
            this.Note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(100, 27);
            this.Note.TabIndex = 5;
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(419, 46);
            this.Nouveau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 29);
            this.Nouveau.TabIndex = 6;
            this.Nouveau.Text = "nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(419, 111);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 29);
            this.Ajouter.TabIndex = 7;
            this.Ajouter.Text = "ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(419, 176);
            this.Modifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 29);
            this.Modifier.TabIndex = 8;
            this.Modifier.Text = "modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            this.Modifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Modifier_KeyPress);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(596, 46);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 29);
            this.Supprimer.TabIndex = 9;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(596, 108);
            this.Recherche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(75, 29);
            this.Recherche.TabIndex = 10;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = true;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // Matiere
            // 
            this.Matiere.FormattingEnabled = true;
            this.Matiere.Location = new System.Drawing.Point(245, 111);
            this.Matiere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Matiere.Name = "Matiere";
            this.Matiere.Size = new System.Drawing.Size(121, 28);
            this.Matiere.TabIndex = 11;
            this.Matiere.SelectedIndexChanged += new System.EventHandler(this.Matiere_SelectedIndexChanged);
            // 
            // Gestion_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.Matiere);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Code_eleve);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelMatiere);
            this.Controls.Add(this.labelCode);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Gestion_notes";
            this.Text = "Gestion des notes";
            this.Load += new System.EventHandler(this.Gestion_notes_Load);
            this.Resize += new System.EventHandler(this.Gestion_notes_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelMatiere;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox Code_eleve;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.ComboBox Matiere;
    }
}