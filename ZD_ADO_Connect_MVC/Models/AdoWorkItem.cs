using System;
using System.Collections.Generic;

namespace ZdAdoConnectorMvc.Models
{
    public class AdoWorkItem
    {
        public long Id { get; set; }
        public long Rev { get; set; }
        public Dictionary<string, string> Fields { get; set; }
        public CommentVersionRef CommentVersionRef { get; set; }
        public AdoResponseLinks Links { get; set; }
        public Uri Url { get; set; }
    }

    public class CommentVersionRef
    {
        public long CommentId { get; set; }
        public long Version { get; set; }
        public Uri Url { get; set; }
        public bool IsDeleted { get; set; }
        public string Text { get; set; }
        public object CreatedInRevision { get; set; }
    }

    public class PurpleFields
    {
        public Uri Href { get; set; }
    }

    public class AdoResponseLinks
    {
        public PurpleFields Self { get; set; }
        public PurpleFields WorkItemUpdates { get; set; }
        public PurpleFields WorkItemRevisions { get; set; }
        public PurpleFields WorkItemComments { get; set; }
        public PurpleFields Html { get; set; }
        public PurpleFields WorkItemType { get; set; }
        public PurpleFields Fields { get; set; }
    }

    //public class Fields_OLD
    //{
    //    [JsonProperty("System.AreaPath")]
    //    public string SystemAreaPath { get; set; }

    //    [JsonProperty("System.TeamProject")]
    //    public string SystemTeamProject { get; set; }

    //    [JsonProperty("System.IterationPath")]
    //    public string SystemIterationPath { get; set; }

    //    [JsonProperty("System.WorkItemType")]
    //    public string SystemWorkItemType { get; set; }

    //    [JsonProperty("System.State")]
    //    public string SystemState { get; set; }

    //    [JsonProperty("System.Reason")]
    //    public string SystemReason { get; set; }

    //    [JsonProperty("System.CreatedDate")]
    //    public DateTimeOffset SystemCreatedDate { get; set; }

    //    [JsonProperty("System.CreatedBy")]
    //    public SystemCedBy SystemCreatedBy { get; set; }

    //    [JsonProperty("System.ChangedDate")]
    //    public DateTimeOffset SystemChangedDate { get; set; }

    //    [JsonProperty("System.ChangedBy")]
    //    public SystemCedBy SystemChangedBy { get; set; }

    //    [JsonProperty("System.CommentCount")]
    //    public long SystemCommentCount { get; set; }

    //    [JsonProperty("System.Title")]
    //    public string SystemTitle { get; set; }

    //    [JsonProperty("Microsoft.VSTS.Common.StateChangeDate")]
    //    public DateTimeOffset MicrosoftVstsCommonStateChangeDate { get; set; }

    //    [JsonProperty("Microsoft.VSTS.Common.Priority")]
    //    public long MicrosoftVstsCommonPriority { get; set; }

    //    [JsonProperty("Microsoft.VSTS.Common.Severity")]
    //    public string MicrosoftVstsCommonSeverity { get; set; }

    //    [JsonProperty("Microsoft.VSTS.Common.ValueArea")]
    //    public string MicrosoftVstsCommonValueArea { get; set; }

    //    [JsonProperty("System.History")]
    //    public string SystemHistory { get; set; }

    //    [JsonProperty("Microsoft.VSTS.TCM.SystemInfo")]
    //    public string MicrosoftVstsTcmSystemInfo { get; set; }

    //    [JsonProperty("Microsoft.VSTS.TCM.ReproSteps")]
    //    public string MicrosoftVstsTcmReproSteps { get; set; }
    //}

    //public class SystemCedBy
    //{
    //    [JsonProperty("displayName")]
    //    public string DisplayName { get; set; }

    //    [JsonProperty("url")]
    //    public Uri Url { get; set; }

    //    [JsonProperty("_links")]
    //    public SystemChangedByLinks Links { get; set; }

    //    [JsonProperty("id")]
    //    public Guid Id { get; set; }

    //    [JsonProperty("uniqueName")]
    //    public string UniqueName { get; set; }

    //    [JsonProperty("imageUrl")]
    //    public Uri ImageUrl { get; set; }

    //    [JsonProperty("descriptor")]
    //    public string Descriptor { get; set; }
    //}

    //public class SystemChangedByLinks
    //{
    //    [JsonProperty("avatar")]
    //    public PurpleFields Avatar { get; set; }
    //}
}
