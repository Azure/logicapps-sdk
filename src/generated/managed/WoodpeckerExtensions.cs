//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Woodpecker
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WoodpeckerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "woodpecker")]
        public IBodyWorkflowAction<ProspectsGetResponseItem[]> ProspectsGet(Expression<Func<string>> search = null, Expression<Func<string>> activity = null, Expression<Func<string>> campaignId = null, Expression<Func<bool>> campaignsDetail = null, Expression<Func<sortInput>> sort = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/prospects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (activity != null)
                callPayload.Queries["activity"] = ExpressionConverter.Convert(activity);
            if (campaignId != null)
                callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(campaignId);
            if (campaignsDetail != null)
                callPayload.Queries["campaigns_detail"] = ExpressionConverter.Convert(campaignsDetail);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<ProspectsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "woodpecker")]
        public IBodyWorkflowAction<string> ProspectsDelete(Expression<Func<int>> id = null, Expression<Func<int>> campaignsId = null)
        {
            var apiCallPath = "/prospects";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (campaignsId != null)
                callPayload.Queries["campaigns_id"] = ExpressionConverter.Convert(campaignsId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "woodpecker")]
        public IBodyWorkflowAction<ProspectsPostResponse> Prospects(Expression<Func<bodyupdateInput>> bodyupdate = null, Expression<Func<bodyforceInput>> bodyforce = null, Expression<Func<bodyprospectsInputItem[]>> bodyprospects = null)
        {
            var apiCallPath = "/add_prospects_list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyupdate != null)
            {
                body["update"] = ExpressionConverter.ConvertO(bodyupdate);
                bodypropCount++;
            }

            if (bodyforce != null)
            {
                body["force"] = ExpressionConverter.ConvertO(bodyforce);
                bodypropCount++;
            }

            if (bodyprospects != null)
            {
                body["prospects"] = ExpressionConverter.ConvertO(bodyprospects);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProspectsPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "woodpecker")]
        public IBodyWorkflowAction<ProspectsCampaignPostResponse> ProspectsCampaign(Expression<Func<int>> bodycampaigncampaignId = null, Expression<Func<bodyupdateInput>> bodyupdate = null, Expression<Func<bodyforceInput>> bodyforce = null, Expression<Func<bodyprospectsInputItem2[]>> bodyprospects = null)
        {
            var apiCallPath = "/add_prospects_campaign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var campaignObject = new JObject();
            var campaignObjectpropCount = 0;
            if (bodycampaigncampaignId != null)
            {
                campaignObject["campaign_id"] = ExpressionConverter.ConvertO(bodycampaigncampaignId);
                campaignObjectpropCount++;
            }

            if (campaignObjectpropCount > 0)
            {
                body["campaign"] = campaignObject;
                bodypropCount++;
            }

            if (bodyupdate != null)
            {
                body["update"] = ExpressionConverter.ConvertO(bodyupdate);
                bodypropCount++;
            }

            if (bodyforce != null)
            {
                body["force"] = ExpressionConverter.ConvertO(bodyforce);
                bodypropCount++;
            }

            if (bodyprospects != null)
            {
                body["prospects"] = ExpressionConverter.ConvertO(bodyprospects);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProspectsCampaignPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "woodpecker")]
        public IBodyWorkflowAction<CampaignsGetResponseItem[]> CampaignsGet(Expression<Func<statusInput>> status = null, Expression<Func<int>> id = null)
        {
            var apiCallPath = "/campaign_list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<CampaignsGetResponseItem[]>(callPayload);
        }
    }

    public class WoodpeckerTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProspectsGetResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("last_contacted")]
        public string LastContacted { get; set; }

        [JsonProperty("last_replied")]
        public string LastReplied { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("encrypted")]
        public bool Encrypted { get; set; }

        [JsonProperty("snipet1")]
        public string Snipet1 { get; set; }

        [JsonProperty("snipet2")]
        public string Snipet2 { get; set; }

        [JsonProperty("snipet3")]
        public string Snipet3 { get; set; }

        [JsonProperty("snipet4")]
        public string Snipet4 { get; set; }

        [JsonProperty("snippet1")]
        public string Snippet1 { get; set; }

        [JsonProperty("snippet2")]
        public string Snippet2 { get; set; }

        [JsonProperty("snippet3")]
        public string Snippet3 { get; set; }

        [JsonProperty("snippet4")]
        public string Snippet4 { get; set; }

        [JsonProperty("snippet5")]
        public string Snippet5 { get; set; }

        [JsonProperty("snippet6")]
        public string Snippet6 { get; set; }

        [JsonProperty("snippet7")]
        public string Snippet7 { get; set; }

        [JsonProperty("snippet8")]
        public string Snippet8 { get; set; }

        [JsonProperty("snipper9")]
        public string Snipper9 { get; set; }

        [JsonProperty("snippet10")]
        public string Snippet10 { get; set; }

        [JsonProperty("snippet11")]
        public string Snippet11 { get; set; }

        [JsonProperty("snippet12")]
        public string Snippet12 { get; set; }

        [JsonProperty("snippet13")]
        public string Snippet13 { get; set; }

        [JsonProperty("snippet14")]
        public string Snippet14 { get; set; }

        [JsonProperty("snippet15")]
        public string Snippet15 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("campaigns_details")]
        public ProspectsGetResponseItemCampaignsDetailsTypeItem[] CampaignsDetails { get; set; }
    }

    public class ProspectsGetResponseItemCampaignsDetailsTypeItem
    {
        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("campaign_status")]
        public string CampaignStatus { get; set; }

        [JsonProperty("campaign_prospect_status")]
        public string CampaignProspectStatus { get; set; }

        [JsonProperty("interested")]
        public string Interested { get; set; }

        [JsonProperty("campaign_email")]
        public string CampaignEmail { get; set; }
    }

    public enum sortInput
    {
        [EnumMember(Value = "+id")]
        ID,
        [EnumMember(Value = "+email")]
        Email,
        [EnumMember(Value = "+first_name")]
        FirstName,
        [EnumMember(Value = "+last_name")]
        LastName,
        [EnumMember(Value = "+company")]
        Company,
        [EnumMember(Value = "+organization_id")]
        OrganizationID,
        [EnumMember(Value = "+industry")]
        Industry,
        [EnumMember(Value = "+website")]
        Website,
        [EnumMember(Value = "+linkedin_url")]
        LinkedInURL,
        [EnumMember(Value = "+tags")]
        Tags,
        [EnumMember(Value = "+title")]
        Title,
        [EnumMember(Value = "+phone")]
        Phone,
        [EnumMember(Value = "+address")]
        Address,
        [EnumMember(Value = "+city")]
        City,
        [EnumMember(Value = "+state")]
        State,
        [EnumMember(Value = "+country")]
        Country,
        [EnumMember(Value = "+last_contacted")]
        LastContacted,
        [EnumMember(Value = "+last_replied")]
        LastReplied,
        [EnumMember(Value = "+updated")]
        Updated,
        [EnumMember(Value = "+status")]
        Status,
        [EnumMember(Value = "-id")]
        IDDescending,
        [EnumMember(Value = "-email")]
        EmailDescending,
        [EnumMember(Value = "-first_name")]
        FirstNameDescending,
        [EnumMember(Value = "-last_name")]
        LastNameDescending,
        [EnumMember(Value = "-company")]
        CompanyDescending,
        [EnumMember(Value = "-organization_id")]
        OrganizationIDDescending,
        [EnumMember(Value = "-industry")]
        IndustryDescending,
        [EnumMember(Value = "-website")]
        WebsiteDescending,
        [EnumMember(Value = "-linkedin_url")]
        LinkedInURLDescending,
        [EnumMember(Value = "-tags")]
        TagsDescending,
        [EnumMember(Value = "-title")]
        TitleDescending,
        [EnumMember(Value = "-phone")]
        PhoneDescending,
        [EnumMember(Value = "-address")]
        AddressDescending,
        [EnumMember(Value = "-city")]
        CityDescending,
        [EnumMember(Value = "-state")]
        StateDescending,
        [EnumMember(Value = "-country")]
        CountryDescending,
        [EnumMember(Value = "-last_contacted")]
        LastContactedDescending,
        [EnumMember(Value = "-last_replied")]
        LastRepliedDescending,
        [EnumMember(Value = "-updated")]
        UpdatedDescending,
        [EnumMember(Value = "-status")]
        StatusDescending
    }

    public enum statusInput
    {
        RUNNING,
        DRAFT,
        EDITED,
        PAUSED,
        STOPPED,
        COMPLETED,
        DELETED
    }

    public class ProspectsPostResponse
    {
        [JsonProperty("prospects")]
        public ProspectsPostResponseProspectsTypeItem[] Prospects { get; set; }

        [JsonProperty("status")]
        public ProspectsPostResponseStatusType Status { get; set; }
    }

    public class ProspectsPostResponseProspectsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ProspectsPostResponseStatusType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }

    public enum bodyupdateInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum bodyforceInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class bodyprospectsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("snippet1")]
        public string Snippet1 { get; set; }

        [JsonProperty("snippet2")]
        public string Snippet2 { get; set; }

        [JsonProperty("snippet3")]
        public string Snippet3 { get; set; }

        [JsonProperty("snippet4")]
        public string Snippet4 { get; set; }

        [JsonProperty("snippet5")]
        public string Snippet5 { get; set; }

        [JsonProperty("snippet6")]
        public string Snippet6 { get; set; }

        [JsonProperty("snippet7")]
        public string Snippet7 { get; set; }

        [JsonProperty("snippet8")]
        public string Snippet8 { get; set; }

        [JsonProperty("snippet9")]
        public string Snippet9 { get; set; }

        [JsonProperty("snippet10")]
        public string Snippet10 { get; set; }

        [JsonProperty("snippet11")]
        public string Snippet11 { get; set; }

        [JsonProperty("snippet12")]
        public string Snippet12 { get; set; }

        [JsonProperty("snippet13")]
        public string Snippet13 { get; set; }

        [JsonProperty("snippet14")]
        public string Snippet14 { get; set; }

        [JsonProperty("snippet15")]
        public string Snippet15 { get; set; }
    }

    public class ProspectsCampaignPostResponse
    {
        [JsonProperty("prospects")]
        public ProspectsCampaignPostResponseProspectsTypeItem[] Prospects { get; set; }

        [JsonProperty("status")]
        public ProspectsCampaignPostResponseStatusType Status { get; set; }
    }

    public class ProspectsCampaignPostResponseProspectsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ProspectsCampaignPostResponseStatusType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }

    public class bodyprospectsInputItem2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("snippet1")]
        public string Snippet1 { get; set; }

        [JsonProperty("snippet2")]
        public string Snippet2 { get; set; }

        [JsonProperty("snippet3")]
        public string Snippet3 { get; set; }

        [JsonProperty("snippet4")]
        public string Snippet4 { get; set; }

        [JsonProperty("snippet5")]
        public string Snippet5 { get; set; }

        [JsonProperty("snippet6")]
        public string Snippet6 { get; set; }

        [JsonProperty("snippet7")]
        public string Snippet7 { get; set; }

        [JsonProperty("snippet8")]
        public string Snippet8 { get; set; }

        [JsonProperty("snipper9")]
        public string Snipper9 { get; set; }

        [JsonProperty("snippet10")]
        public string Snippet10 { get; set; }

        [JsonProperty("snippet11")]
        public string Snippet11 { get; set; }

        [JsonProperty("snippet12")]
        public string Snippet12 { get; set; }

        [JsonProperty("snippet13")]
        public string Snippet13 { get; set; }

        [JsonProperty("snippet14")]
        public string Snippet14 { get; set; }

        [JsonProperty("snippet15")]
        public string Snippet15 { get; set; }
    }

    public class CampaignsGetResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("gdpr_unsubscribe")]
        public bool GdprUnsubscribe { get; set; }

        [JsonProperty("folder_name")]
        public string FolderName { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("per_day")]
        public int PerDay { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("stats")]
        public CampaignsGetResponseItemStatsType Stats { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class CampaignsGetResponseItemStatsType
    {
        [JsonProperty("interested")]
        public int Interested { get; set; }

        [JsonProperty("not_interested")]
        public int NotInterested { get; set; }

        [JsonProperty("maybe_later")]
        public int MaybeLater { get; set; }

        [JsonProperty("replied")]
        public int Replied { get; set; }

        [JsonProperty("autoreplied")]
        public int Autoreplied { get; set; }

        [JsonProperty("bounced")]
        public int Bounced { get; set; }

        [JsonProperty("check")]
        public int Check { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("delivery")]
        public int Delivery { get; set; }

        [JsonProperty("invalid")]
        public int Invalid { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("prospects")]
        public int Prospects { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("optout")]
        public int Optout { get; set; }

        [JsonProperty("emails")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItem[] Emails { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItem
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("use_prospect_timezone")]
        public string UseProspectTimezone { get; set; }

        [JsonProperty("sunFrom")]
        public int SunFrom { get; set; }

        [JsonProperty("sunTo")]
        public int SunTo { get; set; }

        [JsonProperty("monFrom")]
        public int MonFrom { get; set; }

        [JsonProperty("monTo")]
        public int MonTo { get; set; }

        [JsonProperty("tueFrom")]
        public int TueFrom { get; set; }

        [JsonProperty("tueTo")]
        public int TueTo { get; set; }

        [JsonProperty("wedFrom")]
        public int WedFrom { get; set; }

        [JsonProperty("wedTo")]
        public int WedTo { get; set; }

        [JsonProperty("thuFrom")]
        public int ThuFrom { get; set; }

        [JsonProperty("thuTo")]
        public int ThuTo { get; set; }

        [JsonProperty("friFrom")]
        public int FriFrom { get; set; }

        [JsonProperty("friTo")]
        public int FriTo { get; set; }

        [JsonProperty("satFrom")]
        public int SatFrom { get; set; }

        [JsonProperty("satTo")]
        public int SatTo { get; set; }

        [JsonProperty("sunday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemSundayTypeItem[] Sunday { get; set; }

        [JsonProperty("monday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemMondayTypeItem[] Monday { get; set; }

        [JsonProperty("tuesday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemTuesdayTypeItem[] Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemWednesdayTypeItem[] Wednesday { get; set; }

        [JsonProperty("thursday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemThursdayTypeItem[] Thursday { get; set; }

        [JsonProperty("friday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemFridayTypeItem[] Friday { get; set; }

        [JsonProperty("saturday")]
        public CampaignsGetResponseItemStatsTypeEmailsTypeItemSaturdayTypeItem[] Saturday { get; set; }

        [JsonProperty("track_open")]
        public bool TrackOpen { get; set; }

        [JsonProperty("track_click")]
        public bool TrackClick { get; set; }

        [JsonProperty("attach_follow")]
        public bool AttachFollow { get; set; }

        [JsonProperty("follow_up")]
        public int FollowUp { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }

        [JsonProperty("emailSend")]
        public int EmailSend { get; set; }

        [JsonProperty("toSend")]
        public int ToSend { get; set; }

        [JsonProperty("delivery")]
        public int Delivery { get; set; }

        [JsonProperty("open")]
        public int Open { get; set; }

        [JsonProperty("reply")]
        public int Reply { get; set; }

        [JsonProperty("invalid")]
        public int Invalid { get; set; }

        [JsonProperty("bounce")]
        public int Bounce { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemSundayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemMondayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemTuesdayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemWednesdayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemThursdayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemFridayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }

    public class CampaignsGetResponseItemStatsTypeEmailsTypeItemSaturdayTypeItem
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Woodpecker;

    public partial class WorkflowManagedActions
    {
        public WoodpeckerActions Woodpecker(string connectionId) => new WoodpeckerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WoodpeckerTriggers Woodpecker(string connectionId) => new WoodpeckerTriggers(connectionId);
    }
}