using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwLglCase
{
    public int CseIdpk { get; set; }

    public string CseSubject { get; set; } = null!;

    public string CseShtName { get; set; } = null!;

    public string CseDescription { get; set; } = null!;

    public string CseSuitNo { get; set; } = null!;

    public string CseReferenceNo { get; set; } = null!;

    public DateTime CseReceivedDate { get; set; }

    public DateTime CseReqForInfoDate { get; set; }

    public DateTime CseReqForInfoReceivedDate { get; set; }

    public DateTime CseEoAdueDate { get; set; }

    public DateTime CseEoAfiledDate { get; set; }

    public DateTime CseSoDdueDate { get; set; }

    public DateTime CseSoDfiledDate { get; set; }

    public string CseClients { get; set; } = null!;

    public int CseCategoryIdfk { get; set; }

    public int CsePriorityIdfk { get; set; }

    public int CseStatusIdfk { get; set; }

    public bool CseActive { get; set; }

    public string CseRmks { get; set; } = null!;

    public byte CsePercentComplete { get; set; }

    public string CseProgressActivity { get; set; } = null!;

    public bool CseLocked { get; set; }

    public bool CseAcknowledged { get; set; }

    public string CseParties { get; set; } = null!;

    public string CseCounsel { get; set; } = null!;

    public string CseCourt { get; set; } = null!;

    public int PjrIdpk { get; set; }

    public string PjrPhase { get; set; } = null!;

    public string PjrName { get; set; } = null!;

    public string PjrShtName { get; set; } = null!;

    public int PnmIdpk { get; set; }

    public string PnmName { get; set; } = null!;

    public string PnmShtName { get; set; } = null!;

    public DateTime? PnmStartDate { get; set; }

    public DateTime? PjrActualEndDate { get; set; }

    public DateTime? PjrStartDate { get; set; }

    public int CseProjectIdfk { get; set; }

    public bool CseEoaFiled { get; set; }

    public bool CseSodFiled { get; set; }

    public int CseClassIdfk { get; set; }

    public int CseInitialClaimCurrencyIdfk { get; set; }

    public int CseInitialClaimCurrencyId { get; set; }

    public string CseInitialClaimCurrencyName { get; set; } = null!;

    public string CseInitialClaimCurrencyShtName { get; set; } = null!;

    public string CseInitialClaimCurrencySymbol { get; set; } = null!;

    public bool CseInitialClaimCurrencyForeign { get; set; }

    public bool CseInitialClaimCurrencyActive { get; set; }

    public int CseAgreedClaimCurrencyIdfk { get; set; }

    public int CseAgreedClaimCurrencyId { get; set; }

    public string CseAgreedClaimCurrencyName { get; set; } = null!;

    public string CseAgreedClaimCurrencyShtName { get; set; } = null!;

    public string CseAgreedClaimCurrencySymbol { get; set; } = null!;

    public bool CseAgreedClaimCurrencyForeign { get; set; }

    public bool CseAgreedClaimCurrencyActive { get; set; }

    public decimal CseInitialClaim { get; set; }

    public decimal CseAgreedClaim { get; set; }

    public byte CseEoaDaysFromWos { get; set; }

    public byte CseDaysFromSodDueDate { get; set; }

    public int CctIdpk { get; set; }

    public string CctName { get; set; } = null!;

    public string CctShtName { get; set; } = null!;

    public bool CctActive { get; set; }

    public byte CctOrder { get; set; }

    public int CclIdpk { get; set; }

    public string CclName { get; set; } = null!;

    public string CclShtName { get; set; } = null!;

    public byte CclOrder { get; set; }

    public bool CclActive { get; set; }

    public int CptIdpk { get; set; }

    public string CptName { get; set; } = null!;

    public string CptShtName { get; set; } = null!;

    public byte CptOrder { get; set; }

    public bool CptActive { get; set; }

    public int CstIdpk { get; set; }

    public string CstName { get; set; } = null!;

    public string CstShtName { get; set; } = null!;

    public byte CstOrder { get; set; }

    public bool CstActive { get; set; }

    public string CseSettingsRmks { get; set; } = null!;
}
