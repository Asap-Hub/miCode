using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupMembersRemovalReason
{
    public int GrrIdpk { get; set; }

    public string? GrrName { get; set; }

    public string? GrrShtName { get; set; }

    public bool? GrrActive { get; set; }

    public bool? GrrDeleted { get; set; }

    public string? GrrRmks { get; set; }

    public int? GrrCreatedBy { get; set; }

    public int? GrrEditedBy { get; set; }

    public DateTime? GrrCreationDate { get; set; }

    public DateTime? GrrEditedDate { get; set; }
}
