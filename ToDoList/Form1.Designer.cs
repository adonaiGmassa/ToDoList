namespace ToDoList
{
    partial class ToDoList
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
            this.txtbTache = new System.Windows.Forms.TextBox();
            this.btnValide = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // txtbTache
            // 
            this.txtbTache.Location = new System.Drawing.Point(291, 93);
            this.txtbTache.Name = "txtbTache";
            this.txtbTache.Size = new System.Drawing.Size(221, 26);
            this.txtbTache.TabIndex = 1;
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(361, 145);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(75, 25);
            this.btnValide.TabIndex = 2;
            this.btnValide.Text = "Valide";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(415, 270);
            this.dataGridView1.TabIndex = 3;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.txtbTache);
            this.Controls.Add(this.lblTitre);
            this.Name = "ToDoList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtbTache;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

