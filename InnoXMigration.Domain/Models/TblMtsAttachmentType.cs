using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsAttachmentType
{
    public int AttIdpk { get; set; }

    public string? AttName { get; set; }

    public string? AttShtName { get; set; }

    public bool? AttActive { get; set; }

    public string? AttRmks { get; set; }

    public int? AttCreatedBy { get; set; }

    public int? AttEditedBy { get; set; }

    public DateTime? AttCreationDate { get; set; }

    public DateTime? AttEditedDate { get; set; }
}
