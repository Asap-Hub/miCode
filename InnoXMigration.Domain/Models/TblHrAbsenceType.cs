using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAbsenceType
{
    public int AtpIdpk { get; set; }

    public string? AtpName { get; set; }

    public string? AtpShtName { get; set; }

    public bool? AtpActive { get; set; }

    public bool? AtpAnnualLeave { get; set; }

    public bool? AtpDeductFromAnnualLeave { get; set; }

    public string? AtpRmks { get; set; }

    public int? AtpCreatedBy { get; set; }

    public int? AtpEditedBy { get; set; }

    public DateTime? AtpCreationDate { get; set; }

    public DateTime? AtpEditedDate { get; set; }
}
