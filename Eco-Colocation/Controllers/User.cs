
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
    
public partial class User
{

    public User()
    {

        this.Activated = true;

        this.RentalAd = new HashSet<RentalAd>();

    }


    public int IdUser { get; set; }

    public string Email { get; set; }

    public bool Activated { get; set; }



    public virtual ICollection<RentalAd> RentalAd { get; set; }

    public virtual Person Person { get; set; }

    public virtual webpages_Membership webpages_Membership { get; set; }

}

}
