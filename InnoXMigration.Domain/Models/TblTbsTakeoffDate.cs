using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsTakeoffDate
{
    public int FtodIdpk { get; set; }

    public DateTime? FtodDate { get; set; }

    public bool? FtodCurrent { get; set; }

    public int? FtodCreatedBy { get; set; }

    public int? FtodEditedBy { get; set; }

    public DateTime? FtodCreationDate { get; set; }
}
