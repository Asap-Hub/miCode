using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTravelDetail
{
    public int TrdIdpk { get; set; }

    public string? TrdStaffNo { get; set; }

    public string? TrdStaffName { get; set; }

    public string? TrdDept { get; set; }

    public string? TrdSection { get; set; }

    public string? TrdUnit { get; set; }

    public string? TrdPurpose { get; set; }

    public string? TrdOrigin { get; set; }

    public string? TrdDestination { get; set; }

    public string? TrdRoute { get; set; }

    public DateTime? TrdPlannedDepartDate { get; set; }

    public DateTime? TrdActualDepartDate { get; set; }

    public DateTime? TrdReturnDate { get; set; }

    public DateTime? TrdChequeDate { get; set; }

    public DateTime? TrdTicketReceiptDate { get; set; }

    public string? TrdTravelAgency { get; set; }

    public string? TrdAirline { get; set; }

    public decimal? TrdAmount { get; set; }

    public int? TrdCurrencyIdfk { get; set; }

    public string? TrdInvoiceNo { get; set; }

    public string? TrdStatus { get; set; }

    public string? TrdPayment { get; set; }

    public string? TrdChequeNo { get; set; }

    public bool? TrdVisa { get; set; }

    public string? TrdSubmission { get; set; }

    public bool? TrdCancelled { get; set; }

    public bool? TrdVisaRefused { get; set; }

    public bool? TrdIsStaff { get; set; }

    public string? TrdActive { get; set; }

    public string? TrdRmks { get; set; }

    public string? TrdCreatedBy { get; set; }

    public int? TrdEditedBy { get; set; }

    public DateTime? TrdCreationDate { get; set; }

    public DateTime? TrdEditedDate { get; set; }
}
