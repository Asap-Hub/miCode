using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbStationShiftHour
{
    public int SshIdpk { get; set; }

    public DateTime? SshDate { get; set; }

    public int? SshStationIdfk { get; set; }

    public decimal? SshHours { get; set; }

    public bool? SshActive { get; set; }

    public string? SshRmks { get; set; }

    public int StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnPlc { get; set; }

    public bool? StnActive { get; set; }

    public string? StnRmks { get; set; }

    public int? SshCreatedBy { get; set; }

    public int? SshEditedBy { get; set; }

    public DateTime? SshCreationDate { get; set; }

    public DateTime? SshEditedDate { get; set; }
}
