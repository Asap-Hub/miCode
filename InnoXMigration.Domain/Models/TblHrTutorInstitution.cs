using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTutorInstitution
{
    public int TinIdpk { get; set; }

    public int? TinTutorIdfk { get; set; }

    public int? TinInstitutionIdfk { get; set; }

    public bool? TinActive { get; set; }

    public string? TinRmks { get; set; }

    public int? TinCreatedBy { get; set; }

    public int? TinEditedBy { get; set; }

    public DateTime? TinCreationDate { get; set; }

    public DateTime? TinEditedDate { get; set; }
}
