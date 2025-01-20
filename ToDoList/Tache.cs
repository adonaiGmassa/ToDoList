using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Tache
    {
        public string nomTache { get; set; }
        public string descriptionTache { get; set; }
        public DateTime echeance { get; set; }

        // Méthode pour ajoute une tache
        public void AjoutTache() { }

        // Méthode pour mettre à jour une tache
        public void MajTache() { }

        // Méthode pour supprime une tache
        public void SuppTache() { }
    }
}
