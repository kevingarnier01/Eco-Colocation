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
    
    public partial class Agence
    {
        public int IdAgence { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string AdresseSiegeSocial { get; set; }
        public string NumSiret { get; set; }
        public short FraisAgence { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
