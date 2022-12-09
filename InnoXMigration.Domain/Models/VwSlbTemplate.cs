using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbTemplate
{
    public int TmpIdpk { get; set; }

    public string? TmpText { get; set; }

    public int EvtIdpk { get; set; }

    public string? EvtName { get; set; }

    public string? EvtShtName { get; set; }

    public bool? EvtActive { get; set; }

    public string? EvtRmks { get; set; }

    public string? TmpRmks { get; set; }

    public bool? TmpActive { get; set; }

    public int? TmpEventTypeIdfk { get; set; }

    public int StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnContact { get; set; }

    public string? StnPlc { get; set; }

    public bool? StnActive { get; set; }

    public string? StnRmks { get; set; }

    public int? TmpStationIdfk { get; set; }

    public DateTime? TmpCreationDate { get; set; }
}
