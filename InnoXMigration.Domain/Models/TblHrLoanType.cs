using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLoanType
{
    public int LtpIdpk { get; set; }

    public string LtpName { get; set; } = null!;

    public string LtpShtName { get; set; } = null!;

    public bool? LtpLoan { get; set; }

    public bool? LtpAdvance { get; set; }

    public bool? LtpClaim { get; set; }

    public decimal? LtpOrder { get; set; }

    public bool? LtpActive { get; set; }

    public string? LtpRmks { get; set; }

    public string? LtpCreatedBy { get; set; }

    public int? LtpEditedBy { get; set; }

    public DateTime? LtpCreationDate { get; set; }

    public DateTime? LtpEditedDate { get; set; }
}
