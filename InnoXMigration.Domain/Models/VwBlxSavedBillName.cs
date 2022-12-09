using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxSavedBillName
{
    public int FbnmIdpk { get; set; }

    public string? FbnmName { get; set; }

    public string? FbnmShtName { get; set; }

    public DateTime? FbnmStartDate { get; set; }

    public DateTime? FbnmEndDate { get; set; }

    public int? FanrIdpk { get; set; }

    public string? FrttName { get; set; }

    public string? FrttShtName { get; set; }
}
