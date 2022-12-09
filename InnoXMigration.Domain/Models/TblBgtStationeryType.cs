using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtStationeryType
{
    public int SttIdpk { get; set; }

    public string? SttName { get; set; }

    public string? SttShtName { get; set; }

    public bool? SttActive { get; set; }

    public string? SttRmks { get; set; }

    public int? SttCreatedBy { get; set; }

    public int? SttEditedBy { get; set; }

    public DateTime? SttCreationDate { get; set; }

    public DateTime? SttEditedDate { get; set; }
}
