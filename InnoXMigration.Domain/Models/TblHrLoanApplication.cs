using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLoanApplication
{
    public int LapIdpk { get; set; }

    public int? LapApplicantEmpIdfk { get; set; }

    public int? LapLoanTypeIdfk { get; set; }

    public DateTime? LapDate { get; set; }

    public decimal? LapAmount { get; set; }

    public string? LapDescription { get; set; }

    public bool? LapApproved { get; set; }

    public bool? LapRejected { get; set; }

    public string? LapStaffDetails { get; set; }

    public string? LapLoanDetails { get; set; }

    public string? LapAmountDetails { get; set; }

    public int? LapRejectedByEmpIdfk { get; set; }

    public bool? LapApplicationOk { get; set; }

    public int? LapFirstApproverEmpIdfk { get; set; }

    public DateTime? LapFirstApprovalDate { get; set; }

    public string? LapFirstApprovalRmks { get; set; }

    public int? LapFirstRejecterEmpIdfk { get; set; }

    public DateTime? LapFirstRejectionDate { get; set; }

    public string? LapFirstRejectionRmks { get; set; }

    public int? LapSecondApproverEmpIdfk { get; set; }

    public int? LapThirdApproverEmpIdfk { get; set; }

    public int? LapFourthApproverEmpIdfk { get; set; }

    public int? LapFifthApproverEmpIdfk { get; set; }

    public bool? LapActive { get; set; }

    public string? LapRmks { get; set; }

    public string? LapCreatedBy { get; set; }

    public int? LapEditedBy { get; set; }

    public DateTime? LapCreationDate { get; set; }

    public DateTime? LapEditedDate { get; set; }
}
