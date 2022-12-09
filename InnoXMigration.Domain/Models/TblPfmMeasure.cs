using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmMeasure
{
    public int MsrIdpk { get; set; }

    public string? MsrName { get; set; }

    public string? MsrShtName { get; set; }

    public bool? MsrActive { get; set; }

    public string? MsrRmks { get; set; }

    public string? MsrCreatedBy { get; set; }

    public int? MsrEditedBy { get; set; }

    public DateTime? MsrCreationDate { get; set; }

    public DateTime? MsrEditedDate { get; set; }
}
