using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsWorkshopAttendantsAssignment
{
    public int WaaIdpk { get; set; }

    public int? WaaEmpIdfk { get; set; }

    public int? WaaCreatedBy { get; set; }

    public int? WaaEditedBy { get; set; }

    public DateTime? WaaCreationDate { get; set; }

    public DateTime? WaaEditedDate { get; set; }

    public bool? WaaCancelRequests { get; set; }

    public bool? WaaScheduleAlerts { get; set; }

    public bool? WaaOpenJobCards { get; set; }

    public bool? WaaManageJobDetails { get; set; }

    public bool? WaaManageMaterials { get; set; }

    public bool? WaaManageWorkOrders { get; set; }

    public bool? WaaManageInvoices { get; set; }

    public bool? WaaManageUpdates { get; set; }

    public bool? WaaSeeStatistics { get; set; }

    public bool? WaaActive { get; set; }

    public string? WaaRmks { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string EmpLegacyName { get; set; } = null!;

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

    public int? WaaWorkshopIdfk { get; set; }

    public bool? WaaManage { get; set; }

    public bool? WaaView { get; set; }

    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public bool? WsdActive { get; set; }

    public string? WsdRmks { get; set; }

    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool? WaaGetSms { get; set; }

    public string? EmpName12 { get; set; }

    public bool WaaApproveRequests { get; set; }
}
