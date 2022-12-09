using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelDumpComment
{
    public int FdcIdpk { get; set; }

    public int? FdcFuelDumpIdfk { get; set; }

    public int? FdcEmpIdfk { get; set; }

    public string? FdcComment { get; set; }

    public bool? FdcActive { get; set; }

    public int? FdcCreatedBy { get; set; }

    public int? FdcEditedBy { get; set; }

    public DateTime? FdcCreationDate { get; set; }

    public DateTime? FdcEditedDate { get; set; }
}
