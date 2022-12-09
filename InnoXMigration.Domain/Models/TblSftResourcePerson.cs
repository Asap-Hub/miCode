using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftResourcePerson
{
    public int RspIdpk { get; set; }

    public int? RspEmpIdfk { get; set; }

    public string? RspResourcePerson { get; set; }

    public string? RspCompany { get; set; }

    public string? RspMobNo { get; set; }

    public string? RspAddress { get; set; }

    public bool? RspIsStaff { get; set; }

    public bool? RspActive { get; set; }

    public string? RspRmks { get; set; }

    public int? RspCreatedBy { get; set; }

    public int? RspEditedBy { get; set; }

    public DateTime? RspCreationDate { get; set; }

    public DateTime? RspEditedDate { get; set; }
}
