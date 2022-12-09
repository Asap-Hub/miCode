using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtWorkProgress
{
    public int WpgIdpk { get; set; }

    public int? WpgWorkPlanIdfk { get; set; }

    public DateTime? WpgDate { get; set; }

    public string? WpgStatus { get; set; }

    public short? WpgPercentComplete { get; set; }

    public string? WpgRmks { get; set; }

    public int? WpgCreatedBy { get; set; }

    public int? WpgEditedBy { get; set; }

    public DateTime? WpgCreationDate { get; set; }

    public DateTime? WpgEditedDate { get; set; }
}
