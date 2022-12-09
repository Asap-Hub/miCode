using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCust
{
    public int FcustIdpk { get; set; }

    public DateTime? FcustSetupDate { get; set; }

    public DateTime? FcustEndDate { get; set; }

    public string? FcustName { get; set; }

    public string? FcustShtName { get; set; }

    public string? FcustRefNo { get; set; }

    public string? FcustAddress { get; set; }

    public string? FcustSalutation { get; set; }

    public string? FcustContact { get; set; }

    public string? FcustEmail { get; set; }

    public string? FcustMobNo { get; set; }

    public string? FcustTelNo { get; set; }

    public string? FcustSmsName { get; set; }

    public string? FcustEmailName { get; set; }

    public int? FcustCurntCurrIdfk { get; set; }

    public int? FcustCurntCustTypIdfk { get; set; }

    public double? FcustCurntRlr { get; set; }

    public double? FcustCurntTsr { get; set; }

    public bool? FcustActive { get; set; }

    public string? FcustRmks { get; set; }

    public int? FcustCreatedBy { get; set; }

    public int? FcustEditedBy { get; set; }

    public DateTime? FcustCreationDate { get; set; }

    public DateTime? FcustEditedDate { get; set; }
}
