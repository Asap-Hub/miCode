using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpEducationHistory
{
    public int EehIdpk { get; set; }

    public int? EehEmpIdfk { get; set; }

    public int? EehInstitutionIdfk { get; set; }

    public int? EehAwardingInstitutionIdfk { get; set; }

    public int? EehCertificateGroupIdfk { get; set; }

    public int? EehCertificateTypeIdfk { get; set; }

    public int? EehProgramIdfk { get; set; }

    public int? EehSponsorIdfk { get; set; }

    public int? EehGradingTypeIdfk { get; set; }

    public int? EehTownIdfk { get; set; }

    public string? EehCertificateName { get; set; }

    public string? EehCertificateSerialNo { get; set; }

    public string? EehCertificateId { get; set; }

    public DateTime? EehStartDate { get; set; }

    public DateTime? EehEndDate { get; set; }

    public DateTime? EehAwardDate { get; set; }

    public DateTime? EehApprovalDate { get; set; }

    public int? EehApprovedByEmpIdfk { get; set; }

    public string? EehApprovalRemarks { get; set; }

    public string? EehRmks { get; set; }

    public bool? EehApproved { get; set; }

    public int? EehCreatedBy { get; set; }

    public int? EehEditedBy { get; set; }

    public DateTime? EehCreationDate { get; set; }

    public DateTime? EehEditedDate { get; set; }
}
