using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompFacility
{
    public int FcftIdpk { get; set; }

    public int? FcftCompIdfk { get; set; }

    public int? FcftFacilityTypeIdfk { get; set; }

    public DateTime? FcftStartDate { get; set; }

    public DateTime? FcftEndDate { get; set; }

    public string? FcftContactPerson { get; set; }

    public string? FcftPhoneNo { get; set; }

    public string? FcftLocation { get; set; }

    public bool? FcftActive { get; set; }

    public string? FcftRmks { get; set; }

    public int? FcftCreatedBy { get; set; }

    public int? FcftEditedBy { get; set; }

    public DateTime? FcftCreationDate { get; set; }

    public DateTime? FcftEditedDate { get; set; }
}
