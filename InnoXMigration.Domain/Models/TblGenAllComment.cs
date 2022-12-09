using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAllComment
{
    public int AcmIdpk { get; set; }

    public int? AcmRecordIdfk { get; set; }

    public int? AcmEmpIdfk { get; set; }

    public string? AcmComment { get; set; }

    public string? AcmFrom { get; set; }

    public string? AcmType { get; set; }

    public bool? AcmActive { get; set; }

    public int? AcmCreatedBy { get; set; }

    public int? AcmEditedBy { get; set; }

    public DateTime? AcmCreationDate { get; set; }

    public DateTime? AcmEditedDate { get; set; }
}
