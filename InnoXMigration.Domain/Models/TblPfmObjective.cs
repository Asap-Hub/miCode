using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmObjective
{
    public int ObjIdpk { get; set; }

    public int? ObjMissionIdfk { get; set; }

    public string? ObjThemeIdfk { get; set; }

    public string? ObjPerspectiveIdfk { get; set; }

    public string? ObjOwnerEmpIdfk { get; set; }

    public string? ObjName { get; set; }

    public string? ObjShtName { get; set; }

    public string? ObjDescription { get; set; }

    public string? ObjOutcome { get; set; }

    public byte? ObjOrder { get; set; }

    public bool? ObjActive { get; set; }

    public string? ObjRmks { get; set; }

    public string? ObjCreatedBy { get; set; }

    public int? ObjEditedBy { get; set; }

    public DateTime? ObjCreationDate { get; set; }

    public DateTime? ObjEditedDate { get; set; }
}
