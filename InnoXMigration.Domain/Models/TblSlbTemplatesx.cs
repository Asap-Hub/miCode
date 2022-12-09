using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbTemplatesx
{
    public int FtmpIdpk { get; set; }

    public string? FtmpText { get; set; }

    public int? FtmpEventTypeIdfk { get; set; }

    public int? FtmpStationIdfk { get; set; }

    public bool? FtmpActive { get; set; }

    public string? FtmpRmks { get; set; }

    public int? FtmpCreatedBy { get; set; }

    public DateTime? FtmpCreationDate { get; set; }

    public int? FtmpEditedBy { get; set; }

    public DateTime? FtmpEditedDate { get; set; }
}
