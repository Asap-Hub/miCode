using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsItem
{
    public int ItmIdpk { get; set; }

    public string? ItmName { get; set; }

    public string? ItmShtName { get; set; }

    public int? ItmEmpIdfk { get; set; }

    public bool? ItmActive { get; set; }

    public string? ItmRmks { get; set; }

    public int? ItmEditedBy { get; set; }

    public int? ItmCreatedBy { get; set; }

    public DateTime? ItmCreationDate { get; set; }

    public DateTime? ItmEditedDate { get; set; }
}
