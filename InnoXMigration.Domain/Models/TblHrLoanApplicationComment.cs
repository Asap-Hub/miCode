using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLoanApplicationComment
{
    public int LacIdpk { get; set; }

    public int? LacLoanIdfk { get; set; }

    public bool? LacActive { get; set; }

    public string? LacComment { get; set; }

    public string? LacCreatedBy { get; set; }

    public int? LacEditedBy { get; set; }

    public DateTime? LacCreationDate { get; set; }

    public DateTime? LacEditedDate { get; set; }
}
