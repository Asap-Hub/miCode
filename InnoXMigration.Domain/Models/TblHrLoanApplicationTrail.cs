using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLoanApplicationTrail
{
    public int LatIdpk { get; set; }

    public int? LatLoanIdfk { get; set; }

    public string? LatTrail { get; set; }

    public string? LatCreatedBy { get; set; }

    public int? LatEditedBy { get; set; }

    public DateTime? LatCreationDate { get; set; }

    public DateTime? LatEditedDate { get; set; }
}
