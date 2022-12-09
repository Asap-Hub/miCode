using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAirConModel
{
    public int AmdIdpk { get; set; }

    public string? AmdName { get; set; }

    public string? AmdShtName { get; set; }

    public int? AmdManufacturerIdfk { get; set; }

    public int? AmdBrandIdfk { get; set; }

    public bool? AmdActive { get; set; }

    public string? AmdRmks { get; set; }

    public string? AmdCreatedBy { get; set; }

    public int? AmdEditedBy { get; set; }

    public DateTime? AmdCreationDate { get; set; }

    public DateTime? AmdEditedDate { get; set; }
}
