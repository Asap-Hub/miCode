using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleConditionReturn
{
    public int VcrIdpk { get; set; }

    public int? VcrVehicleAssignmentIdfk { get; set; }

    public string? VcrInside { get; set; }

    public string? VcrOutside { get; set; }

    public string? VcrTyre { get; set; }

    public string? VcrSuspension { get; set; }

    public string? VcrEngine { get; set; }

    public string? VcrAirConditioner { get; set; }

    public bool? VcrBoard { get; set; }

    public bool? VcrActive { get; set; }

    public string? VcrRmks { get; set; }

    public int VasIdpk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public bool? VasAssigned { get; set; }

    public string? VdtChassisNo { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public int EmpIdpk { get; set; }

    public string EmpLastName { get; set; } = null!;

    public string EmpStaffNo { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpName1 { get; set; } = null!;

    public string EmpFirstName { get; set; } = null!;

    public string EmpOthernames { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int DriverEmpIdfk { get; set; }

    public string DriverStaffNo { get; set; } = null!;

    public string DriverLname { get; set; } = null!;

    public string DriverFname { get; set; } = null!;

    public string DriverOnames { get; set; } = null!;

    public string DriverHrmsName { get; set; } = null!;

    public string DriverEmpName { get; set; } = null!;

    public string DriverEmpName1 { get; set; } = null!;

    public string DriverEmpName2 { get; set; } = null!;

    public string DriverEmpName3 { get; set; } = null!;

    public string DriverEmpName4 { get; set; } = null!;

    public short? DriverGndIdfk { get; set; }

    public string? DriverGndName { get; set; }

    public string? DriverGndShtName { get; set; }

    public int? DriverDptIdfk { get; set; }

    public string? DriverDptName { get; set; }

    public string? DriverDptShtName { get; set; }

    public int? DriverSxnIdfk { get; set; }

    public int OwnerEmpIdfk { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public string OwnerLname { get; set; } = null!;

    public string OwnerFname { get; set; } = null!;

    public string OwnerHrmsName { get; set; } = null!;

    public string OwnerEmpName { get; set; } = null!;

    public string OwnerEmpName1 { get; set; } = null!;

    public string OwnerEmpName2 { get; set; } = null!;

    public string OwnerEmpName3 { get; set; } = null!;

    public string OwnerEmpName4 { get; set; } = null!;

    public int? OwnerDptIdfk { get; set; }

    public string? OwnerDptName { get; set; }

    public string? OwnerDptShtName { get; set; }

    public int? OwnerSxnIdfk { get; set; }

    public string? OwnerSxnName { get; set; }

    public string? OwnerSxnShtName { get; set; }

    public int? OwnerUntIdfk { get; set; }

    public string? OwnerUntName { get; set; }

    public string? OwnerEmailOff { get; set; }

    public string? OwnerEmailPers { get; set; }

    public int? OwnerJbtIdfk { get; set; }

    public string? OwnerJbtName { get; set; }

    public string? OwnerJbtShtName { get; set; }

    public int? OwnerOfcIdfk { get; set; }

    public string? OwnerOfcName { get; set; }

    public string? OwnerOfcShtName { get; set; }

    public int? OwnerRomIdfk { get; set; }

    public string? OwnerRomName { get; set; }

    public string? OwnerRomShtName { get; set; }

    public bool? OwnerIsDirector { get; set; }

    public bool? OwnerIsManager { get; set; }

    public bool? OwnerIsSupervisor { get; set; }

    public bool? OwnerIsStaff { get; set; }

    public bool? OwnerIsSeniorStaff { get; set; }

    public bool? OwnerIsJuniorStaff { get; set; }

    public bool? OwnerIsManagementStaff { get; set; }

    public bool? OwnerIsServicePerson { get; set; }

    public bool? OwnerIsVoluntaryPerson { get; set; }

    public bool? OwnerHideMobNo { get; set; }

    public string? OwnerTelNo { get; set; }

    public string? OwnerMobNo { get; set; }

    public string? OwnerPlc { get; set; }

    public string? OwnerMobNox { get; set; }

    public int? OwnerLocIdfk { get; set; }

    public string? OwnerLocName { get; set; }

    public string? OwnerLocShtName { get; set; }

    public DateTime? VcrDate { get; set; }

    public int? VdtIdpk { get; set; }

    public decimal? ManufactureAge { get; set; }

    public decimal? SupplyAge { get; set; }

    public string? VdtRegNo { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public bool? VdtAssigned { get; set; }

    public decimal? VdtPrice { get; set; }

    public byte? VdtSeatingCapacity { get; set; }

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public bool? VmkActive { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public string? SplMainContact { get; set; }

    public string? SplMobNos { get; set; }

    public string? SplEmail { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public string? DriverPlc { get; set; }

    public string? DriverEmpMobNo { get; set; }

    public string? DriverJbtName { get; set; }

    public string? DriverJbtShtName { get; set; }

    public string? DriverMobNox { get; set; }

    public bool? CurForeign { get; set; }

    public string? VcrCondition { get; set; }

    public string? DriverSxnName { get; set; }

    public string? DriverSxnShtName { get; set; }

    public int? DriverUntIdfk { get; set; }

    public string? DriverUntName { get; set; }

    public string? DriverUntShtName { get; set; }

    public int? DriverLocIdfk { get; set; }

    public string? DriverLocName { get; set; }

    public string? DriverLocShtName { get; set; }

    public string? DriverEmpTelNo { get; set; }

    public string? DriverEmailOff { get; set; }

    public string? DriverEmailPers { get; set; }

    public int? DriverJbtIdfk { get; set; }

    public bool? DriverHideMobNo { get; set; }

    public bool? DriverIsStaff { get; set; }

    public bool? DriverIsSeniorStaff { get; set; }

    public bool? DriverIsJuniorStaff { get; set; }

    public bool? DriverIsManagementStaff { get; set; }

    public bool? DriverIsServicePerson { get; set; }

    public bool? DriverIsVoluntaryPerson { get; set; }

    public bool VcrSubmitted { get; set; }

    public int? VcrSubmittedByEmpIdfk { get; set; }

    public int SubmitterEmpIdpk { get; set; }

    public string SubmitterStaffNo { get; set; } = null!;

    public string SubmitterLname { get; set; } = null!;

    public string SubmitterFname { get; set; } = null!;

    public string SubmitterOnames { get; set; } = null!;

    public string SubmitterHrmsName { get; set; } = null!;

    public string SubmitterEmpName { get; set; } = null!;

    public string SubmitterEmpName1 { get; set; } = null!;

    public string SubmitterEmpName2 { get; set; } = null!;

    public string SubmitterEmpName3 { get; set; } = null!;

    public string SubmitterEmpName4 { get; set; } = null!;

    public string SubmitterEmpName5 { get; set; } = null!;

    public string SubmitterEmpName6 { get; set; } = null!;

    public string SubmitterEmpName7 { get; set; } = null!;

    public string SubmitterEmpName8 { get; set; } = null!;

    public string SubmitterEmpName9 { get; set; } = null!;

    public string SubmitterEmpName10 { get; set; } = null!;

    public string SubmitterEmpName11 { get; set; } = null!;

    public int SubmitterDeptIdpk { get; set; }

    public string SubmitterDeptName { get; set; } = null!;

    public string SubmitterDeptShtName { get; set; } = null!;

    public int SubmitterSxnId { get; set; }

    public string SubmitterSxnName { get; set; } = null!;

    public string SubmitterSxnShtName { get; set; } = null!;

    public int AckEmpIdpk { get; set; }

    public string AckStaffNo { get; set; } = null!;

    public string AckLname { get; set; } = null!;

    public string AckFname { get; set; } = null!;

    public string AckOnames { get; set; } = null!;

    public string AckHrmsName { get; set; } = null!;

    public string AckEmpName { get; set; } = null!;

    public string AckEmpName1 { get; set; } = null!;

    public string AckEmpName2 { get; set; } = null!;

    public string AckEmpName3 { get; set; } = null!;

    public string AckEmpName4 { get; set; } = null!;

    public string AckEmpName5 { get; set; } = null!;

    public string AckEmpName6 { get; set; } = null!;

    public string AckEmpName7 { get; set; } = null!;

    public string AckEmpName8 { get; set; } = null!;

    public string AckEmpName9 { get; set; } = null!;

    public string AckEmpName10 { get; set; } = null!;

    public string AckEmpName11 { get; set; } = null!;

    public int AckDeptIdpk { get; set; }

    public string AckDeptName { get; set; } = null!;

    public string AckDeptShtName { get; set; } = null!;

    public int AckSxnId { get; set; }

    public string AckSxnName { get; set; } = null!;

    public string AckSxnShtName { get; set; } = null!;

    public bool VcrAcknowledged { get; set; }

    public string SubmitterPlc { get; set; } = null!;

    public string SubmitterMobNo { get; set; } = null!;

    public string SubmitterMobNox { get; set; } = null!;

    public string AckPlc { get; set; } = null!;

    public string AckMobNo { get; set; } = null!;

    public string AckMobNox { get; set; } = null!;

    public bool VcrCard { get; set; }

    public bool VcrNonCard { get; set; }

    public decimal VcrOdometerStart { get; set; }

    public decimal VcrOdometerEnd { get; set; }

    public decimal? VcrDistance { get; set; }

    public string? VcrCreatedBy { get; set; }

    public int? VcrEditedBy { get; set; }

    public DateTime? VcrCreationDate { get; set; }

    public DateTime? VcrEditedDate { get; set; }

    public int TruIdpk { get; set; }

    public string TruName { get; set; } = null!;

    public string TruShtName { get; set; } = null!;

    public int? VasVehicleControllerEmpIdfk { get; set; }

    public int? VasAdminEmpIdfk { get; set; }

    public int? VasDriverEmpIdfk { get; set; }

    public int? VasOwnerEmpIdfk { get; set; }
}
