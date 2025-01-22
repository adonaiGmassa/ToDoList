using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Tache
    {
        #region Variables
        private string nomTache;
        private string descriptionTache;
        private DateTime echeance;
        private bool termine;
        #endregion

        #region Accesseurs 
        public string NomTache
        {
            get { return nomTache; }
            set { nomTache = value; }
        }
        public string DescriptionTache
        {
            get { return descriptionTache; }
            set { descriptionTache = value; }
        }
        public DateTime Echeance
        {
            get { return echeance; }
            set { echeance = value; }
        }
        public bool Termine
        {
            get { return termine; }
            set { termine = value; }
        }

        #endregion

        // Constructeur pour initialiser la tâche
        public Tache(string titre, string description, DateTime dueDate, bool state)
        {
            nomTache = titre;
            descriptionTache = description;
            echeance = dueDate;
            termine = state;
        }


        // Méthode pour ajoute une tache
        public void AjoutTache() {}

        // Méthode pour mettre à jour une tache
        public void MajTache() { }

        // Méthode pour supprime une tache
        public void SuppTache() { }
    }
}
