namespace ToDoList
{
    partial class FormList
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtfiltre = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnMajTache = new System.Windows.Forms.Button();
            this.btnfiltre = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(295, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(217, 56);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "ToDoList";
            // 
            // txtfiltre
            // 
            this.txtfiltre.Location = new System.Drawing.Point(14, 111);
            this.txtfiltre.Name = "txtfiltre";
            this.txtfiltre.Size = new System.Drawing.Size(256, 26);
            this.txtfiltre.TabIndex = 1;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(653, 257);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(143, 31);
            this.btnAjout.TabIndex = 2;
            this.btnAjout.Text = "Ajoute tache";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(566, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(653, 397);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(143, 31);
            this.btnSupp.TabIndex = 4;
            this.btnSupp.Text = "Supprime tache";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnMajTache
            // 
            this.btnMajTache.Location = new System.Drawing.Point(653, 328);
            this.btnMajTache.Name = "btnMajTache";
            this.btnMajTache.Size = new System.Drawing.Size(143, 31);
            this.btnMajTache.TabIndex = 5;
            this.btnMajTache.Text = "Modifie tache";
            this.btnMajTache.UseVisualStyleBackColor = true;
            this.btnMajTache.Click += new System.EventHandler(this.btnMajTache_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Location = new System.Drawing.Point(486, 109);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(94, 28);
            this.btnfiltre.TabIndex = 6;
            this.btnfiltre.Text = "Valider";
            this.btnfiltre.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 547);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnfiltre);
            this.Controls.Add(this.btnMajTache);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtfiltre);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormList";
            this.Text = "TODOLIST";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtfiltre;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnMajTache;
        private System.Windows.Forms.Button btnfiltre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

