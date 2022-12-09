using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsProjectPortfolio
{
    public int PpfIdpk { get; set; }

    public string? PpfName { get; set; }

    public string? PpfShtName { get; set; }

    public string? PpfDescription { get; set; }

    public int? PpfCorpObjectiveIdfk { get; set; }

    public bool? PpfActive { get; set; }

    public string? PpfRmks { get; set; }

    public int? PpfCreatedBy { get; set; }

    public int? PpfEditedBy { get; set; }

    public DateTime? PpfCreationDate { get; set; }

    public DateTime? PpfEditedDate { get; set; }
}
