using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspDocLocation
{
    public int FdlcIdpk { get; set; }

    public int? FdlcDocIdfk { get; set; }

    public int? FdlcLocIdfk { get; set; }

    public bool? FdlcActive { get; set; }

    public int? FdlcCreatedBy { get; set; }

    public int? FdlcEditedBy { get; set; }

    public DateTime? FdlcCreationDate { get; set; }

    public DateTime? FdlcEditedDate { get; set; }
}
