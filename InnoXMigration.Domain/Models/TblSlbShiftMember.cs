using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbShiftMember
{
    public int SmbIdpk { get; set; }

    public DateTime? SmbDate { get; set; }

    public string? SmbMembers { get; set; }

    public int? SmbLogStationIdfk { get; set; }

    public bool? SmbOnDuty { get; set; }

    public bool? SmbDeleted { get; set; }

    public bool? SmbSyncToLocal { get; set; }

    public string? SmbRmks { get; set; }

    public int? SmbCreatedBy { get; set; }

    public DateTime? SmbCreationDate { get; set; }

    public int? SmbEditedBy { get; set; }

    public DateTime? SmbEditedDate { get; set; }
}
