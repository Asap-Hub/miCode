using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSccGenUnitPriceAssignment
{
    public int GpaIdpk { get; set; }

    public int? GpaGenUnitIdfk { get; set; }

    public decimal? GpaPrice { get; set; }

    public DateTime? GpaStartDate { get; set; }

    public DateTime? GpaEndDate { get; set; }

    public bool? GpaActive { get; set; }

    public string? GpaRmks { get; set; }

    public int? GpaCreatedBy { get; set; }

    public int? GpaEditedBy { get; set; }

    public DateTime? GpaCreationDate { get; set; }

    public DateTime? GpaEditedDate { get; set; }
}
