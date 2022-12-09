using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPurchaseMode
{
    public int PcmIdpk { get; set; }

    public string? PcmName { get; set; }

    public string? PcmShtName { get; set; }

    public bool? PcmFuelDump { get; set; }

    public bool? PcmPettyCash { get; set; }

    public bool? PcmCard { get; set; }

    public bool? PcmActive { get; set; }

    public string? PcmRmks { get; set; }

    public string? PcmCreatedBy { get; set; }

    public int? PcmEditedBy { get; set; }

    public DateTime? PcmCreationDate { get; set; }

    public DateTime? PcmEditedDate { get; set; }
}
