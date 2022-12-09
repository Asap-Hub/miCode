using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUatTestScenario
{
    public int UtsIdpk { get; set; }

    public string? UtsName { get; set; }

    public string? UtsShtName { get; set; }

    public int? UtsModuleIdfk { get; set; }

    public int? UtsSubmoduleIdfk { get; set; }

    public string? UtsCode { get; set; }

    public DateTime? UtsStartDate { get; set; }

    public DateTime? UtsEndDate { get; set; }

    public decimal? UtsPassMark { get; set; }

    public decimal? UtsPercentagePassed { get; set; }

    public decimal? UtsPercentageFailed { get; set; }

    public decimal? UtsPercentageOnRetest { get; set; }

    public decimal? UtsPercentageNotRun { get; set; }

    public byte? UtsNoOfSteps { get; set; }

    public DateTime? UtsClosureDate { get; set; }

    public int? UtsNoOfTestCases { get; set; }

    public int? UtsStatusIdfk { get; set; }

    public int? UtsImpactIdfk { get; set; }

    public int? UtsProcessTypeIdfk { get; set; }

    public int? UtsFunctionalDomainIdfk { get; set; }

    public string? UtsTesters { get; set; }

    public string? UtsResolvers { get; set; }

    public bool? UtsLocked { get; set; }

    public string? UtsValidations { get; set; }

    public bool? UtsScriptsAssigned { get; set; }

    public bool? UtsActive { get; set; }

    public string? UtsRmks { get; set; }

    public int? UtsCreatedBy { get; set; }

    public int? UtsEditedBy { get; set; }

    public DateTime? UtsCreationDate { get; set; }

    public DateTime? UtsEditedDate { get; set; }
}
