using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDocClass
{
    public int DcsIdpk { get; set; }

    public string? DcsName { get; set; }

    public string? DcsShtname { get; set; }

    public string? DcsCode { get; set; }

    public bool? DcsActive { get; set; }

    public string? DcsRmks { get; set; }

    public int? DcsCreatedBy { get; set; }

    public int? DcsEditedBy { get; set; }

    public DateTime? DcsCreationDate { get; set; }

    public DateTime? DcsEditedDate { get; set; }
}
