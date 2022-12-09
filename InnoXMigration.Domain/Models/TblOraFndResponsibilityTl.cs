using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraFndResponsibilityTl
{
    public string? ApplicationId { get; set; }

    public string? ResponsibilityId { get; set; }

    public string? Language { get; set; }

    public string? ResponsibilityName { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreationDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? LastUpdateLogin { get; set; }

    public string? Description { get; set; }

    public string? SourceLang { get; set; }
}
