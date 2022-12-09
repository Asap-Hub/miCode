using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsIssueType
{
    public int PitIdpk { get; set; }

    public string? PitName { get; set; }

    public string? PitShtName { get; set; }

    public bool? PitActive { get; set; }

    public byte? PitOrder { get; set; }

    public string? PitRmks { get; set; }

    public int? PitCreatedBy { get; set; }

    public int? PitEditedBy { get; set; }

    public DateTime? PitCreationDate { get; set; }

    public DateTime? PitEditedDate { get; set; }
}
