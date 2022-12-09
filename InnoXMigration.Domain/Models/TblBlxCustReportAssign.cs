using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustReportAssign
{
    public int FcraIdpk { get; set; }

    public DateTime? FcraDate { get; set; }

    public int? FcraCustIdfk { get; set; }

    public int? FcraCustTypeIdfk { get; set; }

    public string? FcraReport { get; set; }

    public string? FcraRmks { get; set; }

    public int? FcraCreatedBy { get; set; }

    public DateTime? FcraCreationDate { get; set; }
}
