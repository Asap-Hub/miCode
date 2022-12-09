using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsPrepareBill
{
    public int PrbIdpk { get; set; }

    public DateTime? PrbDate { get; set; }

    public int? PrbEmpIdfk { get; set; }

    public string? PrbBillName { get; set; }

    public string? PrbBillTitle { get; set; }

    public string? PrbMobNo { get; set; }

    public string? PrbRmks { get; set; }

    public int? PrbCreatedBy { get; set; }

    public int? PrbEditedBy { get; set; }

    public DateTime? PrbCreationDate { get; set; }

    public DateTime? PrbEditedDate { get; set; }
}
