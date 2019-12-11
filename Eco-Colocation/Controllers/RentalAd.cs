
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
    
public partial class RentalAd
{

    public RentalAd()
    {

        this.RentalRoom = new HashSet<RentalRoom>();

    }


    public int IdRentalAd { get; set; }

    public int IdAccount { get; set; }

    public string Introduction { get; set; }

    public string Description { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string Department { get; set; }

    public string DepartmentNumber { get; set; }

    public string Region { get; set; }

    public string Country { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public byte HousingType { get; set; }

    public byte HousingImplantation { get; set; }

    public short HousingSurface { get; set; }

    public int LandSurface { get; set; }

    public short HousingPieceNumber { get; set; }

    public short RoommateNumberStaying { get; set; }

    public short RoommateNumberResearched { get; set; }

    public bool AccessHandicapped { get; set; }

    public bool AccesPublicTransport { get; set; }

    public string AccesInfoSup { get; set; }

    public bool TolerationAlcoholConsommation { get; set; }

    public bool TolerationSmoker { get; set; }

    public bool TolerationPets { get; set; }

    public string TolerationInfoSup { get; set; }

    public System.DateTime DatePublish { get; set; }

    public bool ActivatedAnnouncement { get; set; }



    public virtual ICollection<RentalRoom> RentalRoom { get; set; }

    public virtual Account Account { get; set; }

}

}
