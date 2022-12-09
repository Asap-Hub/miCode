using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstContractor
{
    public int CtrIdpk { get; set; }

    public string? CtrName { get; set; }

    public string? CtrShtName { get; set; }

    public string? CtrContact { get; set; }

    public string? CtrProfession { get; set; }

    public string? CtrTelNo { get; set; }

    public string? CtrMobNos { get; set; }

    public string? CtrAddress { get; set; }

    public string? CtrEmail { get; set; }

    public int? CtrLocIdfk { get; set; }

    public int? CtrTownIdfk { get; set; }

    public bool? CtrActive { get; set; }

    public bool? CtrWardsman { get; set; }

    public string? CtrRmks { get; set; }

    public int? CtrCreatedBy { get; set; }

    public int? CtrEditedBy { get; set; }

    public DateTime? CtrCreationDate { get; set; }

    public DateTime? CtrEditedDate { get; set; }
}
