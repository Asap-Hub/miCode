using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrJobLevel
{
    public int JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public int? JlvJobIdfk { get; set; }

    public DateTime? JlvStartDate { get; set; }

    public DateTime? JlvEndDate { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public bool? JobActive { get; set; }

    public bool? JlvActive { get; set; }

    public string? JlvRmks { get; set; }

    public int? JlvCreatedBy { get; set; }

    public int? JlvEditedBy { get; set; }

    public DateTime? JlvCreationDate { get; set; }

    public DateTime? JlvEditedDate { get; set; }

    public string? JobRmks { get; set; }

    public int? JobCreatedBy { get; set; }

    public int? JobEditedBy { get; set; }

    public DateTime? JobCreationDate { get; set; }

    public DateTime? JobEditedDate { get; set; }
}
