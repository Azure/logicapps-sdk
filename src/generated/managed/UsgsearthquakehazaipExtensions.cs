//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usgsearthquakehazaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsgsearthquakehazaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usgsearthquakehazaip")]
        public IBodyWorkflowAction<GetResponse> Get(Expression<Func<string>> endtime = null, Expression<Func<string>> starttime = null, Expression<Func<string>> updatedafter = null, Expression<Func<double>> minlatitude = null, Expression<Func<double>> minlongitude = null, Expression<Func<double>> maxlatitude = null, Expression<Func<double>> maxlongitude = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<double>> maxradius = null, Expression<Func<double>> maxradiuskm = null, Expression<Func<string>> catalog = null, Expression<Func<string>> contributor = null, Expression<Func<string>> eventid = null, Expression<Func<bool>> includeallmagnitudes = null, Expression<Func<bool>> includeallorigins = null, Expression<Func<bool>> includedeleted = null, Expression<Func<bool>> includesuperseded = null, Expression<Func<double>> maxdepth = null, Expression<Func<double>> maxmagnitude = null, Expression<Func<double>> mindepth = null, Expression<Func<double>> minmagnitude = null, Expression<Func<string>> alertlevel = null, Expression<Func<string>> eventtype = null, Expression<Func<double>> maxcdi = null, Expression<Func<double>> maxgap = null, Expression<Func<double>> maxmmi = null, Expression<Func<int>> maxsig = null, Expression<Func<double>> mincdi = null, Expression<Func<int>> minfelt = null, Expression<Func<double>> mingap = null, Expression<Func<int>> minsig = null, Expression<Func<string>> producttype = null, Expression<Func<string>> productcode = null, Expression<Func<string>> reviewstatus = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderby = null)
        {
            var apiCallPath = "/query";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("geojson");
            if (endtime != null)
                callPayload.Queries["endtime"] = ExpressionConverter.Convert(endtime);
            if (starttime != null)
                callPayload.Queries["starttime"] = ExpressionConverter.Convert(starttime);
            if (updatedafter != null)
                callPayload.Queries["updatedafter"] = ExpressionConverter.Convert(updatedafter);
            if (minlatitude != null)
                callPayload.Queries["minlatitude"] = ExpressionConverter.Convert(minlatitude);
            if (minlongitude != null)
                callPayload.Queries["minlongitude"] = ExpressionConverter.Convert(minlongitude);
            if (maxlatitude != null)
                callPayload.Queries["maxlatitude"] = ExpressionConverter.Convert(maxlatitude);
            if (maxlongitude != null)
                callPayload.Queries["maxlongitude"] = ExpressionConverter.Convert(maxlongitude);
            if (latitude != null)
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (maxradius != null)
                callPayload.Queries["maxradius"] = ExpressionConverter.Convert(maxradius);
            if (maxradiuskm != null)
                callPayload.Queries["maxradiuskm"] = ExpressionConverter.Convert(maxradiuskm);
            if (catalog != null)
                callPayload.Queries["catalog"] = ExpressionConverter.Convert(catalog);
            if (contributor != null)
                callPayload.Queries["contributor"] = ExpressionConverter.Convert(contributor);
            if (eventid != null)
                callPayload.Queries["eventid"] = ExpressionConverter.Convert(eventid);
            if (includeallmagnitudes != null)
                callPayload.Queries["includeallmagnitudes"] = ExpressionConverter.Convert(includeallmagnitudes);
            if (includeallorigins != null)
                callPayload.Queries["includeallorigins"] = ExpressionConverter.Convert(includeallorigins);
            if (includedeleted != null)
                callPayload.Queries["includedeleted"] = ExpressionConverter.Convert(includedeleted);
            if (includesuperseded != null)
                callPayload.Queries["includesuperseded"] = ExpressionConverter.Convert(includesuperseded);
            if (maxdepth != null)
                callPayload.Queries["maxdepth"] = ExpressionConverter.Convert(maxdepth);
            if (maxmagnitude != null)
                callPayload.Queries["maxmagnitude"] = ExpressionConverter.Convert(maxmagnitude);
            if (mindepth != null)
                callPayload.Queries["mindepth"] = ExpressionConverter.Convert(mindepth);
            if (minmagnitude != null)
                callPayload.Queries["minmagnitude"] = ExpressionConverter.Convert(minmagnitude);
            if (alertlevel != null)
                callPayload.Queries["alertlevel"] = ExpressionConverter.Convert(alertlevel);
            if (eventtype != null)
                callPayload.Queries["eventtype"] = ExpressionConverter.Convert(eventtype);
            if (maxcdi != null)
                callPayload.Queries["maxcdi"] = ExpressionConverter.Convert(maxcdi);
            if (maxgap != null)
                callPayload.Queries["maxgap"] = ExpressionConverter.Convert(maxgap);
            if (maxmmi != null)
                callPayload.Queries["maxmmi"] = ExpressionConverter.Convert(maxmmi);
            if (maxsig != null)
                callPayload.Queries["maxsig"] = ExpressionConverter.Convert(maxsig);
            if (mincdi != null)
                callPayload.Queries["mincdi"] = ExpressionConverter.Convert(mincdi);
            if (minfelt != null)
                callPayload.Queries["minfelt"] = ExpressionConverter.Convert(minfelt);
            if (mingap != null)
                callPayload.Queries["mingap"] = ExpressionConverter.Convert(mingap);
            if (minsig != null)
                callPayload.Queries["minsig"] = ExpressionConverter.Convert(minsig);
            if (producttype != null)
                callPayload.Queries["producttype"] = ExpressionConverter.Convert(producttype);
            if (productcode != null)
                callPayload.Queries["productcode"] = ExpressionConverter.Convert(productcode);
            if (reviewstatus != null)
                callPayload.Queries["reviewstatus"] = ExpressionConverter.Convert(reviewstatus);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderby != null)
                callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
            return new ApiConnectionAction<GetResponse>(callPayload);
        }
    }

    public class UsgsearthquakehazaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("metadata")]
        public GetResponseMetadataType Metadata { get; set; }

        [JsonProperty("features")]
        public GetResponseFeaturesTypeItem[] Features { get; set; }

        [JsonProperty("bbox")]
        public double[] Bbox { get; set; }
    }

    public class GetResponseMetadataType
    {
        [JsonProperty("generated")]
        public int Generated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetResponseFeaturesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public GetResponseFeaturesTypeItemPropertiesType Properties { get; set; }

        [JsonProperty("geometry")]
        public GetResponseFeaturesTypeItemGeometryType Geometry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetResponseFeaturesTypeItemPropertiesType
    {
        [JsonProperty("mag")]
        public double Mag { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("felt")]
        public int Felt { get; set; }

        [JsonProperty("cdi")]
        public double Cdi { get; set; }

        [JsonProperty("mmi")]
        public double Mmi { get; set; }

        [JsonProperty("alert")]
        public string Alert { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tsunami")]
        public int Tsunami { get; set; }

        [JsonProperty("sig")]
        public int Sig { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("ids")]
        public string Ids { get; set; }

        [JsonProperty("sources")]
        public string Sources { get; set; }

        [JsonProperty("types")]
        public string Types { get; set; }

        [JsonProperty("nst")]
        public int Nst { get; set; }

        [JsonProperty("dmin")]
        public double Dmin { get; set; }

        [JsonProperty("rms")]
        public double Rms { get; set; }

        [JsonProperty("gap")]
        public double Gap { get; set; }

        [JsonProperty("magType")]
        public string MagType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetResponseFeaturesTypeItemGeometryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Usgsearthquakehazaip;

    public partial class WorkflowManagedActions
    {
        public UsgsearthquakehazaipActions Usgsearthquakehazaip(string connectionId) => new UsgsearthquakehazaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UsgsearthquakehazaipTriggers Usgsearthquakehazaip(string connectionId) => new UsgsearthquakehazaipTriggers(connectionId);
    }
}