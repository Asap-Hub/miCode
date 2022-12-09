using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbTemplate
{
    public int TmpIdpk { get; set; }

    public string? TmpText { get; set; }

    public int? TmpEventTypeIdfk { get; set; }

    public int? TmpStationIdfk { get; set; }

    public bool? TmpActive { get; set; }

    public string? TmpRmks { get; set; }

    public int? TmpCreatedBy { get; set; }

    public DateTime? TmpCreationDate { get; set; }

    public int? TmpEditedBy { get; set; }

    public DateTime? TmpEditedDate { get; set; }
}
