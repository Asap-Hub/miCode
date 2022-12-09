using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsMinutesDoc
{
    public int MdcIdpk { get; set; }

    public int? MdcMinutesIdfk { get; set; }

    public byte[]? MdcDoc { get; set; }

    public string? MdcTitle { get; set; }

    public string? MdcFormat { get; set; }

    public bool? MdcMainDoc { get; set; }

    public bool? MdcActive { get; set; }

    public int? MdcCreatedBy { get; set; }

    public int? MdcEditedBy { get; set; }

    public DateTime? MdcCreationDate { get; set; }

    public DateTime? MdcEditedDate { get; set; }
}
