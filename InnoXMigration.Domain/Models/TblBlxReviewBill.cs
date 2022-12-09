using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxReviewBill
{
    public int FrvbIdpk { get; set; }

    public DateTime? FrvbDate { get; set; }

    public int? FrvbEmpIdfk { get; set; }

    public string? FrvbBillName { get; set; }

    public string? FrvbBillTitle { get; set; }

    public string? FrvbMobNo { get; set; }

    public string? FrvbRmks { get; set; }

    public int? FrvbCreatedBy { get; set; }

    public int? FrvbEditedBy { get; set; }

    public DateTime? FrvbCreationDate { get; set; }

    public DateTime? FrvbEditedDate { get; set; }
}
