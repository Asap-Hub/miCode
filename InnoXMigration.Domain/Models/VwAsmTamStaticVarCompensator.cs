using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamStaticVarCompensator
{
    public int SvcIdpk { get; set; }

    public string SvcNomenclature { get; set; } = null!;

    public string SvcShtName { get; set; } = null!;

    public bool SvcActive { get; set; }

    public int FstnIdpk { get; set; }

    public string FstnName { get; set; } = null!;

    public string FstnShtName { get; set; } = null!;

    public string SvcRmks { get; set; } = null!;

    public bool FstnActive { get; set; }

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string FlocShtName { get; set; } = null!;

    public string FareName { get; set; } = null!;

    public string FareShtName { get; set; } = null!;

    public bool FareActive { get; set; }

    public DateTime SvcStartDate { get; set; }

    public DateTime SvcEndDate { get; set; }
}
