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
        public IBodyWorkflowAction<GetResponse> Get([WorkflowExpression] Func<string> endtime = null, [WorkflowExpression] Func<string> starttime = null, [WorkflowExpression] Func<string> updatedafter = null, [WorkflowExpression] Func<double> minlatitude = null, [WorkflowExpression] Func<double> minlongitude = null, [WorkflowExpression] Func<double> maxlatitude = null, [WorkflowExpression] Func<double> maxlongitude = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<double> maxradius = null, [WorkflowExpression] Func<double> maxradiuskm = null, [WorkflowExpression] Func<string> catalog = null, [WorkflowExpression] Func<string> contributor = null, [WorkflowExpression] Func<string> eventid = null, [WorkflowExpression] Func<bool> includeallmagnitudes = null, [WorkflowExpression] Func<bool> includeallorigins = null, [WorkflowExpression] Func<bool> includedeleted = null, [WorkflowExpression] Func<bool> includesuperseded = null, [WorkflowExpression] Func<double> maxdepth = null, [WorkflowExpression] Func<double> maxmagnitude = null, [WorkflowExpression] Func<double> mindepth = null, [WorkflowExpression] Func<double> minmagnitude = null, [WorkflowExpression] Func<string> alertlevel = null, [WorkflowExpression] Func<string> eventtype = null, [WorkflowExpression] Func<double> maxcdi = null, [WorkflowExpression] Func<double> maxgap = null, [WorkflowExpression] Func<double> maxmmi = null, [WorkflowExpression] Func<int> maxsig = null, [WorkflowExpression] Func<double> mincdi = null, [WorkflowExpression] Func<int> minfelt = null, [WorkflowExpression] Func<double> mingap = null, [WorkflowExpression] Func<int> minsig = null, [WorkflowExpression] Func<string> producttype = null, [WorkflowExpression] Func<string> productcode = null, [WorkflowExpression] Func<string> reviewstatus = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> orderby = null)
        {
            SourceExpression.Validate(endtime, nameof(endtime), required: false);
            SourceExpression.Validate(starttime, nameof(starttime), required: false);
            SourceExpression.Validate(updatedafter, nameof(updatedafter), required: false);
            SourceExpression.Validate(minlatitude, nameof(minlatitude), required: false);
            SourceExpression.Validate(minlongitude, nameof(minlongitude), required: false);
            SourceExpression.Validate(maxlatitude, nameof(maxlatitude), required: false);
            SourceExpression.Validate(maxlongitude, nameof(maxlongitude), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(maxradius, nameof(maxradius), required: false);
            SourceExpression.Validate(maxradiuskm, nameof(maxradiuskm), required: false);
            SourceExpression.Validate(catalog, nameof(catalog), required: false);
            SourceExpression.Validate(contributor, nameof(contributor), required: false);
            SourceExpression.Validate(eventid, nameof(eventid), required: false);
            SourceExpression.Validate(includeallmagnitudes, nameof(includeallmagnitudes), required: false);
            SourceExpression.Validate(includeallorigins, nameof(includeallorigins), required: false);
            SourceExpression.Validate(includedeleted, nameof(includedeleted), required: false);
            SourceExpression.Validate(includesuperseded, nameof(includesuperseded), required: false);
            SourceExpression.Validate(maxdepth, nameof(maxdepth), required: false);
            SourceExpression.Validate(maxmagnitude, nameof(maxmagnitude), required: false);
            SourceExpression.Validate(mindepth, nameof(mindepth), required: false);
            SourceExpression.Validate(minmagnitude, nameof(minmagnitude), required: false);
            SourceExpression.Validate(alertlevel, nameof(alertlevel), required: false);
            SourceExpression.Validate(eventtype, nameof(eventtype), required: false);
            SourceExpression.Validate(maxcdi, nameof(maxcdi), required: false);
            SourceExpression.Validate(maxgap, nameof(maxgap), required: false);
            SourceExpression.Validate(maxmmi, nameof(maxmmi), required: false);
            SourceExpression.Validate(maxsig, nameof(maxsig), required: false);
            SourceExpression.Validate(mincdi, nameof(mincdi), required: false);
            SourceExpression.Validate(minfelt, nameof(minfelt), required: false);
            SourceExpression.Validate(mingap, nameof(mingap), required: false);
            SourceExpression.Validate(minsig, nameof(minsig), required: false);
            SourceExpression.Validate(producttype, nameof(producttype), required: false);
            SourceExpression.Validate(productcode, nameof(productcode), required: false);
            SourceExpression.Validate(reviewstatus, nameof(reviewstatus), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("geojson");
                if (endtime != null)
                    callPayload.Queries["endtime"] = SourceExpressionConverter.ConvertO(endtime);
                if (starttime != null)
                    callPayload.Queries["starttime"] = SourceExpressionConverter.ConvertO(starttime);
                if (updatedafter != null)
                    callPayload.Queries["updatedafter"] = SourceExpressionConverter.ConvertO(updatedafter);
                if (minlatitude != null)
                    callPayload.Queries["minlatitude"] = SourceExpressionConverter.ConvertO(minlatitude);
                if (minlongitude != null)
                    callPayload.Queries["minlongitude"] = SourceExpressionConverter.ConvertO(minlongitude);
                if (maxlatitude != null)
                    callPayload.Queries["maxlatitude"] = SourceExpressionConverter.ConvertO(maxlatitude);
                if (maxlongitude != null)
                    callPayload.Queries["maxlongitude"] = SourceExpressionConverter.ConvertO(maxlongitude);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (maxradius != null)
                    callPayload.Queries["maxradius"] = SourceExpressionConverter.ConvertO(maxradius);
                if (maxradiuskm != null)
                    callPayload.Queries["maxradiuskm"] = SourceExpressionConverter.ConvertO(maxradiuskm);
                if (catalog != null)
                    callPayload.Queries["catalog"] = SourceExpressionConverter.ConvertO(catalog);
                if (contributor != null)
                    callPayload.Queries["contributor"] = SourceExpressionConverter.ConvertO(contributor);
                if (eventid != null)
                    callPayload.Queries["eventid"] = SourceExpressionConverter.ConvertO(eventid);
                if (includeallmagnitudes != null)
                    callPayload.Queries["includeallmagnitudes"] = SourceExpressionConverter.ConvertO(includeallmagnitudes);
                if (includeallorigins != null)
                    callPayload.Queries["includeallorigins"] = SourceExpressionConverter.ConvertO(includeallorigins);
                if (includedeleted != null)
                    callPayload.Queries["includedeleted"] = SourceExpressionConverter.ConvertO(includedeleted);
                if (includesuperseded != null)
                    callPayload.Queries["includesuperseded"] = SourceExpressionConverter.ConvertO(includesuperseded);
                if (maxdepth != null)
                    callPayload.Queries["maxdepth"] = SourceExpressionConverter.ConvertO(maxdepth);
                if (maxmagnitude != null)
                    callPayload.Queries["maxmagnitude"] = SourceExpressionConverter.ConvertO(maxmagnitude);
                if (mindepth != null)
                    callPayload.Queries["mindepth"] = SourceExpressionConverter.ConvertO(mindepth);
                if (minmagnitude != null)
                    callPayload.Queries["minmagnitude"] = SourceExpressionConverter.ConvertO(minmagnitude);
                if (alertlevel != null)
                    callPayload.Queries["alertlevel"] = SourceExpressionConverter.ConvertO(alertlevel);
                if (eventtype != null)
                    callPayload.Queries["eventtype"] = SourceExpressionConverter.ConvertO(eventtype);
                if (maxcdi != null)
                    callPayload.Queries["maxcdi"] = SourceExpressionConverter.ConvertO(maxcdi);
                if (maxgap != null)
                    callPayload.Queries["maxgap"] = SourceExpressionConverter.ConvertO(maxgap);
                if (maxmmi != null)
                    callPayload.Queries["maxmmi"] = SourceExpressionConverter.ConvertO(maxmmi);
                if (maxsig != null)
                    callPayload.Queries["maxsig"] = SourceExpressionConverter.ConvertO(maxsig);
                if (mincdi != null)
                    callPayload.Queries["mincdi"] = SourceExpressionConverter.ConvertO(mincdi);
                if (minfelt != null)
                    callPayload.Queries["minfelt"] = SourceExpressionConverter.ConvertO(minfelt);
                if (mingap != null)
                    callPayload.Queries["mingap"] = SourceExpressionConverter.ConvertO(mingap);
                if (minsig != null)
                    callPayload.Queries["minsig"] = SourceExpressionConverter.ConvertO(minsig);
                if (producttype != null)
                    callPayload.Queries["producttype"] = SourceExpressionConverter.ConvertO(producttype);
                if (productcode != null)
                    callPayload.Queries["productcode"] = SourceExpressionConverter.ConvertO(productcode);
                if (reviewstatus != null)
                    callPayload.Queries["reviewstatus"] = SourceExpressionConverter.ConvertO(reviewstatus);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                return callPayload;
            }

            return new ApiConnectionAction<GetResponse>(BuildSourceInput);
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