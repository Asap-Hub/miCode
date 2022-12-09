using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbJobHazardAnalysis
{
    public int JhaIdpk { get; set; }

    public string? JhaPreparedByEmpIdfk { get; set; }

    public string? JhaPreparedBy { get; set; }

    public bool? JhaCheckedByEmpIdfk { get; set; }

    public bool? JhaActive { get; set; }

    public string? JhaRmks { get; set; }

    public int? JhaCreatedBy { get; set; }

    public int? JhaEditedBy { get; set; }

    public DateTime? JhaCreationDate { get; set; }

    public DateTime? JhaEditedDate { get; set; }
}
