using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDefaultTextMessage
{
    public int DtmIdpk { get; set; }

    public string? DtmTitle { get; set; }

    public string? DtmMessage { get; set; }

    public int? DtmCatIdfk { get; set; }

    public bool? DtmActive { get; set; }

    public string? DtmRmks { get; set; }

    public int? DtmCreatedBy { get; set; }

    public int? DtmEditedBy { get; set; }

    public DateTime? DtmCreationDate { get; set; }

    public DateTime? DtmEditedDate { get; set; }
}
