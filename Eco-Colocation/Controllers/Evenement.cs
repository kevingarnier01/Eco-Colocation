//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eco_Colocation.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evenement
    {
        public Evenement()
        {
            this.EvenementPresence = new HashSet<EvenementPresence>();
            this.EvenementAssocie = new HashSet<EvenementAssocie>();
            this.EvenementAssocie1 = new HashSet<EvenementAssocie>();
        }
    
        public int IdEvenement { get; set; }
        public int IdUtilisateur { get; set; }
        public System.DateTime DateDebut { get; set; }
        public System.DateTime DateFin { get; set; }
        public string NumRue { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Departement { get; set; }
        public string NumDepartement { get; set; }
        public string Region { get; set; }
        public string Pays { get; set; }
        public string Lien { get; set; }
        public string Description { get; set; }
        public string NomImage { get; set; }
        public System.DateTime DatePublication { get; set; }
    
        public virtual ICollection<EvenementPresence> EvenementPresence { get; set; }
        public virtual ICollection<EvenementAssocie> EvenementAssocie { get; set; }
        public virtual ICollection<EvenementAssocie> EvenementAssocie1 { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
