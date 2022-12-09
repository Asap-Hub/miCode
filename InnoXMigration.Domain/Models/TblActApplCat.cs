using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblActApplCat
{
    public int FactIdpk { get; set; }

    public string? FactName { get; set; }

    public string? FactShtName { get; set; }

    public int? FactApplTypeIdfk { get; set; }

    public bool? FactHasPt { get; set; }

    public bool? FactActive { get; set; }

    public string? FactRmks { get; set; }

    public int? FactCreatedBy { get; set; }

    public int? FactEditedBy { get; set; }

    public DateTime? FactCreationDate { get; set; }

    public DateTime? FactEditedDate { get; set; }
}
