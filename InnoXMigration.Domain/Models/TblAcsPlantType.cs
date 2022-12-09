using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsPlantType
{
    public int FptpIdpk { get; set; }

    public string? FptpName { get; set; }

    public string? FptpShtName { get; set; }

    public int? FptpApplCatIdfk { get; set; }

    public bool? FptpActive { get; set; }

    public string? FptpRmks { get; set; }

    public int? FptpCreatedBy { get; set; }

    public int? FptpEditedBy { get; set; }

    public DateTime? FptpCreationDate { get; set; }

    public DateTime? FptpEditedDate { get; set; }
}
