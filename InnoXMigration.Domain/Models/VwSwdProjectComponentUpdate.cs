using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectComponentUpdate
{
    public int PcuIdpk { get; set; }

    public int? PcuProjectIdfk { get; set; }

    public int? PcuStreamDetailIdfk { get; set; }

    public int? PcuComponentIdfk { get; set; }

    public int? PcuTrendIdfk { get; set; }

    public bool? PcuActive { get; set; }

    public string? PcuRmks { get; set; }

    public int? PsdIdpk { get; set; }

    public DateTime? PsdStartDate { get; set; }

    public DateTime? PsdEndDate { get; set; }

    public string? PsdName { get; set; }

    public int? TinIdpk { get; set; }

    public string? TinName { get; set; }

    public string? TinShtName { get; set; }

    public string? TinColour { get; set; }

    public byte? TinOrder { get; set; }

    public int? PcmIdpk { get; set; }

    public string? PcmName { get; set; }

    public string? PcmShtName { get; set; }

    public byte? PcmOrder { get; set; }

    public int? PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public int? PcuStreamIdfk { get; set; }

    public int? PsnIdpk { get; set; }

    public string? PsnName { get; set; }

    public string? PsnShtName { get; set; }

    public bool? PsnActive { get; set; }
}
