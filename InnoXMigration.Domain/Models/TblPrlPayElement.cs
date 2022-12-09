using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlPayElement
{
    public int PelIdpk { get; set; }

    public string? PelName { get; set; }

    public string? PelShtName { get; set; }

    public bool? PelEarning { get; set; }

    public bool? PelDeduction { get; set; }

    public bool? PelOvertime { get; set; }

    public bool? PelCummulative { get; set; }

    public bool? PelBalance { get; set; }

    public bool? PelRetroPay { get; set; }

    public bool? PelActive { get; set; }

    public string? PelRmks { get; set; }

    public int? PelCreatedBy { get; set; }

    public int? PelEditedBy { get; set; }

    public DateTime? PelCreationDate { get; set; }

    public DateTime? PelEditedDate { get; set; }
}
