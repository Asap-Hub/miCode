using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatTestScenarioProcess
{
    public int TspIdpk { get; set; }

    public int? TspScenarioIdfk { get; set; }

    public int UtsIdpk { get; set; }

    public int? PrjIdpk { get; set; }

    public int StsIdpk { get; set; }

    public int ImpIdpk { get; set; }

    public int? TspStatusIdfk { get; set; }

    public int? TspImpactIdfk { get; set; }

    public int? UtsModuleIdfk { get; set; }

    public int? TspProcessNo { get; set; }

    public string? TspTestCase { get; set; }

    public string? TspDescription { get; set; }

    public string? TspExpectedResult { get; set; }

    public string? TspActualTestResult { get; set; }

    public string? UtsName { get; set; }

    public string? UtsShtName { get; set; }

    public string UtsCode { get; set; } = null!;

    public bool? UtsActive { get; set; }

    public string? UtsRmks { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public string TspRmks { get; set; } = null!;

    public string StsName { get; set; } = null!;

    public string StsShtName { get; set; } = null!;

    public string ImpName { get; set; } = null!;

    public string ImpShtName { get; set; } = null!;

    public string TspResolversComment { get; set; } = null!;

    public decimal TspPercentageWeight { get; set; }

    public bool TspActive { get; set; }

    public string UtsTesters { get; set; } = null!;

    public string UtsResolvers { get; set; } = null!;

    public int SstIdpk { get; set; }

    public string SstName { get; set; } = null!;

    public string SstShtName { get; set; } = null!;

    public int SimIdpk { get; set; }

    public string SimName { get; set; } = null!;

    public string SimShtName { get; set; } = null!;

    public DateTime UtsStartDate { get; set; }

    public DateTime UtsEndDate { get; set; }

    public decimal UtsPassMark { get; set; }

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public bool? ApmActive { get; set; }

    public decimal UtsPercentagePassed { get; set; }

    public decimal UtsPercentageFailed { get; set; }

    public bool? ApmIsHelpModule { get; set; }

    public byte? ApmHelpModuleOrder { get; set; }

    public decimal PrjPercentComplete { get; set; }

    public string? ApmCode { get; set; }

    public byte? ApmOrder { get; set; }

    public decimal UtsPercentageOnRetest { get; set; }

    public DateTime UtsClosureDate { get; set; }

    public int UtsNoOfTestCases { get; set; }

    public bool UtsLocked { get; set; }

    public decimal UtsPercentageNotRun { get; set; }

    public bool? TspAcknowledged { get; set; }

    public DateTime? TspAcknowledgedOn { get; set; }

    public int? TspAcknowledgedByEmpIdfk { get; set; }

    public bool TspDeleted { get; set; }
}
