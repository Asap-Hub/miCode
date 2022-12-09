using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrArea
{
    public int AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public DateTime? AreStartDate { get; set; }

    public DateTime? AreEndDate { get; set; }

    public string? AreCode { get; set; }

    public bool? AreActive { get; set; }

    public string? AreRmks { get; set; }

    public int? AreCreatedby { get; set; }

    public int? AreEditedBy { get; set; }

    public DateTime? AreCreationDate { get; set; }

    public DateTime? AreEditedDate { get; set; }
}
