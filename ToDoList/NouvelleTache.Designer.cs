﻿namespace ToDoList
{
    partial class NouvelleTache
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
            this.btnValider = new System.Windows.Forms.Button();
            this.txtTache = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpTache = new System.Windows.Forms.DateTimePicker();
            this.lblT = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.cnTermine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(201, 407);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(143, 31);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtTache
            // 
            this.txtTache.Location = new System.Drawing.Point(213, 100);
            this.txtTache.Name = "txtTache";
            this.txtTache.Size = new System.Drawing.Size(374, 26);
            this.txtTache.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(99, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(596, 56);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Ajoute une nouvelle tache";
            // 
            // btnAnnule
            // 
            this.btnAnnule.Location = new System.Drawing.Point(477, 407);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(143, 31);
            this.btnAnnule.TabIndex = 6;
            this.btnAnnule.Text = "Annule";
            this.btnAnnule.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(213, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(374, 118);
            this.txtDescription.TabIndex = 7;
            // 
            // dtpTache
            // 
            this.dtpTache.Location = new System.Drawing.Point(213, 314);
            this.dtpTache.Name = "dtpTache";
            this.dtpTache.Size = new System.Drawing.Size(374, 26);
            this.dtpTache.TabIndex = 8;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(216, 77);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(136, 20);
            this.lblT.TabIndex = 9;
            this.lblT.Text = "Nom de la Tache :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(211, 136);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(97, 20);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description :";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(214, 291);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(138, 20);
            this.lblD.TabIndex = 11;
            this.lblD.Text = "Date d\'echeance :";
            // 
            // cnTermine
            // 
            this.cnTermine.AutoSize = true;
            this.cnTermine.Location = new System.Drawing.Point(347, 365);
            this.cnTermine.Name = "cnTermine";
            this.cnTermine.Size = new System.Drawing.Size(140, 24);
            this.cnTermine.TabIndex = 12;
            this.cnTermine.Text = "Tache Termine";
            this.cnTermine.UseVisualStyleBackColor = true;
            // 
            // NouvelleTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnTermine);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.dtpTache);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtTache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NouvelleTache";
            this.Text = "NouvelleTache";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtTache;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnule;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblD;
        public System.Windows.Forms.DateTimePicker dtpTache;
        public System.Windows.Forms.CheckBox cnTermine;

        public System.Windows.Forms.TextBox TxtTache
        {
            get { return txtTache; }
            set { txtTache = value; }
        }

        public System.Windows.Forms.TextBox TxtDescription
        {
            get { return txtDescription; }
            set { txtDescription = value; }
        }
    }
}