using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompHelpdeskAttendantsAssignment
{
    public int HaaIdpk { get; set; }

    public int? HaaEmpIdfk { get; set; }

    public int? HaaWorkshopIdfk { get; set; }

    public bool? HaaManage { get; set; }

    public bool? HaaView { get; set; }

    public bool? HaaCancelRequests { get; set; }

    public bool? HaaScheduleAlerts { get; set; }

    public bool? HaaOpenJobCards { get; set; }

    public bool? HaaManageJobDetails { get; set; }

    public bool? HaaManageMaterials { get; set; }

    public bool? HaaManageWorkOrders { get; set; }

    public bool? HaaManageInvoices { get; set; }

    public bool? HaaManageUpdates { get; set; }

    public bool? HaaSeeStatistics { get; set; }

    public bool? HaaGetSms { get; set; }

    public bool? HaaActive { get; set; }

    public string? HaaRmks { get; set; }

    public int? HaaCreatedBy { get; set; }

    public int? HaaEditedBy { get; set; }

    public DateTime? HaaCreationDate { get; set; }

    public DateTime? HaaEditedDate { get; set; }
}
