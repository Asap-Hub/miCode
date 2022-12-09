using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgCoreValue
{
    public int CvlIdpk { get; set; }

    public string? CvlMissionIdfk { get; set; }

    public string? CvlCategory { get; set; }

    public string? CvlCoreValue { get; set; }

    public string? CvlShtCoreValue { get; set; }

    public int? CvlDeptIdfk { get; set; }

    public int? CvlSectionIdfk { get; set; }

    public int? CvlUnitIdfk { get; set; }

    public DateTime? CvlStartDate { get; set; }

    public DateTime? CvlEndDate { get; set; }

    public int? CvlOrder { get; set; }

    public bool? CvlActive { get; set; }

    public string? CvlRmks { get; set; }

    public string? CvlCreatedBy { get; set; }

    public int? CvlEditedBy { get; set; }

    public DateTime? CvlCreationDate { get; set; }

    public DateTime? CvlEditedDate { get; set; }
}
