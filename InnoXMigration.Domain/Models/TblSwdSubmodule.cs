using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdSubmodule
{
    public int SmdIdpk { get; set; }

    public string? SmdName { get; set; }

    public string? SmdShtName { get; set; }

    public int? SmdModuleIdfk { get; set; }

    public byte? SmdOrder { get; set; }

    public string? SmdCode { get; set; }

    public bool? SmdActive { get; set; }

    public string? SmdRmks { get; set; }

    public int? SmdCreatedBy { get; set; }

    public int? SmdEditedBy { get; set; }

    public DateTime? SmdCreationDate { get; set; }

    public DateTime? SmdEditedDate { get; set; }
}
