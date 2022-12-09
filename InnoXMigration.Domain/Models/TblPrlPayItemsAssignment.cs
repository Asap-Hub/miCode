using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlPayItemsAssignment
{
    public int PiaIdpk { get; set; }

    public string? PiaName { get; set; }

    public string? PiaShtName { get; set; }

    public bool? PiaActive { get; set; }

    public string? PiaRmks { get; set; }

    public int? PiaCreatedBy { get; set; }

    public int? PiaEditedBy { get; set; }

    public DateTime? PiaCreationDate { get; set; }

    public DateTime? PiaEditedDate { get; set; }
}
