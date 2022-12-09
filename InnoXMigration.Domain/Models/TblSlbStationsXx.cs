using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbStationsXx
{
    public int FstnIdpk { get; set; }

    public string? FstnName { get; set; }

    public string? Namex { get; set; }

    public string? FstnShtName { get; set; }

    public string? Shtnamex { get; set; }

    public string? FstnCode { get; set; }

    public string? FstnContact { get; set; }

    public string? FstnTelNo { get; set; }

    public string? FstnPlc { get; set; }

    public bool? FstnActive { get; set; }

    public string? FstnRmks { get; set; }

    public int? FstnCreatedBy { get; set; }

    public int? FstnEditedBy { get; set; }

    public DateTime? FstnCreationDate { get; set; }

    public DateTime? FstnEditedDate { get; set; }
}
