using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamCapacitorBank
{
    public int CbkIdpk { get; set; }

    public string CbkNomenclature { get; set; } = null!;

    public string CbkShtName { get; set; } = null!;

    public bool CbkActive { get; set; }

    public int FstnIdpk { get; set; }

    public string FstnName { get; set; } = null!;

    public string FstnShtName { get; set; } = null!;

    public string CbkRmks { get; set; } = null!;

    public bool FstnActive { get; set; }

    public bool? CbkStationService { get; set; }

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string FlocShtName { get; set; } = null!;

    public string FareName { get; set; } = null!;

    public string FareShtName { get; set; } = null!;

    public bool FareActive { get; set; }

    public DateTime CbkStartDate { get; set; }

    public DateTime CbkEndDate { get; set; }
}
