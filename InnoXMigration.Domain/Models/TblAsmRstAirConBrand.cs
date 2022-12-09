using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAirConBrand
{
    public int AcbIdpk { get; set; }

    public string? AcbName { get; set; }

    public string? AcbShtName { get; set; }

    public int? AcbAirConClassIdfk { get; set; }

    public bool? AcbActive { get; set; }

    public string? AcbRmks { get; set; }

    public string? AcbCreatedBy { get; set; }

    public int? AcbEditedBy { get; set; }

    public DateTime? AcbCreationDate { get; set; }

    public DateTime? AcbEditedDate { get; set; }
}
