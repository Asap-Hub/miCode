using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsServProviderTransaction
{
    public int SptIdpk { get; set; }

    public string? SptCustomerNo { get; set; }

    public string? SptCustomer { get; set; }

    public DateTime? SptDate { get; set; }

    public TimeSpan? SptTime { get; set; }

    public DateTime? SptDateTimex { get; set; }

    public string? SptDateTime2 { get; set; }

    public string? SptMonth { get; set; }

    public string? SptMonthNumber { get; set; }

    public string? SptDriverCode { get; set; }

    public string? SptRegNo { get; set; }

    public string? SptCardType { get; set; }

    public string? SptCardNo { get; set; }

    public string? SptCardName { get; set; }

    public int? SptReceiptNo { get; set; }

    public decimal? SptPastMileage { get; set; }

    public decimal? SptCurrentMileage { get; set; }

    public decimal? SptMileagex { get; set; }

    public string? SptOperationType { get; set; }

    public string? SptProductCode { get; set; }

    public string? SptProduct { get; set; }

    public decimal? SptUnitPrice { get; set; }

    public decimal? SptQuantity { get; set; }

    public decimal? SptAmount { get; set; }

    public decimal? SptAmountx { get; set; }

    public decimal? SptBalance { get; set; }

    public string? SptCurrencyNo { get; set; }

    public string? SptCurrency { get; set; }

    public string? SptStationNo { get; set; }

    public string? SptPlace { get; set; }

    public string? SptInvoiceDate { get; set; }

    public string? SptInvoiceNo { get; set; }

    public bool? SptActive { get; set; }

    public string? SptRmks { get; set; }

    public string? SptCreatedBy { get; set; }

    public int? SptEditedBy { get; set; }

    public DateTime? SptCreationDate { get; set; }

    public DateTime? SptEditedDate { get; set; }

    public int VehAssignDeptId { get; set; }

    public string VehAssignDeptName { get; set; } = null!;

    public string VehAssignDeptShtName { get; set; } = null!;

    public int VehAssignSxnId { get; set; }

    public string VehAssignSxnName { get; set; } = null!;

    public string VehAssignSxnShtName { get; set; } = null!;

    public int? SptVehicleAssignmentIdfk { get; set; }

    public int VehAssignIdpk { get; set; }

    public int VehAssignVehicleDetailIdfk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public bool VehAssignAssigned { get; set; }

    public bool VehAssignActive { get; set; }

    public string VehAssignRmks { get; set; } = null!;

    public int VehAssignUntId { get; set; }

    public string VehAssignUntName { get; set; } = null!;

    public string VehAssignUntShtName { get; set; } = null!;

    public int? SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public int? SptServiceProviderIdfk { get; set; }

    public string DriverCodeCode { get; set; } = null!;

    public DateTime DriverCodeEndDate { get; set; }

    public bool DriverCodeActive { get; set; }

    public int DriverCodeEmpId { get; set; }

    public string DriverCodeStaffNo { get; set; } = null!;

    public string DriverCodeLname { get; set; } = null!;

    public string DriverCodeFname { get; set; } = null!;

    public string DriverCodeOnames { get; set; } = null!;

    public string DriverCodeHrmsName { get; set; } = null!;

    public string DriverCodeEmpName { get; set; } = null!;

    public string DriverCodeEmpName1 { get; set; } = null!;

    public string DriverCodeEmpName2 { get; set; } = null!;

    public string DriverCodeEmpName3 { get; set; } = null!;

    public string DriverCodeEmpName4 { get; set; } = null!;

    public string DriverCodeEmpName5 { get; set; } = null!;

    public string DriverCodeEmpName6 { get; set; } = null!;

    public string DriverCodeEmpName7 { get; set; } = null!;

    public string DriverCodeEmpName8 { get; set; } = null!;

    public string DriverCodeEmpName9 { get; set; } = null!;

    public string DriverCodeEmpName10 { get; set; } = null!;

    public string DriverCodeEmpName11 { get; set; } = null!;

    public int DriverCodeDeptId { get; set; }

    public string DriverCodeDeptName { get; set; } = null!;

    public string DriverCodeDeptShtName { get; set; } = null!;

    public int DriverCodeSxnId { get; set; }

    public string DriverCodeSxnName { get; set; } = null!;

    public string DriverCodeSxnShtName { get; set; } = null!;

    public int DriverCodeUnitId { get; set; }

    public string DriverCodeUnitName { get; set; } = null!;

    public string DriverCodeUnitShtName { get; set; } = null!;

    public int DriverCodeLocId { get; set; }

    public string DriverCodeLocName { get; set; } = null!;

    public string DriverCodeLocShtName { get; set; } = null!;

    public int DriverCodeJobId { get; set; }

    public string DriverCodeJobName { get; set; } = null!;

    public string DriverCodeJobShtName { get; set; } = null!;

    public string DriverCodeJbtName { get; set; } = null!;

    public string DriverCodeJbtShtName { get; set; } = null!;

    public DateTime DriverCodeAssignDate { get; set; }

    public string DriverCodeServiceProvider { get; set; } = null!;

    public string DriverCodeServProviderShtName { get; set; } = null!;

    public string DriverCodeServProvMainContact { get; set; } = null!;

    public string DriverCodeSerProvMobNos { get; set; } = null!;

    public string DriverCodeServProvEmail { get; set; } = null!;

    public string DriverCodeServProvTelNos { get; set; } = null!;

    public string DriverCodeServProvPostalAddress { get; set; } = null!;

    public string DriverCodeServProvResAddress { get; set; } = null!;

    public bool DriverCodeServProvActive { get; set; }

    public string DriverCodeServProvRmks { get; set; } = null!;

    public byte? VdtSeatingCapacity { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public decimal VdtTankCapacity { get; set; }

    public decimal SptRefillIntervalHours { get; set; }

    public decimal SptRefillIntervalDays { get; set; }

    public decimal SptRefillIntervalDaysx { get; set; }

    public decimal SptRefillIntervalHoursx { get; set; }

    public int MdlIdpk { get; set; }

    public string MdlName { get; set; } = null!;

    public string MdlShtName { get; set; } = null!;

    public int VmkIdpk { get; set; }

    public string VmkName { get; set; } = null!;

    public string VmkShtName { get; set; } = null!;

    public int VhcIdpk { get; set; }

    public string VhcName { get; set; } = null!;

    public string VhcShtName { get; set; } = null!;

    public int VdtIdpk { get; set; }

    public bool SptVerified { get; set; }

    public bool? DriverIsStaff { get; set; }
}
