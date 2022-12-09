using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdRelatedObject
{
    public int DroIdpk { get; set; }

    public int? DroMainObjectIdfk { get; set; }

    public string? DroObjectName { get; set; }

    public string? DroObjectType { get; set; }

    public string? DroObjectSchema { get; set; }

    public string? DroRmks { get; set; }

    public int? DroCreatedBy { get; set; }

    public int? DroEditedBy { get; set; }

    public DateTime? DroCreationDate { get; set; }

    public DateTime? DroEditedDate { get; set; }
}
