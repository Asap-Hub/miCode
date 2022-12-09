using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompStatus
{
    public int StsIdpk { get; set; }

    public string? StsName { get; set; }

    public string? StsShtName { get; set; }

    public bool? StsFitStatus { get; set; }

    public bool? StsActive { get; set; }

    public string? StsRmks { get; set; }

    public int? StsCreatedBy { get; set; }

    public int? StsEditedBy { get; set; }

    public DateTime? StsCreationDate { get; set; }

    public DateTime? StsEditedDate { get; set; }
}
