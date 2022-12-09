using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbEventTypesx
{
    public int FevtIdpk { get; set; }

    public string? FevtName { get; set; }

    public string? FevtShtName { get; set; }

    public bool? FevtMidnightCondition { get; set; }

    public bool? FevtShiftChange { get; set; }

    public bool? FevtShiftTakeOver { get; set; }

    public bool? FevtShowInLogBook { get; set; }

    public bool? FevtActive { get; set; }

    public string? FevtRmks { get; set; }

    public int? FevtCreatedBy { get; set; }

    public int? FevtEditedBy { get; set; }

    public DateTime? FevtCreationDate { get; set; }

    public DateTime? FevtEditedDate { get; set; }
}
