using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraClassificationRank
{
    public string? Classification { get; set; }

    public byte? SortOrder { get; set; }
}
