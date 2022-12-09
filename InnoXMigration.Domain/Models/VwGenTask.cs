using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTask
{
    public int TskIdpk { get; set; }

    public DateTime? TskStartDate { get; set; }

    public DateTime? TskDueDate { get; set; }

    public DateTime? TskCompletionDate { get; set; }

    public decimal TskInitialPercentComplete { get; set; }

    public decimal TskPercentComplete { get; set; }

    public string? TskAssignedTo { get; set; }

    public int TskStatusIdfk { get; set; }

    public int TskPriorityIdfk { get; set; }

    public string TskSubject { get; set; } = null!;

    public string TskTask { get; set; } = null!;

    public bool TskActive { get; set; }

    public string TskRmks { get; set; } = null!;

    public string TskProgressActivities { get; set; } = null!;

    public int? TskAssignedByEmpIdfk { get; set; }

    public int? AssignedByEmpId { get; set; }

    public string? AssignedByStaffNo { get; set; }

    public string? AssignedByLname { get; set; }

    public string? AssignedByFname { get; set; }

    public string? AssignedByOnames { get; set; }

    public string? AssignedByEmpName { get; set; }

    public string? AssignedByEmpName1 { get; set; }

    public string? AssignedByEmpName2 { get; set; }

    public string? AssignedByEmpName3 { get; set; }

    public int? AssignedByDeptId { get; set; }

    public string? AssignedByDeptName { get; set; }

    public string? AssignedByDeptShtName { get; set; }

    public int? AssignedBySxnId { get; set; }

    public string? AssignedBySxnName { get; set; }

    public string? AssignedBySxnShtName { get; set; }

    public int? AssignedByUnitId { get; set; }

    public string? AssignedByUnitName { get; set; }

    public string? AssignedByUnitShtName { get; set; }

    public int? AssignedByLocId { get; set; }

    public string? AssignedByLocName { get; set; }

    public string? AssignedByLocShtName { get; set; }

    public string? AssignedByEmpName14 { get; set; }

    public string? AssignedByEmpName15 { get; set; }

    public decimal TskEffectiveCommunication { get; set; }

    public decimal TskTimelyUpdates { get; set; }

    public decimal TskTimelyCompletionOfTask { get; set; }

    public decimal TskQualityOfDelivery { get; set; }

    public decimal? RatingPercent { get; set; }

    public bool TskSatisfied { get; set; }

    public int TdpIdpk { get; set; }

    public string TdpName { get; set; } = null!;

    public string TdpShtName { get; set; } = null!;

    public byte TdpOrder { get; set; }

    public bool TdpActive { get; set; }

    public int StsIdpk { get; set; }

    public string StsName { get; set; } = null!;

    public string StsShtName { get; set; } = null!;

    public byte StsOrder { get; set; }

    public bool StsActive { get; set; }

    public string TskRatingRmks { get; set; } = null!;

    public bool TskScoring { get; set; }

    public int ObjIdpk { get; set; }

    public string ObjObjective { get; set; } = null!;

    public string PtvName { get; set; } = null!;

    public string PtvShtName { get; set; } = null!;

    public int MvsIdpk { get; set; }

    public string MvsName { get; set; } = null!;

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string MvsMission { get; set; } = null!;

    public string MvsMissionSht { get; set; } = null!;

    public string MvsVision { get; set; } = null!;

    public string MvsVisionSht { get; set; } = null!;

    public int? TskObjectiveIdfk { get; set; }

    public string? TskObjective { get; set; }

    public string? TskObjectiveCriteria { get; set; }

    public string? TskInitiative { get; set; }

    public int? TskInitiativeIdfk { get; set; }
}
