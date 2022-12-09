using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrDependantClass
{
    public int DclIdpk { get; set; }

    public string? DclName { get; set; }

    public string? DclShtName { get; set; }

    public byte? DclMaxNo { get; set; }

    public string? DclCode { get; set; }

    public bool? DclDependant { get; set; }

    public bool? DclWard { get; set; }

    public bool? DclActive { get; set; }

    public string? DclRmks { get; set; }

    public string? DclCreatedBy { get; set; }

    public int? DclEditedBy { get; set; }

    public DateTime? DclCreationDate { get; set; }

    public DateTime? DclEditedDate { get; set; }
}
