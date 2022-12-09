using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbOrderToOperate
{
    public int OtoIdpk { get; set; }

    public int? OtoGuaranteeApplicationIdfk { get; set; }

    public int? OtoPreparedByEmpIdfk { get; set; }

    public string? OtoPreparedBy { get; set; }

    public int? OtoCheckedByEmpIdfk { get; set; }

    public string? OtoCheckedBy { get; set; }

    public int? OtoOrderedBempIdfk { get; set; }

    public int PgtIdpk { get; set; }

    public string? PgtName { get; set; }

    public string? PgtShtName { get; set; }

    public bool? PgtWorkPermit { get; set; }

    public bool? PgtWorkAndTestPermit { get; set; }

    public bool? PgtStationGuarantee { get; set; }

    public string? PgaRequestNo { get; set; }

    public bool PgaEmergency { get; set; }

    public string? OtoOrderedBy { get; set; }

    public int? OtoCompletedByEmpIdfk { get; set; }

    public string? OtoCompletedBy { get; set; }

    public int? OtoProtectionGuaranteeIdfk { get; set; }

    public int? OtoMimicBoardChangedByEmpIdfk { get; set; }

    public string? OtoMimicBoardChangedBy { get; set; }

    public string? OtoPurposeOfOrder { get; set; }

    public DateTime? OtoPreparedOn { get; set; }

    public DateTime? OtoCheckedOn { get; set; }

    public DateTime? OtoOrderedOn { get; set; }

    public DateTime? OtoCompletedOn { get; set; }

    public DateTime? OtoMimicBoardChangedOn { get; set; }

    public bool? OtoActive { get; set; }

    public int PgaIdpk { get; set; }

    public int? OtoCreatedBy { get; set; }

    public int? OtoEditedBy { get; set; }

    public DateTime? OtoCreationDate { get; set; }

    public DateTime? OtoEditedDate { get; set; }

    public string? PgtCode { get; set; }
}
