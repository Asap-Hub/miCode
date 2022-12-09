using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraFndUser
{
    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? LastUpdateLogin { get; set; }

    public string? EncryptedFoundationPassword { get; set; }

    public string? EncryptedUserPassword { get; set; }

    public string? SessionNumber { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Description { get; set; }

    public string? LastLogonDate { get; set; }

    public string? PasswordDate { get; set; }

    public string? PasswordAccessesLeft { get; set; }

    public string? PasswordLifespanAccesses { get; set; }

    public string? PasswordLifespanDays { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmailAddress { get; set; }

    public string? SupplierId { get; set; }

    public string? WebPassword { get; set; }

    public string? UserGuid { get; set; }

    public string? GcnCodeCombinationId { get; set; }

    public string? PersonPartyId { get; set; }
}
