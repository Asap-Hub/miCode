using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenIssueLog
{
    public int IlgIdpk { get; set; }

    public bool Ilgfixed { get; set; }

    public string IlgIssue { get; set; } = null!;

    public byte[]? IlgImage { get; set; }

    public string IlgResolutionActivity { get; set; } = null!;

    public int? IlgCreatedBy { get; set; }

    public int? IlgEditedBy { get; set; }

    public DateTime? IlgCreationDate { get; set; }

    public DateTime? IlgEditedDate { get; set; }

    public int? IlgReportedByEmpIdfk { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public int? CreatedByEmpId { get; set; }

    public string? CreatedByUsername { get; set; }

    public string? CreatedByLname { get; set; }

    public string? CreatedByOnames { get; set; }

    public string? CreatedByName { get; set; }

    public string? CreatedByLocation { get; set; }

    public string? CreatedByArea { get; set; }

    public int? CreatedBySectionId { get; set; }

    public string? CreatedBySection { get; set; }

    public int? CreatedByDeptId { get; set; }

    public string? CreatedByDept { get; set; }

    public int? ReportedByEmpId { get; set; }

    public string? ReportedByStaffNo { get; set; }

    public string? ReportedByLname { get; set; }

    public string? ReportedByFname { get; set; }

    public string? ReportedByOnames { get; set; }

    public string? ReportedByHrmsName { get; set; }

    public string? ReportedByName { get; set; }

    public int? ReportedByDeptId { get; set; }

    public string? ReportedByDept { get; set; }

    public string? ReportedByDeptSht { get; set; }

    public int? ReportedBySectionId { get; set; }

    public string? ReportedBySection { get; set; }

    public string? ReportedByShtSection { get; set; }

    public int? ReportedByUnitId { get; set; }

    public string? ReportedByUnit { get; set; }

    public string? ReportedByShtUnit { get; set; }

    public int? ReportedByAreaId { get; set; }

    public string? ReportedByArea { get; set; }

    public string? ReportedByShtArea { get; set; }

    public int? ReportedByTitleId { get; set; }

    public string? ReportedByTitle { get; set; }

    public string? ReportedByShtTitle { get; set; }

    public DateTime? IlgIssueDate { get; set; }

    public int IctIdpk { get; set; }

    public string? IctName { get; set; }

    public string? IctShtName { get; set; }

    public bool? IctActive { get; set; }

    public string? IctRmks { get; set; }

    public DateTime? IlgDueDate { get; set; }

    public byte IlgInitialPercentComplete { get; set; }

    public byte IlgPercentComplete { get; set; }

    public DateTime IlgCompletionDate { get; set; }

    public DateTime IlgUpdateDate { get; set; }

    public int IlgClassIdfk { get; set; }

    public int IlgSubclassIdfk { get; set; }

    public int IlgStatusIdfk { get; set; }

    public int IlgImpactIdfk { get; set; }

    public int IclIdpk { get; set; }

    public string IclName { get; set; } = null!;

    public string IclShtName { get; set; } = null!;

    public bool IclActive { get; set; }

    public string IclRmks { get; set; } = null!;

    public int IscIdpk { get; set; }

    public string IscName { get; set; } = null!;

    public string IscShtName { get; set; } = null!;

    public int IscClassIdfk { get; set; }

    public bool IscActive { get; set; }

    public string IscRmks { get; set; } = null!;

    public int IstIdpk { get; set; }

    public string IstName { get; set; } = null!;

    public string IstShtName { get; set; } = null!;

    public bool IstActive { get; set; }

    public string IstRmks { get; set; } = null!;

    public int IimIdpk { get; set; }

    public string IimName { get; set; } = null!;

    public string IimShtName { get; set; } = null!;

    public bool IimActive { get; set; }

    public string IimRmks { get; set; } = null!;

    public string IlgLocation { get; set; } = null!;

    public int IlgIssueTypeIdfk { get; set; }

    public int ItpIdpk { get; set; }

    public string ItpName { get; set; } = null!;

    public string ItpShtName { get; set; } = null!;

    public bool ItpActive { get; set; }

    public string ItpRmks { get; set; } = null!;

    public string IlgAcceptanceRmks { get; set; } = null!;

    public string IlgUpdatedBy { get; set; } = null!;

    public string IlgUpdatedByDept { get; set; } = null!;

    public string IlgUpdatedBySection { get; set; } = null!;

    public string IlgUpdatedByLocation { get; set; } = null!;

    public decimal IlgRating { get; set; }

    public string IlgTechnicalDescription { get; set; } = null!;

    public int IlgDeptIdfk { get; set; }

    public int IlgSectionIdfk { get; set; }

    public int RequestDeptId { get; set; }

    public string RequestDeptName { get; set; } = null!;

    public string RequestDeptShtName { get; set; } = null!;

    public int RequestSxnId { get; set; }

    public string RequestSxnName { get; set; } = null!;

    public string RequestSxnShtName { get; set; } = null!;

    public int IlcIdpk { get; set; }

    public string IlcName { get; set; } = null!;

    public string IlcShtName { get; set; } = null!;

    public int IlgLocationIdfk { get; set; }

    public int? IlgCategoryIdfk { get; set; }
}
