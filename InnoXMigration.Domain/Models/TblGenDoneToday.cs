using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDoneToday
{
    public int DtdIdpk { get; set; }

    public DateTime? DtdStartDate { get; set; }

    public DateTime? DtdEndDate { get; set; }

    public int? DtdPriorityIdfk { get; set; }

    public byte? DtdPercentComplete { get; set; }

    public string? DtdTitle { get; set; }

    public string? DtdActivity { get; set; }

    public string? DtdLocation { get; set; }

    public string? DtdCategory { get; set; }

    public byte? DtdWeekNo { get; set; }

    public string? DtdDoneBy { get; set; }

    public bool? DtdActive { get; set; }

    public byte[]? DtdCancelComment { get; set; }

    public int? DtdCreatedBy { get; set; }

    public int? DtdEditedBy { get; set; }

    public DateTime? DtdCreationDate { get; set; }

    public DateTime? DtdEditedDate { get; set; }
}
