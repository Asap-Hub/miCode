using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelDumpAttendantsAssignment
{
    public int FaaIdpk { get; set; }

    public int? FaaEmpIdfk { get; set; }

    public int? FaaServiceStationIdfk { get; set; }

    public bool? FaaManage { get; set; }

    public bool? FaaView { get; set; }

    public bool? FaaAuthorise { get; set; }

    public bool? FaaActive { get; set; }

    public string? FaaRmks { get; set; }

    public int? FaaCreatedBy { get; set; }

    public int? FaaEditedBy { get; set; }

    public DateTime? FaaCreationDate { get; set; }

    public DateTime? FaaEditedDate { get; set; }
}
