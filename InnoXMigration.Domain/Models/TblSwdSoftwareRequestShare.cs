using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdSoftwareRequestShare
{
    public int SrsIdpk { get; set; }

    public int? SrsRequestIdfk { get; set; }

    public int? SrsEmpIdfk { get; set; }

    public bool? SrsAdmin { get; set; }

    public bool? SrsUpdate { get; set; }

    public bool? SrsLock { get; set; }

    public bool? SrsRead { get; set; }

    public bool? SrsActive { get; set; }

    public int? SrsCreatedBy { get; set; }

    public DateTime? SrsCreationDate { get; set; }

    public int? SrsEditedBy { get; set; }

    public DateTime? SrsEditedDate { get; set; }
}
