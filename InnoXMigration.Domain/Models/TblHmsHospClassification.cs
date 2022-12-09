using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHmsHospClassification
{
    public int HscIdpk { get; set; }

    public string? HscName { get; set; }

    public string? HscShtName { get; set; }

    public bool? HscActive { get; set; }

    public string? HscRmks { get; set; }

    public string? HscCreatedBy { get; set; }

    public int? HscEditedBy { get; set; }

    public DateTime? HscCreationDate { get; set; }

    public DateTime? HscEditedDate { get; set; }
}
