using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrStaffBeneficiary
{
    public int SbfIdpk { get; set; }

    public int? SbfEmpIdfk { get; set; }

    public string? SbfBeneficiaryName { get; set; }

    public int? SbfRelationshipIdfk { get; set; }

    public DateTime? SbfBeneficiaryDoB { get; set; }

    public decimal? SbfTier2Percentage { get; set; }

    public decimal? SbfTier3Percentage { get; set; }

    public string? SbfBeneficiaryAddress { get; set; }

    public int? SbfIdtypeIdfk { get; set; }

    public string? SbfIdnumber { get; set; }

    public int? SbfWitnessedByEmpIdfk { get; set; }

    public DateTime? SbfWitnessedOn { get; set; }

    public int? SbfApprovedByEmpIdfk { get; set; }

    public int? SbfDisapprovedByEmpIdfk { get; set; }

    public bool? SbfSubmitted { get; set; }

    public bool? SbfWitnessed { get; set; }

    public bool? SbfApproved { get; set; }

    public bool? SbfDisapproved { get; set; }

    public DateTime? SbfApprovedOn { get; set; }

    public DateTime? SbfDisapprovedOn { get; set; }

    public bool? SbfActive { get; set; }

    public string? SbfRmks { get; set; }

    public int? SbfCreatedBy { get; set; }

    public int? SbfEditedBy { get; set; }

    public DateTime? SbfCreationDate { get; set; }

    public DateTime? SbfEditedDate { get; set; }
}
