using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHmsPrivilegesAssignment
{
    public int PvaIdpk { get; set; }

    public int? PvaEmpIdfk { get; set; }

    public int? PvaFacilityIdfk { get; set; }

    public bool? PvaDoctor { get; set; }

    public bool? PvaNurse { get; set; }

    public bool? PvaPharmacist { get; set; }

    public bool? PvaScheduleAppointment { get; set; }

    public bool? PvaApprove { get; set; }

    public bool? PvaRecommendPersonalRequests { get; set; }

    public bool? PvaApprovePersonalRequests { get; set; }

    public bool? PvaRecommend { get; set; }

    public bool? PvaRequestForOthers { get; set; }

    public bool? PvaSeeRating { get; set; }

    public bool? PvaSeeAllDeptsCostCenters { get; set; }

    public bool? PvaSeeOnlySectionsCostCenters { get; set; }

    public bool? PvaSeeAllCostCenters { get; set; }

    public bool? PvaReceiveAllRequestSms { get; set; }

    public bool? PvaActive { get; set; }

    public bool? PvaAlert { get; set; }

    public string? PvaRmks { get; set; }

    public int? PvaCreatedBy { get; set; }

    public int? PvaEditedBy { get; set; }

    public DateTime? PvaCreationDate { get; set; }

    public DateTime? PvaEditedDate { get; set; }
}
