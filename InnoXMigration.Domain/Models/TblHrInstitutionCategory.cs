using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrInstitutionCategory
{
    public int IncIdpk { get; set; }

    public string? IncName { get; set; }

    public string? IncShtName { get; set; }

    public string? IncShtCode { get; set; }

    public bool? IncActive { get; set; }

    public string? IncRmks { get; set; }

    public int? IncCreatedBy { get; set; }

    public int? IncEditedBy { get; set; }

    public DateTime? IncCreationDate { get; set; }

    public DateTime? IncEditedDate { get; set; }
}
