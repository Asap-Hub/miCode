using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgProduct
{
    public int FprdIdpk { get; set; }

    public string? FprdName { get; set; }

    public string? FprdShtName { get; set; }

    public bool? FprdActive { get; set; }

    public string? FprdRmks { get; set; }

    public int? FprdCreatedBy { get; set; }

    public int? FprdEditedBy { get; set; }

    public DateTime? FprdCreationDate { get; set; }

    public DateTime? FprdEditedDate { get; set; }
}
