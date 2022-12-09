using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgMeasuresTarget
{
    public int MtgIdpk { get; set; }

    public int? MtgMissionIdfk { get; set; }

    public int? MtgThemeIdfk { get; set; }

    public int? MtgPerspectiveIdfk { get; set; }

    public int? MtgObjectiveIdfk { get; set; }

    public DateTime? MtgStartDate { get; set; }

    public DateTime? MtgEndDate { get; set; }

    public string? MtgMeasure { get; set; }

    public string? MtgDescription { get; set; }

    public string? MtgSource { get; set; }

    public string? MtgSourcingInstrument { get; set; }

    public bool? MgtAvailable { get; set; }

    public bool? MtgReliable { get; set; }

    public string? MtgTarget { get; set; }

    public string? MtgMinValue { get; set; }

    public string? MtgMaxValue { get; set; }

    public string? MtgUnitOfMeasure { get; set; }

    public string? MtgUnit { get; set; }

    public bool? MtgActive { get; set; }

    public string? MtgRmks { get; set; }

    public string? MtgCreatedBy { get; set; }

    public int? MtgEditedBy { get; set; }

    public DateTime? MtgCreationDate { get; set; }

    public DateTime? MtgEditedDate { get; set; }
}
