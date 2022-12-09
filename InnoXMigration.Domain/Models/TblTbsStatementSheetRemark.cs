using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsStatementSheetRemark
{
    public int SsrIdpk { get; set; }

    public int? SsrFeederIdfk { get; set; }

    public DateTime? SsrDate { get; set; }

    public string? SsrRmks { get; set; }

    public int? SsrCreatedBy { get; set; }

    public int? SsrEditedBy { get; set; }

    public DateTime? SsrCreationDate { get; set; }

    public DateTime? SsrEditedDate { get; set; }
}
