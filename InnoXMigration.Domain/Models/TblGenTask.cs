using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTask
{
    public int TskIdpk { get; set; }

    public DateTime? TskStartDate { get; set; }

    public DateTime? TskDueDate { get; set; }

    public DateTime? TskUpdateDate { get; set; }

    public DateTime? TskCompletionDate { get; set; }

    public decimal? TskInitialPercentComplete { get; set; }

    public decimal? TskPercentComplete { get; set; }

    public int? TskAssignedByEmpIdfk { get; set; }

    public string? TskAssignedBy { get; set; }

    public string? TskAssignedTo { get; set; }

    public string? TskProgressActivities { get; set; }

    public int? TskStatusIdfk { get; set; }

    public int? TskPriorityIdfk { get; set; }

    public string? TskObjectiveCriteria { get; set; }

    public int? TskObjectiveIdfk { get; set; }

    public string? TskObjective { get; set; }

    public string? TskInitiative { get; set; }

    public int? TskInitiativeIdfk { get; set; }

    public string? TskSubject { get; set; }

    public string? TskTask { get; set; }

    public bool? TskScoring { get; set; }

    public decimal? TskEffectiveCommunication { get; set; }

    public decimal? TskTimelyUpdates { get; set; }

    public decimal? TskTimelyCompletionOfTask { get; set; }

    public decimal? TskQualityOfDelivery { get; set; }

    public bool? TskSatisfied { get; set; }

    public bool? TskActive { get; set; }

    public string? TskRmks { get; set; }

    public string? TskRatingRmks { get; set; }

    public int? TskCreatedBy { get; set; }

    public int? TskEditedBy { get; set; }

    public DateTime? TskCreationDate { get; set; }

    public DateTime? TskEditedDate { get; set; }
}
