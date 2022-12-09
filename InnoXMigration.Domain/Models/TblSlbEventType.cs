using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbEventType
{
    public int EvtIdpk { get; set; }

    public string? EvtName { get; set; }

    public string? EvtShtName { get; set; }

    public bool? EvtMidnightCondition { get; set; }

    public bool? EvtShiftChange { get; set; }

    public bool? EvtShiftTakeOver { get; set; }

    public bool? EvtShowInLogBook { get; set; }

    public bool? EvtActive { get; set; }

    public string? EvtRmks { get; set; }

    public int? EvtCreatedBy { get; set; }

    public int? EvtEditedBy { get; set; }

    public DateTime? EvtCreationDate { get; set; }

    public DateTime? EvtEditedDate { get; set; }
}
