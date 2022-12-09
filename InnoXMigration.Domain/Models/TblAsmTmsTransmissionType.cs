using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsTransmissionType
{
    public int TrtIdpk { get; set; }

    public string? TrtName { get; set; }

    public string? TrtShtName { get; set; }

    public bool? TrtActive { get; set; }

    public string? TrtRmks { get; set; }

    public string? TrtCreatedBy { get; set; }

    public int? TrtEditedBy { get; set; }

    public DateTime? TrtCreationDate { get; set; }

    public DateTime? TrtEditedDate { get; set; }
}
