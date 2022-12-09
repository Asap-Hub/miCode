using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxCustReportAssign
{
    public int FcraIdpk { get; set; }

    public DateTime? FcraDate { get; set; }

    public int? FcraCustIdfk { get; set; }

    public string? FcraReport { get; set; }

    public int? FcraCustTypeIdfk { get; set; }

    public int FcustIdpk { get; set; }

    public string? FcustName { get; set; }

    public string? FcustShtName { get; set; }

    public string? FcraRmks { get; set; }
}
