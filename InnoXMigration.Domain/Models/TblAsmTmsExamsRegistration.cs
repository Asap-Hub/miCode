using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsExamsRegistration
{
    public int ErgIdpk { get; set; }

    public int? ErgExamNameIdfk { get; set; }

    public int? ErgEmpIdfk { get; set; }

    public DateTime? ErgStartDate { get; set; }

    public DateTime? ErgEndDate { get; set; }

    public DateTime? ErgWrittenOn { get; set; }

    public bool? ErgPassed { get; set; }

    public bool? ErgSmsSent { get; set; }

    public bool? ErgSmsCount { get; set; }

    public bool? ErgActive { get; set; }

    public string? ErgRmks { get; set; }

    public int? ErgCreatedby { get; set; }

    public int? ErgEditedBy { get; set; }

    public DateTime? ErgCreationDate { get; set; }

    public DateTime? ErgEditedDate { get; set; }
}
