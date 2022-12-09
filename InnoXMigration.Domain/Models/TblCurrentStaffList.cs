using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblCurrentStaffList
{
    public string? StaffNo { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public string? Location { get; set; }

    public string? Title { get; set; }

    public string? Job { get; set; }

    public string? HireDate { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Grade { get; set; }

    public string? Step { get; set; }

    public string? CostCenter { get; set; }

    public string? SsNumber { get; set; }

    public string? PersonType { get; set; }

    public string? AssignmentStatus { get; set; }

    public string? AssignmentCategory { get; set; }

    public string? AnnualSalary { get; set; }

    public string? Sex { get; set; }

    public string? Nationality { get; set; }

    public string? MaritalStatus { get; set; }

    public string? SupervisorName { get; set; }

    public string PAsOfDate { get; set; } = null!;
}
