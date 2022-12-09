using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmDeptInitiative
{
    public int DinIdpk { get; set; }

    public string? DinName { get; set; }

    public string? DinShtName { get; set; }

    public decimal? DinOrder { get; set; }

    public bool? DinActive { get; set; }

    public string? DinRmks { get; set; }

    public string? DinCreatedBy { get; set; }

    public int? DinEditedBy { get; set; }

    public DateTime? DinCreationDate { get; set; }

    public DateTime? DinEditedDate { get; set; }
}
