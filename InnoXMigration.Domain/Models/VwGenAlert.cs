using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenAlert
{
    public int AltIdpk { get; set; }

    public int? AltEmpIdfk { get; set; }

    public int? AltCreatedBy { get; set; }

    public int? UsaIdpk { get; set; }

    public string? AltFormCode { get; set; }

    public string? AltMessage { get; set; }

    public bool? AltTakeAction { get; set; }

    public DateTime? AltCreationDate { get; set; }

    public int? AltEditedBy { get; set; }

    public DateTime? AltEditedDate { get; set; }

    public int? AfmIdpk { get; set; }

    public string? AfmName { get; set; }

    public string? AfmType { get; set; }

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public string? ApmCode { get; set; }

    public string? AfmCode { get; set; }

    public byte? ApmOrder { get; set; }

    public int RecipientEmpId { get; set; }

    public string RecipientStaffNo { get; set; } = null!;

    public string RecipientLname { get; set; } = null!;

    public string RecipientFname { get; set; } = null!;

    public string RecipientOnames { get; set; } = null!;

    public string RecipientEmpName { get; set; } = null!;

    public string RecipientEmpName1 { get; set; } = null!;

    public string RecipientEmpName2 { get; set; } = null!;

    public string RecipientEmpName3 { get; set; } = null!;

    public string RecipientEmpName4 { get; set; } = null!;

    public short RecipientGndIdfk { get; set; }

    public string RecipientGndName { get; set; } = null!;

    public string RecipientGndShtName { get; set; } = null!;

    public int RecipientDptIdfk { get; set; }

    public string RecipientDptName { get; set; } = null!;

    public string RecipientDptShtName { get; set; } = null!;

    public int RecipientSxnIdfk { get; set; }

    public string RecipientSxnName { get; set; } = null!;

    public string RecipientSxnShtName { get; set; } = null!;

    public int RecipientUntIdfk { get; set; }

    public string RecipientUntName { get; set; } = null!;

    public string RecipientUntShtName { get; set; } = null!;

    public int RecipientLocIdfk { get; set; }

    public string RecipientLocName { get; set; } = null!;

    public string RecipientLocShtName { get; set; } = null!;

    public string RecipientEmpTelNo { get; set; } = null!;

    public string RecipientEmpMobNo { get; set; } = null!;

    public string Empintercom { get; set; } = null!;

    public string RecipientEmailOff { get; set; } = null!;

    public string RecipientEmailPers { get; set; } = null!;

    public int RecipientJbtIdfk { get; set; }

    public string RecipientJbtName { get; set; } = null!;

    public string RecipientJbtShtName { get; set; } = null!;

    public bool RecipientHideMobNo { get; set; }

    public string RecipientMobNox { get; set; } = null!;

    public bool RecipientIsStaff { get; set; }

    public bool RecipientIsSeniorStaff { get; set; }

    public bool RecipientIsJuniorStaff { get; set; }

    public bool RecipientIsManagementStaff { get; set; }

    public bool RecipientIsServicePerson { get; set; }

    public int CreatedByEmpId { get; set; }

    public string CreatedByStaffNo { get; set; } = null!;

    public string CreatedByLname { get; set; } = null!;

    public string CreatedByFname { get; set; } = null!;

    public string CreatedByOnames { get; set; } = null!;

    public string CreatedByEmpName { get; set; } = null!;

    public string CreatedByEmpName1 { get; set; } = null!;

    public string CreatedByEmpName2 { get; set; } = null!;

    public string CreatedByEmpName3 { get; set; } = null!;

    public string CreatedByEmpName4 { get; set; } = null!;

    public string CreatedByEmpName5 { get; set; } = null!;

    public short CreatedByGndIdfk { get; set; }

    public string CreatedByGndName { get; set; } = null!;

    public string CreatedByGndShtName { get; set; } = null!;

    public int CreatedByDptIdfk { get; set; }

    public string CreatedByDptName { get; set; } = null!;

    public string CreatedByDptShtName { get; set; } = null!;

    public int CreatedBySxnIdfk { get; set; }

    public string CreatedBySxnName { get; set; } = null!;

    public string CreatedBySxnShtName { get; set; } = null!;

    public int CreatedByUntIdfk { get; set; }

    public string CreatedByUntName { get; set; } = null!;

    public string CreatedByUntShtName { get; set; } = null!;

    public int CreatedByLocIdfk { get; set; }

    public string CreatedByLocName { get; set; } = null!;

    public string CreatedByLocShtName { get; set; } = null!;

    public string CreatedByEmpTelNo { get; set; } = null!;

    public string CreatedByEmpMobNo { get; set; } = null!;

    public string CreatedByIntercom { get; set; } = null!;

    public string CreatedByEmailOff { get; set; } = null!;

    public string CreatedByEmailPers { get; set; } = null!;

    public int CreatedByJbtIdfk { get; set; }

    public string CreatedByJbtName { get; set; } = null!;

    public string CreatedByJbtShtName { get; set; } = null!;

    public bool CreatedByHideMobNo { get; set; }

    public string CreatedByMobNox { get; set; } = null!;

    public bool CreatedByIsStaff { get; set; }

    public bool CreatedByIsSeniorStaff { get; set; }

    public bool CreatedByIsJuniorStaff { get; set; }

    public bool CreatedByIsManagementStaff { get; set; }

    public bool CreatedByIsServicePerson { get; set; }

    public bool? AltSeen { get; set; }
}
