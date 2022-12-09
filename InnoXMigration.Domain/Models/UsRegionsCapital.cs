using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class UsRegionsCapital
{
    public double? CountryId { get; set; }

    public string? Region { get; set; }

    public string? ShtName { get; set; }

    public string? Code { get; set; }

    public string? Capital { get; set; }
}
