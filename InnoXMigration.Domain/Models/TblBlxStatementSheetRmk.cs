using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxStatementSheetRmk
{
    public int FssrIdpk { get; set; }

    public int? FssrFeederIdfk { get; set; }

    public DateTime? FssrDate { get; set; }

    public string? FssrRmks { get; set; }

    public int? FssrCreatedBy { get; set; }

    public int? FssrEditedBy { get; set; }

    public DateTime? FssrCreationDate { get; set; }

    public DateTime? FssrEditedDate { get; set; }
}
