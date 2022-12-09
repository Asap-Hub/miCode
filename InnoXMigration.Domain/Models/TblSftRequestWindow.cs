using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftRequestWindow
{
    public int RqwIdpk { get; set; }

    public string? RqwName { get; set; }

    public string? RqwShtName { get; set; }

    public DateTime? RqwStartDate { get; set; }

    public DateTime? RqwEndDate { get; set; }

    public bool? RqwOpened { get; set; }

    public bool? RqwActive { get; set; }

    public string? RqwRmks { get; set; }

    public string? RqwCreatedBy { get; set; }

    public int? RqwEditedBy { get; set; }

    public DateTime? RqwCreationDate { get; set; }

    public DateTime? RqwEditedDate { get; set; }
}
