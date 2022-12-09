using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompPartCapacity
{
    public int FcpcIdpk { get; set; }

    public int? FcpcCompIdfk { get; set; }

    public int? FcpcPartCapIdfk { get; set; }

    public int? FcpcBusSectorIdfk { get; set; }

    public DateTime? FcpcStartDate { get; set; }

    public DateTime? FcpcEndDate { get; set; }

    public string? FcpcRmks { get; set; }

    public bool? FcpcActive { get; set; }

    public int? FcpcCreatedBy { get; set; }

    public int? FcpcEditedBy { get; set; }

    public DateTime? FcpcCreationDate { get; set; }

    public DateTime? FcpcEditedDate { get; set; }
}
