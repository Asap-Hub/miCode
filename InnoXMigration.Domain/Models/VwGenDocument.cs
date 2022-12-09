using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenDocument
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

    public string? GdsRmks { get; set; }

    public bool? GdsActive { get; set; }

    public int? GdsCreatedBy { get; set; }

    public int? GdsEditedBy { get; set; }

    public DateTime? GdsCreationDate { get; set; }

    public DateTime? GdsEditedDate { get; set; }

    public int GdtIdpk { get; set; }

    public string? GdtName { get; set; }

    public string? GdtShtName { get; set; }

    public bool? GdtActive { get; set; }

    public string? GdtRmks { get; set; }

    public string? GdtCreatedBy { get; set; }

    public int? GdtEditedBy { get; set; }

    public DateTime? GdtCreationDate { get; set; }

    public DateTime? GdtEditedDate { get; set; }

    public bool GdsDeleted { get; set; }

    public int GdcIdpk { get; set; }

    public string? GdcName { get; set; }

    public string? GdcShtName { get; set; }

    public bool? GdcActive { get; set; }

    public string? GdcRmks { get; set; }

    public string? GdcCreatedBy { get; set; }

    public int? GdcEditedBy { get; set; }

    public DateTime? GdcCreationDate { get; set; }

    public DateTime? GdcEditedDate { get; set; }
}
