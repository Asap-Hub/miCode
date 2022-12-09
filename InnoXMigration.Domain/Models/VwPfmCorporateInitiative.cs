using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmCorporateInitiative
{
    public int CinIdpk { get; set; }

    public int? CinPerspectiveIdfk { get; set; }

    public string? CinName { get; set; }

    public string? CinShtName { get; set; }

    public bool? CinActive { get; set; }

    public string? CinRmks { get; set; }

    public int? PtvIdpk { get; set; }

    public string? PtvName { get; set; }

    public string? PtvShtName { get; set; }

    public string? PtvQuestionsAnswered { get; set; }

    public int? PtvOrder { get; set; }

    public bool? PtvFinancials { get; set; }

    public bool? PtvOrganisationalCapacity { get; set; }

    public bool? PtvCustomersStakeholders { get; set; }

    public bool? PtvBusinessProcesses { get; set; }

    public bool? PtvActive { get; set; }

    public string? PtvRmks { get; set; }

    public DateTime? CinStartDate { get; set; }

    public DateTime? CinEndDate { get; set; }
}
