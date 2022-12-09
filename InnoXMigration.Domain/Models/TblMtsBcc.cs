using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsBcc
{
    public int BccIdpk { get; set; }

    public int? BccMailIdfk { get; set; }

    public int? BccItemIdfk { get; set; }

    public DateTime? BccCreationDate { get; set; }
}
