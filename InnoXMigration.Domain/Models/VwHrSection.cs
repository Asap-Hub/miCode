using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrSection
{
    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int? SxnDeptIdfk { get; set; }

    public bool? SxnActive { get; set; }

    public string SxnRmks { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public bool DptActive { get; set; }

    public string DptRmks { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public string SxnCode { get; set; } = null!;

    public int SxnBranchIdfk { get; set; }

    public int ObrIdpk { get; set; }

    public string ObrName { get; set; } = null!;

    public string ObrShtName { get; set; } = null!;

    public string ObrCode { get; set; } = null!;

    public DateTime? ObrStartDate { get; set; }

    public DateTime? ObrEndDate { get; set; }

    public DateTime? SxnStartDate { get; set; }

    public DateTime? SxnEndDate { get; set; }

    public int? SxnDirEmpIdfk { get; set; }

    public string? SxnDirStaffNo { get; set; }

    public string? SxnDirEmpName { get; set; }

    public int? SxnMgrEmpIdfk { get; set; }

    public string? SxnMgrStaffNo { get; set; }

    public string? SxnMgrEmpName { get; set; }
}
