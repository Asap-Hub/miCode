using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOperatorHomeStation
{
    public int OhaIdpk { get; set; }

    public string? OhaOprIdfk { get; set; }

    public string? OhaSstIdfk { get; set; }

    public bool? OhaActive { get; set; }

    public string? OhaRmks { get; set; }

    public int? OhaCreatedBy { get; set; }

    public int? OhaEditedBy { get; set; }

    public DateTime? OhaCreationDate { get; set; }

    public DateTime? OhaEditedDate { get; set; }
}
