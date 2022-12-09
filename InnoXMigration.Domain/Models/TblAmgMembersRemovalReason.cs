using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgMembersRemovalReason
{
    public int MrrIdpk { get; set; }

    public string? MrrName { get; set; }

    public string? MrrShtName { get; set; }

    public bool? MrrActive { get; set; }

    public bool? MrrDeleted { get; set; }

    public string? MrrRmks { get; set; }

    public int? MrrCreatedBy { get; set; }

    public int? MrrEditedBy { get; set; }

    public DateTime? MrrCreationDate { get; set; }

    public DateTime? MrrEditedDate { get; set; }
}
