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
    
    public partial class Colocataire
    {
        public int IdColocataire { get; set; }
        public int IdEcoColocExistante { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string DateNaissance { get; set; }
        public string Civilite { get; set; }
    
        public virtual EcoColocExistante EcoColocExistante { get; set; }
    }
}
