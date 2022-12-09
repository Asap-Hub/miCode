using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamFeeder
{
    public int FdrIdpk { get; set; }

    public string FdrName { get; set; } = null!;

    public string FdrShtName { get; set; } = null!;

    public bool FdrActive { get; set; }

    public int FstnIdpk { get; set; }

    public string FstnName { get; set; } = null!;

    public string FstnShtName { get; set; } = null!;

    public string FdrRmks { get; set; } = null!;

    public bool FstnActive { get; set; }

    public int FcustIdpk { get; set; }

    public string FcustName { get; set; } = null!;

    public string FcustShtName { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public string FcustAddress { get; set; } = null!;

    public string FcustSalutation { get; set; } = null!;

    public string FcustContact { get; set; } = null!;

    public string FcustEmail { get; set; } = null!;

    public string FcustMobNo { get; set; } = null!;

    public string FcustTelNo { get; set; } = null!;

    public string CurntCtpName { get; set; } = null!;

    public string CurntCtpShtName { get; set; } = null!;

    public string CurntCurrName { get; set; } = null!;

    public string CurntCurrShtName { get; set; } = null!;

    public string CurntCurrSymbol { get; set; } = null!;

    public bool CurntCurrForeign { get; set; }

    public DateTime? FcustSetupDate { get; set; }

    public DateTime? FcustEndDate { get; set; }

    public string FcustRefNo { get; set; } = null!;

    public string FcustSmsName { get; set; } = null!;

    public string FcustEmailName { get; set; } = null!;

    public bool? FdrStationService { get; set; }

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string FlocShtName { get; set; } = null!;

    public string FareName { get; set; } = null!;

    public string FareShtName { get; set; } = null!;

    public bool FareActive { get; set; }

    public DateTime FdrStartDate { get; set; }

    public DateTime FdrEndDate { get; set; }

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }
}
