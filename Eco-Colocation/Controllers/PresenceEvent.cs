
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

	public partial class PresenceEvent
{

    public int IdUser { get; set; }

    public int IdEvent { get; set; }

    public byte Status { get; set; }



    public virtual Event Event { get; set; }

    public virtual User User { get; set; }

}

}
