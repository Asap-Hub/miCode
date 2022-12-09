using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsWorkshopDetail
{
    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdTelNo { get; set; }

    public string? WsdPlc { get; set; }

    public string? WsdAddress { get; set; }

    public string? WsdEmail { get; set; }

    public int? WsdLocIdfk { get; set; }

    public int? WsdTownIdfk { get; set; }

    public bool? WsdActive { get; set; }

    public bool? WsdExternal { get; set; }

    public string? WsdRmks { get; set; }

    public int? WsdCreatedBy { get; set; }

    public int? WsdEditedBy { get; set; }

    public DateTime? WsdCreationDate { get; set; }

    public DateTime? WsdEditedDate { get; set; }
}
