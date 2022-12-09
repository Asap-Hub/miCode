using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsDocTemplate
{
    public int DtmIdpk { get; set; }

    public string? DtmName { get; set; }

    public byte[]? DtmFile { get; set; }

    public int? DtmTemplateTypeIdfk { get; set; }

    public bool? DtmActive { get; set; }

    public string? DtmCode { get; set; }

    public string? DtmRmks { get; set; }

    public int TmtIdpk { get; set; }

    public string? TmtName { get; set; }

    public string? TmtShtName { get; set; }

    public bool? TmtActive { get; set; }

    public string? TmtRmks { get; set; }

    public string? DtmShtCategory { get; set; }

    public string? DtmCategory { get; set; }
}
