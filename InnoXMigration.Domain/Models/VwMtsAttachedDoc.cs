using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsAttachedDoc
{
    public int AtdIdpk { get; set; }

    public int? AtdMailIdfk { get; set; }

    public byte[]? AtdDoc { get; set; }

    public string AtdFileName { get; set; } = null!;

    public string AtdFileNo { get; set; } = null!;

    public string AtdFormat { get; set; } = null!;

    public bool? AtdActive { get; set; }

    public int? AttIdpk { get; set; }

    public string AttName { get; set; } = null!;

    public string AttShtName { get; set; } = null!;

    public bool? AttActive { get; set; }

    public string? AttRmks { get; set; }

    public string AtdSubject { get; set; } = null!;

    public bool AtdMainAttachment { get; set; }

    public int? AtdAttachmentTypeIdfk { get; set; }

    public int? AtdCreatedBy { get; set; }

    public int? AtdEditedBy { get; set; }

    public string? AtdAttachedFrom { get; set; }

    public DateTime? AtdCreationDate { get; set; }

    public DateTime? AtdEditedDate { get; set; }

    public string? AtdType { get; set; }
}
