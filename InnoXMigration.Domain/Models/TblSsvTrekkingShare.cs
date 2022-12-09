using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingShare
{
    public int TshIdpk { get; set; }

    public int? TshTrekkingRequestIdfk { get; set; }

    public int? TshEmpIdfk { get; set; }

    public bool? TshOwner { get; set; }

    public bool? TshUpdate { get; set; }

    public bool? TshReader { get; set; }

    public bool? TshSign { get; set; }

    public string? TshType { get; set; }

    public bool? TshRead { get; set; }

    public int? TshCreatedBy { get; set; }

    public DateTime? TshCreationDate { get; set; }
}
