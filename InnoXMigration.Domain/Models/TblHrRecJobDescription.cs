using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrRecJobDescription
{
    public int RjdIdpk { get; set; }

    public byte[]? RjdDoc { get; set; }

    public int? RjdJobOpeningIdfk { get; set; }

    public string? RjdDocFormat { get; set; }

    public bool? RjdActive { get; set; }

    public string? RjdRmks { get; set; }

    public int? RjdCreatedBy { get; set; }

    public DateTime? RjdCreationDate { get; set; }

    public int? RjdEditedBy { get; set; }

    public DateTime? RjdEditedDate { get; set; }
}
