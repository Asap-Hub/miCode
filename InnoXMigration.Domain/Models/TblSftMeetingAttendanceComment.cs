using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingAttendanceComment
{
    public int MacIdpk { get; set; }

    public int? MacMeetingAttendanceIdfk { get; set; }

    public int? MacEmpIdfk { get; set; }

    public string? MacComment { get; set; }

    public bool? MacActive { get; set; }

    public int? MacCreatedBy { get; set; }

    public int? MacEditedBy { get; set; }

    public DateTime? MacCreationDate { get; set; }

    public DateTime? MacEditedDate { get; set; }
}
