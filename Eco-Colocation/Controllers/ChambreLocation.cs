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
    
    public partial class ChambreLocation
    {
        public int IdChambreLocation { get; set; }
        public int IdAnnonceLocation { get; set; }
        public decimal Loyer { get; set; }
        public decimal Charges { get; set; }
        public string DetailCharges { get; set; }
        public Nullable<decimal> Caution { get; set; }
        public short Superficie { get; set; }
        public bool Meublee { get; set; }
        public System.DateTime DateDisponibilite { get; set; }
        public Nullable<System.DateTime> DateFinDisponibilite { get; set; }
    
        public virtual AnnonceLocation AnnonceLocation { get; set; }
    }
}
