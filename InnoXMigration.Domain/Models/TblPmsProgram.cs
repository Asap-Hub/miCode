using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsProgram
{
    public int PgmIdpk { get; set; }

    public string? PgmName { get; set; }

    public string? PgmShtName { get; set; }

    public string? PgmDescription { get; set; }

    public int? PgmPortfolioIdfk { get; set; }

    public bool? PgmActive { get; set; }

    public string? PgmRmks { get; set; }

    public int? PgmCreatedBy { get; set; }

    public int? PgmEditedBy { get; set; }

    public DateTime? PgmCreationDate { get; set; }

    public DateTime? PgmEditedDate { get; set; }
}
