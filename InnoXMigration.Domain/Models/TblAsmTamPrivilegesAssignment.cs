using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamPrivilegesAssignment
{
    public int TpaIdpk { get; set; }

    public int? TpaEmpIdfk { get; set; }

    public int? TpaLocationIdfk { get; set; }

    public bool? TpaManage { get; set; }

    public bool? TpaView { get; set; }

    public bool? TpaCancelRequests { get; set; }

    public bool? TpaScheduleAlerts { get; set; }

    public bool? TpaOpenJobCards { get; set; }

    public bool? TpaManageJobDetails { get; set; }

    public bool? TpaManageMaterials { get; set; }

    public bool? TpaManageWorkOrders { get; set; }

    public bool? TpaManageInvoices { get; set; }

    public bool? TpaManageUpdates { get; set; }

    public bool? TpaApproveRequests { get; set; }

    public bool? TpaSeeStatistics { get; set; }

    public bool? TpaGetSms { get; set; }

    public bool? TpaActive { get; set; }

    public string? TpaRmks { get; set; }

    public int? TpaCreatedBy { get; set; }

    public int? TpaEditedBy { get; set; }

    public DateTime? TpaCreationDate { get; set; }

    public DateTime? TpaEditedDate { get; set; }
}
