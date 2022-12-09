using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOmgApplicationStatus
{
    public int ApsIdpk { get; set; }

    public string? ApsName { get; set; }

    public string? ApsShtName { get; set; }

    public string? ApsCode { get; set; }

    public bool? ApsActive { get; set; }

    public string? ApsRmks { get; set; }

    public int? ApsCreatedBy { get; set; }

    public int? ApsEditedBy { get; set; }

    public DateTime? ApsCreationDate { get; set; }

    public DateTime? ApsEditedDate { get; set; }
}
