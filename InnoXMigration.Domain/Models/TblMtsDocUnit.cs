using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDocUnit
{
    public int DcuIdpk { get; set; }

    public string? DcuName { get; set; }

    public string? DcuShtName { get; set; }

    public string? DcuCode { get; set; }

    public string? Dcu1stCode { get; set; }

    public string? Dcu2ndCode { get; set; }

    public string? Dcu3rdCode { get; set; }

    public string? Dcu4thCode { get; set; }

    public string? Dcu5thCode { get; set; }

    public string? Dcu6thCode { get; set; }

    public bool? DcuActive { get; set; }

    public string? DcuRmks { get; set; }

    public int? DcuCreatedBy { get; set; }

    public int? DcuEditedBy { get; set; }

    public DateTime? DcuCreationDate { get; set; }

    public DateTime? DcuEditedDate { get; set; }
}
