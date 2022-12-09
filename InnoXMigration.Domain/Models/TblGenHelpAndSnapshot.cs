using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenHelpAndSnapshot
{
    public int HnsIdpk { get; set; }

    public int? HnsModuleIdfk { get; set; }

    public string? HnsCategory { get; set; }

    public string? HnsTitle { get; set; }

    public byte[]? HnsFile { get; set; }

    public byte[]? HnsPdfFile { get; set; }

    public DateTime? HnsStartDate { get; set; }

    public DateTime? HnsEndDate { get; set; }

    public decimal? HnsOrder { get; set; }

    public string? HnsVersion { get; set; }

    public bool? HnsShowPdf { get; set; }

    public bool? HnsActive { get; set; }

    public string? HnsRmks { get; set; }

    public int? HnsCreatedBy { get; set; }

    public int? HnsEditedBy { get; set; }

    public DateTime? HnsCreationDate { get; set; }

    public DateTime? HnsEditedDate { get; set; }
}
