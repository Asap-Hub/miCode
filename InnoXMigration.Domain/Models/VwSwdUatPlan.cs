using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatPlan
{
    public int UpnIdpk { get; set; }

    public int? UpnProjectIdfk { get; set; }

    public string? UpnTitle { get; set; }

    public string? UpnDescription { get; set; }

    public string? UpnResponsibility { get; set; }

    public DateTime? UpnStartDate { get; set; }

    public DateTime? UpnEndDate { get; set; }

    public bool? UpnActive { get; set; }

    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public string UpnRmks { get; set; } = null!;
}
