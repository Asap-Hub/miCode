using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingCalendar
{
    public int McdIdpk { get; set; }

    public string? McdName { get; set; }

    public string? McdShtName { get; set; }

    public DateTime? McdStartDate { get; set; }

    public DateTime? McdEndDate { get; set; }

    public bool? McdOpened { get; set; }

    public bool? McdActive { get; set; }

    public string? McdRmks { get; set; }

    public string? McdCreatedBy { get; set; }

    public int? McdEditedBy { get; set; }

    public DateTime? McdCreationDate { get; set; }

    public DateTime? McdEditedDate { get; set; }
}
