using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatTestScenario
{
    public int UtsIdpk { get; set; }

    public string? UtsName { get; set; }

    public string? UtsShtName { get; set; }

    public int? UtsModuleIdfk { get; set; }

    public string UtsCode { get; set; } = null!;

    public decimal UtsPassMark { get; set; }

    public decimal UtsPercentagePassed { get; set; }

    public decimal UtsPercentageFailed { get; set; }

    public decimal UtsPercentageOnRetest { get; set; }

    public decimal UtsPercentageNotRun { get; set; }

    public int UtsNoOfTestCases { get; set; }

    public bool? UtsActive { get; set; }

    public string? UtsRmks { get; set; }

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public int? ApmProjectIdfk { get; set; }

    public bool? ApmActive { get; set; }

    public int? PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public DateTime? PrjProposedEndDate { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public DateTime? PrjLastUpdatedOn { get; set; }

    public int? PrjCategoryIdfk { get; set; }

    public int? PrjStatusIdfk { get; set; }

    public int? PrjPriorityIdfk { get; set; }

    public string? PrjRequestedBy { get; set; }

    public string PrjDescription { get; set; } = null!;

    public string PrjUpdates { get; set; } = null!;

    public decimal PrjPercentComplete { get; set; }

    public string? PrjLastDoneBy { get; set; }

    public bool? PrjActive { get; set; }

    public string? PrjRmks { get; set; }

    public byte? ApmOrder { get; set; }

    public bool? ApmIsHelpModule { get; set; }

    public byte? ApmHelpModuleOrder { get; set; }

    public string? ApmCode { get; set; }

    public int UtsStatusIdfk { get; set; }

    public int UtsImpactIdfk { get; set; }

    public int SstIdpk { get; set; }

    public string SstName { get; set; } = null!;

    public string SstShtName { get; set; } = null!;

    public int SimIdpk { get; set; }

    public string SimName { get; set; } = null!;

    public string SimShtName { get; set; } = null!;

    public string UtsTesters { get; set; } = null!;

    public string UtsResolvers { get; set; } = null!;

    public DateTime UtsStartDate { get; set; }

    public DateTime UtsEndDate { get; set; }

    public DateTime UtsClosureDate { get; set; }

    public int PtpIdpk { get; set; }

    public string PtpName { get; set; } = null!;

    public string PtpShtName { get; set; } = null!;

    public string UtsValidations { get; set; } = null!;

    public bool UtsLocked { get; set; }

    public bool UtsScriptsAssigned { get; set; }

    public int SmdIdpk { get; set; }

    public string SmdName { get; set; } = null!;

    public string SmdShtName { get; set; } = null!;

    public bool SmdActive { get; set; }

    public int? FdmIdpk { get; set; }

    public string? FdmName { get; set; }

    public string? FdmShtName { get; set; }

    public bool? FdmActive { get; set; }

    public byte UtsNoOfSteps { get; set; }
}
