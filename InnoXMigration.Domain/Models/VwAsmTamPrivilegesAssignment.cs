using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamPrivilegesAssignment
{
    public int TpaIdpk { get; set; }

    public int? TpaEmpIdfk { get; set; }

    public int? TpaCreatedBy { get; set; }

    public int? TpaEditedBy { get; set; }

    public DateTime? TpaCreationDate { get; set; }

    public DateTime? TpaEditedDate { get; set; }

    public bool? TpaCancelRequests { get; set; }

    public bool? TpaScheduleAlerts { get; set; }

    public bool? TpaOpenJobCards { get; set; }

    public bool? TpaManageJobDetails { get; set; }

    public bool? TpaManageMaterials { get; set; }

    public bool? TpaManageWorkOrders { get; set; }

    public bool? TpaManageInvoices { get; set; }

    public bool? TpaManageUpdates { get; set; }

    public bool? TpaSeeStatistics { get; set; }

    public bool? TpaActive { get; set; }

    public string? TpaRmks { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int? TpaLocationIdfk { get; set; }

    public bool? TpaManage { get; set; }

    public bool? TpaView { get; set; }

    public int TalIdpk { get; set; }

    public string? TalName { get; set; }

    public string? TalShtName { get; set; }

    public bool? TalActive { get; set; }

    public string? TalRmks { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool? TpaGetSms { get; set; }

    public string? EmpName12 { get; set; }
}
