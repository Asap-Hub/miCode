using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsBcc
{
    public int BccIdpk { get; set; }

    public int? BccMailIdfk { get; set; }

    public int? BccItemIdfk { get; set; }

    public DateTime? BccCreationDate { get; set; }

    public int ItmIdpk { get; set; }

    public string? ItmName { get; set; }

    public string? ItmShtName { get; set; }

    public bool? ItmActive { get; set; }
}
