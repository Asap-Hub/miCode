using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglParty
{
    public int PtsIdpk { get; set; }

    public string? PtsType { get; set; }

    public int? PtsEntityTypeIdfk { get; set; }

    public string? PtsName { get; set; }

    public string? PtsShtName { get; set; }

    public int? PtsGenderIdfk { get; set; }

    public int? PtsNationalityIdfk { get; set; }

    public int? PtsResidenceIdfk { get; set; }

    public int? PtsMaritalStatusIdfk { get; set; }

    public DateTime? PtsDoB { get; set; }

    public DateTime? PtsEstablishmentDate { get; set; }

    public string? PtsHouseNo { get; set; }

    public string? PtsSsno { get; set; }

    public string? PtsLawyers { get; set; }

    public string? PtsMobNo { get; set; }

    public string? PtsEmail { get; set; }

    public string? PtsAddress { get; set; }

    public string? PtsWebsite { get; set; }

    public int? PtsRepresentative { get; set; }

    public bool? PtsActive { get; set; }

    public string? PtsRmks { get; set; }

    public int? PtsCreatedBy { get; set; }

    public int? PtsLastEditedBy { get; set; }

    public DateTime? PtsCreationDate { get; set; }

    public DateTime? PtsLastEditedDate { get; set; }
}
