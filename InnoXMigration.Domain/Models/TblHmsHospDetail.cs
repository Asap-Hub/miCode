using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHmsHospDetail
{
    public int HdtIdpk { get; set; }

    public string? HdtName { get; set; }

    public string? HdtShtName { get; set; }

    public int? HdtCategoryIdfk { get; set; }

    public int? HdtClassificationIdfk { get; set; }

    public int? HdtTownIdfk { get; set; }

    public string? HdtMainContacts { get; set; }

    public string? HdtMobNos { get; set; }

    public string? HdtTelNos { get; set; }

    public string? HdtEmail { get; set; }

    public string? HdtWhatsappNo { get; set; }

    public string? HdtFacebook { get; set; }

    public string? HdtTwitterHandle { get; set; }

    public string? HdtLinkedIn { get; set; }

    public string? HdtPostalAddress { get; set; }

    public string? HdtResidentialAddress { get; set; }

    public string? HdtWebsite { get; set; }

    public string? HdtLatitude { get; set; }

    public string? HdtLongitude { get; set; }

    public bool? HdtApproved { get; set; }

    public bool? HdtReferralHospital { get; set; }

    public bool? HdtActive { get; set; }

    public string? HdtRmks { get; set; }

    public bool? HdtDeleted { get; set; }

    public int? HdtCreatedBy { get; set; }

    public int? HdtEditedBy { get; set; }

    public DateTime? HdtCreationDate { get; set; }

    public DateTime? HdtEditedDate { get; set; }
}
