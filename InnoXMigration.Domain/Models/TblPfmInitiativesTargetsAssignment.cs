using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmInitiativesTargetsAssignment
{
    public int ItaIdpk { get; set; }

    public string? ItaInitiativeIdfk { get; set; }

    public string? ItaTargetIdfk { get; set; }

    public bool? ItaActive { get; set; }

    public string? ItaRmks { get; set; }

    public string? ItaCreatedBy { get; set; }

    public int? ItaEditedBy { get; set; }

    public DateTime? ItaCreationDate { get; set; }

    public DateTime? ItaEditedDate { get; set; }
}
