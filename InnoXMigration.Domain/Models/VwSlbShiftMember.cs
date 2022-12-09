using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbShiftMember
{
    public int SmbIdpk { get; set; }

    public DateTime? SmbDate { get; set; }

    public string? SmbMembers { get; set; }

    public int? SmbLogStationIdfk { get; set; }

    public bool? SmbOnDuty { get; set; }

    public bool? SmbDeleted { get; set; }

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnPlc { get; set; }

    public bool? StnActive { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public bool? LocActive { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? StnRmks { get; set; }

    public string SmbRmks { get; set; } = null!;
}
