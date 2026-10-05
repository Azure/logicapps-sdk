//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usgsearthquakehazaip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsgsearthquakehazaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usgsearthquakehazaip")]
        [WorkflowExpressionFactory(nameof(__BuildGet))]
        public IBodyWorkflowAction<GetResponse> Get([WorkflowExpression] Func<string> endtime = null, [WorkflowExpression] Func<string> starttime = null, [WorkflowExpression] Func<string> updatedafter = null, [WorkflowExpression] Func<double> minlatitude = null, [WorkflowExpression] Func<double> minlongitude = null, [WorkflowExpression] Func<double> maxlatitude = null, [WorkflowExpression] Func<double> maxlongitude = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<double> maxradius = null, [WorkflowExpression] Func<double> maxradiuskm = null, [WorkflowExpression] Func<string> catalog = null, [WorkflowExpression] Func<string> contributor = null, [WorkflowExpression] Func<string> eventid = null, [WorkflowExpression] Func<bool> includeallmagnitudes = null, [WorkflowExpression] Func<bool> includeallorigins = null, [WorkflowExpression] Func<bool> includedeleted = null, [WorkflowExpression] Func<bool> includesuperseded = null, [WorkflowExpression] Func<double> maxdepth = null, [WorkflowExpression] Func<double> maxmagnitude = null, [WorkflowExpression] Func<double> mindepth = null, [WorkflowExpression] Func<double> minmagnitude = null, [WorkflowExpression] Func<string> alertlevel = null, [WorkflowExpression] Func<string> eventtype = null, [WorkflowExpression] Func<double> maxcdi = null, [WorkflowExpression] Func<double> maxgap = null, [WorkflowExpression] Func<double> maxmmi = null, [WorkflowExpression] Func<int> maxsig = null, [WorkflowExpression] Func<double> mincdi = null, [WorkflowExpression] Func<int> minfelt = null, [WorkflowExpression] Func<double> mingap = null, [WorkflowExpression] Func<int> minsig = null, [WorkflowExpression] Func<string> producttype = null, [WorkflowExpression] Func<string> productcode = null, [WorkflowExpression] Func<string> reviewstatus = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> orderby = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetResponse> __BuildGet(WorkflowValue<string> endtime = null, WorkflowValue<string> starttime = null, WorkflowValue<string> updatedafter = null, WorkflowValue<double> minlatitude = null, WorkflowValue<double> minlongitude = null, WorkflowValue<double> maxlatitude = null, WorkflowValue<double> maxlongitude = null, WorkflowValue<double> latitude = null, WorkflowValue<double> longitude = null, WorkflowValue<double> maxradius = null, WorkflowValue<double> maxradiuskm = null, WorkflowValue<string> catalog = null, WorkflowValue<string> contributor = null, WorkflowValue<string> eventid = null, WorkflowValue<bool> includeallmagnitudes = null, WorkflowValue<bool> includeallorigins = null, WorkflowValue<bool> includedeleted = null, WorkflowValue<bool> includesuperseded = null, WorkflowValue<double> maxdepth = null, WorkflowValue<double> maxmagnitude = null, WorkflowValue<double> mindepth = null, WorkflowValue<double> minmagnitude = null, WorkflowValue<string> alertlevel = null, WorkflowValue<string> eventtype = null, WorkflowValue<double> maxcdi = null, WorkflowValue<double> maxgap = null, WorkflowValue<double> maxmmi = null, WorkflowValue<int> maxsig = null, WorkflowValue<double> mincdi = null, WorkflowValue<int> minfelt = null, WorkflowValue<double> mingap = null, WorkflowValue<int> minsig = null, WorkflowValue<string> producttype = null, WorkflowValue<string> productcode = null, WorkflowValue<string> reviewstatus = null, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null, WorkflowValue<string> orderby = null)
        {
            WorkflowValue.Validate(endtime, nameof(endtime), required: false);
            WorkflowValue.Validate(starttime, nameof(starttime), required: false);
            WorkflowValue.Validate(updatedafter, nameof(updatedafter), required: false);
            WorkflowValue.Validate(minlatitude, nameof(minlatitude), required: false);
            WorkflowValue.Validate(minlongitude, nameof(minlongitude), required: false);
            WorkflowValue.Validate(maxlatitude, nameof(maxlatitude), required: false);
            WorkflowValue.Validate(maxlongitude, nameof(maxlongitude), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(maxradius, nameof(maxradius), required: false);
            WorkflowValue.Validate(maxradiuskm, nameof(maxradiuskm), required: false);
            WorkflowValue.Validate(catalog, nameof(catalog), required: false);
            WorkflowValue.Validate(contributor, nameof(contributor), required: false);
            WorkflowValue.Validate(eventid, nameof(eventid), required: false);
            WorkflowValue.Validate(includeallmagnitudes, nameof(includeallmagnitudes), required: false);
            WorkflowValue.Validate(includeallorigins, nameof(includeallorigins), required: false);
            WorkflowValue.Validate(includedeleted, nameof(includedeleted), required: false);
            WorkflowValue.Validate(includesuperseded, nameof(includesuperseded), required: false);
            WorkflowValue.Validate(maxdepth, nameof(maxdepth), required: false);
            WorkflowValue.Validate(maxmagnitude, nameof(maxmagnitude), required: false);
            WorkflowValue.Validate(mindepth, nameof(mindepth), required: false);
            WorkflowValue.Validate(minmagnitude, nameof(minmagnitude), required: false);
            WorkflowValue.Validate(alertlevel, nameof(alertlevel), required: false);
            WorkflowValue.Validate(eventtype, nameof(eventtype), required: false);
            WorkflowValue.Validate(maxcdi, nameof(maxcdi), required: false);
            WorkflowValue.Validate(maxgap, nameof(maxgap), required: false);
            WorkflowValue.Validate(maxmmi, nameof(maxmmi), required: false);
            WorkflowValue.Validate(maxsig, nameof(maxsig), required: false);
            WorkflowValue.Validate(mincdi, nameof(mincdi), required: false);
            WorkflowValue.Validate(minfelt, nameof(minfelt), required: false);
            WorkflowValue.Validate(mingap, nameof(mingap), required: false);
            WorkflowValue.Validate(minsig, nameof(minsig), required: false);
            WorkflowValue.Validate(producttype, nameof(producttype), required: false);
            WorkflowValue.Validate(productcode, nameof(productcode), required: false);
            WorkflowValue.Validate(reviewstatus, nameof(reviewstatus), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetResponse>(() =>
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
