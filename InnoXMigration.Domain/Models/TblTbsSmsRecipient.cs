using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsSmsRecipient
{
    public int SrpIdpk { get; set; }

    public int? SrpCustomerIdfk { get; set; }

    public string? SrpName { get; set; }

    public string? SrpSmsName { get; set; }

    public string? SrpMobNo { get; set; }

    public string? SrpEmail { get; set; }

    public bool? SrpActive { get; set; }

    public string? SrpRmks { get; set; }

    public string? SrpCreatedBy { get; set; }

    public int? SrpEditedBy { get; set; }

    public DateTime? SrpCreationDate { get; set; }

    public DateTime? SrpEditedDate { get; set; }
}
