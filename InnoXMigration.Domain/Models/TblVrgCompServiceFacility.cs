using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompServiceFacility
{
    public int FcsfIdpk { get; set; }

    public int? FcsfCompIdfk { get; set; }

    public int? FcsfServiceFacilityIdfk { get; set; }

    public int? FcsfDuration { get; set; }

    public string? FcsfRmks { get; set; }

    public bool? FcsfActive { get; set; }

    public int? FcsfCreatedBy { get; set; }

    public int? FcsfEditedBy { get; set; }

    public DateTime? FcsfCreationDate { get; set; }

    public DateTime? FcsfEditedDate { get; set; }
}
