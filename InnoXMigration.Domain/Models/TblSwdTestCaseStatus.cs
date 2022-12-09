using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdTestCaseStatus
{
    public int TcsIdpk { get; set; }

    public string? TcsName { get; set; }

    public string? TcsShtName { get; set; }

    public decimal? TcsOrder { get; set; }

    public bool? TcsActive { get; set; }

    public string? TcsRmks { get; set; }

    public int? TcsCreatedBy { get; set; }

    public int? TcsEditedBy { get; set; }

    public DateTime? TcsCreationDate { get; set; }

    public DateTime? TcsEditedDate { get; set; }
}
