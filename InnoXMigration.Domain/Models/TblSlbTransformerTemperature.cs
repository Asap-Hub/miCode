using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbTransformerTemperature
{
    public int TtpIdpk { get; set; }

    public int? TtpStationIdfk { get; set; }

    public int? TtpTransformerIdfk { get; set; }

    public DateTime? TtpTime { get; set; }

    public decimal? TtpMinimumOilTemperature { get; set; }

    public decimal? TtpMaximumOilTemperature { get; set; }

    public decimal? TtpMinimumWindingTemperature { get; set; }

    public decimal? TtpMaximumWindingTemperature { get; set; }

    public bool? TtpActive { get; set; }

    public string? TtpRmks { get; set; }

    public int? TtpCreatedBy { get; set; }

    public int? TtpEditedBy { get; set; }

    public DateTime? TtpCreationDate { get; set; }

    public DateTime? TtpEditedDate { get; set; }
}
