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
    
    public partial class AnnonceLocation
    {
        public AnnonceLocation()
        {
            this.ChambreLocation = new HashSet<ChambreLocation>();
        }
    
        public int IdAnnonceLocation { get; set; }
        public int IdUtilisateur { get; set; }
        public string Introduction { get; set; }
        public string Description { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Departement { get; set; }
        public string Region { get; set; }
        public string Pays { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public byte TypeLogement { get; set; }
        public byte ImplantationLogement { get; set; }
        public int SuperficieLogement { get; set; }
        public int SuperficieTerrain { get; set; }
        public short NbPieceLogement { get; set; }
        public short NbHabitantRestant { get; set; }
        public short NbColocRecherche { get; set; }
        public bool AccesHandicape { get; set; }
        public bool AccesTransportCommun { get; set; }
        public string InfoSupAccessibilite { get; set; }
        public bool ConsoAlcoolTolerence { get; set; }
        public bool FumeurTolerence { get; set; }
        public bool AnimauxTolerence { get; set; }
        public string InfoSupTolerence { get; set; }
        public System.DateTime DatePublication { get; set; }
        public bool Activation { get; set; }
    
        public virtual ICollection<ChambreLocation> ChambreLocation { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
