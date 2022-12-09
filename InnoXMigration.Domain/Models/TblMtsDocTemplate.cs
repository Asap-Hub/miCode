using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDocTemplate
{
    public int DtmIdpk { get; set; }

    public string? DtmName { get; set; }

    public byte[]? DtmFile { get; set; }

    public int? DtmTemplateTypeIdfk { get; set; }

    public bool? DtmActive { get; set; }

    public string? DtmCategory { get; set; }

    public string? DtmShtCategory { get; set; }

    public string? DtmCode { get; set; }

    public string? DtmRmks { get; set; }

    public int? DtmCreatedBy { get; set; }

    public int? DtmEditedBy { get; set; }

    public DateTime? DtmCreationDate { get; set; }

    public DateTime? DtmEditedDate { get; set; }
}
