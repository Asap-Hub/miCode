using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectComponentUpdate
{
    public int PcuIdpk { get; set; }

    public int? PcuProjectIdfk { get; set; }

    public int? PcuStreamIdfk { get; set; }

    public int? PcuStreamDetailIdfk { get; set; }

    public int? PcuComponentIdfk { get; set; }

    public int? PcuTrendIdfk { get; set; }

    public bool? PcuActive { get; set; }

    public string? PcuRmks { get; set; }

    public string? PcuCreatedBy { get; set; }

    public int? PcuEditedBy { get; set; }

    public DateTime? PcuCreationDate { get; set; }

    public DateTime? PcuEditedDate { get; set; }
}
