using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxFdrCustAssign
{
    public int FfcaIdpk { get; set; }

    public int? FfcaFdrIdfk { get; set; }

    public int? FfcaCustIdfk { get; set; }

    public DateTime? FfcaDate { get; set; }

    public DateTime? FfcaEndDate { get; set; }

    public bool? FfcaAssigned { get; set; }

    public bool? FfcaTeeingOffFeeder { get; set; }

    public string? FfcaRmks { get; set; }

    public int? FfcaCreatedBy { get; set; }

    public int? FfcaEditedBy { get; set; }

    public DateTime? FfcaCreationDate { get; set; }

    public DateTime? FfcaEditedDate { get; set; }
}
