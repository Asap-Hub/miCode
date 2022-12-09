using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwLglCaseUpdate
{
    public int CupIdpk { get; set; }

    public DateTime? CupDate { get; set; }

    public int CupCaseIdfk { get; set; }

    public string CupUpdate { get; set; } = null!;

    public decimal CupPercentComplete { get; set; }

    public DateTime? CupCompletionDate { get; set; }

    public bool CupActive { get; set; }

    public string CupRmks { get; set; } = null!;

    public int CseIdpk { get; set; }

    public int CupStatusIdfk { get; set; }

    public string CupCreatedBy { get; set; } = null!;

    public int CupEditedBy { get; set; }

    public DateTime? CupCreationDate { get; set; }

    public DateTime? CupEditedDate { get; set; }

    public int CreatedByUserId { get; set; }

    public int CreatedByDeptId { get; set; }

    public string FdptName { get; set; } = null!;

    public int FsxnIdpk { get; set; }

    public string FsxnName { get; set; } = null!;

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public int CreatedByEmpId { get; set; }

    public string CreatedByStaffNo { get; set; } = null!;

    public string? CreatedByEmpName1 { get; set; }

    public string? CreatedByEmpName2 { get; set; }

    public string? CreatedByEmpName5 { get; set; }

    public string? CreatedByEmpName6 { get; set; }

    public string? CreatedByEmpName7 { get; set; }

    public string? CreatedByEmpName8 { get; set; }

    public string? CreatedByEmpName9 { get; set; }

    public string? CreatedByEmpName10 { get; set; }

    public string? CreatedByEmpName11 { get; set; }

    public string? CreatedByDeptShtName { get; set; }

    public string? CreatedBySxnShtName { get; set; }

    public int? CreatedByJobId { get; set; }

    public string? CreatedByJobName { get; set; }

    public string? CreatedByJobTitle { get; set; }

    public int? CreatedByJbtId { get; set; }

    public string? CreatedByJbtName { get; set; }

    public string? CreatedByJbtShtName { get; set; }

    public string? CreatedByMobNo { get; set; }

    public string? CreatedByMobNox { get; set; }

    public string CreatedByIntercom { get; set; } = null!;

    public int CupImpactIdfk { get; set; }

    public string CupDoneBy { get; set; } = null!;

    public string CupDoneByDept { get; set; } = null!;

    public string CupDoneBySection { get; set; } = null!;

    public string CupDoneByLocation { get; set; } = null!;

    public string CupTag { get; set; } = null!;

    public int CimIdpk { get; set; }

    public string CimName { get; set; } = null!;

    public string CimShtName { get; set; } = null!;

    public byte CimOrder { get; set; }

    public bool CimActive { get; set; }

    public int CstIdpk { get; set; }

    public string CstName { get; set; } = null!;

    public string CstShtName { get; set; } = null!;

    public byte CstOrder { get; set; }

    public bool CstActive { get; set; }

    public bool CupRequestForInfo { get; set; }

    public bool CupInfoRequestReceived { get; set; }

    public bool CupLocked { get; set; }
}
