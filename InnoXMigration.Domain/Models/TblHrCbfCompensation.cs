using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCbfCompensation
{
    public int ScmIdpk { get; set; }

    public DateTime? ScmDate { get; set; }

    public string? ScmStaffNo { get; set; }

    public int? ScmDeptIdfk { get; set; }

    public decimal? ScmMonthlySalary { get; set; }

    public decimal? ScmAnnualSalary { get; set; }

    public int? ScmConditionNoOfYears { get; set; }

    public int? ScmEquivalentMonthsDue { get; set; }

    public int? ScmNextAnniversaryAwardIdfk { get; set; }

    public int? ScmPreviousAnniversaryAwardIdfk { get; set; }

    public int? ScmNextAwardIdfk { get; set; }

    public DateTime? ScmNextDueDate { get; set; }

    public int? ScmPreviousAwardIdfk { get; set; }

    public decimal? ScmGiftAwardAmount { get; set; }

    public int? ScmEquivalentMonthsUtilised { get; set; }

    public decimal? ScmNoOfYearsBonus { get; set; }

    public decimal? ScmMonthlyAccrual { get; set; }

    public decimal? ScmCurrentYearAccruals { get; set; }

    public decimal? ScmAccumulatedAccrualToEndOfCurrentYear { get; set; }

    public decimal? ScmRetirementAwardAmount { get; set; }

    public int? ScmYearsUpToRetirement { get; set; }

    public decimal? ScmRetirementAwardYearlyAmount { get; set; }

    public decimal? ScmRetirementAwardMonthlyAmount { get; set; }

    public int? ScmOutstandingLeaveDays { get; set; }

    public decimal? ScmOutstandingAccrualLeaveAmount { get; set; }

    public decimal? ScmYearsConsumed { get; set; }

    public decimal? ScmYearsOutstanding { get; set; }

    public decimal? ScmUndiscountedAnnualCostAmortised { get; set; }

    public decimal? ScmUndiscountedOpeningObligationCost { get; set; }

    public decimal? ScmUndiscountedClosingObligationCost { get; set; }

    public decimal? ScmDiscountedOpeningObligationCost { get; set; }

    public decimal? ScmDiscountedInterestCost { get; set; }

    public decimal? ScmDiscountedCurrentServiceCost { get; set; }

    public decimal? ScmDiscountedClosingObligationCost { get; set; }

    public bool? ScmDue { get; set; }

    public bool? ScmActive { get; set; }

    public string? ScmRmks { get; set; }

    public string? ScmCreatedBy { get; set; }

    public int? ScmEditedBy { get; set; }

    public DateTime? ScmCreationDate { get; set; }

    public DateTime? ScmEditedDate { get; set; }
}
