using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsMaintenanceFrequency
{
    public int MtfIdpk { get; set; }

    public DateTime? MtfStartDate { get; set; }

    public int? MtfVehicleDetailIdfk { get; set; }

    public int? MtfDeptIdfk { get; set; }

    public int? MtfSectionIdfk { get; set; }

    public int? MtfModelIdfk { get; set; }

    public int? MtfWorkshopIdfk { get; set; }

    public int? MtfMaintenanceTypeIdfk { get; set; }

    public string? MtfReschedulePlan { get; set; }

    public int? MtfOwnerEmpIdfk { get; set; }

    public int? MtfDriverEmpIdfk { get; set; }

    public int? MtfAdminEmpIdfk { get; set; }

    public int? MtfControllerEmpIdfk { get; set; }

    public DateTime? MtfLastMaintenanceDate { get; set; }

    public int? MtfFrequencyDays { get; set; }

    public int? MtfFrequencyKm { get; set; }

    public DateTime? MtfMaintenanceDate { get; set; }

    public DateTime? MtfSecondFrequencyDate { get; set; }

    public DateTime? MtfThirdFrequencyDate { get; set; }

    public DateTime? MtfFourthFrequencyDate { get; set; }

    public int? MtfFirstSmsPromptDays { get; set; }

    public int? MtfSecondSmsPromptDays { get; set; }

    public int? MtfThirdSmsPromptDays { get; set; }

    public int? MtfFourthSmsPromptDays { get; set; }

    public bool? MtfPromptDriver { get; set; }

    public bool? MtfPromptOwner { get; set; }

    public bool? MtfPromptAdmin { get; set; }

    public bool? MtfPromptVehicleController { get; set; }

    public bool? MtfPromptManager { get; set; }

    public bool? MtfPromptDirector { get; set; }

    public int? MtsSmsCount { get; set; }

    public bool? MtfSmsSent { get; set; }

    public DateTime? MtfLastAlertDate { get; set; }

    public DateTime? MtfNextAlertDate { get; set; }

    public int? MtfBatchNo { get; set; }

    public bool? MtfAutoReschedule { get; set; }

    public bool? MtfDeleted { get; set; }

    public bool? MtfActive { get; set; }

    public string? MtfRmks { get; set; }

    public int? MtfCreatedBy { get; set; }

    public int? MtfEditedBy { get; set; }

    public DateTime? MtfCreationDate { get; set; }

    public DateTime? MtfEditedDate { get; set; }
}
