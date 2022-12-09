using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblEvtElectionType
{
    public int EtpIdpk { get; set; }

    public string? EtpName { get; set; }

    public string? EtpShtName { get; set; }

    public bool? EtpActive { get; set; }

    public string? EtpRmks { get; set; }

    public string? EtpCreatedBy { get; set; }

    public int? EtpEditedBy { get; set; }

    public DateTime? EtpCreationDate { get; set; }

    public DateTime? EtpEditedDate { get; set; }
}
