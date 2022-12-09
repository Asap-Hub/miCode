using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmCorporateInitiativeAssignment
{
    public int CiaIdpk { get; set; }

    public int? CiaObjectiveIdfk { get; set; }

    public int? CiaInitiativeIdfk { get; set; }

    public bool? CiaActive { get; set; }

    public string? CiaRmks { get; set; }

    public int? CiaCreatedBy { get; set; }

    public int? CiaEditedBy { get; set; }

    public DateTime? CiaCreationDate { get; set; }

    public DateTime? CiaEditedDate { get; set; }

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

    public int? CinIdpk { get; set; }

    public string? CinName { get; set; }

    public string? CinShtName { get; set; }

    public bool? CinActive { get; set; }

    public int? ObjIdpk { get; set; }

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

    public int? CiaPeriodIdfk { get; set; }

    public int? PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public bool? PrdActive { get; set; }

    public string? ObjName { get; set; }
}
