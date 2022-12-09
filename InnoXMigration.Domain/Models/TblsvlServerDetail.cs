using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlServerDetail
{
    public int SvdIdpk { get; set; }

    public int? SvdServerIdfk { get; set; }

    public int? SvdLocationIdfk { get; set; }

    public DateTime? SvdDate { get; set; }

    public string? SvdIp { get; set; }

    public bool? SvdActive { get; set; }

    public string? SvdRmks { get; set; }

    public int? SvdCreatedBy { get; set; }

    public int? SvdEditedBy { get; set; }

    public DateTime? SvdCreationDate { get; set; }

    public DateTime? SvdEditedDate { get; set; }
}
