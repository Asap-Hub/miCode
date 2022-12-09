using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsServProvTransaction
{
    public int SptIdpk { get; set; }

    public int? SptServiceProviderIdfk { get; set; }

    public string? SptCustomerNo { get; set; }

    public string? SptCustomer { get; set; }

    public DateTime? SptDate { get; set; }

    public TimeSpan? SptTime { get; set; }

    public DateTime? SptDateTimex { get; set; }

    public string? SptDateTime2 { get; set; }

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

    public decimal? SptRefillIntervalHours { get; set; }

    public decimal? SptRefillIntervalHoursx { get; set; }

    public decimal? SptRefillIntervalDays { get; set; }

    public decimal? SptRefillIntervalDaysx { get; set; }

    public string? SptCurrencyNo { get; set; }

    public string? SptCurrency { get; set; }

    public string? SptStationNo { get; set; }

    public string? SptPlace { get; set; }

    public string? SptInvoiceDate { get; set; }

    public string? SptInvoiceNo { get; set; }

    public int? SptVehicleAssignmentIdfk { get; set; }

    public int? SptDriversCodeAssignmentIdfk { get; set; }

    public bool? SptVerified { get; set; }

    public bool? SptActive { get; set; }

    public string? SptRmks { get; set; }

    public string? SptCreatedBy { get; set; }

    public int? SptEditedBy { get; set; }

    public DateTime? SptCreationDate { get; set; }

    public DateTime? SptEditedDate { get; set; }
}
