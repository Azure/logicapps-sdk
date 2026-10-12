//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ordnancesurveyplaces
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrdnancesurveyplacesActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildFind))]
        public IBodyWorkflowAction<FindResponse> Find([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> maxresults = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<double> minmatch = null, [WorkflowExpression] Func<int> matchprecision = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindResponse> __BuildFind(WorkflowExpression<string> query, WorkflowExpression<string> format = null, WorkflowExpression<int> maxresults = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> dataset = null, WorkflowExpression<string> lr = null, WorkflowExpression<double> minmatch = null, WorkflowExpression<int> matchprecision = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(maxresults, nameof(maxresults), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(minmatch, nameof(minmatch), required: false);
            WorkflowExpression.Validate(matchprecision, nameof(matchprecision), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            return new DeferredBodyAction<FindResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/find";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                callPayload.Queries["format"] = Convert.ToString("JSON");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(maxresults);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (minmatch != null)
                    callPayload.Queries["minmatch"] = ExpressionConverter.Convert(minmatch);
                if (matchprecision != null)
                    callPayload.Queries["matchprecision"] = ExpressionConverter.Convert(matchprecision);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                return new ApiConnectionAction<FindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildPostcode))]
        public IBodyWorkflowAction<PostcodeResponse> Postcode([WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> maxresults = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostcodeResponse> __BuildPostcode(WorkflowExpression<string> postcode, WorkflowExpression<string> format = null, WorkflowExpression<int> maxresults = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> dataset = null, WorkflowExpression<string> lr = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null)
        {
            WorkflowExpression.Validate(postcode, nameof(postcode), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(maxresults, nameof(maxresults), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            return new DeferredBodyAction<PostcodeResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/postcode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["postcode"] = ExpressionConverter.Convert(postcode);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(maxresults);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                return new ApiConnectionAction<PostcodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildUPRN))]
        public IBodyWorkflowAction<UPRNResponse> UPRN([WorkflowExpression] Func<int> uprn, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UPRNResponse> __BuildUPRN(WorkflowExpression<int> uprn, WorkflowExpression<string> format = null, WorkflowExpression<string> dataset = null, WorkflowExpression<string> lr = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null)
        {
            WorkflowExpression.Validate(uprn, nameof(uprn), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            return new DeferredBodyAction<UPRNResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/uprn";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["uprn"] = ExpressionConverter.Convert(uprn);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                return new ApiConnectionAction<UPRNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildNearest))]
        public IBodyWorkflowAction<NearestResponse> Nearest([WorkflowExpression] Func<string> point, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null, [WorkflowExpression] Func<string> srs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NearestResponse> __BuildNearest(WorkflowExpression<string> point, WorkflowExpression<int> radius = null, WorkflowExpression<string> format = null, WorkflowExpression<string> dataset = null, WorkflowExpression<string> lr = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null, WorkflowExpression<string> srs = null)
        {
            WorkflowExpression.Validate(point, nameof(point), required: true);
            WorkflowExpression.Validate(radius, nameof(radius), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            WorkflowExpression.Validate(srs, nameof(srs), required: false);
            return new DeferredBodyAction<NearestResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/nearest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["point"] = ExpressionConverter.Convert(point);
                if (radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                if (srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
                return new ApiConnectionAction<NearestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildBBox))]
        public IBodyWorkflowAction<BBoxResponse> BBox([WorkflowExpression] Func<string> bbox, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> maxresults = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null, [WorkflowExpression] Func<string> srs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BBoxResponse> __BuildBBox(WorkflowExpression<string> bbox, WorkflowExpression<string> format = null, WorkflowExpression<int> maxresults = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> dataset = null, WorkflowExpression<string> lr = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null, WorkflowExpression<string> srs = null)
        {
            WorkflowExpression.Validate(bbox, nameof(bbox), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(maxresults, nameof(maxresults), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            WorkflowExpression.Validate(srs, nameof(srs), required: false);
            return new DeferredBodyAction<BBoxResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/bbox";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bbox"] = ExpressionConverter.Convert(bbox);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(maxresults);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                if (srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
                return new ApiConnectionAction<BBoxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildRadius))]
        public IBodyWorkflowAction<RadiusResponse> Radius([WorkflowExpression] Func<string> point, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> maxresults = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null, [WorkflowExpression] Func<string> srs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RadiusResponse> __BuildRadius(WorkflowExpression<string> point, WorkflowExpression<int> radius = null, WorkflowExpression<string> format = null, WorkflowExpression<int> maxresults = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> dataset = null, WorkflowExpression<string> lr = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null, WorkflowExpression<string> srs = null)
        {
            WorkflowExpression.Validate(point, nameof(point), required: true);
            WorkflowExpression.Validate(radius, nameof(radius), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(maxresults, nameof(maxresults), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            WorkflowExpression.Validate(srs, nameof(srs), required: false);
            return new DeferredBodyAction<RadiusResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/radius";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["point"] = ExpressionConverter.Convert(point);
                callPayload.Queries["radius"] = Convert.ToString(100);
                if (radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(maxresults);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                if (srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
                return new ApiConnectionAction<RadiusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        [WorkflowExpressionFactory(nameof(__BuildPolygon))]
        public IBodyWorkflowAction<PolygonResponse> Polygon([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodygeometry, [WorkflowExpression] Func<int> referencepoint = null, [WorkflowExpression] Func<int> maxresults = null, [WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> fq = null, [WorkflowExpression] Func<string> outputSrs = null, [WorkflowExpression] Func<string> srs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PolygonResponse> __BuildPolygon(WorkflowExpression<string> contentType, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodygeometry, WorkflowExpression<int> referencepoint = null, WorkflowExpression<int> maxresults = null, WorkflowExpression<string> dataset = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> lr = null, WorkflowExpression<string> fq = null, WorkflowExpression<string> outputSrs = null, WorkflowExpression<string> srs = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodygeometry, nameof(bodygeometry), required: true);
            WorkflowExpression.Validate(referencepoint, nameof(referencepoint), required: false);
            WorkflowExpression.Validate(maxresults, nameof(maxresults), required: false);
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(lr, nameof(lr), required: false);
            WorkflowExpression.Validate(fq, nameof(fq), required: false);
            WorkflowExpression.Validate(outputSrs, nameof(outputSrs), required: false);
            WorkflowExpression.Validate(srs, nameof(srs), required: false);
            return new DeferredBodyAction<PolygonResponse>(() =>
            {
                var apiCallPath = "/places/v1/addresses/polygon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (referencepoint != null)
                    callPayload.Queries["referencepoint"] = ExpressionConverter.Convert(referencepoint);
                if (maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(maxresults);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(lr);
                if (fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(fq);
                if (outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(outputSrs);
                if (srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["geometry"] = ExpressionConverter.ConvertO(bodygeometry);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PolygonResponse>(callPayload);
            });
        }
    }

    public class OrdnancesurveyplacesTriggers([ConnectionName] string connectionId)
    {
    }

    public class FindResponse
    {
        [JsonProperty("header")]
        public FindResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public FindResponseResultsTypeItem[] Results { get; set; }
    }

    public class FindResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class FindResponseResultsTypeItem
    {
        public FindResponseResultsTypeItemDPAType DPA { get; set; }
        public FindResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class FindResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class FindResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class PostcodeResponse
    {
        [JsonProperty("header")]
        public PostcodeResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public PostcodeResponseResultsTypeItem[] Results { get; set; }
    }

    public class PostcodeResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class PostcodeResponseResultsTypeItem
    {
        public PostcodeResponseResultsTypeItemDPAType DPA { get; set; }
        public PostcodeResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class PostcodeResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class PostcodeResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class UPRNResponse
    {
        [JsonProperty("header")]
        public UPRNResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public UPRNResponseResultsTypeItem[] Results { get; set; }
    }

    public class UPRNResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class UPRNResponseResultsTypeItem
    {
        public UPRNResponseResultsTypeItemDPAType DPA { get; set; }
        public UPRNResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class UPRNResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class UPRNResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class NearestResponse
    {
        [JsonProperty("header")]
        public NearestResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public NearestResponseResultsTypeItem[] Results { get; set; }
    }

    public class NearestResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class NearestResponseResultsTypeItem
    {
        public NearestResponseResultsTypeItemDPAType DPA { get; set; }
        public NearestResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class NearestResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class NearestResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class BBoxResponse
    {
        [JsonProperty("header")]
        public BBoxResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public BBoxResponseResultsTypeItem[] Results { get; set; }
    }

    public class BBoxResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class BBoxResponseResultsTypeItem
    {
        public BBoxResponseResultsTypeItemDPAType DPA { get; set; }
        public BBoxResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class BBoxResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class BBoxResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class RadiusResponse
    {
        [JsonProperty("header")]
        public RadiusResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public RadiusResponseResultsTypeItem[] Results { get; set; }
    }

    public class RadiusResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class RadiusResponseResultsTypeItem
    {
        public RadiusResponseResultsTypeItemDPAType DPA { get; set; }
        public RadiusResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class RadiusResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class RadiusResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class PolygonResponse
    {
        [JsonProperty("header")]
        public PolygonResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public PolygonResponseResultsTypeItem[] Results { get; set; }
    }

    public class PolygonResponseHeaderType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalresults")]
        public int Totalresults { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("lr")]
        public string Lr { get; set; }

        [JsonProperty("maxresults")]
        public int Maxresults { get; set; }

        [JsonProperty("matchprecision")]
        public int Matchprecision { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("output_srs")]
        public string OutputSrs { get; set; }
    }

    public class PolygonResponseResultsTypeItem
    {
        public PolygonResponseResultsTypeItemDPAType DPA { get; set; }
        public PolygonResponseResultsTypeItemLPIType LPI { get; set; }
    }

    public class PolygonResponseResultsTypeItemDPAType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string ORGANISATIONNAME { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BUILDINGNUMBER { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string THOROUGHFARENAME { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DEPENDENTLOCALITY { get; set; }

        [JsonProperty("POST_TOWN")]
        public string POSTTOWN { get; set; }
        public string POSTCODE { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BLPUSTATECODE { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BLPUSTATEDATE { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }

    public class PolygonResponseResultsTypeItemLPIType
    {
        public string UPRN { get; set; }
        public string ADDRESS { get; set; }
        public string USRN { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LPIKEY { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PAOSTARTNUMBER { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string STREETDESCRIPTION { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TOWNNAME { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string ADMINISTRATIVEAREA { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string POSTCODELOCATOR { get; set; }
        public string RPC { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCOORDINATE { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCOORDINATE { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LOGICALSTATUSCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string CLASSIFICATIONCODE { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string CLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LOCALCUSTODIANCODE { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LOCALCUSTODIANCODEDESCRIPTION { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string POSTALADDRESSCODE { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string POSTALADDRESSCODEDESCRIPTION { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BLPUSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TOPOGRAPHYLAYERTOID { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LASTUPDATEDATE { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string STREETSTATECODE { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string STREETSTATECODEDESCRIPTION { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string STREETCLASSIFICATIONCODE { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string STREETCLASSIFICATIONCODEDESCRIPTION { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LPILOGICALSTATUSCODE { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LPILOGICALSTATUSCODEDESCRIPTION { get; set; }
        public string LANGUAGE { get; set; }
        public double MATCH { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MATCHDESCRIPTION { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ordnancesurveyplaces;

    public partial class WorkflowManagedActions
    {
        public OrdnancesurveyplacesActions Ordnancesurveyplaces(string connectionId) => new OrdnancesurveyplacesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OrdnancesurveyplacesTriggers Ordnancesurveyplaces(string connectionId) => new OrdnancesurveyplacesTriggers(connectionId);
    }
}