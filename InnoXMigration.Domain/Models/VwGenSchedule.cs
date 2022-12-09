using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenSchedule
{
    public int ScdIdpk { get; set; }

    public string? ScdProjectIdfk { get; set; }

    public int ScpIdpk { get; set; }

    public string? ScpName { get; set; }

    public string? ScpShtName { get; set; }

    public string? ScdTask { get; set; }

    public string? ScdTaskDescription { get; set; }

    public DateTime? ScdStartDate { get; set; }

    public DateTime? ScdDueDate { get; set; }

    public DateTime? ScdCompletionDate { get; set; }

    public DateTime? ScdUpdateDate { get; set; }

    public string? ScdUnitOfMeasure { get; set; }

    public decimal? ScdMinValue { get; set; }

    public decimal? ScdMaxValue { get; set; }

    public int? ScdPriorityIdfk { get; set; }

    public decimal? ScdInitialPercentComplete { get; set; }

    public decimal? ScdPercentComplete { get; set; }

    public string? ScdUpdateActivity { get; set; }

    public string? ScdReminder { get; set; }

    public string? ScdLocation { get; set; }

    public string? ScdCategory { get; set; }

    public decimal ScdReferenceWeight { get; set; }

    public decimal ScdApplicableWeight { get; set; }

    public decimal ScdAdjustableWeight { get; set; }

    public int? ScdCreatedBy { get; set; }

    public int? ScdEditedBy { get; set; }

    public DateTime? ScdReminderDate { get; set; }

    public DateTime? ScdCreationDate { get; set; }

    public DateTime? ScdEditedDate { get; set; }

    public int? TdpIdpk { get; set; }

    public string? TdpName { get; set; }

    public string? TdpShtName { get; set; }

    public bool? TdpActive { get; set; }

    public byte? TdpOrder { get; set; }

    public string? TdpRmks { get; set; }

    public bool? ScdExcludeWeekends { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? UsaUsername { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public bool? LocActive { get; set; }

    public string? EmpDirTelNo { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpIntercom { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFirstName { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public string? EmpMobNox { get; set; }

    public string? LocShtName { get; set; }

    public string? ScdUnit { get; set; }

    public decimal? ScdInitialValueComplete { get; set; }

    public decimal? ScdValueComplete { get; set; }

    public DateTime? ScpStartDate { get; set; }

    public DateTime? ScpEndDate { get; set; }

    public DateTime? ScpLastUpdatedOn { get; set; }

    public decimal? ScpCost { get; set; }

    public decimal? ScpPercentComplete { get; set; }

    public string? ScpResources { get; set; }

    public string? DptCode { get; set; }

    public string? SxnCode { get; set; }

    public bool? ScdPlanned { get; set; }

    public string? ScdDurationUnit { get; set; }

    public decimal? ScpReferenceWeight { get; set; }

    public decimal? ScpApplicableWeight { get; set; }

    public decimal? ScpAdjustableWeight { get; set; }

    public decimal? ScdDuration { get; set; }

    public decimal? ScdReferencePercentComplete { get; set; }

    public decimal? ScdApplicablePercentComplete { get; set; }

    public decimal? ScdAdjustedPercentComplete { get; set; }

    public decimal? ScpReferencePercentComplete { get; set; }

    public decimal? ScpApplicablePercentComplete { get; set; }

    public decimal? ScpAdjustedPercentComplete { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string? UntCode { get; set; }

    public bool? UntActive { get; set; }

    public string? ScpRmks { get; set; }
}
