using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsPmActivityDetail
{
    public int PadIdpk { get; set; }

    public int? PadPreventiveMaintenanceActivityIdfk { get; set; }

    public int? PadMaintenanceItemIdfk { get; set; }

    public DateTime? PadStartDate { get; set; }

    public DateTime? PadEndDate { get; set; }

    public decimal? PadCost { get; set; }

    public bool? PadFaulty { get; set; }

    public bool? PadReplaced { get; set; }

    public bool? PadActive { get; set; }

    public string? PadRmks { get; set; }

    public string? PadCreatedBy { get; set; }

    public int? PadEditedBy { get; set; }

    public DateTime? PadCreationDate { get; set; }

    public DateTime? PadEditedDate { get; set; }
}
