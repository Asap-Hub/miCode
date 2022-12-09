using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwLglParty
{
    public int PtsIdpk { get; set; }

    public string? PtsType { get; set; }

    public short? LetIdpk { get; set; }

    public string? LetName { get; set; }

    public string? LetShtName { get; set; }

    public string? PtsName { get; set; }

    public string? PtsShtName { get; set; }

    public int? PtsMaritalStatusIdfk { get; set; }

    public int? MtsIdpk { get; set; }

    public string? MtsName { get; set; }

    public string? MtsShtName { get; set; }

    public DateTime? PtsDoB { get; set; }

    public DateTime? PtsEstablishmentDate { get; set; }

    public string? PtsHouseNo { get; set; }

    public string? PtsSsno { get; set; }

    public string? PtsMobNo { get; set; }

    public string? PtsEmail { get; set; }

    public string? PtsAddress { get; set; }

    public string? PtsWebsite { get; set; }

    public bool? PtsActive { get; set; }

    public string? PtsRmks { get; set; }

    public short? GndIdpk { get; set; }

    public string? GndName { get; set; }

    public string? GndshtName { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public int? PtsCreatedBy { get; set; }

    public int? PtsLastEditedBy { get; set; }

    public DateTime? PtsCreationDate { get; set; }

    public DateTime? PtsLastEditedDate { get; set; }

    public string PtsLawyers { get; set; } = null!;
}
