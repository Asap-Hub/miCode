using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsEmpDocumentDetail
{
    public int EddIdpk { get; set; }

    public int? EddEmpIdfk { get; set; }

    public string? EddTitle { get; set; }

    public string? EddDescription { get; set; }

    public DateTime? EddDocDate { get; set; }

    public int? EddDocTypeIdfk { get; set; }

    public bool? EddClassified { get; set; }

    public bool? EddActive { get; set; }

    public string? EddRmks { get; set; }

    public int? DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public bool? DtpDriversLicense { get; set; }

    public bool? DtpActive { get; set; }

    public bool? EddHasAttachment { get; set; }

    public int? EddCreaeddBy { get; set; }

    public DateTime? EddCreationDate { get; set; }

    public DateTime? EddEditeddate { get; set; }

    public int? EddEditedBy { get; set; }

    public bool EddVerified { get; set; }
}
