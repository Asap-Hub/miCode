using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJob
{
    public int JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public bool? JobActive { get; set; }

    public string? JobRmks { get; set; }

    public int? JobCreatedBy { get; set; }

    public int? JobEditedBy { get; set; }

    public DateTime? JobCreationDate { get; set; }

    public DateTime? JobEditedDate { get; set; }
}
