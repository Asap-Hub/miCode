using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbCheckStationShiftStatus
{
    public int CssIdpk { get; set; }

    public int? CssStationIdfk { get; set; }

    public bool? CssCheck { get; set; }

    public string? CssRmks { get; set; }

    public int StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnPlc { get; set; }

    public bool? StnActive { get; set; }

    public string? StnRmks { get; set; }

    public int? CssCreatedBy { get; set; }

    public int? CssEditedBy { get; set; }

    public DateTime? CssCreationDate { get; set; }

    public DateTime? CssEditedDate { get; set; }

    public int? StnCreatedBy { get; set; }

    public int? StnEditedBy { get; set; }

    public DateTime? StnCreationDate { get; set; }

    public DateTime? StnEditedDate { get; set; }
}
