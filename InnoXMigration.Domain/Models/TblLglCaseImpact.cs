using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCaseImpact
{
    public int CimIdpk { get; set; }

    public string? CimName { get; set; }

    public string? CimShtName { get; set; }

    public bool? CimActive { get; set; }

    public byte? CimOrder { get; set; }

    public string? CimRmks { get; set; }

    public int? CimCreatedBy { get; set; }

    public int? CimEditedBy { get; set; }

    public DateTime? CimCreationDate { get; set; }

    public DateTime? CimEditedDate { get; set; }
}
