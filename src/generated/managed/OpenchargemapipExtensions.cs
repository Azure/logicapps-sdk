//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openchargemapip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenchargemapipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openchargemapip")]
        public IBodyWorkflowAction<POI[]> POIGet(Expression<Func<string>> client = null, Expression<Func<int>> maxresults = null, Expression<Func<string>> countrycode = null, Expression<Func<string[]>> countryid = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<double>> distance = null, Expression<Func<string>> distanceunit = null, Expression<Func<string[]>> operatorid = null, Expression<Func<string[]>> connectiontypeid = null, Expression<Func<string[]>> levelid = null, Expression<Func<string[]>> usagetypeid = null, Expression<Func<string[]>> statustypeid = null, Expression<Func<string[]>> dataproviderid = null, Expression<Func<bool>> opendata = null, Expression<Func<bool>> includecomments = null, Expression<Func<bool>> verbose = null, Expression<Func<bool>> compact = null, Expression<Func<bool>> camelcase = null, Expression<Func<string>> chargepointid = null, Expression<Func<string[]>> boundingbox = null, Expression<Func<string>> polygon = null, Expression<Func<string>> polyline = null)
        {
            var apiCallPath = "/poi";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["output"] = Convert.ToString("json");
            if (client != null)
                callPayload.Queries["client"] = ExpressionConverter.Convert(client);
            callPayload.Queries["maxresults"] = Convert.ToString(100);
            if (maxresults != null)
                callPayload.Queries["maxresults"] = ExpressionConverter.Convert(maxresults);
            if (countrycode != null)
                callPayload.Queries["countrycode"] = ExpressionConverter.Convert(countrycode);
            if (countryid != null)
                callPayload.Queries["countryid"] = ExpressionConverter.Convert(countryid);
            if (latitude != null)
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (distance != null)
                callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
            callPayload.Queries["distanceunit"] = Convert.ToString("Miles");
            if (distanceunit != null)
                callPayload.Queries["distanceunit"] = ExpressionConverter.Convert(distanceunit);
            if (operatorid != null)
                callPayload.Queries["operatorid"] = ExpressionConverter.Convert(operatorid);
            if (connectiontypeid != null)
                callPayload.Queries["connectiontypeid"] = ExpressionConverter.Convert(connectiontypeid);
            if (levelid != null)
                callPayload.Queries["levelid"] = ExpressionConverter.Convert(levelid);
            if (usagetypeid != null)
                callPayload.Queries["usagetypeid"] = ExpressionConverter.Convert(usagetypeid);
            if (statustypeid != null)
                callPayload.Queries["statustypeid"] = ExpressionConverter.Convert(statustypeid);
            if (dataproviderid != null)
                callPayload.Queries["dataproviderid"] = ExpressionConverter.Convert(dataproviderid);
            if (opendata != null)
                callPayload.Queries["opendata"] = ExpressionConverter.Convert(opendata);
            callPayload.Queries["includecomments"] = Convert.ToString(false);
            if (includecomments != null)
                callPayload.Queries["includecomments"] = ExpressionConverter.Convert(includecomments);
            callPayload.Queries["verbose"] = Convert.ToString(true);
            if (verbose != null)
                callPayload.Queries["verbose"] = ExpressionConverter.Convert(verbose);
            callPayload.Queries["compact"] = Convert.ToString(false);
            if (compact != null)
                callPayload.Queries["compact"] = ExpressionConverter.Convert(compact);
            callPayload.Queries["camelcase"] = Convert.ToString(false);
            if (camelcase != null)
                callPayload.Queries["camelcase"] = ExpressionConverter.Convert(camelcase);
            if (chargepointid != null)
                callPayload.Queries["chargepointid"] = ExpressionConverter.Convert(chargepointid);
            if (boundingbox != null)
                callPayload.Queries["boundingbox"] = ExpressionConverter.Convert(boundingbox);
            if (polygon != null)
                callPayload.Queries["polygon"] = ExpressionConverter.Convert(polygon);
            if (polyline != null)
                callPayload.Queries["polyline"] = ExpressionConverter.Convert(polyline);
            return new ApiConnectionAction<POI[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openchargemapip")]
        public IBodyWorkflowAction<CoreReferenceData> ReferenceDataGet(Expression<Func<string[]>> countryid = null)
        {
            var apiCallPath = "/referencedata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (countryid != null)
                callPayload.Queries["countryid"] = ExpressionConverter.Convert(countryid);
            return new ApiConnectionAction<CoreReferenceData>(callPayload);
        }
    }

    public class OpenchargemapipTriggers([ConnectionName] string connectionId)
    {
    }

    public class POI
    {
        public int ID { get; set; }
        public string UUID { get; set; }
        public UserComment[] UserComments { get; set; }
        public MediaItem[] MediaItems { get; set; }
        public bool IsRecentlyVerified { get; set; }
        public string DateLastVerified { get; set; }
        public string ParentChargePointID { get; set; }
        public int DataProviderID { get; set; }
        public string DataProvidersReference { get; set; }
        public int OperatorID { get; set; }
        public string OperatorsReference { get; set; }
        public int UsageTypeID { get; set; }
        public string UsageCost { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public ConnectionInfo[] Connections { get; set; }
        public int NumberOfPoints { get; set; }
        public string GeneralComments { get; set; }
        public string DatePlanned { get; set; }
        public string DateLastConfirmed { get; set; }
        public int StatusTypeID { get; set; }
        public string DateLastStatusUpdate { get; set; }
        public JToken[] MetadataValues { get; set; }
        public int DataQualityLevel { get; set; }
        public string DateCreated { get; set; }
        public int SubmissionStatusTypeID { get; set; }
        public DataProvider DataProvider { get; set; }
        public OperatorInfo OperatorInfo { get; set; }
        public UsageType UsageType { get; set; }
        public StatusType StatusType { get; set; }
        public SubmissionStatusType SubmissionStatus { get; set; }
    }

    public class UserComment
    {
        public int ID { get; set; }
        public int ChargePointID { get; set; }
        public int CommentTypeID { get; set; }
        public UserCommentType CommentType { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public string RelatedURL { get; set; }
        public string DateCreated { get; set; }
        public UserInfo User { get; set; }
        public int CheckinStatusTypeID { get; set; }
        public CheckinStatusType CheckinStatusType { get; set; }
    }

    public class UserCommentType
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class UserInfo
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int ReputationPoints { get; set; }
        public string ProfileImageURL { get; set; }
    }

    public class CheckinStatusType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsAutomatedCheckin { get; set; }
        public bool IsPositive { get; set; }
    }

    public class MediaItem
    {
        public int ID { get; set; }
        public int ChargePointID { get; set; }
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
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string StateOrProvince { get; set; }
        public string Postcode { get; set; }
        public int CountryID { get; set; }
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
        public int ID { get; set; }
        public string ISOCode { get; set; }
        public string ContinentCode { get; set; }
        public string Title { get; set; }
    }

    public class ConnectionInfo
    {
        public int ID { get; set; }
        public int ConnectionTypeID { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public string Reference { get; set; }
        public int StatusTypeID { get; set; }
        public StatusType StatusType { get; set; }
        public int LevelID { get; set; }
        public LevelType Level { get; set; }
        public int Amps { get; set; }
        public double Voltage { get; set; }
        public double PowerKW { get; set; }
        public int CurrentTypeID { get; set; }
        public SupplyType CurrentType { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
    }

    public class ConnectionType
    {
        public string FormalName { get; set; }
        public bool IsDiscontinued { get; set; }
        public bool IsObsolete { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class StatusType
    {
        public bool IsOperational { get; set; }
        public bool IsUserSelectable { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class LevelType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public bool IsFastChargeCapable { get; set; }
    }

    public class SupplyType
    {
        public int ID { get; set; }
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
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class DataProviderStatusType
    {
        public bool IsProviderEnabled { get; set; }
        public int ID { get; set; }

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
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class UsageType
    {
        public bool IsPayAtLocation { get; set; }
        public bool IsMembershipRequired { get; set; }
        public bool IsAccessKeyRequired { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class SubmissionStatusType
    {
        public int ID { get; set; }
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