using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsRegulatoryLevyOrganisation
{
    public int RloIdpk { get; set; }

    public DateTime? RloDate { get; set; }

    public string? RloName { get; set; }

    public string? RloShtName { get; set; }

    public string? RloAddress { get; set; }

    public string? RloCeoSalutation { get; set; }

    public string? RloCeoShtSalutation { get; set; }

    public string? RloTelNo { get; set; }

    public string? RloEmail { get; set; }

    public string? RloFax { get; set; }

    public string? RloRmks { get; set; }

    public string? RloCreatedBy { get; set; }

    public string? RloEditedBy { get; set; }

    public DateTime? RloCreationDate { get; set; }

    public DateTime? RloEditedDate { get; set; }
}
