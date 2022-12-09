using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobTitle
{
    public int JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public string? JbtCode { get; set; }

    public DateTime? JbtStartDate { get; set; }

    public DateTime? JbtEndDate { get; set; }

    public bool? JbtActive { get; set; }

    public string? JbtRmks { get; set; }

    public int? JbtCreatedBy { get; set; }

    public int? JbtEditedBy { get; set; }

    public DateTime? JbtCreationDate { get; set; }

    public DateTime? JbtEditedDate { get; set; }
}
