using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsRateType
{
    public int RttIdpk { get; set; }

    public string? RttName { get; set; }

    public string? RttShtName { get; set; }

    public bool? RttActive { get; set; }

    public string? RttRmks { get; set; }

    public int? RttCreatedBy { get; set; }

    public int? RttEditedBy { get; set; }

    public DateTime? RttCreationDate { get; set; }

    public DateTime? RttEditedDate { get; set; }
}
