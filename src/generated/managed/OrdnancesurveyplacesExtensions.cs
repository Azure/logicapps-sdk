//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ordnancesurveyplaces
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrdnancesurveyplacesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<FindResponse> Find(Expression<Func<string>> query, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<double>> minmatch = null, Expression<Func<int>> matchprecision = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null)
        {
            var apiCallPath = "/places/v1/addresses/find";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = CSharpExpressionConverter.ConvertO(query);
            callPayload.Queries["format"] = Convert.ToString("JSON");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (maxresults != null)
                callPayload.Queries["maxresults"] = CSharpExpressionConverter.ConvertO(maxresults);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (minmatch != null)
                callPayload.Queries["minmatch"] = CSharpExpressionConverter.ConvertO(minmatch);
            if (matchprecision != null)
                callPayload.Queries["matchprecision"] = CSharpExpressionConverter.ConvertO(matchprecision);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            return new ApiConnectionAction<FindResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<PostcodeResponse> Postcode(Expression<Func<string>> postcode, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null)
        {
            var apiCallPath = "/places/v1/addresses/postcode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["postcode"] = CSharpExpressionConverter.ConvertO(postcode);
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (maxresults != null)
                callPayload.Queries["maxresults"] = CSharpExpressionConverter.ConvertO(maxresults);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            return new ApiConnectionAction<PostcodeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<UPRNResponse> UPRN(Expression<Func<int>> uprn, Expression<Func<string>> format = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null)
        {
            var apiCallPath = "/places/v1/addresses/uprn";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["uprn"] = CSharpExpressionConverter.ConvertO(uprn);
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            return new ApiConnectionAction<UPRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<NearestResponse> Nearest(Expression<Func<string>> point, Expression<Func<int>> radius = null, Expression<Func<string>> format = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var apiCallPath = "/places/v1/addresses/nearest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["point"] = CSharpExpressionConverter.ConvertO(point);
            if (radius != null)
                callPayload.Queries["radius"] = CSharpExpressionConverter.ConvertO(radius);
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            if (srs != null)
                callPayload.Queries["srs"] = CSharpExpressionConverter.ConvertO(srs);
            return new ApiConnectionAction<NearestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<BBoxResponse> BBox(Expression<Func<string>> bbox, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var apiCallPath = "/places/v1/addresses/bbox";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bbox"] = CSharpExpressionConverter.ConvertO(bbox);
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (maxresults != null)
                callPayload.Queries["maxresults"] = CSharpExpressionConverter.ConvertO(maxresults);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            if (srs != null)
                callPayload.Queries["srs"] = CSharpExpressionConverter.ConvertO(srs);
            return new ApiConnectionAction<BBoxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<RadiusResponse> Radius(Expression<Func<string>> point, Expression<Func<int>> radius = null, Expression<Func<string>> format = null, Expression<Func<int>> maxresults = null, Expression<Func<int>> offset = null, Expression<Func<string>> dataset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var apiCallPath = "/places/v1/addresses/radius";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["point"] = CSharpExpressionConverter.ConvertO(point);
            callPayload.Queries["radius"] = Convert.ToString(100);
            if (radius != null)
                callPayload.Queries["radius"] = CSharpExpressionConverter.ConvertO(radius);
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (maxresults != null)
                callPayload.Queries["maxresults"] = CSharpExpressionConverter.ConvertO(maxresults);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            if (srs != null)
                callPayload.Queries["srs"] = CSharpExpressionConverter.ConvertO(srs);
            return new ApiConnectionAction<RadiusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ordnancesurveyplaces")]
        public IBodyWorkflowAction<PolygonResponse> Polygon(Expression<Func<string>> contentType, Expression<Func<string>> bodytype, Expression<Func<string>> bodygeometry, Expression<Func<int>> referencepoint = null, Expression<Func<int>> maxresults = null, Expression<Func<string>> dataset = null, Expression<Func<int>> offset = null, Expression<Func<string>> lr = null, Expression<Func<string>> fq = null, Expression<Func<string>> outputSrs = null, Expression<Func<string>> srs = null)
        {
            var apiCallPath = "/places/v1/addresses/polygon";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (referencepoint != null)
                callPayload.Queries["referencepoint"] = CSharpExpressionConverter.ConvertO(referencepoint);
            if (maxresults != null)
                callPayload.Queries["maxresults"] = CSharpExpressionConverter.ConvertO(maxresults);
            if (dataset != null)
                callPayload.Queries["dataset"] = CSharpExpressionConverter.ConvertO(dataset);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (lr != null)
                callPayload.Queries["lr"] = CSharpExpressionConverter.ConvertO(lr);
            if (fq != null)
                callPayload.Queries["fq"] = CSharpExpressionConverter.ConvertO(fq);
            if (outputSrs != null)
                callPayload.Queries["output_srs"] = CSharpExpressionConverter.ConvertO(outputSrs);
            if (srs != null)
                callPayload.Queries["srs"] = CSharpExpressionConverter.ConvertO(srs);
            callPayload.Headers["Content-type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
            bodypropCount++;
            body["geometry"] = CSharpExpressionConverter.ConvertToken(bodygeometry);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PolygonResponse>(callPayload);
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