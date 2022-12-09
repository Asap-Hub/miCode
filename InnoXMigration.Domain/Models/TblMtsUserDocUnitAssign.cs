using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsUserDocUnitAssign
{
    public int UdaIdpk { get; set; }

    public int? UdaUserIdfk { get; set; }

    public int? UdaAssignUnitIdfk { get; set; }

    public DateTime? UdaDate { get; set; }

    public bool? UdaActive { get; set; }

    public string? UdaRmks { get; set; }

    public int? UdaCreatedBy { get; set; }

    public int? UdaEditedBy { get; set; }

    public DateTime? UdaCreationDate { get; set; }

    public DateTime? UdaEditedDate { get; set; }
}
