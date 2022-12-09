using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectStreamDetail
{
    public int PsdIdpk { get; set; }

    public DateTime? PsdStartDate { get; set; }

    public DateTime? PsdEndDate { get; set; }

    public int? PsdProjectIdfk { get; set; }

    public string? PsdName { get; set; }

    public string? PsdProjectStageIdfk { get; set; }

    public int? PsdTrendIndicatorIdfk { get; set; }

    public bool? PsdActive { get; set; }

    public string? PsdRmks { get; set; }

    public int? PsdCreatedBy { get; set; }

    public int? PsdEditedBy { get; set; }

    public DateTime? PsdCreationDate { get; set; }

    public DateTime? PsdEditedDate { get; set; }
}
