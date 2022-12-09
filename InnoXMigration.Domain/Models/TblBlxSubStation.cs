using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxSubStation
{
    public int FsstIdpk { get; set; }

    public string? FsstName { get; set; }

    public string? FsstShtName { get; set; }

    public int? FsstAreaIdfk { get; set; }

    public bool? FsstActive { get; set; }

    public string? FsstRmks { get; set; }

    public int? FsstCreatedBy { get; set; }

    public int? FsstEditedBy { get; set; }

    public DateTime? FsstCreationDate { get; set; }

    public DateTime? FsstEditedDate { get; set; }
}
