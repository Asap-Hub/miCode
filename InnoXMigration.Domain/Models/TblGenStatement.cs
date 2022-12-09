using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenStatement
{
    public int StmIdpk { get; set; }

    public int? StmStatementTypeIdfk { get; set; }

    public string? StmTitle { get; set; }

    public string? StmStatement { get; set; }

    public string? StmAnswer { get; set; }

    public DateTime? StmStartDate { get; set; }

    public DateTime? StmEndDate { get; set; }

    public decimal? StmOrder { get; set; }

    public bool? StmChecked { get; set; }

    public DateTime? StmCheckedDate { get; set; }

    public int? StmCheckedBy { get; set; }

    public int? StmUpVotes { get; set; }

    public int? StmDownVotes { get; set; }

    public string? StmRmks { get; set; }

    public int? StmCreatedBy { get; set; }

    public int? StmEditedBy { get; set; }

    public DateTime? StmCreationDate { get; set; }

    public DateTime? StmEditedDate { get; set; }
}
