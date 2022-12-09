using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsOutTo
{
    public int OtsIdpk { get; set; }

    public int? OtsMailIdfk { get; set; }

    public int? OtsItemIdfk { get; set; }

    public int ItmIdpk { get; set; }

    public string? ItmName { get; set; }

    public string? ItmShtName { get; set; }

    public bool? ItmActive { get; set; }

    public DateTime? OtsCreationDate { get; set; }
}
