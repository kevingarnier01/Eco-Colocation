
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
    
public partial class ResearchRoommate
{

    public ResearchRoommate()
    {

        this.ActivatedAnnouncement = true;

        this.Place = new HashSet<Place>();

    }


    public int IdResearchRoommate { get; set; }

    public int IdPerson { get; set; }

    public short MaxBudget { get; set; }

    public byte EmailAlert { get; set; }

    public string SearchCriteria { get; set; }

    public string EcoPractice { get; set; }

    public string PictureName { get; set; }

    public bool ActivatedAnnouncement { get; set; }



    public virtual Person Person { get; set; }

    public virtual ICollection<Place> Place { get; set; }

}

}
