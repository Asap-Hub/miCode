using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleRequestsx
{
    public int VrqIdpk { get; set; }

    public DateTime? VrqDepartureTime { get; set; }

    public DateTime? VrqArrivalTime { get; set; }

    public string VrqCategory { get; set; } = null!;

    public byte? VrqRequestSeatingCapacity { get; set; }

    public string VrqDebit { get; set; } = null!;

    public string VrqDebitSection { get; set; } = null!;

    public byte VrqApprovedSeatingCapacity { get; set; }

    public string VrqDebitDept { get; set; } = null!;

    public string VrqApprovalRmks { get; set; } = null!;

    public string VrqCancellationRmks { get; set; } = null!;

    public int VrqApprovedVehicleIdfk { get; set; }

    public string VrqPurpose { get; set; } = null!;

    public bool VrqApproved { get; set; }

    public bool? VrqActive { get; set; }

    public bool VrqSmsSent { get; set; }

    public string VrqRmks { get; set; } = null!;

    public string? VrqCreatedBy { get; set; }

    public DateTime? VrqCreationDate { get; set; }

    public int RequesterEmpId { get; set; }

    public string? RequesterStaffNo { get; set; }

    public string? RequesterLname { get; set; }

    public string? RequesterFname { get; set; }

    public string RequesterOnames { get; set; } = null!;

    public string RequesterHrmsName { get; set; } = null!;

    public string? RequesterEmpName { get; set; }

    public string? RequesterEmpName1 { get; set; }

    public string? RequesterEmpName2 { get; set; }

    public string? RequesterEmpName3 { get; set; }

    public string? RequesterEmpName4 { get; set; }

    public string? RequesterEmpName5 { get; set; }

    public string? RequesterEmpName6 { get; set; }

    public string? RequesterEmpName7 { get; set; }

    public string? RequesterEmpName8 { get; set; }

    public string? RequesterEmpName9 { get; set; }

    public string? RequesterEmpName10 { get; set; }

    public string? RequesterEmpName11 { get; set; }

    public int RequesterDeptId { get; set; }

    public string RequesterDeptName { get; set; } = null!;

    public string RequesterDeptShtName { get; set; } = null!;

    public int RequesterSxnId { get; set; }

    public string RequesterSxnName { get; set; } = null!;

    public string RequesterSxnShtName { get; set; } = null!;

    public int RequesterLocId { get; set; }

    public string RequesterLocName { get; set; } = null!;

    public string RequesterLocShtName { get; set; } = null!;

    public string RequesterMobNox { get; set; } = null!;

    public string RequesterPlc { get; set; } = null!;

    public string RequesterMobNo { get; set; } = null!;

    public int RequesterJbtId { get; set; }

    public string RequesterJbtName { get; set; } = null!;

    public string RequesterJbtShtName { get; set; } = null!;

    public int DriverEmpId { get; set; }

    public string DriverStaffNo { get; set; } = null!;

    public string DriverLname { get; set; } = null!;

    public string DriverFname { get; set; } = null!;

    public string DriverOnames { get; set; } = null!;

    public string DriverHrmsNames { get; set; } = null!;

    public string DriverEmpName { get; set; } = null!;

    public string DriverEmpName1 { get; set; } = null!;

    public string DriverEmpName2 { get; set; } = null!;

    public string DriverEmpName3 { get; set; } = null!;

    public string DriverEmpName4 { get; set; } = null!;

    public string DriverEmpName5 { get; set; } = null!;

    public string DriverEmpName6 { get; set; } = null!;

    public string DriverEmpName7 { get; set; } = null!;

    public string DriverEmpName8 { get; set; } = null!;

    public string DriverEmpName9 { get; set; } = null!;

    public string DriverEmpName10 { get; set; } = null!;

    public string DriverEmpName11 { get; set; } = null!;

    public int DriverDeptId { get; set; }

    public string DriverDeptName { get; set; } = null!;

    public string DriverDeptShtName { get; set; } = null!;

    public int DriverSxnId { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int DriverLocId { get; set; }

    public string DriverLocName { get; set; } = null!;

    public string DriverLocShtName { get; set; } = null!;

    public string DriverMobNox { get; set; } = null!;

    public string DriverPlc { get; set; } = null!;

    public string DriverMobNo { get; set; } = null!;

    public int DriverJbtId { get; set; }

    public string DriverJbtName { get; set; } = null!;

    public string DriverJbtShtName { get; set; } = null!;

    public string? VrqFromTown { get; set; }

    public string? VrqToTown { get; set; }

    public int FromRgnId { get; set; }

    public string? FromRgnName { get; set; }

    public string? FromRgnShtName { get; set; }

    public int? FromRgnCtyId { get; set; }

    public string? FromRgnCtyName { get; set; }

    public string? FromRgnCtyShtName { get; set; }

    public string? FromRgnCtyNationality { get; set; }

    public int ToRgnId { get; set; }

    public string? ToRgnName { get; set; }

    public string? ToRgnShtName { get; set; }

    public int? ToRgnCtyId { get; set; }

    public string? ToRgnCtyName { get; set; }

    public string? ToRgnCtyShtName { get; set; }

    public string? ToRgnCtyNationality { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public decimal VdtTankCapacity { get; set; }

    public byte VdtSeatingCapacity { get; set; }

    public short RequesterGndId { get; set; }

    public string RequesterGndName { get; set; } = null!;

    public string RequesterGndShtName { get; set; } = null!;

    public int? ApproverEmpId { get; set; }

    public string? ApproverStaffNo { get; set; }

    public string? ApproverLname { get; set; }

    public string? ApproverFname { get; set; }

    public string? ApproverOnames { get; set; }

    public string? ApproverHrmsName { get; set; }

    public string? ApproverEmpName { get; set; }

    public string? ApproverEmpName1 { get; set; }

    public string? ApproverEmpName2 { get; set; }

    public string? ApproverEmpName3 { get; set; }

    public string? ApproverEmpName4 { get; set; }

    public string? ApproverEmpName5 { get; set; }

    public string? ApproverEmpName6 { get; set; }

    public string? ApproverEmpName7 { get; set; }

    public string? ApproverEmpName8 { get; set; }

    public string? ApproverEmpName9 { get; set; }

    public string? ApproverEmpName10 { get; set; }

    public string? ApproverEmpName11 { get; set; }

    public int? ApproverDeptId { get; set; }

    public string? ApproverDeptName { get; set; }

    public string? ApproverDeptShtName { get; set; }

    public int? ApproverSxnId { get; set; }

    public string? ApproverSxnName { get; set; }

    public string? ApproverSxnShtName { get; set; }

    public int? ApproverLocId { get; set; }

    public string? ApproverLocName { get; set; }

    public string? ApproverLocShtName { get; set; }

    public string? ApproverMobNox { get; set; }

    public string? ApproverPlc { get; set; }

    public string? ApproverMobNo { get; set; }

    public int? ApproverJbtId { get; set; }

    public string? ApproverJbtName { get; set; }

    public string? ApproverJbtShtName { get; set; }

    public short ApproverGndId { get; set; }

    public string ApproverGndName { get; set; } = null!;

    public string ApproverGndShtName { get; set; } = null!;

    public int VraIdpk { get; set; }

    public string VraName { get; set; } = null!;

    public string VraShtName { get; set; } = null!;

    public bool VraActive { get; set; }

    public int Expr1 { get; set; }

    public int VrqAreaIdfk { get; set; }

    public bool VrqRequestDriver { get; set; }

    public bool VrqRequestVehicle { get; set; }

    public bool VrqDriverApproved { get; set; }

    public bool VrqVehicleApproved { get; set; }

    public int? VrqRequesterEmpIdfk { get; set; }

    public string VrqRoute { get; set; } = null!;

    public bool VrqCancelled { get; set; }

    public int VrqCancelledByEmpIdfk { get; set; }

    public DateTime? VrqCancelledOn { get; set; }
}
