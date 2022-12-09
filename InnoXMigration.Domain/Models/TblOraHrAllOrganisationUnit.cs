using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraHrAllOrganisationUnit
{
    public int Idpk { get; set; }

    public string? OrganizationId { get; set; }

    public string? BusinessGroupId { get; set; }

    public string? CostAllocationKeyflexId { get; set; }

    public string? LocationId { get; set; }

    public string? SoftCodingKeyflexId { get; set; }

    public string? DateFrom { get; set; }

    public string? Comments { get; set; }

    public string? DateTo { get; set; }

    public string? InternalExternalFlag { get; set; }

    public string? InternalAddressLine { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? DeptCode { get; set; }

    public string? SectionCode { get; set; }

    public string? UnitCode { get; set; }

    public string? OrgUnitName { get; set; }

    public string? RequestId { get; set; }

    public string? ProgramApplicationId { get; set; }

    public string? ProgramId { get; set; }

    public string? ProgramUpdateDate { get; set; }

    public string? AttributeCategory { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdateLogin { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreationDate { get; set; }

    public string? ObjectVersionNumber { get; set; }
}
