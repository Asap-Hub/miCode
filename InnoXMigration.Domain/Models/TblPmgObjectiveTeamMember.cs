using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgObjectiveTeamMember
{
    public int OtmIdpk { get; set; }

    public int? OtmObjectiveIdfk { get; set; }

    public int? OtmEmpIdfk { get; set; }

    public string? OtmStartDate { get; set; }

    public string? OtmEndDate { get; set; }

    public bool? OtmOwner { get; set; }

    public bool? OtmActive { get; set; }

    public string? OtmRmks { get; set; }

    public string? OtmCreatedBy { get; set; }

    public int? OtmEditedBy { get; set; }

    public DateTime? OtmCreationDate { get; set; }

    public DateTime? OtmEditedDate { get; set; }
}
