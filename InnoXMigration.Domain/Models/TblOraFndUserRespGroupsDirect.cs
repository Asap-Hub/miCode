using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraFndUserRespGroupsDirect
{
    public string? UserId { get; set; }

    public string? ResponsibilityId { get; set; }

    public string? ResponsibilityApplicationId { get; set; }

    public string? SecurityGroupId { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreationDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? LastUpdateLogin { get; set; }

    public string? Description { get; set; }

    public bool? ActiveStatus { get; set; }
}
