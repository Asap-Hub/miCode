using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsBillApproval
{
    public int BapIdpk { get; set; }

    public int? BapCustIdfk { get; set; }

    public string? BapBillCat { get; set; }

    public string? BapReportDate { get; set; }

    public bool? BapApproved { get; set; }

    public int? BapCreatedBy { get; set; }

    public DateTime? BapCreationDate { get; set; }

    public DateTime? BapDeletiondate { get; set; }
}
