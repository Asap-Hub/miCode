using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdDatabaseObject
{
    public int DobIdpk { get; set; }

    public string? DobObjectName { get; set; }

    public string? DobObjectType { get; set; }

    public string? DobObjectSchema { get; set; }

    public int? DobModuleIdfk { get; set; }

    public string? DobRmks { get; set; }

    public int ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmCode { get; set; }

    public byte? ApmOrder { get; set; }

    public string? ApmRmks { get; set; }
}
