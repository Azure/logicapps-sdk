//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Pixelaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete()
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserPostResponse> UserPost(Expression<Func<string>> bodytoken = null, Expression<Func<string>> bodyusername = null, Expression<Func<bodyagreeTermsOfServiceInput>> bodyagreeTermsOfService = null, Expression<Func<bodynotMinorInput>> bodynotMinor = null, Expression<Func<string>> bodythanksCode = null)
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytoken != null)
            {
                body["token"] = ExpressionConverter.ConvertO(bodytoken);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodyagreeTermsOfService != null)
            {
                body["agreeTermsOfService"] = ExpressionConverter.ConvertO(bodyagreeTermsOfService);
                bodypropCount++;
            }

            if (bodynotMinor != null)
            {
                body["notMinor"] = ExpressionConverter.ConvertO(bodynotMinor);
                bodypropCount++;
            }

            if (bodythanksCode != null)
            {
                body["thanksCode"] = ExpressionConverter.ConvertO(bodythanksCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<TokenPutResponse> TokenPut(Expression<Func<string>> bodynewToken, Expression<Func<string>> bodythanksCode = null)
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["newToken"] = ExpressionConverter.ConvertO(bodynewToken);
            if (bodythanksCode != null)
            {
                body["thanksCode"] = ExpressionConverter.ConvertO(bodythanksCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TokenPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<ProfilePutResponse> ProfilePut(Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodygravatarIconEmail = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyaboutURL = null, Expression<Func<string[]>> bodycontributeURLs = null, Expression<Func<string>> bodypinnedGraphID = null)
        {
            var apiCallPath = "/@";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodygravatarIconEmail != null)
            {
                body["gravatarIconEmail"] = ExpressionConverter.ConvertO(bodygravatarIconEmail);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyaboutURL != null)
            {
                body["aboutURL"] = ExpressionConverter.ConvertO(bodyaboutURL);
                bodypropCount++;
            }

            if (bodycontributeURLs != null)
            {
                body["contributeURLs"] = ExpressionConverter.ConvertO(bodycontributeURLs);
                bodypropCount++;
            }

            if (bodypinnedGraphID != null)
            {
                body["pinnedGraphID"] = ExpressionConverter.ConvertO(bodypinnedGraphID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProfilePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphsGetResponse> GraphsGet()
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphDeleteResponse> GraphDelete(Expression<Func<string>> graphID)
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            return new ApiConnectionAction<GraphDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPostResponse> GraphPost(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyunit, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyselfSufficient = null, Expression<Func<bool>> bodyisSecret = null, Expression<Func<bool>> bodypublishOptionalData = null)
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["unit"] = ExpressionConverter.ConvertO(bodyunit);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["color"] = ExpressionConverter.ConvertO(bodycolor);
            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyselfSufficient != null)
            {
                body["selfSufficient"] = ExpressionConverter.ConvertO(bodyselfSufficient);
                bodypropCount++;
            }

            if (bodyisSecret != null)
            {
                body["isSecret"] = ExpressionConverter.ConvertO(bodyisSecret);
                bodypropCount++;
            }

            if (bodypublishOptionalData != null)
            {
                body["publishOptionalData"] = ExpressionConverter.ConvertO(bodypublishOptionalData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GraphPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPutResponse> GraphPut(Expression<Func<string>> graphID, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyunit = null, Expression<Func<bodycolorInput>> bodycolor = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyselfSufficient = null, Expression<Func<bool>> bodyisSecret = null, Expression<Func<bool>> bodypublishOptionalData = null)
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyunit != null)
            {
                body["unit"] = ExpressionConverter.ConvertO(bodyunit);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyselfSufficient != null)
            {
                body["selfSufficient"] = ExpressionConverter.ConvertO(bodyselfSufficient);
                bodypropCount++;
            }

            if (bodyisSecret != null)
            {
                body["isSecret"] = ExpressionConverter.ConvertO(bodyisSecret);
                bodypropCount++;
            }

            if (bodypublishOptionalData != null)
            {
                body["publishOptionalData"] = ExpressionConverter.ConvertO(bodypublishOptionalData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GraphPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphGetResponse> GraphGet(Expression<Func<string>> graphID)
        {
            var apiCallPath = "/v1/users/graphs/graph-def";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            return new ApiConnectionAction<GraphGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphSVGGetResponse> GraphSVGGet(Expression<Func<string>> graphID, Expression<Func<string>> date = null, Expression<Func<modeInput>> mode = null, Expression<Func<appearanceInput>> appearance = null)
        {
            var apiCallPath = "/v1/users/graphs/graphSVG";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            if (mode != null)
                callPayload.Queries["mode"] = ExpressionConverter.Convert(mode);
            if (appearance != null)
                callPayload.Queries["appearance"] = ExpressionConverter.Convert(appearance);
            return new ApiConnectionAction<GraphSVGGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelsGetResponse> PixelsGet(Expression<Func<string>> graphID, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<bool>> withBody = null)
        {
            var apiCallPath = "/v1/users/graphs/pixels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            if (from != null)
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            if (to != null)
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            if (withBody != null)
                callPayload.Queries["withBody"] = ExpressionConverter.Convert(withBody);
            return new ApiConnectionAction<PixelsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<StatsGetResponse> StatsGet(Expression<Func<string>> graphID)
        {
            var apiCallPath = "/v1/users/graphs/stats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            return new ApiConnectionAction<StatsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPostResponse> PixelPost(Expression<Func<string>> graphID, Expression<Func<string>> bodydate, Expression<Func<string>> bodyquantity)
        {
            var apiCallPath = "/v1/users/graphs/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            bodypropCount++;
            body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
            var optionalDataObject = new JObject();
            var optionalDataObjectpropCount = 0;
            if (optionalDataObjectpropCount > 0)
            {
                body["optionalData"] = optionalDataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelGetResponse> PixelGet(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDeleteResponse> PixelDelete(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelRetinaGetResponse> PixelRetinaGet(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel/retina";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelRetinaGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelIncrementPutResponse> PixelIncrementPut(Expression<Func<string>> graphID = null)
        {
            var apiCallPath = "/v1/users/graphs/increment";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (graphID != null)
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Headers["Content-Length"] = Convert.ToString(0);
            return new ApiConnectionAction<PixelIncrementPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDecrementPutResponse> PixelDecrementPut(Expression<Func<string>> graphID = null)
        {
            var apiCallPath = "/v1/users/graphs/decrement";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (graphID != null)
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Headers["Content-Length"] = Convert.ToString(0);
            return new ApiConnectionAction<PixelDecrementPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelAddPutResponse> PixelAddPut(Expression<Func<string>> graphID, Expression<Func<int>> bodyquantity = null)
        {
            var apiCallPath = "/v1/users/graphs/add";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquantity != null)
            {
                body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelAddPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelSubtractPutResponse> PixelSubtractPut(Expression<Func<string>> graphID, Expression<Func<int>> bodyquantity = null)
        {
            var apiCallPath = "/v1/users/graphs/subtract";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquantity != null)
            {
                body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelSubtractPutResponse>(callPayload);
        }
    }

    public class PixelaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class UserPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public enum bodyagreeTermsOfServiceInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public enum bodynotMinorInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public class TokenPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class ProfilePutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphsGetResponse
    {
        [JsonProperty("graphs")]
        public GraphsGetResponseGraphsTypeItem[] Graphs { get; set; }
    }

    public class GraphsGetResponseGraphsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "float")]
        Float
    }

    public enum bodycolorInput
    {
        [EnumMember(Value = "shibafu")]
        Shibafu,
        [EnumMember(Value = "momiji")]
        Momiji,
        [EnumMember(Value = "sora")]
        Sora,
        [EnumMember(Value = "ichou")]
        Ichou,
        [EnumMember(Value = "ajisai")]
        Ajisai,
        [EnumMember(Value = "kuro")]
        Kuro
    }

    public class GraphPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphSVGGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum modeInput
    {
        [EnumMember(Value = "short")]
        Short,
        [EnumMember(Value = "badge")]
        Badge,
        [EnumMember(Value = "line")]
        Line
    }

    public enum appearanceInput
    {
        [EnumMember(Value = "dark")]
        Dark
    }

    public class PixelsGetResponse
    {
        [JsonProperty("pixels")]
        public PixelsGetResponsePixelsTypeItem[] Pixels { get; set; }
    }

    public class PixelsGetResponsePixelsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("optionalData")]
        public JToken OptionalData { get; set; }
    }

    public class StatsGetResponse
    {
        [JsonProperty("totalPixelsCount")]
        public int TotalPixelsCount { get; set; }

        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }

        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("avgQuantity")]
        public double AvgQuantity { get; set; }

        [JsonProperty("todaysQuantity")]
        public int TodaysQuantity { get; set; }
    }

    public class PixelPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelGetResponse
    {
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    public class PixelDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelRetinaGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class PixelIncrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelDecrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelAddPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelSubtractPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Pixelaip;

    public partial class WorkflowManagedActions
    {
        public PixelaipActions Pixelaip(string connectionId) => new PixelaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PixelaipTriggers Pixelaip(string connectionId) => new PixelaipTriggers(connectionId);
    }
}