using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsMeterReadingRemark
{
    public int MrrIdpk { get; set; }

    public int? MrrCustIdfk { get; set; }

    public DateTime? MrrBeginDate { get; set; }

    public DateTime? MrrEndDate { get; set; }

    public string? MrrRemarks { get; set; }

    public int? MrrCreatedBy { get; set; }

    public int? MrrEditedBy { get; set; }

    public DateTime? MrrCreationDate { get; set; }

    public DateTime? MrrEditedDate { get; set; }
}
