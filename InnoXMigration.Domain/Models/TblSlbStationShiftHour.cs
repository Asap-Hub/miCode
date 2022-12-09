using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbStationShiftHour
{
    public int SshIdpk { get; set; }

    public DateTime? SshDate { get; set; }

    public int? SshStationIdfk { get; set; }

    public decimal? SshHours { get; set; }

    public bool? SshActive { get; set; }

    public string? SshRmks { get; set; }

    public int? SshCreatedBy { get; set; }

    public int? SshEditedBy { get; set; }

    public DateTime? SshCreationDate { get; set; }

    public DateTime? SshEditedDate { get; set; }
}
