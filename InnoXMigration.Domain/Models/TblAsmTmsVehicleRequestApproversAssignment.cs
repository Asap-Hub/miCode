using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleRequestApproversAssignment
{
    public int VaaIdpk { get; set; }

    public int? VaaEmpIdfk { get; set; }

    public int? VaaRequestAreaIdfk { get; set; }

    public bool? VaaApprove { get; set; }

    public bool? VaaRecommendPersonalRequests { get; set; }

    public bool? VaaApprovePersonalRequests { get; set; }

    public bool? VaaAssign { get; set; }

    public bool? VaaDriver { get; set; }

    public bool? VaaRecommend { get; set; }

    public bool? VaaRequestForOthers { get; set; }

    public bool? VaaManageKeys { get; set; }

    public bool? VaaSeeRating { get; set; }

    public bool? VaaSeeAllDeptsCostCenters { get; set; }

    public bool? VaaSeeOnlySectionsCostCenters { get; set; }

    public bool? VaaSeeAllCostCenters { get; set; }

    public bool? VaaReceiveAllRequestSms { get; set; }

    public bool? VaaActive { get; set; }

    public bool? VaaAlert { get; set; }

    public string? VaaRmks { get; set; }

    public int? VaaCreatedBy { get; set; }

    public int? VaaEditedBy { get; set; }

    public DateTime? VaaCreationDate { get; set; }

    public DateTime? VaaEditedDate { get; set; }
}
