using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmSectionInitiativeAssignment
{
    public int SxiIdpk { get; set; }

    public int? SxiSectionIdfk { get; set; }

    public int? SxiObjectiveIdfk { get; set; }

    public int? SxiInitiativeIdfk { get; set; }

    public bool? SxiActive { get; set; }

    public string? SxiRmks { get; set; }

    public int? SxiCreatedBy { get; set; }

    public int? SxiEditedBy { get; set; }

    public DateTime? SxiCreationDate { get; set; }

    public DateTime? SxiEditedDate { get; set; }

    public int? MvsIdpk { get; set; }

    public string? MvsName { get; set; }

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string? MvsMission { get; set; }

    public string? MvsMissionSht { get; set; }

    public string? MvsVision { get; set; }

    public string? MvsVisionSht { get; set; }

    public bool? MvsActive { get; set; }

    public int? ThmIdpk { get; set; }

    public string? ThmName { get; set; }

    public bool? ThmActive { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public string? SxnCode { get; set; }

    public int? CinIdpk { get; set; }

    public string? CinName { get; set; }

    public string? CinShtName { get; set; }

    public bool? CinActive { get; set; }

    public int? ObjIdpk { get; set; }

    public string? ObjObjective { get; set; }

    public bool? ObjActive { get; set; }

    public int? PtvIdpk { get; set; }

    public string? PtvName { get; set; }

    public string? PtvShtName { get; set; }

    public string? PtvQuestionsAnswered { get; set; }

    public bool? PtvActive { get; set; }

    public int? OwnerEmpId { get; set; }

    public string? OwnerStaffNo { get; set; }

    public string? OwnerLastName { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerOtherNames { get; set; }

    public string? OwnerEmpName { get; set; }

    public string? OwnerEmpName1 { get; set; }

    public int? OwnerDptId { get; set; }

    public string? OwnerDptName { get; set; }

    public string? OwnerDptShtName { get; set; }

    public int? OwnerSxnId { get; set; }

    public string? OwnerSxnName { get; set; }

    public string? OwnerSxnShtName { get; set; }

    public string? ObjDescription { get; set; }

    public int? SxiPeriodIdfk { get; set; }

    public int? PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public bool? PrdActive { get; set; }

    public int BgtIdpk { get; set; }

    public string BgtName { get; set; } = null!;

    public string BgtShtName { get; set; } = null!;

    public DateTime? BgtStartDate { get; set; }

    public DateTime? BgtEndDate { get; set; }

    public bool BgtActive { get; set; }

    public int SxiBudgetIdfk { get; set; }

    public int? SxiDeptIdfk { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }
}
