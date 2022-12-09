using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAirConRefrigerant
{
    public int AcrIdpk { get; set; }

    public string? AcrName { get; set; }

    public string? AcrShtName { get; set; }

    public bool? AcrActive { get; set; }

    public string? AcrRmks { get; set; }

    public string? AcrCreatedBy { get; set; }

    public int? AcrEditedBy { get; set; }

    public DateTime? AcrCreationDate { get; set; }

    public DateTime? AcrEditedDate { get; set; }
}
