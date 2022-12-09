using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstHouseNumber
{
    public int HnoIdpk { get; set; }

    public string? HnoName { get; set; }

    public string? HnoShtName { get; set; }

    public int? HnoBlockIdfk { get; set; }

    public bool? HnoSecurityPost { get; set; }

    public bool? HnoCanteen { get; set; }

    public bool? HnoOffice { get; set; }

    public bool? HnoConferenceRoom { get; set; }

    public bool? HnoResidence { get; set; }

    public bool? HnoActive { get; set; }

    public string? HnoRmks { get; set; }

    public int? HnoCreatedBy { get; set; }

    public int? HnoEditedBy { get; set; }

    public DateTime? HnoCreationDate { get; set; }

    public DateTime? HnoEditedDate { get; set; }
}
