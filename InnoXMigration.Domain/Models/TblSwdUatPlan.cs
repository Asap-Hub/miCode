using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUatPlan
{
    public int UpnIdpk { get; set; }

    public int? UpnProjectIdfk { get; set; }

    public string? UpnTitle { get; set; }

    public string? UpnDescription { get; set; }

    public string? UpnResponsibility { get; set; }

    public DateTime? UpnStartDate { get; set; }

    public DateTime? UpnEndDate { get; set; }

    public string? UpnRmks { get; set; }

    public bool? UpnActive { get; set; }

    public int? UpnCreatedBy { get; set; }

    public DateTime? UpnCreationDate { get; set; }

    public int? UpnEditedBy { get; set; }

    public DateTime? UpnEditedDate { get; set; }
}
