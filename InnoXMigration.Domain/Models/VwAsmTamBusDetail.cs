using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamBusDetail
{
    public int BdtIdpk { get; set; }

    public int BdtStationIdfk { get; set; }

    public string BdtName { get; set; } = null!;

    public string BdtShtName { get; set; } = null!;

    public bool BdtActive { get; set; }

    public string BdtRmks { get; set; } = null!;

    public int StnIdpk { get; set; }

    public string StnContact { get; set; } = null!;

    public string StnTelNo { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string FareName { get; set; } = null!;

    public string FareShtName { get; set; } = null!;

    public int FareIdpk { get; set; }

    public bool StnActive { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public string StnCode { get; set; } = null!;

    public decimal BdtMinimumVoltage { get; set; }

    public decimal BdtMaximumVoltage { get; set; }
}
