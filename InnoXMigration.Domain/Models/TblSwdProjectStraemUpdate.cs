using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectStraemUpdate
{
    public int PsuIdpk { get; set; }

    public int? PsuStreamIdfk { get; set; }

    public int? PsuStreamDetailIdfk { get; set; }

    public int? PsuStreamLeadEmpIdfk { get; set; }

    public int? PsuPresenterEmpIdfk { get; set; }

    public string? PsuTitle { get; set; }

    public string? PsuSummary { get; set; }

    public string? PsuProgressActivities { get; set; }

    public string? PsuNextActivities { get; set; }

    public string? PsuRisks { get; set; }

    public int? PsuTrendIndicatorIdfk { get; set; }

    public bool? PsuActive { get; set; }

    public string? PsuRmks { get; set; }

    public int? PsuCreatedBy { get; set; }

    public int? PsuEditedBy { get; set; }

    public DateTime? PsuCreationDate { get; set; }

    public DateTime? PsuEditedDate { get; set; }
}
