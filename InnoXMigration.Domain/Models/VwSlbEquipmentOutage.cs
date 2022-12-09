using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbEquipmentOutage
{
    public int EotIdpk { get; set; }

    public int? EotOutageTypeIdfk { get; set; }

    public int? EotEquipmentTypeIdfk { get; set; }

    public int? EotEquipmentDetailIdfk { get; set; }

    public string? EotEquipment { get; set; }

    public DateTime? EotStartTime { get; set; }

    public DateTime? EotEndTime { get; set; }

    public int? TimeDifference { get; set; }

    public string? EotReason { get; set; }

    public bool? EotActive { get; set; }

    public string? EotRmks { get; set; }

    public int? OetIdpk { get; set; }

    public string? OetName { get; set; }

    public string? OetShtName { get; set; }

    public bool? OetTransformer { get; set; }

    public bool? OetLine { get; set; }

    public bool? OetFeeder { get; set; }

    public int? OtpIdpk { get; set; }

    public string? OtpName { get; set; }

    public string? OtpShtName { get; set; }

    public bool? OtpPlanned { get; set; }

    public bool? OtpActive { get; set; }

    public int? EotStationIdfk { get; set; }

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public string EotDetails { get; set; } = null!;
}
