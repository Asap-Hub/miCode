using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoInspectionDetail
{
    public int WidIdpk { get; set; }

    public string? WidName { get; set; }

    public DateTime? WidStartDate { get; set; }

    public DateTime? WidEndDate { get; set; }

    public int? WidSafetyGroupIdfk { get; set; }

    public int? WidStationIdfk { get; set; }

    public bool? WidScoring { get; set; }

    public bool? WidWasacoAuditChecklist { get; set; }

    public bool? WidWasacoAuditReport { get; set; }

    public bool? WidActive { get; set; }

    public string? WidRmks { get; set; }

    public int? WidCreatedBy { get; set; }

    public int? WidEditedBy { get; set; }

    public DateTime? WidCreationDate { get; set; }

    public DateTime? WidEditedDate { get; set; }
}
