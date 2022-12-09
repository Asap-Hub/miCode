using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdRelatedObject
{
    public int DobIdpk { get; set; }

    public string? DobObjectName { get; set; }

    public string? DobObjectType { get; set; }

    public string? DobObjectSchema { get; set; }

    public int? DobModuleIdfk { get; set; }

    public string? DobRmks { get; set; }

    public int DroIdpk { get; set; }

    public int? DroMainObjectIdfk { get; set; }

    public string? DroObjectName { get; set; }

    public string? DroObjectType { get; set; }

    public string? DroObjectSchema { get; set; }

    public string? DroRmks { get; set; }

    public int ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmCode { get; set; }

    public byte? ApmOrder { get; set; }
}
