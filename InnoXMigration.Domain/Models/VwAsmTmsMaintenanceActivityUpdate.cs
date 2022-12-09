using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceActivityUpdate
{
    public int MauIdpk { get; set; }

    public DateTime? MauDate { get; set; }

    public int? MauMaintActivityIdfk { get; set; }

    public int? MauJobIdfk { get; set; }

    public string? MauActivityUpdate { get; set; }

    public decimal? MauPercentComplete { get; set; }

    public bool? MauActive { get; set; }

    public string? MauRmks { get; set; }

    public string? MauCreatedBy { get; set; }

    public int? MauEditedBy { get; set; }

    public DateTime? MauCreationDate { get; set; }

    public DateTime? MauEditedDate { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int UsaIdpk { get; set; }

    public string DptShtName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int MtaIdpk { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string? MtaJobNo { get; set; }

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int MjdIdpk { get; set; }

    public string? MjdJob { get; set; }

    public string? MjdDescription { get; set; }

    public DateTime? MjdDate { get; set; }

    public int? MjdMaintActivityIdfk { get; set; }

    public int? WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }
}
