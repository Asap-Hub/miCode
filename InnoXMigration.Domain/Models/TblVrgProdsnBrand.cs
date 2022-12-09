using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgProdsnBrand
{
    public int FpnbIdpk { get; set; }

    public int? FpnbProdTypeIdfk { get; set; }

    public int? FpnbProdIdfk { get; set; }

    public int? FpnbBrandIdfk { get; set; }

    public bool? FpnbActive { get; set; }

    public string? FpnbRmks { get; set; }

    public int? FpnbCreatedBy { get; set; }

    public int? FpnbEditedBy { get; set; }

    public DateTime? FpnbCreationDate { get; set; }

    public DateTime? FpnbEditedDate { get; set; }
}
