using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspMessage
{
    public int FmsgIdpk { get; set; }

    public string? FmsgMsgType { get; set; }

    public string? FmsgTitle { get; set; }

    public string? FmsgMessage { get; set; }

    public decimal? FmsgOrder { get; set; }

    public DateTime? FmsgStartDate { get; set; }

    public DateTime? FmsgEndDate { get; set; }

    public bool? FmsgPicked { get; set; }

    public bool? FmsgActive { get; set; }

    public int? FmsgCreatedBy { get; set; }

    public int? FmsgEditedBy { get; set; }

    public DateTime? FmsgCreationDate { get; set; }

    public DateTime? FmsgEditedDate { get; set; }
}
