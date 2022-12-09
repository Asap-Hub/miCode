using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrRelationship
{
    public int RlsIdpk { get; set; }

    public string? RlsName { get; set; }

    public string? RlsShtName { get; set; }

    public bool? RlsActive { get; set; }

    public string? RlsRmks { get; set; }

    public int? RlsCreatedBy { get; set; }

    public int? RlsEditedBy { get; set; }

    public DateTime? RlsCreationDate { get; set; }

    public DateTime? RlsEditedDate { get; set; }
}
