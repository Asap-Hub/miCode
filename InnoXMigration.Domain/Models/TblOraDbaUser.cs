using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraDbaUser
{
    public string? Username { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public string? AccountStatus { get; set; }

    public string? LockDate { get; set; }

    public string? ExpiryDate { get; set; }

    public string? DefaultTablespace { get; set; }

    public string? TemporaryTablespace { get; set; }

    public string? Created { get; set; }

    public string? Profile { get; set; }

    public string? InitialRsrcConsumerGroup { get; set; }

    public string? ExternalName { get; set; }
}
