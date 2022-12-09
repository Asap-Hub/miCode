using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspDocSection
{
    public int FdsnIdpk { get; set; }

    public int? FdsnDocIdfk { get; set; }

    public int? FdsnSexnIdfk { get; set; }

    public bool? FdsnActive { get; set; }

    public int? FdsnCreatedBy { get; set; }

    public int? FdsnEditedBy { get; set; }

    public DateTime? FdsnCreationDate { get; set; }

    public DateTime? FdsnEditedDate { get; set; }
}
