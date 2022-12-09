using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrInstitutionGroup
{
    public int IngIdpk { get; set; }

    public string? IngName { get; set; }

    public string? IngShtName { get; set; }

    public string? IngShtCode { get; set; }

    public bool? IngActive { get; set; }

    public string? IngRmks { get; set; }

    public int? IngCreatedBy { get; set; }

    public int? IngEditedBy { get; set; }

    public DateTime? IngCreationDate { get; set; }

    public DateTime? IngEditedDate { get; set; }
}
