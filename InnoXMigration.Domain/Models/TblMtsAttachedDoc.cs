using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsAttachedDoc
{
    public int AtdIdpk { get; set; }

    public int? AtdMailIdfk { get; set; }

    public byte[]? AtdDoc { get; set; }

    public string? AtdFileName { get; set; }

    public string? AtdFileNo { get; set; }

    public int? AtdAttachmentTypeIdfk { get; set; }

    public string? AtdSubject { get; set; }

    public string? AtdFormat { get; set; }

    public string? AtdAttachedFrom { get; set; }

    public bool? AtdMainAttachment { get; set; }

    public bool? AtdActive { get; set; }

    public int? AtdCreatedBy { get; set; }

    public int? AtdEditedBy { get; set; }

    public DateTime? AtdCreationDate { get; set; }

    public DateTime? AtdEditedDate { get; set; }

    public string? AtdType { get; set; }
}
