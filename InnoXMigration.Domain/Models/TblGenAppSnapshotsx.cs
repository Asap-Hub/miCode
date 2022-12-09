using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAppSnapshotsx
{
    public int AssIdpk { get; set; }

    public int? AssModuleIdfk { get; set; }

    public string? AssTitle { get; set; }

    public string? AssDescription { get; set; }

    public DateTime? AssStartDate { get; set; }

    public DateTime? AssEndDate { get; set; }

    public decimal? AssOrder { get; set; }

    public string? AssRmks { get; set; }

    public int? AssCreatedBy { get; set; }

    public int? AssEditedBy { get; set; }

    public DateTime? AssCreationDate { get; set; }

    public DateTime? AssEditedDate { get; set; }
}
