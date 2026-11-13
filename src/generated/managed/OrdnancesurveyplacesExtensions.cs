//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ordnancesurveyplaces
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrdnancesurveyplacesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<FindResponse, ApiConnectionActionConfiguration> Find(Expression<Func<string>> query, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<double>> minmatch = null, Expression<Func<int>> matchprecision = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_minmatch = WorkflowExpression.Compile(minmatch, nameof(minmatch), required: false);
            var __workflow_matchprecision = WorkflowExpression.Compile(matchprecision, nameof(matchprecision), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            return new DeferredBodyAction<FindResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/find";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["format"] = Convert.ToString("JSON");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_minmatch != null)
                    callPayload.Queries["minmatch"] = ExpressionConverter.Convert(__workflow_minmatch);
                if (__workflow_matchprecision != null)
                    callPayload.Queries["matchprecision"] = ExpressionConverter.Convert(__workflow_matchprecision);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                return new ApiConnectionAction<FindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<PostcodeResponse, ApiConnectionActionConfiguration> Postcode(Expression<Func<string>> postcode, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null)
        {
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            return new DeferredBodyAction<PostcodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/postcode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                return new ApiConnectionAction<PostcodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<UprnResponse, ApiConnectionActionConfiguration> Uprn(Expression<Func<int>> uprn, Expression<Func<string>> format = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null)
        {
            var __workflow_uprn = WorkflowExpression.Compile(uprn, nameof(uprn), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            return new DeferredBodyAction<UprnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/uprn";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["uprn"] = ExpressionConverter.Convert(__workflow_uprn);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                return new ApiConnectionAction<UprnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<NearestResponse, ApiConnectionActionConfiguration> Nearest(Expression<Func<string>> point, Expression<Func<int>> radius = null, Expression<Func<string>> format = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var __workflow_point = WorkflowExpression.Compile(point, nameof(point), required: true);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<NearestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/nearest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["point"] = ExpressionConverter.Convert(__workflow_point);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                return new ApiConnectionAction<NearestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<BBoxResponse, ApiConnectionActionConfiguration> BBox(Expression<Func<string>> bbox, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var __workflow_bbox = WorkflowExpression.Compile(bbox, nameof(bbox), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<BBoxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/bbox";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bbox"] = ExpressionConverter.Convert(__workflow_bbox);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                return new ApiConnectionAction<BBoxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<RadiusResponse, ApiConnectionActionConfiguration> Radius(Expression<Func<string>> point, Expression<Func<int>> radius = null, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var __workflow_point = WorkflowExpression.Compile(point, nameof(point), required: true);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<RadiusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/radius";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["point"] = ExpressionConverter.Convert(__workflow_point);
                callPayload.Queries["radius"] = Convert.ToString(100);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                return new ApiConnectionAction<RadiusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<PolygonResponse, ApiConnectionActionConfiguration> Polygon(Expression<Func<string>> contentType, Expression<Func<BodyInput>> body, Expression<Func<int>> referencepoint = null, Expression<Func<int>> maxresults = null, Expression<Func<string>> dataset = null, Expression<Func<int>> offset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_referencepoint = WorkflowExpression.Compile(referencepoint, nameof(referencepoint), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_lr = WorkflowExpression.Compile(lr, nameof(lr), required: false);
            var __workflow_fq = WorkflowExpression.Compile(fq, nameof(fq), required: false);
            var __workflow_outputSrs = WorkflowExpression.Compile(outputSrs, nameof(outputSrs), required: false);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<PolygonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/places/v1/addresses/polygon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_referencepoint != null)
                    callPayload.Queries["referencepoint"] = ExpressionConverter.Convert(__workflow_referencepoint);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(__workflow_dataset);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_lr != null)
                    callPayload.Queries["lr"] = ExpressionConverter.Convert(__workflow_lr);
                if (__workflow_fq != null)
                    callPayload.Queries["fq"] = ExpressionConverter.Convert(__workflow_fq);
                if (__workflow_outputSrs != null)
                    callPayload.Queries["output_srs"] = ExpressionConverter.Convert(__workflow_outputSrs);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        [JsonProperty("DPA")]
        public FindResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public FindResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class FindResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class FindResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
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
        [JsonProperty("DPA")]
        public PostcodeResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public PostcodeResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class PostcodeResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class PostcodeResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class UprnResponse
    {
        [JsonProperty("header")]
        public UprnResponseHeaderType Header { get; set; }

        [JsonProperty("results")]
        public UprnResponseResultsTypeItem[] Results { get; set; }
    }

    public class UprnResponseHeaderType
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

    public class UprnResponseResultsTypeItem
    {
        [JsonProperty("DPA")]
        public UprnResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public UprnResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class UprnResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class UprnResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
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
        [JsonProperty("DPA")]
        public NearestResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public NearestResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class NearestResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class NearestResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
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
        [JsonProperty("DPA")]
        public BBoxResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public BBoxResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class BBoxResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class BBoxResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
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
        [JsonProperty("DPA")]
        public RadiusResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public RadiusResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class RadiusResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class RadiusResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
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
        [JsonProperty("DPA")]
        public PolygonResponseResultsTypeItemDpaType Dpa { get; set; }

        [JsonProperty("LPI")]
        public PolygonResponseResultsTypeItemLpiType Lpi { get; set; }
    }

    public class PolygonResponseResultsTypeItemDpaType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }

        [JsonProperty("BUILDING_NUMBER")]
        public string BuildingNumber { get; set; }

        [JsonProperty("THOROUGHFARE_NAME")]
        public string ThoroughfareName { get; set; }

        [JsonProperty("DEPENDENT_LOCALITY")]
        public string DependentLocality { get; set; }

        [JsonProperty("POST_TOWN")]
        public string PostTown { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE")]
        public string BlpuStateCode { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("BLPU_STATE_DATE")]
        public string BlpuStateDate { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class PolygonResponseResultsTypeItemLpiType
    {
        [JsonProperty("UPRN")]
        public string Uprn { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("USRN")]
        public string Usrn { get; set; }

        [JsonProperty("LPI_KEY")]
        public string LpiKey { get; set; }

        [JsonProperty("PAO_START_NUMBER")]
        public string PaoStartNumber { get; set; }

        [JsonProperty("STREET_DESCRIPTION")]
        public string StreetDescription { get; set; }

        [JsonProperty("TOWN_NAME")]
        public string TownName { get; set; }

        [JsonProperty("ADMINISTRATIVE_AREA")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("POSTCODE_LOCATOR")]
        public string PostcodeLocator { get; set; }

        [JsonProperty("RPC")]
        public string Rpc { get; set; }

        [JsonProperty("X_COORDINATE")]
        public double XCoordinate { get; set; }

        [JsonProperty("Y_COORDINATE")]
        public double YCoordinate { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }

        [JsonProperty("LOGICAL_STATUS_CODE")]
        public string LogicalStatusCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE")]
        public string ClassificationCode { get; set; }

        [JsonProperty("CLASSIFICATION_CODE_DESCRIPTION")]
        public string ClassificationCodeDescription { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE")]
        public int LocalCustodianCode { get; set; }

        [JsonProperty("LOCAL_CUSTODIAN_CODE_DESCRIPTION")]
        public string LocalCustodianCodeDescription { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE")]
        public string PostalAddressCode { get; set; }

        [JsonProperty("POSTAL_ADDRESS_CODE_DESCRIPTION")]
        public string PostalAddressCodeDescription { get; set; }

        [JsonProperty("BLPU_STATE_CODE_DESCRIPTION")]
        public string BlpuStateCodeDescription { get; set; }

        [JsonProperty("TOPOGRAPHY_LAYER_TOID")]
        public string TopographyLayerToid { get; set; }

        [JsonProperty("LAST_UPDATE_DATE")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("STREET_STATE_CODE")]
        public string StreetStateCode { get; set; }

        [JsonProperty("STREET_STATE_CODE_DESCRIPTION")]
        public string StreetStateCodeDescription { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE")]
        public string StreetClassificationCode { get; set; }

        [JsonProperty("STREET_CLASSIFICATION_CODE_DESCRIPTION")]
        public string StreetClassificationCodeDescription { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE")]
        public string LpiLogicalStatusCode { get; set; }

        [JsonProperty("LPI_LOGICAL_STATUS_CODE_DESCRIPTION")]
        public string LpiLogicalStatusCodeDescription { get; set; }

        [JsonProperty("LANGUAGE")]
        public string Language { get; set; }

        [JsonProperty("MATCH")]
        public double Match { get; set; }

        [JsonProperty("MATCH_DESCRIPTION")]
        public string MatchDescription { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(string geometry)
        {
            this.Geometry = geometry;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; } = "Feature";

        [JsonProperty("geometry", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Geometry { get; set; }
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