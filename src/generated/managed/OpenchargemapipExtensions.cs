//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openchargemapip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenchargemapipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openchargemapip")]
        public IBodyWorkflowAction<POI[], ApiConnectionActionConfiguration> POIGet(Expression<Func<string>> client = null, Expression<Func<int>> maxresults = null, Expression<Func<string>> countrycode = null, Expression<Func<string[]>> countryid = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<double>> distance = null, Expression<Func<string>> distanceunit = null, Expression<Func<string[]>> operatorid = null, Expression<Func<string[]>> connectiontypeid = null, Expression<Func<string[]>> levelid = null, Expression<Func<string[]>> usagetypeid = null, Expression<Func<string[]>> statustypeid = null, Expression<Func<string[]>> dataproviderid = null, Expression<Func<bool>> opendata = null, Expression<Func<bool>> includecomments = null, Expression<Func<bool>> verbose = null, Expression<Func<bool>> compact = null, Expression<Func<bool>> camelcase = null, Expression<Func<string>> chargepointid = null, Expression<Func<string[]>> boundingbox = null, Expression<Func<string>> polygon = null, Expression<Func<string>> polyline = null)
        {
            var __workflow_client = WorkflowExpression.Compile(client, nameof(client), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_countrycode = WorkflowExpression.Compile(countrycode, nameof(countrycode), required: false);
            var __workflow_countryid = WorkflowExpression.Compile(countryid, nameof(countryid), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_distance = WorkflowExpression.Compile(distance, nameof(distance), required: false);
            var __workflow_distanceunit = WorkflowExpression.Compile(distanceunit, nameof(distanceunit), required: false);
            var __workflow_operatorid = WorkflowExpression.Compile(operatorid, nameof(operatorid), required: false);
            var __workflow_connectiontypeid = WorkflowExpression.Compile(connectiontypeid, nameof(connectiontypeid), required: false);
            var __workflow_levelid = WorkflowExpression.Compile(levelid, nameof(levelid), required: false);
            var __workflow_usagetypeid = WorkflowExpression.Compile(usagetypeid, nameof(usagetypeid), required: false);
            var __workflow_statustypeid = WorkflowExpression.Compile(statustypeid, nameof(statustypeid), required: false);
            var __workflow_dataproviderid = WorkflowExpression.Compile(dataproviderid, nameof(dataproviderid), required: false);
            var __workflow_opendata = WorkflowExpression.Compile(opendata, nameof(opendata), required: false);
            var __workflow_includecomments = WorkflowExpression.Compile(includecomments, nameof(includecomments), required: false);
            var __workflow_verbose = WorkflowExpression.Compile(verbose, nameof(verbose), required: false);
            var __workflow_compact = WorkflowExpression.Compile(compact, nameof(compact), required: false);
            var __workflow_camelcase = WorkflowExpression.Compile(camelcase, nameof(camelcase), required: false);
            var __workflow_chargepointid = WorkflowExpression.Compile(chargepointid, nameof(chargepointid), required: false);
            var __workflow_boundingbox = WorkflowExpression.Compile(boundingbox, nameof(boundingbox), required: false);
            var __workflow_polygon = WorkflowExpression.Compile(polygon, nameof(polygon), required: false);
            var __workflow_polyline = WorkflowExpression.Compile(polyline, nameof(polyline), required: false);
            return new DeferredBodyAction<POI[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/poi";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output"] = Convert.ToString("json");
                if (__workflow_client != null)
                    callPayload.Queries["client"] = ExpressionConverter.Convert(__workflow_client);
                callPayload.Queries["maxresults"] = Convert.ToString(100);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_countrycode != null)
                    callPayload.Queries["countrycode"] = ExpressionConverter.Convert(__workflow_countrycode);
                if (__workflow_countryid != null)
                    callPayload.Queries["countryid"] = ExpressionConverter.Convert(__workflow_countryid);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_distance != null)
                    callPayload.Queries["distance"] = ExpressionConverter.Convert(__workflow_distance);
                callPayload.Queries["distanceunit"] = Convert.ToString("Miles");
                if (__workflow_distanceunit != null)
                    callPayload.Queries["distanceunit"] = ExpressionConverter.Convert(__workflow_distanceunit);
                if (__workflow_operatorid != null)
                    callPayload.Queries["operatorid"] = ExpressionConverter.Convert(__workflow_operatorid);
                if (__workflow_connectiontypeid != null)
                    callPayload.Queries["connectiontypeid"] = ExpressionConverter.Convert(__workflow_connectiontypeid);
                if (__workflow_levelid != null)
                    callPayload.Queries["levelid"] = ExpressionConverter.Convert(__workflow_levelid);
                if (__workflow_usagetypeid != null)
                    callPayload.Queries["usagetypeid"] = ExpressionConverter.Convert(__workflow_usagetypeid);
                if (__workflow_statustypeid != null)
                    callPayload.Queries["statustypeid"] = ExpressionConverter.Convert(__workflow_statustypeid);
                if (__workflow_dataproviderid != null)
                    callPayload.Queries["dataproviderid"] = ExpressionConverter.Convert(__workflow_dataproviderid);
                if (__workflow_opendata != null)
                    callPayload.Queries["opendata"] = ExpressionConverter.Convert(__workflow_opendata);
                callPayload.Queries["includecomments"] = Convert.ToString(false);
                if (__workflow_includecomments != null)
                    callPayload.Queries["includecomments"] = ExpressionConverter.Convert(__workflow_includecomments);
                callPayload.Queries["verbose"] = Convert.ToString(true);
                if (__workflow_verbose != null)
                    callPayload.Queries["verbose"] = ExpressionConverter.Convert(__workflow_verbose);
                callPayload.Queries["compact"] = Convert.ToString(false);
                if (__workflow_compact != null)
                    callPayload.Queries["compact"] = ExpressionConverter.Convert(__workflow_compact);
                callPayload.Queries["camelcase"] = Convert.ToString(false);
                if (__workflow_camelcase != null)
                    callPayload.Queries["camelcase"] = ExpressionConverter.Convert(__workflow_camelcase);
                if (__workflow_chargepointid != null)
                    callPayload.Queries["chargepointid"] = ExpressionConverter.Convert(__workflow_chargepointid);
                if (__workflow_boundingbox != null)
                    callPayload.Queries["boundingbox"] = ExpressionConverter.Convert(__workflow_boundingbox);
                if (__workflow_polygon != null)
                    callPayload.Queries["polygon"] = ExpressionConverter.Convert(__workflow_polygon);
                if (__workflow_polyline != null)
                    callPayload.Queries["polyline"] = ExpressionConverter.Convert(__workflow_polyline);
                return new ApiConnectionAction<POI[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openchargemapip")]
        public IBodyWorkflowAction<CoreReferenceData, ApiConnectionActionConfiguration> ReferenceDataGet(Expression<Func<string[]>> countryid = null)
        {
            var __workflow_countryid = WorkflowExpression.Compile(countryid, nameof(countryid), required: false);
            return new DeferredBodyAction<CoreReferenceData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/referencedata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_countryid != null)
                    callPayload.Queries["countryid"] = ExpressionConverter.Convert(__workflow_countryid);
                return new ApiConnectionAction<CoreReferenceData>(callPayload);
            });
        }
    }

    public class OpenchargemapipTriggers([ConnectionName] string connectionId)
    {
    }

    public class POI
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string UUID { get; set; }
        public UserComment[] UserComments { get; set; }
        public MediaItem[] MediaItems { get; set; }
        public bool IsRecentlyVerified { get; set; }
        public string DateLastVerified { get; set; }

        [JsonProperty("ParentChargePointID")]
        public string ParentChargePointId { get; set; }

        [JsonProperty("DataProviderID")]
        public int DataProviderId { get; set; }
        public string DataProvidersReference { get; set; }

        [JsonProperty("OperatorID")]
        public int OperatorId { get; set; }
        public string OperatorsReference { get; set; }

        [JsonProperty("UsageTypeID")]
        public int UsageTypeId { get; set; }
        public string UsageCost { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public ConnectionInfo[] Connections { get; set; }
        public int NumberOfPoints { get; set; }
        public string GeneralComments { get; set; }
        public string DatePlanned { get; set; }
        public string DateLastConfirmed { get; set; }

        [JsonProperty("StatusTypeID")]
        public int StatusTypeId { get; set; }
        public string DateLastStatusUpdate { get; set; }
        public JToken[] MetadataValues { get; set; }
        public int DataQualityLevel { get; set; }
        public string DateCreated { get; set; }

        [JsonProperty("SubmissionStatusTypeID")]
        public int SubmissionStatusTypeId { get; set; }
        public DataProvider DataProvider { get; set; }
        public OperatorInfo OperatorInfo { get; set; }
        public UsageType UsageType { get; set; }
        public StatusType StatusType { get; set; }
        public SubmissionStatusType SubmissionStatus { get; set; }
    }

    public class UserComment
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("ChargePointID")]
        public int ChargePointId { get; set; }

        [JsonProperty("CommentTypeID")]
        public int CommentTypeId { get; set; }
        public UserCommentType CommentType { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public string RelatedURL { get; set; }
        public string DateCreated { get; set; }
        public UserInfo User { get; set; }

        [JsonProperty("CheckinStatusTypeID")]
        public int CheckinStatusTypeId { get; set; }
        public CheckinStatusType CheckinStatusType { get; set; }
    }

    public class UserCommentType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Username { get; set; }
        public int ReputationPoints { get; set; }
        public string ProfileImageURL { get; set; }
    }

    public class CheckinStatusType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsAutomatedCheckin { get; set; }
        public bool IsPositive { get; set; }
    }

    public class MediaItem
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("ChargePointID")]
        public int ChargePointId { get; set; }
        public string ItemURL { get; set; }
        public string ItemThumbnailURL { get; set; }
        public string Comment { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVideo { get; set; }
        public bool IsFeaturedItem { get; set; }
        public bool IsExternalResource { get; set; }
        public UserInfo User { get; set; }
        public string DateCreated { get; set; }
    }

    public class AddressInfo
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string StateOrProvince { get; set; }
        public string Postcode { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ContactTelephone1 { get; set; }
        public string ContactTelephone2 { get; set; }
        public string ContactEmail { get; set; }
        public string AccessComments { get; set; }
        public string RelatedURL { get; set; }
        public double Distance { get; set; }
        public int DistanceUnit { get; set; }
        public string Title { get; set; }
    }

    public class Country
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string ISOCode { get; set; }
        public string ContinentCode { get; set; }
        public string Title { get; set; }
    }

    public class ConnectionInfo
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("ConnectionTypeID")]
        public int ConnectionTypeId { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public string Reference { get; set; }

        [JsonProperty("StatusTypeID")]
        public int StatusTypeId { get; set; }
        public StatusType StatusType { get; set; }

        [JsonProperty("LevelID")]
        public int LevelId { get; set; }
        public LevelType Level { get; set; }
        public int Amps { get; set; }
        public double Voltage { get; set; }
        public double PowerKW { get; set; }

        [JsonProperty("CurrentTypeID")]
        public int CurrentTypeId { get; set; }
        public SupplyType CurrentType { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
    }

    public class ConnectionType
    {
        public string FormalName { get; set; }
        public bool IsDiscontinued { get; set; }
        public bool IsObsolete { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class StatusType
    {
        public bool IsOperational { get; set; }
        public bool IsUserSelectable { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class LevelType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public bool IsFastChargeCapable { get; set; }
    }

    public class SupplyType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class DataProvider
    {
        public string WebsiteURL { get; set; }
        public string Comments { get; set; }
        public DataProviderStatusType DataProviderStatusType { get; set; }
        public bool IsRestrictedEdit { get; set; }
        public bool IsOpenDataLicensed { get; set; }
        public bool IsApprovedImport { get; set; }
        public string License { get; set; }
        public string DateLastImported { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class DataProviderStatusType
    {
        public bool IsProviderEnabled { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class OperatorInfo
    {
        public string WebsiteURL { get; set; }
        public string Comments { get; set; }
        public string PhonePrimaryContact { get; set; }
        public string PhoneSecondaryContact { get; set; }
        public bool IsPrivateIndividual { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public string BookingURL { get; set; }
        public string ContactEmail { get; set; }
        public string FaultReportEmail { get; set; }
        public bool IsRestrictedEdit { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class UsageType
    {
        public bool IsPayAtLocation { get; set; }
        public bool IsMembershipRequired { get; set; }
        public bool IsAccessKeyRequired { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class SubmissionStatusType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsLive { get; set; }
    }

    public class CoreReferenceData
    {
        public LevelType[] ChargerTypes { get; set; }
        public ConnectionType[] ConnectionTypes { get; set; }
        public CheckinStatusType[] CheckinStatusTypes { get; set; }
        public Country[] Countries { get; set; }
        public SupplyType[] CurrentTypes { get; set; }
        public DataProvider[] DataProviders { get; set; }
        public OperatorInfo[] Operators { get; set; }
        public StatusType[] StatusTypes { get; set; }
        public SubmissionStatusType[] SubmissionStatusTypes { get; set; }
        public UsageType[] UsageTypes { get; set; }
        public UserCommentType[] UserCommentTypes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openchargemapip;

    public partial class WorkflowManagedActions
    {
        public OpenchargemapipActions Openchargemapip(string connectionId) => new OpenchargemapipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenchargemapipTriggers Openchargemapip(string connectionId) => new OpenchargemapipTriggers(connectionId);
    }
}