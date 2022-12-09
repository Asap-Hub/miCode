using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxBillApproval
{
    public int FbapIdpk { get; set; }

    public int? FbapCustIdfk { get; set; }

    public string? FbapBillCat { get; set; }

    public string? FbapReportDate { get; set; }

    public bool? FbapApproved { get; set; }

    public int? FbapCreatedBy { get; set; }

    public DateTime? FbapCreationDate { get; set; }

    public DateTime? FbapDeletiondate { get; set; }
}
