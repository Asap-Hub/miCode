using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinPrlPayslipDocument
{
    public int PsdIdpk { get; set; }

    public int? PsdEmpIdfk { get; set; }

    public byte[]? PsdDoc { get; set; }

    public string? PsdStaffNo { get; set; }

    public DateTime? PsdDate { get; set; }

    public string? PsdRunType { get; set; }

    public bool? PsdActive { get; set; }

    public int? PsdCreatedBy { get; set; }

    public int? PsdEditedBy { get; set; }

    public DateTime? PsdCreationDate { get; set; }

    public DateTime? PsdEditedDate { get; set; }

    public string? PsdType { get; set; }

    public string? PsdAttachedFrom { get; set; }
}
