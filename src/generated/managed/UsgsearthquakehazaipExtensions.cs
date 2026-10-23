//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usgsearthquakehazaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsgsearthquakehazaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usgsearthquakehazaip")]
        public IBodyWorkflowAction<GetResponse, ApiConnectionActionConfiguration> Get(Expression<Func<string>> endtime = null, Expression<Func<string>> starttime = null, Expression<Func<string>> updatedafter = null, Expression<Func<double>> minlatitude = null, Expression<Func<double>> minlongitude = null, Expression<Func<double>> maxlatitude = null, Expression<Func<double>> maxlongitude = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<double>> maxradius = null, Expression<Func<double>> maxradiuskm = null, Expression<Func<string>> catalog = null, Expression<Func<string>> contributor = null, Expression<Func<string>> eventid = null, Expression<Func<bool>> includeallmagnitudes = null, Expression<Func<bool>> includeallorigins = null, Expression<Func<bool>> includedeleted = null, Expression<Func<bool>> includesuperseded = null, Expression<Func<double>> maxdepth = null, Expression<Func<double>> maxmagnitude = null, Expression<Func<double>> mindepth = null, Expression<Func<double>> minmagnitude = null, Expression<Func<string>> alertlevel = null, Expression<Func<string>> eventtype = null, Expression<Func<double>> maxcdi = null, Expression<Func<double>> maxgap = null, Expression<Func<double>> maxmmi = null, Expression<Func<int>> maxsig = null, Expression<Func<double>> mincdi = null, Expression<Func<int>> minfelt = null, Expression<Func<double>> mingap = null, Expression<Func<int>> minsig = null, Expression<Func<string>> producttype = null, Expression<Func<string>> productcode = null, Expression<Func<string>> reviewstatus = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_endtime = WorkflowExpression.Compile(endtime, nameof(endtime), required: false);
            var __workflow_starttime = WorkflowExpression.Compile(starttime, nameof(starttime), required: false);
            var __workflow_updatedafter = WorkflowExpression.Compile(updatedafter, nameof(updatedafter), required: false);
            var __workflow_minlatitude = WorkflowExpression.Compile(minlatitude, nameof(minlatitude), required: false);
            var __workflow_minlongitude = WorkflowExpression.Compile(minlongitude, nameof(minlongitude), required: false);
            var __workflow_maxlatitude = WorkflowExpression.Compile(maxlatitude, nameof(maxlatitude), required: false);
            var __workflow_maxlongitude = WorkflowExpression.Compile(maxlongitude, nameof(maxlongitude), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_maxradius = WorkflowExpression.Compile(maxradius, nameof(maxradius), required: false);
            var __workflow_maxradiuskm = WorkflowExpression.Compile(maxradiuskm, nameof(maxradiuskm), required: false);
            var __workflow_catalog = WorkflowExpression.Compile(catalog, nameof(catalog), required: false);
            var __workflow_contributor = WorkflowExpression.Compile(contributor, nameof(contributor), required: false);
            var __workflow_eventid = WorkflowExpression.Compile(eventid, nameof(eventid), required: false);
            var __workflow_includeallmagnitudes = WorkflowExpression.Compile(includeallmagnitudes, nameof(includeallmagnitudes), required: false);
            var __workflow_includeallorigins = WorkflowExpression.Compile(includeallorigins, nameof(includeallorigins), required: false);
            var __workflow_includedeleted = WorkflowExpression.Compile(includedeleted, nameof(includedeleted), required: false);
            var __workflow_includesuperseded = WorkflowExpression.Compile(includesuperseded, nameof(includesuperseded), required: false);
            var __workflow_maxdepth = WorkflowExpression.Compile(maxdepth, nameof(maxdepth), required: false);
            var __workflow_maxmagnitude = WorkflowExpression.Compile(maxmagnitude, nameof(maxmagnitude), required: false);
            var __workflow_mindepth = WorkflowExpression.Compile(mindepth, nameof(mindepth), required: false);
            var __workflow_minmagnitude = WorkflowExpression.Compile(minmagnitude, nameof(minmagnitude), required: false);
            var __workflow_alertlevel = WorkflowExpression.Compile(alertlevel, nameof(alertlevel), required: false);
            var __workflow_eventtype = WorkflowExpression.Compile(eventtype, nameof(eventtype), required: false);
            var __workflow_maxcdi = WorkflowExpression.Compile(maxcdi, nameof(maxcdi), required: false);
            var __workflow_maxgap = WorkflowExpression.Compile(maxgap, nameof(maxgap), required: false);
            var __workflow_maxmmi = WorkflowExpression.Compile(maxmmi, nameof(maxmmi), required: false);
            var __workflow_maxsig = WorkflowExpression.Compile(maxsig, nameof(maxsig), required: false);
            var __workflow_mincdi = WorkflowExpression.Compile(mincdi, nameof(mincdi), required: false);
            var __workflow_minfelt = WorkflowExpression.Compile(minfelt, nameof(minfelt), required: false);
            var __workflow_mingap = WorkflowExpression.Compile(mingap, nameof(mingap), required: false);
            var __workflow_minsig = WorkflowExpression.Compile(minsig, nameof(minsig), required: false);
            var __workflow_producttype = WorkflowExpression.Compile(producttype, nameof(producttype), required: false);
            var __workflow_productcode = WorkflowExpression.Compile(productcode, nameof(productcode), required: false);
            var __workflow_reviewstatus = WorkflowExpression.Compile(reviewstatus, nameof(reviewstatus), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("geojson");
                if (__workflow_endtime != null)
                    callPayload.Queries["endtime"] = ExpressionConverter.Convert(__workflow_endtime);
                if (__workflow_starttime != null)
                    callPayload.Queries["starttime"] = ExpressionConverter.Convert(__workflow_starttime);
                if (__workflow_updatedafter != null)
                    callPayload.Queries["updatedafter"] = ExpressionConverter.Convert(__workflow_updatedafter);
                if (__workflow_minlatitude != null)
                    callPayload.Queries["minlatitude"] = ExpressionConverter.Convert(__workflow_minlatitude);
                if (__workflow_minlongitude != null)
                    callPayload.Queries["minlongitude"] = ExpressionConverter.Convert(__workflow_minlongitude);
                if (__workflow_maxlatitude != null)
                    callPayload.Queries["maxlatitude"] = ExpressionConverter.Convert(__workflow_maxlatitude);
                if (__workflow_maxlongitude != null)
                    callPayload.Queries["maxlongitude"] = ExpressionConverter.Convert(__workflow_maxlongitude);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_maxradius != null)
                    callPayload.Queries["maxradius"] = ExpressionConverter.Convert(__workflow_maxradius);
                if (__workflow_maxradiuskm != null)
                    callPayload.Queries["maxradiuskm"] = ExpressionConverter.Convert(__workflow_maxradiuskm);
                if (__workflow_catalog != null)
                    callPayload.Queries["catalog"] = ExpressionConverter.Convert(__workflow_catalog);
                if (__workflow_contributor != null)
                    callPayload.Queries["contributor"] = ExpressionConverter.Convert(__workflow_contributor);
                if (__workflow_eventid != null)
                    callPayload.Queries["eventid"] = ExpressionConverter.Convert(__workflow_eventid);
                if (__workflow_includeallmagnitudes != null)
                    callPayload.Queries["includeallmagnitudes"] = ExpressionConverter.Convert(__workflow_includeallmagnitudes);
                if (__workflow_includeallorigins != null)
                    callPayload.Queries["includeallorigins"] = ExpressionConverter.Convert(__workflow_includeallorigins);
                if (__workflow_includedeleted != null)
                    callPayload.Queries["includedeleted"] = ExpressionConverter.Convert(__workflow_includedeleted);
                if (__workflow_includesuperseded != null)
                    callPayload.Queries["includesuperseded"] = ExpressionConverter.Convert(__workflow_includesuperseded);
                if (__workflow_maxdepth != null)
                    callPayload.Queries["maxdepth"] = ExpressionConverter.Convert(__workflow_maxdepth);
                if (__workflow_maxmagnitude != null)
                    callPayload.Queries["maxmagnitude"] = ExpressionConverter.Convert(__workflow_maxmagnitude);
                if (__workflow_mindepth != null)
                    callPayload.Queries["mindepth"] = ExpressionConverter.Convert(__workflow_mindepth);
                if (__workflow_minmagnitude != null)
                    callPayload.Queries["minmagnitude"] = ExpressionConverter.Convert(__workflow_minmagnitude);
                if (__workflow_alertlevel != null)
                    callPayload.Queries["alertlevel"] = ExpressionConverter.Convert(__workflow_alertlevel);
                if (__workflow_eventtype != null)
                    callPayload.Queries["eventtype"] = ExpressionConverter.Convert(__workflow_eventtype);
                if (__workflow_maxcdi != null)
                    callPayload.Queries["maxcdi"] = ExpressionConverter.Convert(__workflow_maxcdi);
                if (__workflow_maxgap != null)
                    callPayload.Queries["maxgap"] = ExpressionConverter.Convert(__workflow_maxgap);
                if (__workflow_maxmmi != null)
                    callPayload.Queries["maxmmi"] = ExpressionConverter.Convert(__workflow_maxmmi);
                if (__workflow_maxsig != null)
                    callPayload.Queries["maxsig"] = ExpressionConverter.Convert(__workflow_maxsig);
                if (__workflow_mincdi != null)
                    callPayload.Queries["mincdi"] = ExpressionConverter.Convert(__workflow_mincdi);
                if (__workflow_minfelt != null)
                    callPayload.Queries["minfelt"] = ExpressionConverter.Convert(__workflow_minfelt);
                if (__workflow_mingap != null)
                    callPayload.Queries["mingap"] = ExpressionConverter.Convert(__workflow_mingap);
                if (__workflow_minsig != null)
                    callPayload.Queries["minsig"] = ExpressionConverter.Convert(__workflow_minsig);
                if (__workflow_producttype != null)
                    callPayload.Queries["producttype"] = ExpressionConverter.Convert(__workflow_producttype);
                if (__workflow_productcode != null)
                    callPayload.Queries["productcode"] = ExpressionConverter.Convert(__workflow_productcode);
                if (__workflow_reviewstatus != null)
                    callPayload.Queries["reviewstatus"] = ExpressionConverter.Convert(__workflow_reviewstatus);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                return new ApiConnectionAction<GetResponse>(callPayload);
            });
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
