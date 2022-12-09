using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraFndApplication
{
    public string? ApplicationId { get; set; }

    public string? ApplicationShortName { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? LastUpdateLogin { get; set; }

    public string? Basepath { get; set; }

    public string? ProductCode { get; set; }
}
