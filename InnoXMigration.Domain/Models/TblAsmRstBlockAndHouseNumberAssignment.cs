using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstBlockAndHouseNumberAssignment
{
    public int BhaIdpk { get; set; }

    public DateTime? BhaDate { get; set; }

    public int? BhaBlockIdfk { get; set; }

    public int? BhaHouseNoIdfk { get; set; }

    public bool? BhaCanteen { get; set; }

    public bool? BhaSecurityPost { get; set; }

    public bool? BhaConferenceRoom { get; set; }

    public bool? BhaOffice { get; set; }

    public bool? BhaResidence { get; set; }

    public bool? BhaActive { get; set; }

    public string? BhaRmks { get; set; }

    public string? BhaCreatedBy { get; set; }

    public int? BhaEditedBy { get; set; }

    public DateTime? BhaCreationDate { get; set; }

    public DateTime? BhaEditedDate { get; set; }
}
