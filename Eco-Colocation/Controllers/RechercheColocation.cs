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
    
    public partial class RechercheColocation
    {
        public RechercheColocation()
        {
            this.Lieu = new HashSet<Lieu>();
        }
    
        public int IdRechercheColocation { get; set; }
        public int IdUtilisateur { get; set; }
        public short BudgetMax { get; set; }
        public byte AlerteParEmail { get; set; }
        public string CritereRecherche { get; set; }
        public string PratiqueEcolo { get; set; }
        public string NomPhoto { get; set; }
        public string ActivationAnnonce { get; set; }
    
        public virtual ICollection<Lieu> Lieu { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
