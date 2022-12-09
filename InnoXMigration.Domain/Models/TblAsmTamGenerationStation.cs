using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamGenerationStation
{
    public int GstIdpk { get; set; }

    public string? GstName { get; set; }

    public string? GstShtName { get; set; }

    public int? GstGenerationCompanyIdfk { get; set; }

    public int? GstLocationIdfk { get; set; }

    public bool? GstActive { get; set; }

    public string? GstRemarks { get; set; }

    public int? GstCreatedBy { get; set; }

    public int? GstEditedBy { get; set; }

    public DateTime? GstCreationDate { get; set; }

    public DateTime? GstEditedDate { get; set; }
}
