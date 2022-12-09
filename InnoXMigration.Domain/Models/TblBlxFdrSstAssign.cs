using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxFdrSstAssign
{
    public int FfsaIdpk { get; set; }

    public int? FfsaSstIdfk { get; set; }

    public int? FfsaFdrIdfk { get; set; }

    public DateTime? FfsaDate { get; set; }

    public DateTime? FfsaEndDate { get; set; }

    public bool? FfsaActive { get; set; }

    public string? FfsaRmks { get; set; }

    public int? FfsaCreatedBy { get; set; }

    public int? FfsaEditedBy { get; set; }

    public DateTime? FfsaCreationDate { get; set; }

    public DateTime? FfsaEditedDate { get; set; }
}
