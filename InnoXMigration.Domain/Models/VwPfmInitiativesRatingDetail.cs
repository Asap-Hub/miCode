using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmInitiativesRatingDetail
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

    public int RtnIdpk { get; set; }

    public decimal? RtnRate { get; set; }

    public string? RtnInterpretation { get; set; }

    public string? RtnShtInterpretation { get; set; }

    public string? RtnGrade { get; set; }

    public bool? RtnActive { get; set; }

    public int PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public bool? PrdActive { get; set; }
}
