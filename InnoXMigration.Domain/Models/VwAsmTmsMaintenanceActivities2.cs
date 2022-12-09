using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceActivities2
{
    public int MtaIdpk { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string? MtaJobNo { get; set; }

    public int? MtaMaintenanceTypeIdfk { get; set; }

    public decimal? MtaSpeedoIn { get; set; }

    public decimal? MtaSpeedoOut { get; set; }

    public decimal? MtaSpeedoDiff { get; set; }

    public string? MtaDebitCriteria { get; set; }

    public int? MtaDeptIdfk { get; set; }

    public int? MtaSectionIdfk { get; set; }

    public int? MtaUnitIdfk { get; set; }

    public bool? MtaActive { get; set; }

    public string? MtaRmks { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public bool? DptActive { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? UntSectionIdfk { get; set; }

    public string? UntCode { get; set; }

    public bool? UntActive { get; set; }

    public int VasIdpk { get; set; }

    public int? VasVehicleDetailIdfk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public bool? VasAssigned { get; set; }

    public bool VasActive { get; set; }

    public int? VdtIdpk { get; set; }

    public string? VdtChassisNo { get; set; }

    public int Expr1 { get; set; }

    public string Expr2 { get; set; } = null!;

    public string Expr3 { get; set; } = null!;

    public string? VdtRegNo { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public bool? VdtAssigned { get; set; }

    public decimal? VdtPrice { get; set; }

    public string? VdtColour { get; set; }

    public byte? VdtSeatingCapacity { get; set; }

    public bool? VdtActive { get; set; }

    public string? VdtRmks { get; set; }

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

    public bool? VhcActive { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public bool? VstActive { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public string? SplMainContact { get; set; }

    public string? SplMobNos { get; set; }

    public string? SplEmail { get; set; }

    public string? SplTelNos { get; set; }

    public int? FtpIdpk { get; set; }

    public string? FtpName { get; set; }

    public string? FtpShtName { get; set; }

    public bool? FtpActive { get; set; }

    public int? EgtIdpk { get; set; }

    public string? EgtName { get; set; }

    public string? EgtShtName { get; set; }

    public bool? EgtActive { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public decimal? VdtTankCapacity { get; set; }

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

    public string? DriverSxnName { get; set; }

    public string? DriverSxnShtName { get; set; }

    public int? DriverUntIdfk { get; set; }

    public string? DriverUntName { get; set; }

    public string? DriverUntShtName { get; set; }

    public int? DriverLocIdfk { get; set; }

    public string? DriverLocName { get; set; }

    public string? DriverLocShtName { get; set; }

    public string? DriverEmpTelNo { get; set; }

    public string? DriverEmpMobNo { get; set; }

    public string? DriverPlc { get; set; }

    public string? DriverEmailOff { get; set; }

    public string? DriverEmailPers { get; set; }

    public int? DriverJbtIdfk { get; set; }

    public string? DriverJbtName { get; set; }

    public string? DriverJbtShtName { get; set; }

    public bool? DriverHideMobNo { get; set; }

    public string? DriverMobNox { get; set; }

    public bool? DriverIsStaff { get; set; }

    public bool? DriverIsSeniorStaff { get; set; }

    public bool? DriverIsJuniorStaff { get; set; }

    public bool? DriverIsManagementStaff { get; set; }

    public bool? DriverIsServicePerson { get; set; }

    public int OwnerEmpIdfk { get; set; }

    public bool? DriverIsVoluntaryPerson { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpActive { get; set; }

    public string? MtpRmks { get; set; }

    public string? OwnerPlc { get; set; }

    public string OwnerLname { get; set; } = null!;

    public string OwnerFname { get; set; } = null!;

    public string OwnerHrmsName { get; set; } = null!;

    public string? OwnerMobNo { get; set; }

    public string? OwnerJbtName { get; set; }

    public string? OwnerJbtShtName { get; set; }

    public bool? OwnerIsDirector { get; set; }

    public bool? OwnerIsManager { get; set; }

    public bool? OwnerIsSupervisor { get; set; }

    public bool? OwnerIsStaff { get; set; }

    public bool? OwnerIsSeniorStaff { get; set; }

    public bool? OwnerIsJuniorStaff { get; set; }

    public bool? OwnerIsManagementStaff { get; set; }

    public bool? OwnerIsServicePerson { get; set; }

    public bool? OwnerIsVoluntaryPerson { get; set; }

    public string? OwnerMobNox { get; set; }

    public int? TrtIdpk { get; set; }

    public string? TrtName { get; set; }

    public string? TrtShtName { get; set; }

    public string OwnerEmpName { get; set; } = null!;

    public string OwnerEmpName1 { get; set; } = null!;

    public string OwnerEmpName2 { get; set; } = null!;

    public int? MtaVehicleAssignmentIdfk { get; set; }

    public string MtaArrivalCondition { get; set; } = null!;

    public string? MtaJobSummary { get; set; }

    public bool? MtaDone { get; set; }

    public bool? MtaOpened { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public string? CreatedByLname { get; set; }

    public string? CreatedByOnames { get; set; }

    public string? CreatedByEmpName { get; set; }

    public string? CreatedByEmpName1 { get; set; }

    public string? CreatedByEmpName2 { get; set; }

    public int? CreatedByLocId { get; set; }

    public string? CreatedByLocName { get; set; }

    public int? CreatedBySxnId { get; set; }

    public string? CreatedBySxnName { get; set; }

    public int? CreatedByDptId { get; set; }

    public string? CreatedByDptName { get; set; }

    public int? CreatedByJbtId { get; set; }

    public string? CreatedByJbtName { get; set; }

    public string? CreatedByJbtShtName { get; set; }

    public string? CreatedByMobNox { get; set; }

    public string? CreatedByMobNo { get; set; }

    public string? CreatedByPlc { get; set; }

    public DateTime? MtaCreationDate { get; set; }

    public int? MtaEditedBy { get; set; }

    public string? MtaCreatedBy { get; set; }

    public DateTime? MtaEditedDate { get; set; }

    public int? MtaServiceRequestIdfk { get; set; }

    public int? CreatedByEmpId { get; set; }

    public string? CreatedByDptShtName { get; set; }

    public string? CreatedBySxnShtName { get; set; }
}
