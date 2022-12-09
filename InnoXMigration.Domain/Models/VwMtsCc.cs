using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsCc
{
    public int CcpIdpk { get; set; }

    public int? CcpMailIdfk { get; set; }

    public int? CcpItemIdfk { get; set; }

    public DateTime? CcpCreationDate { get; set; }

    public int ItmIdpk { get; set; }

    public string? ItmName { get; set; }

    public string? ItmShtName { get; set; }

    public bool? ItmActive { get; set; }

    public int MtrIdpk { get; set; }

    public DateTime? MtrDocDate { get; set; }

    public DateTime? MtrRecDate { get; set; }

    public DateTime? MtrOutDate { get; set; }
}
