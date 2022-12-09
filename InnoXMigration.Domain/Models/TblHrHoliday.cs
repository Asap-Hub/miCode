using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrHoliday
{
    public int HldIdpk { get; set; }

    public DateTime? HldDate { get; set; }

    public string? HldHolidayName { get; set; }

    public bool? HldActive { get; set; }

    public string? HldRmks { get; set; }

    public int? HldCreatedBy { get; set; }

    public int? HldEditedBy { get; set; }

    public DateTime? HldCreationDate { get; set; }

    public DateTime? HldEditedDate { get; set; }
}
