using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxGenStationsx
{
    public int FgstIdpk { get; set; }

    public int? FgstGenCompIdfk { get; set; }

    public string? FgstName { get; set; }

    public string? FgstShtName { get; set; }

    public bool? FgstActive { get; set; }

    public string? FgstRemarks { get; set; }

    public int? FgstCreatedBy { get; set; }

    public int? FgstEditedBy { get; set; }

    public DateTime? FgstCreationDate { get; set; }

    public DateTime? FgstEditedDate { get; set; }
}
