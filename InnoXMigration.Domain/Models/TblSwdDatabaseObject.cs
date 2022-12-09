using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdDatabaseObject
{
    public int DobIdpk { get; set; }

    public string? DobObjectName { get; set; }

    public string? DobObjectType { get; set; }

    public string? DobObjectSchema { get; set; }

    public int? DobModuleIdfk { get; set; }

    public string? DobRmks { get; set; }

    public int? DobCreatedBy { get; set; }

    public int? DobEditedBy { get; set; }

    public DateTime? DobCreationDate { get; set; }

    public DateTime? DobEditedDate { get; set; }
}
