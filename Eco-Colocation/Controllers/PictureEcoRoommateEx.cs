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
    
    public partial class PictureEcoRoommateEx
    {
        public int IdPictureEcoRoommateEx { get; set; }
        public int IdEcoRoommateExisting { get; set; }
        public string PictureName { get; set; }
        public byte OrderNumber { get; set; }
    
        public virtual EcoRoommateExisting EcoRoommateExisting { get; set; }
    }
}
