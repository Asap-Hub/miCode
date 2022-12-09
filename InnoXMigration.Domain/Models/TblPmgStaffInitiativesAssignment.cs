using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgStaffInitiativesAssignment
{
    public int SiaIdpk { get; set; }

    public int? SiaPeriodIdfk { get; set; }

    public int? SiaSectionIdfk { get; set; }

    public int? SiaUnitIdfk { get; set; }

    public int? SiaCorporateInitiativeIdfk { get; set; }

    public int? SiaUnitInitiativeIdfk { get; set; }

    public int? SiaStaffInitiativeIdfk { get; set; }

    public int? SiaEmpIdfk { get; set; }

    public int? SiaSupervisorEmpIdfk { get; set; }

    public int? SiaManagerEmpIdfk { get; set; }

    public int? SiaDirectorEmpIdfk { get; set; }

    public string? SiaStakeholders { get; set; }

    public string? SiaStakeholderIds { get; set; }

    public int? SiaMeasureIdfk { get; set; }

    public int? SiaTargetIdfk { get; set; }

    public decimal? SiaTargetFrequency { get; set; }

    public short? SiaOrder { get; set; }

    public bool? SiaApplyTargetFrequency { get; set; }

    public bool? SiaAllowActualsManualUpdate { get; set; }

    public int? SiaStaffActualIdfk { get; set; }

    public int? SiaSupActualIdfk { get; set; }

    public string? SiaStaffActualValue { get; set; }

    public string? SiaSupActualValue { get; set; }

    public int? SiaWeight { get; set; }

    public int? SiaStaffRatingIdfk { get; set; }

    public int? SiaSupRatingIdfk { get; set; }

    public decimal? SiaStaffPercentageComplete { get; set; }

    public decimal? SiaSupPercentageComplete { get; set; }

    public bool? SiaCompulsory { get; set; }

    public int? SiaMonitorResultsFromIdfk { get; set; }

    public bool? SiaActive { get; set; }

    public bool? SiaLocked { get; set; }

    public bool? SiaSubmitted { get; set; }

    public DateTime? SiaSubmittedOn { get; set; }

    public int? SiaSubmittedByEmpIdfk { get; set; }

    public bool? SiaMgrChecked { get; set; }

    public bool? SiaSupChecked { get; set; }

    public bool? SiaDirChecked { get; set; }

    public bool? SiaAcknowledged { get; set; }

    public int? SiaAcknowledgedByEmpIdfk { get; set; }

    public DateTime? SiaAcknowledgedOn { get; set; }

    public string? SiaStaffAppraisalRmks { get; set; }

    public string? SiaSupAppraisalRmks { get; set; }

    public string? SiaRmks { get; set; }

    public int? SiaCreatedBy { get; set; }

    public int? SiaEditedBy { get; set; }

    public DateTime? SiaCreationDate { get; set; }

    public DateTime? SiaEditedDate { get; set; }
}
