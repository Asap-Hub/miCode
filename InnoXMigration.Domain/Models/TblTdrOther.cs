using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrOther
{
    public int TdoIdpk { get; set; }

    public int? TdoGroupIdfk { get; set; }

    public string? TdoName { get; set; }

    public string? TdoStaffNo { get; set; }

    public string? TdoPlc { get; set; }

    public string? TdoDirectTelNo { get; set; }

    public string? TdoMobNo { get; set; }

    public string? TdoResidenceNo { get; set; }

    public string? TdoFax { get; set; }

    public string? TdoJobTitle { get; set; }

    public string? TdoDept { get; set; }

    public string? TdoSection { get; set; }

    public string? TdoUnit { get; set; }

    public string? TdoLocation { get; set; }

    public string? TdoEmailOfficial { get; set; }

    public string? TdoEmailPersonal { get; set; }

    public string? TdoOfficeLoc { get; set; }

    public string? TdoRoomNo { get; set; }

    public bool? TdoActive { get; set; }

    public string? TdoRmks { get; set; }

    public DateTime? TdoCreationDate { get; set; }

    public int? TdoCreatedBy { get; set; }

    public int? TdoEditedBy { get; set; }

    public DateTime? TdoEditedDate { get; set; }
}
