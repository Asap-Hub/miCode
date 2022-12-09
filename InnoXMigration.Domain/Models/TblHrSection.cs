using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSection
{
    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int? SxnBranchIdfk { get; set; }

    public int? SxnDeptIdfk { get; set; }

    public string? SxnCode { get; set; }

    public DateTime? SxnStartDate { get; set; }

    public DateTime? SxnEndDate { get; set; }

    public int? SxnDirEmpIdfk { get; set; }

    public string? SxnDirStaffNo { get; set; }

    public string? SxnDirEmpName { get; set; }

    public int? SxnMgrEmpIdfk { get; set; }

    public string? SxnMgrStaffNo { get; set; }

    public string? SxnMgrEmpName { get; set; }

    public int? SxnHeadEmpIdfk { get; set; }

    public bool? SxnActive { get; set; }

    public string? SxnRmks { get; set; }

    public int? SxnCreatedBy { get; set; }

    public int? SxnEditedBy { get; set; }

    public DateTime? SxnCreationDate { get; set; }

    public DateTime? SxnEditedDate { get; set; }
}
