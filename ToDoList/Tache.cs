using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // Constructeur
        public Tache(string titre, string description, DateTime dueDate, bool state)
        {
            nomTache = titre;
            descriptionTache = description;
            echeance = dueDate;
            termine = state;
        }

        // Méthode pour marquer une tâche comme terminée
        public void MarquerTerminee()
        {
            termine = true;
        }

        // Méthode pour obtenir une description textuelle de la tâche
        public string ObtenirDescription()
        {
            return $"{nomTache} - {descriptionTache} - {echeance.ToShortDateString()}";
        }
    }

}
