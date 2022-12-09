using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgMeetingDetail
{
    public int MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public int? MtdAssociationIdfk { get; set; }

    public string? MtdAgenda { get; set; }

    public DateTime? MtdStartTime { get; set; }

    public DateTime? MtdEndTime { get; set; }

    public string? MtdSecretary { get; set; }

    public string? MtdChairman { get; set; }

    public string? MtdWhy { get; set; }

    public bool? MtdActive { get; set; }

    public string? MtdRmks { get; set; }

    public int? MtdCreatedBy { get; set; }

    public int? MtdEditedBy { get; set; }

    public DateTime? MtdCreationDate { get; set; }

    public DateTime? MtdEditedDate { get; set; }
}
