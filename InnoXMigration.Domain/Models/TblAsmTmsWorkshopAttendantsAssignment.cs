using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsWorkshopAttendantsAssignment
{
    public int WaaIdpk { get; set; }

    public int? WaaEmpIdfk { get; set; }

    public int? WaaWorkshopIdfk { get; set; }

    public bool? WaaManage { get; set; }

    public bool? WaaView { get; set; }

    public bool? WaaCancelRequests { get; set; }

    public bool? WaaScheduleAlerts { get; set; }

    public bool? WaaOpenJobCards { get; set; }

    public bool? WaaManageJobDetails { get; set; }

    public bool? WaaManageMaterials { get; set; }

    public bool? WaaManageWorkOrders { get; set; }

    public bool? WaaManageInvoices { get; set; }

    public bool? WaaManageUpdates { get; set; }

    public bool? WaaSeeStatistics { get; set; }

    public bool? WaaApproveRequests { get; set; }

    public bool? WaaGetSms { get; set; }

    public bool? WaaActive { get; set; }

    public string? WaaRmks { get; set; }

    public int? WaaCreatedBy { get; set; }

    public int? WaaEditedBy { get; set; }

    public DateTime? WaaCreationDate { get; set; }

    public DateTime? WaaEditedDate { get; set; }
}
