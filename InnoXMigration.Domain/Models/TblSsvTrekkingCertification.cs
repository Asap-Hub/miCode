using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingCertification
{
    public int TkcIdpk { get; set; }

    public int? TkcRequestIdfk { get; set; }

    public int? TkcCertifierEmpIdfk { get; set; }

    public DateTime? TkcStartDate { get; set; }

    public DateTime? TkcEndDate { get; set; }

    public int? TkcTrekLocationIdfk { get; set; }

    public int? TkcHotelIdfk { get; set; }

    public bool? TkcAccommodation { get; set; }

    public bool? TkcMeals { get; set; }

    public bool? TkcSleepOver { get; set; }

    public bool? TkcStopOver { get; set; }

    public bool? TkcCertified { get; set; }

    public bool? TkcOutOfLocation { get; set; }

    public bool? TkcActive { get; set; }

    public string? TkcRmks { get; set; }

    public int? TkcCreatedBy { get; set; }

    public int? TkcEditedBy { get; set; }

    public DateTime? TkcCertifiedOn { get; set; }

    public DateTime? TkcCreationDate { get; set; }

    public DateTime? TkcEditedDate { get; set; }
}
