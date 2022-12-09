using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgCorporateMeasure
{
    public int CmsIdpk { get; set; }

    public int? CmsPeriodIdfk { get; set; }

    public int? CmsPerspectiveIdfk { get; set; }

    public int? CmsMeasureIdfk { get; set; }

    public int? CmsTargetIdfk { get; set; }

    public bool? CmsActive { get; set; }

    public string? CmsRmks { get; set; }

    public string? CmsCreatedBy { get; set; }

    public int? CmsEditedBy { get; set; }

    public DateTime? CmsCreationDate { get; set; }

    public DateTime? CmsEditedDate { get; set; }
}
