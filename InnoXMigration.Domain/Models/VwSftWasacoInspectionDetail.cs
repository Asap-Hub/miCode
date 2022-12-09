using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftWasacoInspectionDetail
{
    public int WidIdpk { get; set; }

    public string? WidName { get; set; }

    public DateTime? WidStartDate { get; set; }

    public DateTime? WidEndDate { get; set; }

    public bool? WidScoring { get; set; }

    public bool? WidActive { get; set; }

    public string? WidRmks { get; set; }

    public bool? WidWasacoAuditChecklist { get; set; }

    public bool? WidWasacoAuditReport { get; set; }

    public int WstIdpk { get; set; }

    public string? WstName { get; set; }

    public string? WstShtName { get; set; }

    public bool? WstActive { get; set; }

    public int? WidStationIdfk { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }
}
