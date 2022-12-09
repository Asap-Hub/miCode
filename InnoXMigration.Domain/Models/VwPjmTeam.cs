using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmTeam
{
    public int PtmIdpk { get; set; }

    public string? PtmName { get; set; }

    public string? PtmShtName { get; set; }

    public bool? PtmActive { get; set; }

    public int PjrIdpk { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public DateTime? PjrStartDate { get; set; }

    public DateTime? PjrProposedEndDate { get; set; }

    public DateTime? PjrActualEndDate { get; set; }

    public int? PtmProjectIdfk { get; set; }

    public DateTime? PtmStartDate { get; set; }

    public DateTime? PtmEndDate { get; set; }

    public string? PtmRmks { get; set; }

    public int? PtmCreatedBy { get; set; }

    public int? PtmEditedBy { get; set; }

    public DateTime? PtmEditedDate { get; set; }

    public DateTime? PtmCreationDate { get; set; }
}
