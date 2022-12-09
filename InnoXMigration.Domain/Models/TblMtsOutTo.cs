using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsOutTo
{
    public int OtsIdpk { get; set; }

    public int? OtsMailIdfk { get; set; }

    public int? OtsItemIdfk { get; set; }

    public DateTime? OtsCreationDate { get; set; }
}
