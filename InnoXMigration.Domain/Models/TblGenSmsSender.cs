using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsSender
{
    public int SndIdpk { get; set; }

    public string? SndName { get; set; }

    public string? SndShtName { get; set; }

    public bool? SndActive { get; set; }

    public string? SndRmks { get; set; }

    public string? SndCreatedBy { get; set; }

    public int? SndEditedBy { get; set; }

    public DateTime? SndCreationDate { get; set; }

    public DateTime? SndEditedDate { get; set; }
}
