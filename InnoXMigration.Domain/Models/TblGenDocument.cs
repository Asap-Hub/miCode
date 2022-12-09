using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDocument
{
    public int GdsIdpk { get; set; }

    public string? GdsTitle { get; set; }

    public int? GdsDocClassIdfk { get; set; }

    public int? GdsDocTypeIdfk { get; set; }

    public bool? GdsShowPdf { get; set; }

    public byte[]? GdsFile { get; set; }

    public byte[]? GdsPdfFile { get; set; }

    public string? GdsVersion { get; set; }

    public DateTime? GdsStartDate { get; set; }

    public DateTime? GdsEndDate { get; set; }

    public bool? GdsDeleted { get; set; }

    public string? GdsRmks { get; set; }

    public bool? GdsActive { get; set; }

    public int? GdsCreatedBy { get; set; }

    public int? GdsEditedBy { get; set; }

    public DateTime? GdsCreationDate { get; set; }

    public DateTime? GdsEditedDate { get; set; }
}
