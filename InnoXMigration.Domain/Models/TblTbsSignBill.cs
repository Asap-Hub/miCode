using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsSignBill
{
    public int SnbIdpk { get; set; }

    public DateTime? SnbDate { get; set; }

    public int? SnbEmpIdfk { get; set; }

    public string? SnbBillName { get; set; }

    public string? SnbBillTitle { get; set; }

    public string? SnbMobNo { get; set; }

    public string? SnbRmks { get; set; }

    public int? SnbCreatedBy { get; set; }

    public int? SnbEditedBy { get; set; }

    public DateTime? SnbCreationDate { get; set; }

    public DateTime? SnbEditedDate { get; set; }
}
