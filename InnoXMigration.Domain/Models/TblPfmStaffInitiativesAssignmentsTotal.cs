using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmStaffInitiativesAssignmentsTotal
{
    public int SitIdpk { get; set; }

    public int? SitEmpIdfk { get; set; }

    public int? SitStaffAssignmentIdfk { get; set; }

    public int? SitJanScore { get; set; }

    public int? SitFebScore { get; set; }

    public int? SitMarScore { get; set; }

    public int? SitFirstQtrScore { get; set; }

    public int? SitAprScore { get; set; }

    public int? SitMayScore { get; set; }

    public int? SitJunScore { get; set; }

    public int? SitSecondQtrScore { get; set; }

    public int? SitJulScore { get; set; }

    public bool? SitAugScore { get; set; }

    public bool? SitSepScore { get; set; }

    public int? SitThirdQtrScore { get; set; }

    public int? SitOctScore { get; set; }

    public string? SitNovScore { get; set; }

    public string? SitDecScore { get; set; }

    public string? SitFourthQtrScore { get; set; }

    public string? SitSupActualValue { get; set; }

    public decimal? SitTargetPercentageComplete { get; set; }

    public decimal? SitStaffPercentageComplete { get; set; }

    public decimal? SitSupPercentageComplete { get; set; }

    public bool? SitCompulsory { get; set; }

    public int? SitMonitorResultsFromIdfk { get; set; }

    public bool? SitActive { get; set; }

    public bool? SitLocked { get; set; }

    public bool? SitSubmitted { get; set; }

    public DateTime? SitSubmittedOn { get; set; }

    public int? SitSubmittedByEmpIdfk { get; set; }

    public string? SitState { get; set; }

    public bool? SitAcknowledged { get; set; }

    public bool? SitSignedOff { get; set; }

    public int? SitAcknowledgedByEmpIdfk { get; set; }

    public DateTime? SitAcknowledgedOn { get; set; }

    public string? SitStaffAppraisalRmks { get; set; }

    public string? SitSupAppraisalRmks { get; set; }

    public DateTime? SitCompletionDate { get; set; }

    public string? SitRmks { get; set; }

    public int? SitCreatedBy { get; set; }

    public int? SitEditedBy { get; set; }

    public DateTime? SitCreationDate { get; set; }

    public DateTime? SitEditedDate { get; set; }
}
