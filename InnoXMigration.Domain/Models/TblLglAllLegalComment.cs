using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglAllLegalComment
{
    public int AlcIdpk { get; set; }

    public int? AlcRecordIdfk { get; set; }

    public int? AlcEmpIdfk { get; set; }

    public string? AlcComment { get; set; }

    public string? AlcFrom { get; set; }

    public bool? AlcActive { get; set; }

    public int? AlcCreatedBy { get; set; }

    public int? AlcEditedBy { get; set; }

    public DateTime? AlcCreationDate { get; set; }

    public DateTime? AlcEditedDate { get; set; }
}
