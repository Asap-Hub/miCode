using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxPrepareBill
{
    public int FprbIdpk { get; set; }

    public DateTime? FprbDate { get; set; }

    public int? FprbEmpIdfk { get; set; }

    public string? FprbBillName { get; set; }

    public string? FprbBillTitle { get; set; }

    public string? FprbMobNo { get; set; }

    public string? FprbRmks { get; set; }

    public int? FprbCreatedBy { get; set; }

    public int? FprbEditedBy { get; set; }

    public DateTime? FprbCreationDate { get; set; }

    public DateTime? FprbEditedDate { get; set; }
}
