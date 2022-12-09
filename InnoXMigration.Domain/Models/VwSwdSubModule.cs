using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdSubModule
{
    public int SmdIdpk { get; set; }

    public string? SmdName { get; set; }

    public string? SmdShtName { get; set; }

    public int? SmdModuleIdfk { get; set; }

    public byte? SmdOrder { get; set; }

    public string? SmdCode { get; set; }

    public bool? SmdActive { get; set; }

    public string? SmdRmks { get; set; }

    public int ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public int PrjIdpk { get; set; }

    public string PrjName { get; set; } = null!;

    public string PrjShtName { get; set; } = null!;

    public int ApmProjectIdfk { get; set; }
}
