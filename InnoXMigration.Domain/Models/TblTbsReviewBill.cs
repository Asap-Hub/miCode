using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsReviewBill
{
    public int RvbIdpk { get; set; }

    public DateTime? RvbDate { get; set; }

    public int? RvbEmpIdfk { get; set; }

    public string? RvbBillName { get; set; }

    public string? RvbBillTitle { get; set; }

    public string? RvbMobNo { get; set; }

    public string? RvbRmks { get; set; }

    public int? RvbCreatedBy { get; set; }

    public int? RvbEditedBy { get; set; }

    public DateTime? RvbCreationDate { get; set; }

    public DateTime? RvbEditedDate { get; set; }
}
