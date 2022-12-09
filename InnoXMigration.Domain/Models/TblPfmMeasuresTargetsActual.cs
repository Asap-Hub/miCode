using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmMeasuresTargetsActual
{
    public int MtaIdpk { get; set; }

    public int? MtaMeasureIdfk { get; set; }

    public int? MtaTargetIdfk { get; set; }

    public int? MtaActualIdfk { get; set; }

    public bool? MtaActive { get; set; }

    public string? MtaRmks { get; set; }

    public string? MtaCreatedBy { get; set; }

    public int? MtaEditedBy { get; set; }

    public DateTime? MtaCreationDate { get; set; }

    public DateTime? MtaEditedDate { get; set; }
}
