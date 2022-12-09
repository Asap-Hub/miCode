using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsAttendance
{
    public int AtdIdpk { get; set; }

    public int? AtdMinuteIdfk { get; set; }

    public int? AtdEmpIdfk { get; set; }

    public string? AtdCategory { get; set; }

    public byte? AtdCategoryNo { get; set; }

    public bool? AtdOwner { get; set; }

    public bool? AtdReader { get; set; }

    public bool? AtdPrint { get; set; }

    public bool? AtdActive { get; set; }

    public int? AtdCreatedBy { get; set; }

    public int? AtdEditedBy { get; set; }

    public DateTime? AtdCreationDate { get; set; }

    public DateTime? AtdEditedDate { get; set; }
}
