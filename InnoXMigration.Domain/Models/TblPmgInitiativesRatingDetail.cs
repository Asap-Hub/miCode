using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgInitiativesRatingDetail
{
    public int IrdIdpk { get; set; }

    public int? IrdEmpIdfk { get; set; }

    public int? IrdRatingIdfk { get; set; }

    public int? IrdPeriodIdfk { get; set; }

    public int? IrdInitiativeIdfk { get; set; }

    public string? IrdLowerValue { get; set; }

    public string? IrdUpperValue { get; set; }

    public string? IrdUnitOfMeasure { get; set; }

    public byte? IrdOrder { get; set; }

    public bool? IrdActive { get; set; }

    public string? IrdRmks { get; set; }

    public string? IrdCreatedBy { get; set; }

    public int? IrdEditedBy { get; set; }

    public DateTime? IrdCreationDate { get; set; }

    public DateTime? IrdEditedDate { get; set; }
}
