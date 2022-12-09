using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleRequestApproversAssignment
{
    public int VaaIdpk { get; set; }

    public bool? VaaActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName12 { get; set; }

    public string EmpLegacyName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public string? VaaRmks { get; set; }

    public int? VaaEmpIdfk { get; set; }

    public int? VaaCreatedBy { get; set; }

    public int? VaaEditedBy { get; set; }

    public DateTime? VaaCreationDate { get; set; }

    public DateTime? VaaEditedDate { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int VraIdpk { get; set; }

    public string? VraName { get; set; }

    public string? VraShtName { get; set; }

    public bool? VraActive { get; set; }

    public string? VraRmks { get; set; }

    public string? VraCreatedBy { get; set; }

    public int? VraEditedBy { get; set; }

    public int? VaaRequestAreaIdfk { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool VaaApprove { get; set; }

    public bool VaaDriver { get; set; }

    public bool VaaRecommend { get; set; }

    public bool VaaAlert { get; set; }

    public bool VaaManageKeys { get; set; }

    public bool VaaSeeRating { get; set; }

    public bool VaaAssign { get; set; }

    public bool VaaRecommendPersonalRequests { get; set; }

    public bool VaaApprovePersonalRequests { get; set; }

    public bool VaaSeeAllDeptsCostCenters { get; set; }

    public bool VaaSeeOnlySectionsCostCenters { get; set; }

    public bool VaaSeeAllCostCenters { get; set; }

    public bool VaaRequestForOthers { get; set; }

    public bool VaaReceiveAllRequestSms { get; set; }
}
