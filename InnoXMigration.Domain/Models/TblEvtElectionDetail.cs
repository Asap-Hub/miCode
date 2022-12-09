using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblEvtElectionDetail
{
    public int EdtIdpk { get; set; }

    public string? EdtName { get; set; }

    public string? EdtShtName { get; set; }

    public DateTime? EdtVotingStartTime { get; set; }

    public DateTime? EdtVotingEndTime { get; set; }

    public DateTime? EdtCampaignStartTime { get; set; }

    public DateTime? EdtCampaignEndTime { get; set; }

    public int? EdtElectionTypeIdfk { get; set; }

    public string? EdtAdministrators { get; set; }

    public bool? EdtActive { get; set; }

    public string? EdtRmks { get; set; }

    public int? EdtCreatedBy { get; set; }

    public int? EdtEditedBy { get; set; }

    public DateTime? EdtCreationDate { get; set; }

    public DateTime? EdtEditedDate { get; set; }
}
