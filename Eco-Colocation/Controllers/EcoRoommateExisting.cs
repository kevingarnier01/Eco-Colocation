
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
    
public partial class EcoRoommateExisting
{

    public EcoRoommateExisting()
    {

        this.PictureEcoRoommateEx = new HashSet<PictureEcoRoommateEx>();

    }


    public int IdEcoRoommateExisting { get; set; }

    public int IdPerson { get; set; }

    public string EcoRoommateName { get; set; }

    public short RommateNumber { get; set; }

    public string Country { get; set; }

    public string Region { get; set; }

    public string Department { get; set; }

    public string DepartmentNumber { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string Email { get; set; }

    public string Description { get; set; }

    public byte EcoImplication { get; set; }

    public string TableEco { get; set; }

    public string TableHousing { get; set; }



    public virtual ICollection<PictureEcoRoommateEx> PictureEcoRoommateEx { get; set; }

    public virtual Person Person { get; set; }

}

}
