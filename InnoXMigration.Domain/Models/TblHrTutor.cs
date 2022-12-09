using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTutor
{
    public int TutIdpk { get; set; }

    public string? TutName { get; set; }

    public string? TutEmail { get; set; }

    public string? TutFax { get; set; }

    public string? TutPhoneNo { get; set; }

    public bool? TutActive { get; set; }

    public string? TutRmks { get; set; }

    public int? TutCreatedBy { get; set; }

    public int? TutEditedBy { get; set; }

    public DateTime? TutCreationDate { get; set; }

    public DateTime? TutEditedDate { get; set; }
}
