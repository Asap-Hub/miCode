using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHmsHospDetail
{
    public int HdtIdpk { get; set; }

    public string? HdtName { get; set; }

    public string? HdtShtName { get; set; }

    public string? HdtMobNos { get; set; }

    public string? HdtTelNos { get; set; }

    public string? HdtEmail { get; set; }

    public string? HdtWhatsappNo { get; set; }

    public string? HdtFacebook { get; set; }

    public string? HdtTwitterHandle { get; set; }

    public string? HdtLinkedIn { get; set; }

    public string? HdtPostalAddress { get; set; }

    public string? HdtResidentialAddress { get; set; }

    public int? HdtTownIdfk { get; set; }

    public string? HdtLatitude { get; set; }

    public string? HdtLongitude { get; set; }

    public bool? HdtActive { get; set; }

    public string? HdtRmks { get; set; }

    public bool? HdtDeleted { get; set; }

    public int? HdtCreatedBy { get; set; }

    public int? HdtEditedBy { get; set; }

    public DateTime? HdtCreationDate { get; set; }

    public DateTime? HdtEditedDate { get; set; }

    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? RgnCapital { get; set; }

    public string? CtyCapital { get; set; }

    public int HctIdpk { get; set; }

    public string? HctName { get; set; }

    public string? HctShtName { get; set; }

    public bool? HctActive { get; set; }

    public string? HctRmks { get; set; }

    public int HscIdpk { get; set; }

    public string? HscName { get; set; }

    public string? HscShtName { get; set; }

    public bool? HscActive { get; set; }

    public string? HscRmks { get; set; }

    public int? HdtCategoryIdfk { get; set; }

    public int? HdtClassificationIdfk { get; set; }

    public string? HdtMainContacts { get; set; }

    public string? HdtWebsite { get; set; }

    public bool? HdtApproved { get; set; }

    public bool HdtReferralHospital { get; set; }
}
