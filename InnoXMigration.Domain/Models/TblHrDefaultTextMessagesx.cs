using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrDefaultTextMessagesx
{
    public int FdtmIdpk { get; set; }

    public string? FdtmTitle { get; set; }

    public string? FdtmMessage { get; set; }

    public bool? FdtmActive { get; set; }

    public string? FdtmRmks { get; set; }

    public int? FdtmCreatedBy { get; set; }

    public int? FdtmEditedBy { get; set; }

    public DateTime? FdtmCreationDate { get; set; }

    public DateTime? FdtmEditedDate { get; set; }
}
