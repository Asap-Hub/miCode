using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsTransportUnit
{
    public int TruIdpk { get; set; }

    public string? TruName { get; set; }

    public string? TruShtName { get; set; }

    public int? TruDeptIdfk { get; set; }

    public int? TruSectionIdfk { get; set; }

    public int? TruUnitIdfk { get; set; }

    public bool? TruActive { get; set; }

    public string? TruRmks { get; set; }

    public int? TruCreatedBy { get; set; }

    public int? TruEditedBy { get; set; }

    public DateTime? TruCreationDate { get; set; }

    public DateTime? TruEditedDate { get; set; }
}
