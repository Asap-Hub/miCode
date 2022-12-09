using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingGradeName
{
    public int MgnIdpk { get; set; }

    public string? MgnName { get; set; }

    public string? MgnShtName { get; set; }

    public bool? MgnActive { get; set; }

    public string? MgnRmks { get; set; }

    public int? MgnCreatedBy { get; set; }

    public int? MgnEditedBy { get; set; }

    public DateTime? MgnCreationDate { get; set; }

    public DateTime? MgnEditedDate { get; set; }
}
