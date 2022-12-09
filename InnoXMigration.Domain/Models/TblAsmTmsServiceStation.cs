using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsServiceStation
{
    public int SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public string? SstProviderStationName { get; set; }

    public string? SstStationNo { get; set; }

    public int? SstServiceProviderIdfk { get; set; }

    public int? SstTownIdfk { get; set; }

    public string? SstMainContacts { get; set; }

    public string? SstTelNos { get; set; }

    public string? SsteMails { get; set; }

    public bool? SstFuelDump { get; set; }

    public bool? SstActive { get; set; }

    public string? SstRmks { get; set; }

    public string? SstCreatedBy { get; set; }

    public int? SstEditedBy { get; set; }

    public DateTime? SstCreationDate { get; set; }

    public DateTime? SstEditedDate { get; set; }
}
