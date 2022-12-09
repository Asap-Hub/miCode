using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenStatement
{
    public int StmIdpk { get; set; }

    public int? StmStatementTypeIdfk { get; set; }

    public string StmTitle { get; set; } = null!;

    public string StmStatement { get; set; } = null!;

    public DateTime? StmStartDate { get; set; }

    public DateTime? StmEndDate { get; set; }

    public string StmRmks { get; set; } = null!;

    public int StpIdpk { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public bool? StpActive { get; set; }

    public string? StpRmks { get; set; }

    public int? StmOrder { get; set; }

    public bool StmChecked { get; set; }

    public DateTime? StmCheckedDate { get; set; }

    public int? StmCheckedBy { get; set; }

    public int? StmCreatedBy { get; set; }

    public string StmAnswer { get; set; } = null!;

    public int StmUpVotes { get; set; }

    public int StmDownVotes { get; set; }
}
