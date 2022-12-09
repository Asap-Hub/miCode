using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftStationSectionItemsAssignment
{
    public int SiaIdpk { get; set; }

    public DateTime? SiaStartDate { get; set; }

    public DateTime? SiaEndDate { get; set; }

    public decimal? SiaOrder { get; set; }

    public int? SiaSafetyGroupIdfk { get; set; }

    public int? SiaInspectionStationIdfk { get; set; }

    public int? SiaInspectionSectionIdfk { get; set; }

    public int? SiaItemIdfk { get; set; }

    public bool? SiaPositiveAnswerYes { get; set; }

    public bool? SiaActive { get; set; }

    public string? SiaRmks { get; set; }

    public int? SiaCreatedBy { get; set; }

    public int? SiaEditedBy { get; set; }

    public DateTime? SiaCreationDate { get; set; }

    public DateTime? SiaEditedDate { get; set; }
}
