using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbProtectionGuaranteeType
{
    public int PgtIdpk { get; set; }

    public string? PgtName { get; set; }

    public string? PgtShtName { get; set; }

    public string? PgtCode { get; set; }

    public bool? PgtWorkPermit { get; set; }

    public bool? PgtWorkAndTestPermit { get; set; }

    public bool? PgtStationGuarantee { get; set; }

    public string? PgtGuaranteeType { get; set; }

    public bool? PgtActive { get; set; }

    public string? PgtRmks { get; set; }

    public int? PgtCreatedBy { get; set; }

    public int? PgtEditedBy { get; set; }

    public DateTime? PgtCreationDate { get; set; }

    public DateTime? PgtEditedDate { get; set; }
}
