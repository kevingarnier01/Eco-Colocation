
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
    
public partial class AssociatedEvent
{

    public int IdEvent { get; set; }

    public int IdAssociatedEvent { get; set; }



    public virtual Event Event { get; set; }

    public virtual Event Event1 { get; set; }

}

}
