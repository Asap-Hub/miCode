using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenHotel
{
    public int HtlIdpk { get; set; }

    public string? HtlName { get; set; }

    public string? HtlShtName { get; set; }

    public int? HtlOrgLocationIdfk { get; set; }

    public int? HtlTrekkingLocationIdfk { get; set; }

    public int? HtlTownIdfk { get; set; }

    public bool? HtlHotel { get; set; }

    public bool? HtlGuestHouse { get; set; }

    public byte? HtlRatedStars { get; set; }

    public string? HtlContactDetails { get; set; }

    public short? HtlNoOfRooms { get; set; }

    public bool? HtlConferenceFacility { get; set; }

    public string? HtlCompany { get; set; }

    public string? HtlCategory { get; set; }

    public bool? HtlActive { get; set; }

    public string? HtlRmks { get; set; }

    public string? HtlCreatedBy { get; set; }

    public int? HtlEditedBy { get; set; }

    public DateTime? HtlCreationDate { get; set; }

    public DateTime? HtlEditedDate { get; set; }
}
