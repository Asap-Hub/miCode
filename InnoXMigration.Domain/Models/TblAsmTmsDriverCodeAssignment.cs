using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsDriverCodeAssignment
{
    public int DcaIdpk { get; set; }

    public int? DcaServiceProviderIdfk { get; set; }

    public int? DcaDriverEmpIdfk { get; set; }

    public string? DcaCode { get; set; }

    public DateTime? DcaAssignDate { get; set; }

    public DateTime? DcaEndDate { get; set; }

    public bool? DcaActive { get; set; }

    public string? DcaRmks { get; set; }

    public int? DcaCreatedBy { get; set; }

    public int? DcaEditedBy { get; set; }

    public DateTime? DcaCreationDate { get; set; }

    public DateTime? DcaEditedDate { get; set; }
}
