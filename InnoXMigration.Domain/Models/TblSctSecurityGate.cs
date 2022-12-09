using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSctSecurityGate
{
    public int SgtIdpk { get; set; }

    public string? SgtName { get; set; }

    public string? SgtShtName { get; set; }

    public int? SgtOfficeBlockIdfk { get; set; }

    public bool? SgtActive { get; set; }

    public string? SgtRmks { get; set; }

    public string? SgtCreatedBy { get; set; }

    public int? SgtEditedBy { get; set; }

    public DateTime? SgtCreationDate { get; set; }

    public DateTime? SgtEditedDate { get; set; }
}
