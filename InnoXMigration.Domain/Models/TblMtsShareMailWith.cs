using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsShareMailWith
{
    public int SmwIdpk { get; set; }

    public int? SmwMailIdfk { get; set; }

    public string? SmwStaffNo { get; set; }

    public string? SmwEmpName { get; set; }

    public bool? SmwShareDocOnly { get; set; }

    public int? SmwDocIdfk { get; set; }

    public DateTime? SmwCreationDate { get; set; }
}
