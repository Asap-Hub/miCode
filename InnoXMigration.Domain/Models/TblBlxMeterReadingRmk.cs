using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxMeterReadingRmk
{
    public int FmrrIdpk { get; set; }

    public int? FmrrCustIdfk { get; set; }

    public DateTime? FmrrBeginDate { get; set; }

    public DateTime? FmrrEndDate { get; set; }

    public string? FmrrRemarks { get; set; }

    public int? FmrrCreatedBy { get; set; }

    public int? FmrrEditedBy { get; set; }

    public DateTime? FmrrCreationDate { get; set; }

    public DateTime? FmrrEditedDate { get; set; }
}
