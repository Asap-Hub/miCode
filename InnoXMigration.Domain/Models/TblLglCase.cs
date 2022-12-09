using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCase
{
    public int CseIdpk { get; set; }

    public string? CseSubject { get; set; }

    public string? CseShtName { get; set; }

    public string? CseDescription { get; set; }

    public DateTime? CseReceivedDate { get; set; }

    public DateTime? CseReqForInfoDate { get; set; }

    public DateTime? CseReqForInfoReceivedDate { get; set; }

    public DateTime? CseEoAdueDate { get; set; }

    public DateTime? CseEoAfiledDate { get; set; }

    public DateTime? CseSoDdueDate { get; set; }

    public DateTime? CseSoDfiledDate { get; set; }

    public string? CseSuitNo { get; set; }

    public string? CseReferenceNo { get; set; }

    public string? CseClients { get; set; }

    public string? CseParties { get; set; }

    public string? CseCounsel { get; set; }

    public string? CseCourt { get; set; }

    public int? CseCategoryIdfk { get; set; }

    public int? CsePriorityIdfk { get; set; }

    public int? CseStatusIdfk { get; set; }

    public int? CseProjectIdfk { get; set; }

    public int? CseClassIdfk { get; set; }

    public byte? CsePercentComplete { get; set; }

    public string? CseProgressActivity { get; set; }

    public string? CseLastDoneBy { get; set; }

    public byte? CseEoaDaysFromWos { get; set; }

    public byte? CseDaysFromSodDueDate { get; set; }

    public bool? CseLocked { get; set; }

    public bool? CseEoaFiled { get; set; }

    public bool? CseSodFiled { get; set; }

    public bool? CseAcknowledged { get; set; }

    public decimal? CseInitialClaim { get; set; }

    public decimal? CseAgreedClaim { get; set; }

    public int? CseInitialClaimCurrencyIdfk { get; set; }

    public int? CseAgreedClaimCurrencyIdfk { get; set; }

    public bool? CseActive { get; set; }

    public string? CseRmks { get; set; }

    public string? CseSettingsRmks { get; set; }

    public string? CseLastUpdatedBy { get; set; }

    public DateTime? CseLastUpdatedOn { get; set; }

    public string? CseCreatedBy { get; set; }

    public int? CseEditedBy { get; set; }

    public DateTime? CseCreationDate { get; set; }

    public DateTime? CseEditedDate { get; set; }
}
