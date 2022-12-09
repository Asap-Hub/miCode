using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamCapacitorBank
{
    public int CbkIdpk { get; set; }

    public DateTime? CbkStartDate { get; set; }

    public DateTime? CbkEndDate { get; set; }

    public int? CbkStationIdfk { get; set; }

    public string? CbkNomenclature { get; set; }

    public string? CbkShtName { get; set; }

    public bool? CbkStationService { get; set; }

    public bool? CbkActive { get; set; }

    public string? CbkRmks { get; set; }

    public int? CbkCreatedBy { get; set; }

    public int? CbkEditedBy { get; set; }

    public DateTime? CbkCreationDate { get; set; }

    public DateTime? CbkEditedDate { get; set; }
}
