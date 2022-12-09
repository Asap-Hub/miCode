using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxRateType
{
    public int FrttIdpk { get; set; }

    public string? FrttName { get; set; }

    public string? FrttShtName { get; set; }

    public bool? FrttActive { get; set; }

    public string? FrttRmks { get; set; }

    public int? FrttCreatedBy { get; set; }

    public int? FrttEditedBy { get; set; }

    public DateTime? FrttCreationDate { get; set; }

    public DateTime? FrttEditedDate { get; set; }
}
