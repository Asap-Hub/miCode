using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftCompulsorySafetyTopic
{
    public int CstIdpk { get; set; }

    public int? CstSafetyGroupIdfk { get; set; }

    public int? CstSafetyTopicIdfk { get; set; }

    public int? CstMeetingCalendarIdfk { get; set; }

    public string? CstResourcePersons { get; set; }

    public byte? CstCompulsoryNo { get; set; }

    public bool? CstApproved { get; set; }

    public bool? CstTreated { get; set; }

    public bool? CstActive { get; set; }

    public string? CstRmks { get; set; }

    public int? CstCreatedBy { get; set; }

    public int? CstEditedBy { get; set; }

    public DateTime? CstCreationDate { get; set; }

    public DateTime? CstEditedDate { get; set; }
}
