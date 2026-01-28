//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PilotthingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageAlertRo> GetAlerts(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> dateStart = null, Expression<Func<int>> dateEnd = null)
        {
            var apiCallPath = "/api/alerts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            callPayload.Queries["dateStart"] = Convert.ToString(0);
            if (dateStart != null)
                callPayload.Queries["dateStart"] = ExpressionConverter.Convert(dateStart);
            callPayload.Queries["dateEnd"] = Convert.ToString(0);
            if (dateEnd != null)
                callPayload.Queries["dateEnd"] = ExpressionConverter.Convert(dateEnd);
            return new ApiConnectionAction<PageAlertRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AlertRo> UpdateAlertState(Expression<Func<string>> id, Expression<Func<string>> paramJson = null)
        {
            var apiCallPath = String.Format("/api/alerts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(paramJson);
            return new ApiConnectionAction<AlertRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo> GetMeasures(Expression<Func<bool>> detailed = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = "/api/measures";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["detailed"] = Convert.ToString(false);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CountRo> GetCount(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = "/api/measures/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<CountRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureRo> GetMeasure(Expression<Func<string>> id, Expression<Func<bool>> detailed = null)
        {
            var apiCallPath = String.Format("/api/measures/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["detailed"] = Convert.ToString(false);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            return new ApiConnectionAction<MeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetMessages(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = "/api/messages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageMessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetMessagesAndMeasurements(Expression<Func<string>> thingId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = String.Format("/api/messages/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageMessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> AddMessage(Expression<Func<string>> thingId, Expression<Func<string>> messageRobody, Expression<Func<string>> messageRocreationDate, Expression<Func<string>> messageRoerrorMessage, Expression<Func<double>> messageRolatitude, Expression<Func<double>> messageRolongitude, Expression<Func<string>> messageRometadata, Expression<Func<int>> messageRonumber, Expression<Func<messageRoprocessedInput>> messageRoprocessed, Expression<Func<string>> messageRothingname, Expression<Func<string>> messageRotimestamp, Expression<Func<string>> messageRotopic, Expression<Func<string>> messageRoid = null, Expression<Func<bool>> messageRolinkabsolute = null, Expression<Func<string>> messageRolinkauthority = null, Expression<Func<string>> messageRolinkfragment = null, Expression<Func<string>> messageRolinkhost = null, Expression<Func<bool>> messageRolinkopaque = null, Expression<Func<string>> messageRolinkpath = null, Expression<Func<int>> messageRolinkport = null, Expression<Func<string>> messageRolinkquery = null, Expression<Func<string>> messageRolinkrawAuthority = null, Expression<Func<string>> messageRolinkrawFragment = null, Expression<Func<string>> messageRolinkrawPath = null, Expression<Func<string>> messageRolinkrawQuery = null, Expression<Func<string>> messageRolinkrawSchemeSpecificPart = null, Expression<Func<string>> messageRolinkrawUserInfo = null, Expression<Func<string>> messageRolinkscheme = null, Expression<Func<string>> messageRolinkschemeSpecificPart = null, Expression<Func<string>> messageRolinkuserInfo = null, Expression<Func<bool>> messageRorawMeasurementsarray = null, Expression<Func<bool>> messageRorawMeasurementsbigDecimal = null, Expression<Func<bool>> messageRorawMeasurementsbigInteger = null, Expression<Func<bool>> messageRorawMeasurementsbinary = null, Expression<Func<bool>> messageRorawMeasurementsboolean = null, Expression<Func<bool>> messageRorawMeasurementscontainerNode = null, Expression<Func<bool>> messageRorawMeasurementsdouble = null, Expression<Func<bool>> messageRorawMeasurementsfloat = null, Expression<Func<bool>> messageRorawMeasurementsfloatingPointNumber = null, Expression<Func<bool>> messageRorawMeasurementsint = null, Expression<Func<bool>> messageRorawMeasurementsintegralNumber = null, Expression<Func<bool>> messageRorawMeasurementsLong = null, Expression<Func<bool>> messageRorawMeasurementsmissingNode = null, Expression<Func<messageRorawMeasurementsnodeTypeInput>> messageRorawMeasurementsnodeType = null, Expression<Func<bool>> messageRorawMeasurementsnull = null, Expression<Func<bool>> messageRorawMeasurementsnumber = null, Expression<Func<bool>> messageRorawMeasurementsObject = null, Expression<Func<bool>> messageRorawMeasurementspojo = null, Expression<Func<bool>> messageRorawMeasurementsShort = null, Expression<Func<bool>> messageRorawMeasurementstextual = null, Expression<Func<bool>> messageRorawMeasurementsvalueNode = null, Expression<Func<string>> messageRothingdisplayName = null, Expression<Func<string>> messageRothingfixedName = null, Expression<Func<string>> messageRothingid = null, Expression<Func<int>> messageRothingnbAlerts = null, Expression<Func<ThingTagRo[]>> messageRothingtags = null)
        {
            var apiCallPath = String.Format("/api/messages/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var messageRo = new JObject();
            var messageRopropCount = 0;
            messageRopropCount++;
            messageRo["body"] = ExpressionConverter.ConvertO(messageRobody);
            messageRopropCount++;
            messageRo["creationDate"] = ExpressionConverter.ConvertO(messageRocreationDate);
            messageRopropCount++;
            messageRo["errorMessage"] = ExpressionConverter.ConvertO(messageRoerrorMessage);
            if (messageRoid != null)
            {
                messageRo["id"] = ExpressionConverter.ConvertO(messageRoid);
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["latitude"] = ExpressionConverter.ConvertO(messageRolatitude);
            var linkObject = new JObject();
            var linkObjectpropCount = 0;
            if (messageRolinkabsolute != null)
            {
                linkObject["absolute"] = ExpressionConverter.ConvertO(messageRolinkabsolute);
                linkObjectpropCount++;
            }

            if (messageRolinkauthority != null)
            {
                linkObject["authority"] = ExpressionConverter.ConvertO(messageRolinkauthority);
                linkObjectpropCount++;
            }

            if (messageRolinkfragment != null)
            {
                linkObject["fragment"] = ExpressionConverter.ConvertO(messageRolinkfragment);
                linkObjectpropCount++;
            }

            if (messageRolinkhost != null)
            {
                linkObject["host"] = ExpressionConverter.ConvertO(messageRolinkhost);
                linkObjectpropCount++;
            }

            if (messageRolinkopaque != null)
            {
                linkObject["opaque"] = ExpressionConverter.ConvertO(messageRolinkopaque);
                linkObjectpropCount++;
            }

            if (messageRolinkpath != null)
            {
                linkObject["path"] = ExpressionConverter.ConvertO(messageRolinkpath);
                linkObjectpropCount++;
            }

            if (messageRolinkport != null)
            {
                linkObject["port"] = ExpressionConverter.ConvertO(messageRolinkport);
                linkObjectpropCount++;
            }

            if (messageRolinkquery != null)
            {
                linkObject["query"] = ExpressionConverter.ConvertO(messageRolinkquery);
                linkObjectpropCount++;
            }

            if (messageRolinkrawAuthority != null)
            {
                linkObject["rawAuthority"] = ExpressionConverter.ConvertO(messageRolinkrawAuthority);
                linkObjectpropCount++;
            }

            if (messageRolinkrawFragment != null)
            {
                linkObject["rawFragment"] = ExpressionConverter.ConvertO(messageRolinkrawFragment);
                linkObjectpropCount++;
            }

            if (messageRolinkrawPath != null)
            {
                linkObject["rawPath"] = ExpressionConverter.ConvertO(messageRolinkrawPath);
                linkObjectpropCount++;
            }

            if (messageRolinkrawQuery != null)
            {
                linkObject["rawQuery"] = ExpressionConverter.ConvertO(messageRolinkrawQuery);
                linkObjectpropCount++;
            }

            if (messageRolinkrawSchemeSpecificPart != null)
            {
                linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkrawSchemeSpecificPart);
                linkObjectpropCount++;
            }

            if (messageRolinkrawUserInfo != null)
            {
                linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(messageRolinkrawUserInfo);
                linkObjectpropCount++;
            }

            if (messageRolinkscheme != null)
            {
                linkObject["scheme"] = ExpressionConverter.ConvertO(messageRolinkscheme);
                linkObjectpropCount++;
            }

            if (messageRolinkschemeSpecificPart != null)
            {
                linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkschemeSpecificPart);
                linkObjectpropCount++;
            }

            if (messageRolinkuserInfo != null)
            {
                linkObject["userInfo"] = ExpressionConverter.ConvertO(messageRolinkuserInfo);
                linkObjectpropCount++;
            }

            if (linkObjectpropCount > 0)
            {
                messageRo["link"] = linkObject;
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["longitude"] = ExpressionConverter.ConvertO(messageRolongitude);
            var measurementsObject = new JObject();
            var measurementsObjectpropCount = 0;
            if (measurementsObjectpropCount > 0)
            {
                messageRo["measurements"] = measurementsObject;
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["metadata"] = ExpressionConverter.ConvertO(messageRometadata);
            messageRopropCount++;
            messageRo["number"] = ExpressionConverter.ConvertO(messageRonumber);
            messageRopropCount++;
            messageRo["processed"] = ExpressionConverter.ConvertO(messageRoprocessed);
            var rawMeasurementsObject = new JObject();
            var rawMeasurementsObjectpropCount = 0;
            if (messageRorawMeasurementsarray != null)
            {
                rawMeasurementsObject["array"] = ExpressionConverter.ConvertO(messageRorawMeasurementsarray);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsbigDecimal != null)
            {
                rawMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(messageRorawMeasurementsbigDecimal);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsbigInteger != null)
            {
                rawMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(messageRorawMeasurementsbigInteger);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsbinary != null)
            {
                rawMeasurementsObject["binary"] = ExpressionConverter.ConvertO(messageRorawMeasurementsbinary);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsboolean != null)
            {
                rawMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(messageRorawMeasurementsboolean);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementscontainerNode != null)
            {
                rawMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(messageRorawMeasurementscontainerNode);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsdouble != null)
            {
                rawMeasurementsObject["double"] = ExpressionConverter.ConvertO(messageRorawMeasurementsdouble);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsfloat != null)
            {
                rawMeasurementsObject["float"] = ExpressionConverter.ConvertO(messageRorawMeasurementsfloat);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsfloatingPointNumber != null)
            {
                rawMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(messageRorawMeasurementsfloatingPointNumber);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsint != null)
            {
                rawMeasurementsObject["int"] = ExpressionConverter.ConvertO(messageRorawMeasurementsint);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsintegralNumber != null)
            {
                rawMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(messageRorawMeasurementsintegralNumber);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsLong != null)
            {
                rawMeasurementsObject["long"] = ExpressionConverter.ConvertO(messageRorawMeasurementsLong);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsmissingNode != null)
            {
                rawMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(messageRorawMeasurementsmissingNode);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsnodeType != null)
            {
                rawMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(messageRorawMeasurementsnodeType);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsnull != null)
            {
                rawMeasurementsObject["null"] = ExpressionConverter.ConvertO(messageRorawMeasurementsnull);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsnumber != null)
            {
                rawMeasurementsObject["number"] = ExpressionConverter.ConvertO(messageRorawMeasurementsnumber);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsObject != null)
            {
                rawMeasurementsObject["object"] = ExpressionConverter.ConvertO(messageRorawMeasurementsObject);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementspojo != null)
            {
                rawMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(messageRorawMeasurementspojo);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsShort != null)
            {
                rawMeasurementsObject["short"] = ExpressionConverter.ConvertO(messageRorawMeasurementsShort);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementstextual != null)
            {
                rawMeasurementsObject["textual"] = ExpressionConverter.ConvertO(messageRorawMeasurementstextual);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRorawMeasurementsvalueNode != null)
            {
                rawMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(messageRorawMeasurementsvalueNode);
                rawMeasurementsObjectpropCount++;
            }

            if (rawMeasurementsObjectpropCount > 0)
            {
                messageRo["rawMeasurements"] = rawMeasurementsObject;
                messageRopropCount++;
            }

            var thingObject = new JObject();
            var thingObjectpropCount = 0;
            if (messageRothingdisplayName != null)
            {
                thingObject["displayName"] = ExpressionConverter.ConvertO(messageRothingdisplayName);
                thingObjectpropCount++;
            }

            if (messageRothingfixedName != null)
            {
                thingObject["fixedName"] = ExpressionConverter.ConvertO(messageRothingfixedName);
                thingObjectpropCount++;
            }

            if (messageRothingid != null)
            {
                thingObject["id"] = ExpressionConverter.ConvertO(messageRothingid);
                thingObjectpropCount++;
            }

            thingObjectpropCount++;
            thingObject["name"] = ExpressionConverter.ConvertO(messageRothingname);
            if (messageRothingnbAlerts != null)
            {
                thingObject["nbAlerts"] = ExpressionConverter.ConvertO(messageRothingnbAlerts);
                thingObjectpropCount++;
            }

            if (messageRothingtags != null)
            {
                thingObject["tags"] = ExpressionConverter.ConvertO(messageRothingtags);
                thingObjectpropCount++;
            }

            if (thingObjectpropCount > 0)
            {
                messageRo["thing"] = thingObject;
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["timestamp"] = ExpressionConverter.ConvertO(messageRotimestamp);
            messageRopropCount++;
            messageRo["topic"] = ExpressionConverter.ConvertO(messageRotopic);
            if (messageRopropCount > 0)
            {
                callPayload.Body = messageRo;
            }

            return new ApiConnectionAction<MessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> GetMessage(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> GetPreviousMessage(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/messages/{0}/previous", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSiteRo> GetSites(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = "/api/sites";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageSiteRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo[]> CreateSite(Expression<Func<bool>> nodearray = null, Expression<Func<bool>> nodebigDecimal = null, Expression<Func<bool>> nodebigInteger = null, Expression<Func<bool>> nodebinary = null, Expression<Func<bool>> nodeboolean = null, Expression<Func<bool>> nodecontainerNode = null, Expression<Func<bool>> nodedouble = null, Expression<Func<bool>> nodefloat = null, Expression<Func<bool>> nodefloatingPointNumber = null, Expression<Func<bool>> nodeint = null, Expression<Func<bool>> nodeintegralNumber = null, Expression<Func<bool>> nodeLong = null, Expression<Func<bool>> nodemissingNode = null, Expression<Func<nodenodeTypeInput>> nodenodeType = null, Expression<Func<bool>> nodenull = null, Expression<Func<bool>> nodenumber = null, Expression<Func<bool>> nodeObject = null, Expression<Func<bool>> nodepojo = null, Expression<Func<bool>> nodeShort = null, Expression<Func<bool>> nodetextual = null, Expression<Func<bool>> nodevalueNode = null)
        {
            var apiCallPath = "/api/sites";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var node = new JObject();
            var nodepropCount = 0;
            if (nodearray != null)
            {
                node["array"] = ExpressionConverter.ConvertO(nodearray);
                nodepropCount++;
            }

            if (nodebigDecimal != null)
            {
                node["bigDecimal"] = ExpressionConverter.ConvertO(nodebigDecimal);
                nodepropCount++;
            }

            if (nodebigInteger != null)
            {
                node["bigInteger"] = ExpressionConverter.ConvertO(nodebigInteger);
                nodepropCount++;
            }

            if (nodebinary != null)
            {
                node["binary"] = ExpressionConverter.ConvertO(nodebinary);
                nodepropCount++;
            }

            if (nodeboolean != null)
            {
                node["boolean"] = ExpressionConverter.ConvertO(nodeboolean);
                nodepropCount++;
            }

            if (nodecontainerNode != null)
            {
                node["containerNode"] = ExpressionConverter.ConvertO(nodecontainerNode);
                nodepropCount++;
            }

            if (nodedouble != null)
            {
                node["double"] = ExpressionConverter.ConvertO(nodedouble);
                nodepropCount++;
            }

            if (nodefloat != null)
            {
                node["float"] = ExpressionConverter.ConvertO(nodefloat);
                nodepropCount++;
            }

            if (nodefloatingPointNumber != null)
            {
                node["floatingPointNumber"] = ExpressionConverter.ConvertO(nodefloatingPointNumber);
                nodepropCount++;
            }

            if (nodeint != null)
            {
                node["int"] = ExpressionConverter.ConvertO(nodeint);
                nodepropCount++;
            }

            if (nodeintegralNumber != null)
            {
                node["integralNumber"] = ExpressionConverter.ConvertO(nodeintegralNumber);
                nodepropCount++;
            }

            if (nodeLong != null)
            {
                node["long"] = ExpressionConverter.ConvertO(nodeLong);
                nodepropCount++;
            }

            if (nodemissingNode != null)
            {
                node["missingNode"] = ExpressionConverter.ConvertO(nodemissingNode);
                nodepropCount++;
            }

            if (nodenodeType != null)
            {
                node["nodeType"] = ExpressionConverter.ConvertO(nodenodeType);
                nodepropCount++;
            }

            if (nodenull != null)
            {
                node["null"] = ExpressionConverter.ConvertO(nodenull);
                nodepropCount++;
            }

            if (nodenumber != null)
            {
                node["number"] = ExpressionConverter.ConvertO(nodenumber);
                nodepropCount++;
            }

            if (nodeObject != null)
            {
                node["object"] = ExpressionConverter.ConvertO(nodeObject);
                nodepropCount++;
            }

            if (nodepojo != null)
            {
                node["pojo"] = ExpressionConverter.ConvertO(nodepojo);
                nodepropCount++;
            }

            if (nodeShort != null)
            {
                node["short"] = ExpressionConverter.ConvertO(nodeShort);
                nodepropCount++;
            }

            if (nodetextual != null)
            {
                node["textual"] = ExpressionConverter.ConvertO(nodetextual);
                nodepropCount++;
            }

            if (nodevalueNode != null)
            {
                node["valueNode"] = ExpressionConverter.ConvertO(nodevalueNode);
                nodepropCount++;
            }

            if (nodepropCount > 0)
            {
                callPayload.Body = node;
            }

            return new ApiConnectionAction<SiteRo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo> GetSite(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SiteRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction DeleteSite(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo> UpdateSite(Expression<Func<string>> id, Expression<Func<string>> siteRoaddress, Expression<Func<string>> siteRocity, Expression<Func<string>> siteRoname, Expression<Func<string>> siteRopostalCode, Expression<Func<string>> siteRoid = null, Expression<Func<double>> siteRolatitude = null, Expression<Func<double>> siteRolongitude = null)
        {
            var apiCallPath = String.Format("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var siteRo = new JObject();
            var siteRopropCount = 0;
            siteRopropCount++;
            siteRo["address"] = ExpressionConverter.ConvertO(siteRoaddress);
            siteRopropCount++;
            siteRo["city"] = ExpressionConverter.ConvertO(siteRocity);
            if (siteRoid != null)
            {
                siteRo["id"] = ExpressionConverter.ConvertO(siteRoid);
                siteRopropCount++;
            }

            if (siteRolatitude != null)
            {
                siteRo["latitude"] = ExpressionConverter.ConvertO(siteRolatitude);
                siteRopropCount++;
            }

            if (siteRolongitude != null)
            {
                siteRo["longitude"] = ExpressionConverter.ConvertO(siteRolongitude);
                siteRopropCount++;
            }

            siteRopropCount++;
            siteRo["name"] = ExpressionConverter.ConvertO(siteRoname);
            siteRopropCount++;
            siteRo["postalCode"] = ExpressionConverter.ConvertO(siteRopostalCode);
            if (siteRopropCount > 0)
            {
                callPayload.Body = siteRo;
            }

            return new ApiConnectionAction<SiteRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo> GetTags(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = "/api/tags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageThingTagRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> UpdateThingTag(Expression<Func<string>> thingTagRoid = null, Expression<Func<string>> thingTagRotag = null)
        {
            var apiCallPath = "/api/tags";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var thingTagRo = new JObject();
            var thingTagRopropCount = 0;
            if (thingTagRoid != null)
            {
                thingTagRo["id"] = ExpressionConverter.ConvertO(thingTagRoid);
                thingTagRopropCount++;
            }

            if (thingTagRotag != null)
            {
                thingTagRo["tag"] = ExpressionConverter.ConvertO(thingTagRotag);
                thingTagRopropCount++;
            }

            if (thingTagRopropCount > 0)
            {
                callPayload.Body = thingTagRo;
            }

            return new ApiConnectionAction<TagRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> AddThingTag(Expression<Func<string>> thingId, Expression<Func<string>> thingTagRoid = null, Expression<Func<string>> thingTagRotag = null)
        {
            var apiCallPath = String.Format("/api/tags/thing/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var thingTagRo = new JObject();
            var thingTagRopropCount = 0;
            if (thingTagRoid != null)
            {
                thingTagRo["id"] = ExpressionConverter.ConvertO(thingTagRoid);
                thingTagRopropCount++;
            }

            if (thingTagRotag != null)
            {
                thingTagRo["tag"] = ExpressionConverter.ConvertO(thingTagRotag);
                thingTagRopropCount++;
            }

            if (thingTagRopropCount > 0)
            {
                callPayload.Body = thingTagRo;
            }

            return new ApiConnectionAction<TagRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> GetThingTag(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSingleThingRo> GetThings(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<bool>> detailed = null)
        {
            var apiCallPath = "/api/things";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            callPayload.Queries["detailed"] = Convert.ToString(false);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            return new ApiConnectionAction<PageSingleThingRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> AddThingsCsv(Expression<Func<object>> file)
        {
            var apiCallPath = "/api/things";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[]> AssociateThingsWithProduct(Expression<Func<bool>> jsonarray = null, Expression<Func<bool>> jsonbigDecimal = null, Expression<Func<bool>> jsonbigInteger = null, Expression<Func<bool>> jsonbinary = null, Expression<Func<bool>> jsonboolean = null, Expression<Func<bool>> jsoncontainerNode = null, Expression<Func<bool>> jsondouble = null, Expression<Func<bool>> jsonfloat = null, Expression<Func<bool>> jsonfloatingPointNumber = null, Expression<Func<bool>> jsonint = null, Expression<Func<bool>> jsonintegralNumber = null, Expression<Func<bool>> jsonLong = null, Expression<Func<bool>> jsonmissingNode = null, Expression<Func<jsonnodeTypeInput>> jsonnodeType = null, Expression<Func<bool>> jsonnull = null, Expression<Func<bool>> jsonnumber = null, Expression<Func<bool>> jsonObject = null, Expression<Func<bool>> jsonpojo = null, Expression<Func<bool>> jsonShort = null, Expression<Func<bool>> jsontextual = null, Expression<Func<bool>> jsonvalueNode = null)
        {
            var apiCallPath = "/api/things";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var json = new JObject();
            var jsonpropCount = 0;
            if (jsonarray != null)
            {
                json["array"] = ExpressionConverter.ConvertO(jsonarray);
                jsonpropCount++;
            }

            if (jsonbigDecimal != null)
            {
                json["bigDecimal"] = ExpressionConverter.ConvertO(jsonbigDecimal);
                jsonpropCount++;
            }

            if (jsonbigInteger != null)
            {
                json["bigInteger"] = ExpressionConverter.ConvertO(jsonbigInteger);
                jsonpropCount++;
            }

            if (jsonbinary != null)
            {
                json["binary"] = ExpressionConverter.ConvertO(jsonbinary);
                jsonpropCount++;
            }

            if (jsonboolean != null)
            {
                json["boolean"] = ExpressionConverter.ConvertO(jsonboolean);
                jsonpropCount++;
            }

            if (jsoncontainerNode != null)
            {
                json["containerNode"] = ExpressionConverter.ConvertO(jsoncontainerNode);
                jsonpropCount++;
            }

            if (jsondouble != null)
            {
                json["double"] = ExpressionConverter.ConvertO(jsondouble);
                jsonpropCount++;
            }

            if (jsonfloat != null)
            {
                json["float"] = ExpressionConverter.ConvertO(jsonfloat);
                jsonpropCount++;
            }

            if (jsonfloatingPointNumber != null)
            {
                json["floatingPointNumber"] = ExpressionConverter.ConvertO(jsonfloatingPointNumber);
                jsonpropCount++;
            }

            if (jsonint != null)
            {
                json["int"] = ExpressionConverter.ConvertO(jsonint);
                jsonpropCount++;
            }

            if (jsonintegralNumber != null)
            {
                json["integralNumber"] = ExpressionConverter.ConvertO(jsonintegralNumber);
                jsonpropCount++;
            }

            if (jsonLong != null)
            {
                json["long"] = ExpressionConverter.ConvertO(jsonLong);
                jsonpropCount++;
            }

            if (jsonmissingNode != null)
            {
                json["missingNode"] = ExpressionConverter.ConvertO(jsonmissingNode);
                jsonpropCount++;
            }

            if (jsonnodeType != null)
            {
                json["nodeType"] = ExpressionConverter.ConvertO(jsonnodeType);
                jsonpropCount++;
            }

            if (jsonnull != null)
            {
                json["null"] = ExpressionConverter.ConvertO(jsonnull);
                jsonpropCount++;
            }

            if (jsonnumber != null)
            {
                json["number"] = ExpressionConverter.ConvertO(jsonnumber);
                jsonpropCount++;
            }

            if (jsonObject != null)
            {
                json["object"] = ExpressionConverter.ConvertO(jsonObject);
                jsonpropCount++;
            }

            if (jsonpojo != null)
            {
                json["pojo"] = ExpressionConverter.ConvertO(jsonpojo);
                jsonpropCount++;
            }

            if (jsonShort != null)
            {
                json["short"] = ExpressionConverter.ConvertO(jsonShort);
                jsonpropCount++;
            }

            if (jsontextual != null)
            {
                json["textual"] = ExpressionConverter.ConvertO(jsontextual);
                jsonpropCount++;
            }

            if (jsonvalueNode != null)
            {
                json["valueNode"] = ExpressionConverter.ConvertO(jsonvalueNode);
                jsonpropCount++;
            }

            if (jsonpropCount > 0)
            {
                callPayload.Body = json;
            }

            return new ApiConnectionAction<SingleThingRo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[]> GetThingList(Expression<Func<string[]>> thingIds = null)
        {
            var apiCallPath = "/api/things/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(thingIds);
            return new ApiConnectionAction<SingleThingRo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> GetThing(Expression<Func<string>> id, Expression<Func<bool>> detailed = null)
        {
            var apiCallPath = String.Format("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["detailed"] = Convert.ToString(false);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            return new ApiConnectionAction<SingleThingRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction IgnoreThing(Expression<Func<string>> id, Expression<Func<bool>> force = null)
        {
            var apiCallPath = String.Format("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (force != null)
                callPayload.Queries["force"] = ExpressionConverter.Convert(force);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ThingRo> PutThing(Expression<Func<string>> id, Expression<Func<string>> thingRoname, Expression<Func<string>> thingRositeaddress, Expression<Func<string>> thingRositecity, Expression<Func<string>> thingRositename, Expression<Func<string>> thingRositepostalCode, Expression<Func<string>> thingRoapplicationid = null, Expression<Func<string>> thingRoapplicationlink = null, Expression<Func<string>> thingRoapplicationname = null, Expression<Func<string>> thingRoconnectivityid = null, Expression<Func<string>> thingRoconnectivityrawStatus = null, Expression<Func<thingRoconnectivitystatusInput>> thingRoconnectivitystatus = null, Expression<Func<thingRoconnectivitytypeInput>> thingRoconnectivitytype = null, Expression<Func<CustomFieldRo[]>> thingRocustomFields = null, Expression<Func<string>> thingRocustomModelcolor = null, Expression<Func<string>> thingRocustomModelicon = null, Expression<Func<string>> thingRocustomModelid = null, Expression<Func<string>> thingRocustomModellink = null, Expression<Func<string>> thingRocustomModelname = null, Expression<Func<string>> thingRodescription = null, Expression<Func<int>> thingRodevicebatteryLevel = null, Expression<Func<thingRodevicebatteryStatusInput>> thingRodevicebatteryStatus = null, Expression<Func<string>> thingRodevicedeviceType = null, Expression<Func<string>> thingRodeviceid = null, Expression<Func<string>> thingRodevicemanufacturer = null, Expression<Func<int>> thingRodevicememoryFree = null, Expression<Func<int>> thingRodevicememoryTotal = null, Expression<Func<string>> thingRodevicemodel = null, Expression<Func<string>> thingRodevicemodelNumber = null, Expression<Func<string>> thingRodevicename = null, Expression<Func<string>> thingRodeviceserialNumber = null, Expression<Func<thingRodevicestatusInput>> thingRodevicestatus = null, Expression<Func<string>> thingRodisplayName = null, Expression<Func<bool>> thingRodynamicGps = null, Expression<Func<double>> thingRofixedLatitude = null, Expression<Func<double>> thingRofixedLongitude = null, Expression<Func<string>> thingRofixedName = null, Expression<Func<string>> thingRoid = null, Expression<Func<int>> thingRolastActivityDate = null, Expression<Func<double>> thingRolastLatitude = null, Expression<Func<double>> thingRolastLongitude = null, Expression<Func<bool>> thingRolastMeasurementsarray = null, Expression<Func<bool>> thingRolastMeasurementsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsbinary = null, Expression<Func<bool>> thingRolastMeasurementsboolean = null, Expression<Func<bool>> thingRolastMeasurementscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsdouble = null, Expression<Func<bool>> thingRolastMeasurementsfloat = null, Expression<Func<bool>> thingRolastMeasurementsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsint = null, Expression<Func<bool>> thingRolastMeasurementsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsLong = null, Expression<Func<bool>> thingRolastMeasurementsmissingNode = null, Expression<Func<thingRolastMeasurementsnodeTypeInput>> thingRolastMeasurementsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsnull = null, Expression<Func<bool>> thingRolastMeasurementsnumber = null, Expression<Func<bool>> thingRolastMeasurementsObject = null, Expression<Func<bool>> thingRolastMeasurementspojo = null, Expression<Func<bool>> thingRolastMeasurementsShort = null, Expression<Func<bool>> thingRolastMeasurementstextual = null, Expression<Func<bool>> thingRolastMeasurementsvalueNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsarray = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbinary = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsboolean = null, Expression<Func<bool>> thingRolastMeasurementsTimestampscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsdouble = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloat = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsint = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsLong = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsmissingNode = null, Expression<Func<thingRolastMeasurementsTimestampsnodeTypeInput>> thingRolastMeasurementsTimestampsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnull = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsObject = null, Expression<Func<bool>> thingRolastMeasurementsTimestampspojo = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsShort = null, Expression<Func<bool>> thingRolastMeasurementsTimestampstextual = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsvalueNode = null, Expression<Func<int>> thingRolastMessageDate = null, Expression<Func<int>> thingRomessageActivityTimeoutPeriod = null, Expression<Func<int>> thingRonbAlerts = null, Expression<Func<thingRoproductconnectivityTypesInputItem[]>> thingRoproductconnectivityTypes = null, Expression<Func<bool>> thingRoproductgenerateLinks = null, Expression<Func<string>> thingRoproductid = null, Expression<Func<string>> thingRoproductlink = null, Expression<Func<bool>> thingRoproductmanufacturergenerateLinks = null, Expression<Func<string>> thingRoproductmanufacturerid = null, Expression<Func<string>> thingRoproductmanufacturerlink = null, Expression<Func<string>> thingRoproductmanufacturername = null, Expression<Func<string>> thingRoproductmodelcolor = null, Expression<Func<bool>> thingRoproductmodelgenerateLinks = null, Expression<Func<string>> thingRoproductmodelicon = null, Expression<Func<string>> thingRoproductmodelid = null, Expression<Func<bool>> thingRoproductmodelisCustomModel = null, Expression<Func<bool>> thingRoproductmodellinkabsolute = null, Expression<Func<string>> thingRoproductmodellinkauthority = null, Expression<Func<string>> thingRoproductmodellinkfragment = null, Expression<Func<string>> thingRoproductmodellinkhost = null, Expression<Func<bool>> thingRoproductmodellinkopaque = null, Expression<Func<string>> thingRoproductmodellinkpath = null, Expression<Func<int>> thingRoproductmodellinkport = null, Expression<Func<string>> thingRoproductmodellinkquery = null, Expression<Func<string>> thingRoproductmodellinkrawAuthority = null, Expression<Func<string>> thingRoproductmodellinkrawFragment = null, Expression<Func<string>> thingRoproductmodellinkrawPath = null, Expression<Func<string>> thingRoproductmodellinkrawQuery = null, Expression<Func<string>> thingRoproductmodellinkrawSchemeSpecificPart = null, Expression<Func<string>> thingRoproductmodellinkrawUserInfo = null, Expression<Func<string>> thingRoproductmodellinkscheme = null, Expression<Func<string>> thingRoproductmodellinkschemeSpecificPart = null, Expression<Func<string>> thingRoproductmodellinkuserInfo = null, Expression<Func<string>> thingRoproductmodelname = null, Expression<Func<string>> thingRoproductname = null, Expression<Func<string>> thingRoproductreference = null, Expression<Func<string>> thingRositeid = null, Expression<Func<double>> thingRositelatitude = null, Expression<Func<double>> thingRositelongitude = null, Expression<Func<string>> thingRosourceId = null, Expression<Func<thingRostatusInput>> thingRostatus = null, Expression<Func<ThingTagRo[]>> thingRotags = null)
        {
            var apiCallPath = String.Format("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var thingRo = new JObject();
            var thingRopropCount = 0;
            var applicationObject = new JObject();
            var applicationObjectpropCount = 0;
            if (thingRoapplicationid != null)
            {
                applicationObject["id"] = ExpressionConverter.ConvertO(thingRoapplicationid);
                applicationObjectpropCount++;
            }

            if (thingRoapplicationlink != null)
            {
                applicationObject["link"] = ExpressionConverter.ConvertO(thingRoapplicationlink);
                applicationObjectpropCount++;
            }

            if (thingRoapplicationname != null)
            {
                applicationObject["name"] = ExpressionConverter.ConvertO(thingRoapplicationname);
                applicationObjectpropCount++;
            }

            if (applicationObjectpropCount > 0)
            {
                thingRo["application"] = applicationObject;
                thingRopropCount++;
            }

            var connectivityObject = new JObject();
            var connectivityObjectpropCount = 0;
            var additionalPropertiesObject = new JObject();
            var additionalPropertiesObjectpropCount = 0;
            if (additionalPropertiesObjectpropCount > 0)
            {
                connectivityObject["additionalProperties"] = additionalPropertiesObject;
                connectivityObjectpropCount++;
            }

            if (thingRoconnectivityid != null)
            {
                connectivityObject["id"] = ExpressionConverter.ConvertO(thingRoconnectivityid);
                connectivityObjectpropCount++;
            }

            if (thingRoconnectivityrawStatus != null)
            {
                connectivityObject["rawStatus"] = ExpressionConverter.ConvertO(thingRoconnectivityrawStatus);
                connectivityObjectpropCount++;
            }

            if (thingRoconnectivitystatus != null)
            {
                connectivityObject["status"] = ExpressionConverter.ConvertO(thingRoconnectivitystatus);
                connectivityObjectpropCount++;
            }

            if (thingRoconnectivitytype != null)
            {
                connectivityObject["type"] = ExpressionConverter.ConvertO(thingRoconnectivitytype);
                connectivityObjectpropCount++;
            }

            if (connectivityObjectpropCount > 0)
            {
                thingRo["connectivity"] = connectivityObject;
                thingRopropCount++;
            }

            if (thingRocustomFields != null)
            {
                thingRo["customFields"] = ExpressionConverter.ConvertO(thingRocustomFields);
                thingRopropCount++;
            }

            var customModelObject = new JObject();
            var customModelObjectpropCount = 0;
            if (thingRocustomModelcolor != null)
            {
                customModelObject["color"] = ExpressionConverter.ConvertO(thingRocustomModelcolor);
                customModelObjectpropCount++;
            }

            if (thingRocustomModelicon != null)
            {
                customModelObject["icon"] = ExpressionConverter.ConvertO(thingRocustomModelicon);
                customModelObjectpropCount++;
            }

            if (thingRocustomModelid != null)
            {
                customModelObject["id"] = ExpressionConverter.ConvertO(thingRocustomModelid);
                customModelObjectpropCount++;
            }

            if (thingRocustomModellink != null)
            {
                customModelObject["link"] = ExpressionConverter.ConvertO(thingRocustomModellink);
                customModelObjectpropCount++;
            }

            if (thingRocustomModelname != null)
            {
                customModelObject["name"] = ExpressionConverter.ConvertO(thingRocustomModelname);
                customModelObjectpropCount++;
            }

            if (customModelObjectpropCount > 0)
            {
                thingRo["customModel"] = customModelObject;
                thingRopropCount++;
            }

            if (thingRodescription != null)
            {
                thingRo["description"] = ExpressionConverter.ConvertO(thingRodescription);
                thingRopropCount++;
            }

            var deviceObject = new JObject();
            var deviceObjectpropCount = 0;
            if (thingRodevicebatteryLevel != null)
            {
                deviceObject["batteryLevel"] = ExpressionConverter.ConvertO(thingRodevicebatteryLevel);
                deviceObjectpropCount++;
            }

            if (thingRodevicebatteryStatus != null)
            {
                deviceObject["batteryStatus"] = ExpressionConverter.ConvertO(thingRodevicebatteryStatus);
                deviceObjectpropCount++;
            }

            if (thingRodevicedeviceType != null)
            {
                deviceObject["deviceType"] = ExpressionConverter.ConvertO(thingRodevicedeviceType);
                deviceObjectpropCount++;
            }

            if (thingRodeviceid != null)
            {
                deviceObject["id"] = ExpressionConverter.ConvertO(thingRodeviceid);
                deviceObjectpropCount++;
            }

            if (thingRodevicemanufacturer != null)
            {
                deviceObject["manufacturer"] = ExpressionConverter.ConvertO(thingRodevicemanufacturer);
                deviceObjectpropCount++;
            }

            if (thingRodevicememoryFree != null)
            {
                deviceObject["memoryFree"] = ExpressionConverter.ConvertO(thingRodevicememoryFree);
                deviceObjectpropCount++;
            }

            if (thingRodevicememoryTotal != null)
            {
                deviceObject["memoryTotal"] = ExpressionConverter.ConvertO(thingRodevicememoryTotal);
                deviceObjectpropCount++;
            }

            if (thingRodevicemodel != null)
            {
                deviceObject["model"] = ExpressionConverter.ConvertO(thingRodevicemodel);
                deviceObjectpropCount++;
            }

            if (thingRodevicemodelNumber != null)
            {
                deviceObject["modelNumber"] = ExpressionConverter.ConvertO(thingRodevicemodelNumber);
                deviceObjectpropCount++;
            }

            if (thingRodevicename != null)
            {
                deviceObject["name"] = ExpressionConverter.ConvertO(thingRodevicename);
                deviceObjectpropCount++;
            }

            if (thingRodeviceserialNumber != null)
            {
                deviceObject["serialNumber"] = ExpressionConverter.ConvertO(thingRodeviceserialNumber);
                deviceObjectpropCount++;
            }

            if (thingRodevicestatus != null)
            {
                deviceObject["status"] = ExpressionConverter.ConvertO(thingRodevicestatus);
                deviceObjectpropCount++;
            }

            if (deviceObjectpropCount > 0)
            {
                thingRo["device"] = deviceObject;
                thingRopropCount++;
            }

            if (thingRodisplayName != null)
            {
                thingRo["displayName"] = ExpressionConverter.ConvertO(thingRodisplayName);
                thingRopropCount++;
            }

            if (thingRodynamicGps != null)
            {
                thingRo["dynamicGps"] = ExpressionConverter.ConvertO(thingRodynamicGps);
                thingRopropCount++;
            }

            if (thingRofixedLatitude != null)
            {
                thingRo["fixedLatitude"] = ExpressionConverter.ConvertO(thingRofixedLatitude);
                thingRopropCount++;
            }

            if (thingRofixedLongitude != null)
            {
                thingRo["fixedLongitude"] = ExpressionConverter.ConvertO(thingRofixedLongitude);
                thingRopropCount++;
            }

            if (thingRofixedName != null)
            {
                thingRo["fixedName"] = ExpressionConverter.ConvertO(thingRofixedName);
                thingRopropCount++;
            }

            if (thingRoid != null)
            {
                thingRo["id"] = ExpressionConverter.ConvertO(thingRoid);
                thingRopropCount++;
            }

            if (thingRolastActivityDate != null)
            {
                thingRo["lastActivityDate"] = ExpressionConverter.ConvertO(thingRolastActivityDate);
                thingRopropCount++;
            }

            if (thingRolastLatitude != null)
            {
                thingRo["lastLatitude"] = ExpressionConverter.ConvertO(thingRolastLatitude);
                thingRopropCount++;
            }

            if (thingRolastLongitude != null)
            {
                thingRo["lastLongitude"] = ExpressionConverter.ConvertO(thingRolastLongitude);
                thingRopropCount++;
            }

            var lastMeasurementsObject = new JObject();
            var lastMeasurementsObjectpropCount = 0;
            if (thingRolastMeasurementsarray != null)
            {
                lastMeasurementsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigDecimal != null)
            {
                lastMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigInteger != null)
            {
                lastMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsbinary != null)
            {
                lastMeasurementsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsboolean != null)
            {
                lastMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementscontainerNode != null)
            {
                lastMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsdouble != null)
            {
                lastMeasurementsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloat != null)
            {
                lastMeasurementsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloatingPointNumber != null)
            {
                lastMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsint != null)
            {
                lastMeasurementsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsintegralNumber != null)
            {
                lastMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsLong != null)
            {
                lastMeasurementsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsmissingNode != null)
            {
                lastMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsnodeType != null)
            {
                lastMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsnull != null)
            {
                lastMeasurementsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsnumber != null)
            {
                lastMeasurementsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsObject != null)
            {
                lastMeasurementsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementspojo != null)
            {
                lastMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsShort != null)
            {
                lastMeasurementsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementstextual != null)
            {
                lastMeasurementsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsvalueNode != null)
            {
                lastMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                lastMeasurementsObjectpropCount++;
            }

            if (lastMeasurementsObjectpropCount > 0)
            {
                thingRo["lastMeasurements"] = lastMeasurementsObject;
                thingRopropCount++;
            }

            var lastMeasurementsTimestampsObject = new JObject();
            var lastMeasurementsTimestampsObjectpropCount = 0;
            if (thingRolastMeasurementsarray != null)
            {
                lastMeasurementsTimestampsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigDecimal != null)
            {
                lastMeasurementsTimestampsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigInteger != null)
            {
                lastMeasurementsTimestampsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsbinary != null)
            {
                lastMeasurementsTimestampsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsboolean != null)
            {
                lastMeasurementsTimestampsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementscontainerNode != null)
            {
                lastMeasurementsTimestampsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsdouble != null)
            {
                lastMeasurementsTimestampsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloat != null)
            {
                lastMeasurementsTimestampsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloatingPointNumber != null)
            {
                lastMeasurementsTimestampsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsint != null)
            {
                lastMeasurementsTimestampsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsintegralNumber != null)
            {
                lastMeasurementsTimestampsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsLong != null)
            {
                lastMeasurementsTimestampsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsmissingNode != null)
            {
                lastMeasurementsTimestampsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsnodeType != null)
            {
                lastMeasurementsTimestampsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsnull != null)
            {
                lastMeasurementsTimestampsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsnumber != null)
            {
                lastMeasurementsTimestampsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsObject != null)
            {
                lastMeasurementsTimestampsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementspojo != null)
            {
                lastMeasurementsTimestampsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsShort != null)
            {
                lastMeasurementsTimestampsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementstextual != null)
            {
                lastMeasurementsTimestampsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsvalueNode != null)
            {
                lastMeasurementsTimestampsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (lastMeasurementsTimestampsObjectpropCount > 0)
            {
                thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                thingRopropCount++;
            }

            if (thingRolastMessageDate != null)
            {
                thingRo["lastMessageDate"] = ExpressionConverter.ConvertO(thingRolastMessageDate);
                thingRopropCount++;
            }

            if (thingRomessageActivityTimeoutPeriod != null)
            {
                thingRo["messageActivityTimeoutPeriod"] = ExpressionConverter.ConvertO(thingRomessageActivityTimeoutPeriod);
                thingRopropCount++;
            }

            thingRopropCount++;
            thingRo["name"] = ExpressionConverter.ConvertO(thingRoname);
            if (thingRonbAlerts != null)
            {
                thingRo["nbAlerts"] = ExpressionConverter.ConvertO(thingRonbAlerts);
                thingRopropCount++;
            }

            var productObject = new JObject();
            var productObjectpropCount = 0;
            if (thingRoproductconnectivityTypes != null)
            {
                productObject["connectivityTypes"] = ExpressionConverter.ConvertO(thingRoproductconnectivityTypes);
                productObjectpropCount++;
            }

            if (thingRoproductgenerateLinks != null)
            {
                productObject["generateLinks"] = ExpressionConverter.ConvertO(thingRoproductgenerateLinks);
                productObjectpropCount++;
            }

            if (thingRoproductid != null)
            {
                productObject["id"] = ExpressionConverter.ConvertO(thingRoproductid);
                productObjectpropCount++;
            }

            if (thingRoproductlink != null)
            {
                productObject["link"] = ExpressionConverter.ConvertO(thingRoproductlink);
                productObjectpropCount++;
            }

            var manufacturerObject = new JObject();
            var manufacturerObjectpropCount = 0;
            if (thingRoproductmanufacturergenerateLinks != null)
            {
                manufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(thingRoproductmanufacturergenerateLinks);
                manufacturerObjectpropCount++;
            }

            if (thingRoproductmanufacturerid != null)
            {
                manufacturerObject["id"] = ExpressionConverter.ConvertO(thingRoproductmanufacturerid);
                manufacturerObjectpropCount++;
            }

            if (thingRoproductmanufacturerlink != null)
            {
                manufacturerObject["link"] = ExpressionConverter.ConvertO(thingRoproductmanufacturerlink);
                manufacturerObjectpropCount++;
            }

            if (thingRoproductmanufacturername != null)
            {
                manufacturerObject["name"] = ExpressionConverter.ConvertO(thingRoproductmanufacturername);
                manufacturerObjectpropCount++;
            }

            if (manufacturerObjectpropCount > 0)
            {
                productObject["manufacturer"] = manufacturerObject;
                productObjectpropCount++;
            }

            var modelObject = new JObject();
            var modelObjectpropCount = 0;
            if (thingRoproductmodelcolor != null)
            {
                modelObject["color"] = ExpressionConverter.ConvertO(thingRoproductmodelcolor);
                modelObjectpropCount++;
            }

            if (thingRoproductmodelgenerateLinks != null)
            {
                modelObject["generateLinks"] = ExpressionConverter.ConvertO(thingRoproductmodelgenerateLinks);
                modelObjectpropCount++;
            }

            if (thingRoproductmodelicon != null)
            {
                modelObject["icon"] = ExpressionConverter.ConvertO(thingRoproductmodelicon);
                modelObjectpropCount++;
            }

            if (thingRoproductmodelid != null)
            {
                modelObject["id"] = ExpressionConverter.ConvertO(thingRoproductmodelid);
                modelObjectpropCount++;
            }

            if (thingRoproductmodelisCustomModel != null)
            {
                modelObject["isCustomModel"] = ExpressionConverter.ConvertO(thingRoproductmodelisCustomModel);
                modelObjectpropCount++;
            }

            var linkObject = new JObject();
            var linkObjectpropCount = 0;
            if (thingRoproductmodellinkabsolute != null)
            {
                linkObject["absolute"] = ExpressionConverter.ConvertO(thingRoproductmodellinkabsolute);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkauthority != null)
            {
                linkObject["authority"] = ExpressionConverter.ConvertO(thingRoproductmodellinkauthority);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkfragment != null)
            {
                linkObject["fragment"] = ExpressionConverter.ConvertO(thingRoproductmodellinkfragment);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkhost != null)
            {
                linkObject["host"] = ExpressionConverter.ConvertO(thingRoproductmodellinkhost);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkopaque != null)
            {
                linkObject["opaque"] = ExpressionConverter.ConvertO(thingRoproductmodellinkopaque);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkpath != null)
            {
                linkObject["path"] = ExpressionConverter.ConvertO(thingRoproductmodellinkpath);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkport != null)
            {
                linkObject["port"] = ExpressionConverter.ConvertO(thingRoproductmodellinkport);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkquery != null)
            {
                linkObject["query"] = ExpressionConverter.ConvertO(thingRoproductmodellinkquery);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkrawAuthority != null)
            {
                linkObject["rawAuthority"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawAuthority);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkrawFragment != null)
            {
                linkObject["rawFragment"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawFragment);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkrawPath != null)
            {
                linkObject["rawPath"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawPath);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkrawQuery != null)
            {
                linkObject["rawQuery"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawQuery);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkrawSchemeSpecificPart != null)
            {
                linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawSchemeSpecificPart);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkrawUserInfo != null)
            {
                linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawUserInfo);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkscheme != null)
            {
                linkObject["scheme"] = ExpressionConverter.ConvertO(thingRoproductmodellinkscheme);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkschemeSpecificPart != null)
            {
                linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(thingRoproductmodellinkschemeSpecificPart);
                linkObjectpropCount++;
            }

            if (thingRoproductmodellinkuserInfo != null)
            {
                linkObject["userInfo"] = ExpressionConverter.ConvertO(thingRoproductmodellinkuserInfo);
                linkObjectpropCount++;
            }

            if (linkObjectpropCount > 0)
            {
                modelObject["link"] = linkObject;
                modelObjectpropCount++;
            }

            if (thingRoproductmodelname != null)
            {
                modelObject["name"] = ExpressionConverter.ConvertO(thingRoproductmodelname);
                modelObjectpropCount++;
            }

            if (modelObjectpropCount > 0)
            {
                productObject["model"] = modelObject;
                productObjectpropCount++;
            }

            if (thingRoproductname != null)
            {
                productObject["name"] = ExpressionConverter.ConvertO(thingRoproductname);
                productObjectpropCount++;
            }

            if (thingRoproductreference != null)
            {
                productObject["reference"] = ExpressionConverter.ConvertO(thingRoproductreference);
                productObjectpropCount++;
            }

            if (productObjectpropCount > 0)
            {
                thingRo["product"] = productObject;
                thingRopropCount++;
            }

            var siteObject = new JObject();
            var siteObjectpropCount = 0;
            siteObjectpropCount++;
            siteObject["address"] = ExpressionConverter.ConvertO(thingRositeaddress);
            siteObjectpropCount++;
            siteObject["city"] = ExpressionConverter.ConvertO(thingRositecity);
            if (thingRositeid != null)
            {
                siteObject["id"] = ExpressionConverter.ConvertO(thingRositeid);
                siteObjectpropCount++;
            }

            if (thingRositelatitude != null)
            {
                siteObject["latitude"] = ExpressionConverter.ConvertO(thingRositelatitude);
                siteObjectpropCount++;
            }

            if (thingRositelongitude != null)
            {
                siteObject["longitude"] = ExpressionConverter.ConvertO(thingRositelongitude);
                siteObjectpropCount++;
            }

            siteObjectpropCount++;
            siteObject["name"] = ExpressionConverter.ConvertO(thingRositename);
            siteObjectpropCount++;
            siteObject["postalCode"] = ExpressionConverter.ConvertO(thingRositepostalCode);
            if (siteObjectpropCount > 0)
            {
                thingRo["site"] = siteObject;
                thingRopropCount++;
            }

            if (thingRosourceId != null)
            {
                thingRo["sourceId"] = ExpressionConverter.ConvertO(thingRosourceId);
                thingRopropCount++;
            }

            if (thingRostatus != null)
            {
                thingRo["status"] = ExpressionConverter.ConvertO(thingRostatus);
                thingRopropCount++;
            }

            if (thingRotags != null)
            {
                thingRo["tags"] = ExpressionConverter.ConvertO(thingRotags);
                thingRopropCount++;
            }

            if (thingRopropCount > 0)
            {
                callPayload.Body = thingRo;
            }

            return new ApiConnectionAction<ThingRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo> GetThingActiveModel(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/active_model", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ModelRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageCustomFieldRo> GetCustomField(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PageCustomFieldRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CustomFieldRo> CreateCustomField(Expression<Func<string>> id, Expression<Func<string>> customFieldRoid = null, Expression<Func<string>> customFieldRoimageLink = null, Expression<Func<string>> customFieldRolabel = null, Expression<Func<string>> customFieldRoname = null, Expression<Func<customFieldRotypeInput>> customFieldRotype = null, Expression<Func<string>> customFieldRovalue = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var customFieldRo = new JObject();
            var customFieldRopropCount = 0;
            if (customFieldRoid != null)
            {
                customFieldRo["id"] = ExpressionConverter.ConvertO(customFieldRoid);
                customFieldRopropCount++;
            }

            if (customFieldRoimageLink != null)
            {
                customFieldRo["imageLink"] = ExpressionConverter.ConvertO(customFieldRoimageLink);
                customFieldRopropCount++;
            }

            if (customFieldRolabel != null)
            {
                customFieldRo["label"] = ExpressionConverter.ConvertO(customFieldRolabel);
                customFieldRopropCount++;
            }

            if (customFieldRoname != null)
            {
                customFieldRo["name"] = ExpressionConverter.ConvertO(customFieldRoname);
                customFieldRopropCount++;
            }

            if (customFieldRotype != null)
            {
                customFieldRo["type"] = ExpressionConverter.ConvertO(customFieldRotype);
                customFieldRopropCount++;
            }

            if (customFieldRovalue != null)
            {
                customFieldRo["value"] = ExpressionConverter.ConvertO(customFieldRovalue);
                customFieldRopropCount++;
            }

            if (customFieldRopropCount > 0)
            {
                callPayload.Body = customFieldRo;
            }

            return new ApiConnectionAction<CustomFieldRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CustomFieldRo> UpdateCustomField(Expression<Func<string>> id, Expression<Func<string>> customFieldRoid = null, Expression<Func<string>> customFieldRoimageLink = null, Expression<Func<string>> customFieldRolabel = null, Expression<Func<string>> customFieldRoname = null, Expression<Func<customFieldRotypeInput>> customFieldRotype = null, Expression<Func<string>> customFieldRovalue = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var customFieldRo = new JObject();
            var customFieldRopropCount = 0;
            if (customFieldRoid != null)
            {
                customFieldRo["id"] = ExpressionConverter.ConvertO(customFieldRoid);
                customFieldRopropCount++;
            }

            if (customFieldRoimageLink != null)
            {
                customFieldRo["imageLink"] = ExpressionConverter.ConvertO(customFieldRoimageLink);
                customFieldRopropCount++;
            }

            if (customFieldRolabel != null)
            {
                customFieldRo["label"] = ExpressionConverter.ConvertO(customFieldRolabel);
                customFieldRopropCount++;
            }

            if (customFieldRoname != null)
            {
                customFieldRo["name"] = ExpressionConverter.ConvertO(customFieldRoname);
                customFieldRopropCount++;
            }

            if (customFieldRotype != null)
            {
                customFieldRo["type"] = ExpressionConverter.ConvertO(customFieldRotype);
                customFieldRopropCount++;
            }

            if (customFieldRovalue != null)
            {
                customFieldRo["value"] = ExpressionConverter.ConvertO(customFieldRovalue);
                customFieldRopropCount++;
            }

            if (customFieldRopropCount > 0)
            {
                callPayload.Body = customFieldRo;
            }

            return new ApiConnectionAction<CustomFieldRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> DeleteCustomField(Expression<Func<string>> id, Expression<Func<string>> fieldId)
        {
            var apiCallPath = String.Format("/api/things/{0}/custom_fields/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> GetCustomFieldImage(Expression<Func<string>> id, Expression<Func<string>> fieldId)
        {
            var apiCallPath = String.Format("/api/things/{0}/custom_fields/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> PostCustomFieldImage(Expression<Func<string>> id, Expression<Func<string>> fieldId, Expression<Func<object>> file)
        {
            var apiCallPath = String.Format("/api/things/{0}/custom_fields/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> GetThingImage(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureTinyRo[]> GetLastMeasures(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/last_measurements", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MeasureTinyRo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageTinyRo> GetLastMessage(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/last_message", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageTinyRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo> GetThingMeasures(Expression<Func<string>> id, Expression<Func<bool>> detailed = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/measures", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["detailed"] = Convert.ToString(false);
            if (detailed != null)
                callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetThingMessages(Expression<Func<string>> id, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageMessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction DeleteThingMessages(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> CreateThingMessages(Expression<Func<string>> id, Expression<Func<string>> messageRobody, Expression<Func<string>> messageRocreationDate, Expression<Func<string>> messageRoerrorMessage, Expression<Func<double>> messageRolatitude, Expression<Func<double>> messageRolongitude, Expression<Func<string>> messageRometadata, Expression<Func<int>> messageRonumber, Expression<Func<messageRoprocessedInput>> messageRoprocessed, Expression<Func<string>> messageRothingname, Expression<Func<string>> messageRotimestamp, Expression<Func<string>> messageRotopic, Expression<Func<string>> messageRoid = null, Expression<Func<bool>> messageRolinkabsolute = null, Expression<Func<string>> messageRolinkauthority = null, Expression<Func<string>> messageRolinkfragment = null, Expression<Func<string>> messageRolinkhost = null, Expression<Func<bool>> messageRolinkopaque = null, Expression<Func<string>> messageRolinkpath = null, Expression<Func<int>> messageRolinkport = null, Expression<Func<string>> messageRolinkquery = null, Expression<Func<string>> messageRolinkrawAuthority = null, Expression<Func<string>> messageRolinkrawFragment = null, Expression<Func<string>> messageRolinkrawPath = null, Expression<Func<string>> messageRolinkrawQuery = null, Expression<Func<string>> messageRolinkrawSchemeSpecificPart = null, Expression<Func<string>> messageRolinkrawUserInfo = null, Expression<Func<string>> messageRolinkscheme = null, Expression<Func<string>> messageRolinkschemeSpecificPart = null, Expression<Func<string>> messageRolinkuserInfo = null, Expression<Func<bool>> messageRomeasurementsarray = null, Expression<Func<bool>> messageRomeasurementsbigDecimal = null, Expression<Func<bool>> messageRomeasurementsbigInteger = null, Expression<Func<bool>> messageRomeasurementsbinary = null, Expression<Func<bool>> messageRomeasurementsboolean = null, Expression<Func<bool>> messageRomeasurementscontainerNode = null, Expression<Func<bool>> messageRomeasurementsdouble = null, Expression<Func<bool>> messageRomeasurementsfloat = null, Expression<Func<bool>> messageRomeasurementsfloatingPointNumber = null, Expression<Func<bool>> messageRomeasurementsint = null, Expression<Func<bool>> messageRomeasurementsintegralNumber = null, Expression<Func<bool>> messageRomeasurementsLong = null, Expression<Func<bool>> messageRomeasurementsmissingNode = null, Expression<Func<messageRomeasurementsnodeTypeInput>> messageRomeasurementsnodeType = null, Expression<Func<bool>> messageRomeasurementsnull = null, Expression<Func<bool>> messageRomeasurementsnumber = null, Expression<Func<bool>> messageRomeasurementsObject = null, Expression<Func<bool>> messageRomeasurementspojo = null, Expression<Func<bool>> messageRomeasurementsShort = null, Expression<Func<bool>> messageRomeasurementstextual = null, Expression<Func<bool>> messageRomeasurementsvalueNode = null, Expression<Func<bool>> messageRorawMeasurementsarray = null, Expression<Func<bool>> messageRorawMeasurementsbigDecimal = null, Expression<Func<bool>> messageRorawMeasurementsbigInteger = null, Expression<Func<bool>> messageRorawMeasurementsbinary = null, Expression<Func<bool>> messageRorawMeasurementsboolean = null, Expression<Func<bool>> messageRorawMeasurementscontainerNode = null, Expression<Func<bool>> messageRorawMeasurementsdouble = null, Expression<Func<bool>> messageRorawMeasurementsfloat = null, Expression<Func<bool>> messageRorawMeasurementsfloatingPointNumber = null, Expression<Func<bool>> messageRorawMeasurementsint = null, Expression<Func<bool>> messageRorawMeasurementsintegralNumber = null, Expression<Func<bool>> messageRorawMeasurementsLong = null, Expression<Func<bool>> messageRorawMeasurementsmissingNode = null, Expression<Func<messageRorawMeasurementsnodeTypeInput>> messageRorawMeasurementsnodeType = null, Expression<Func<bool>> messageRorawMeasurementsnull = null, Expression<Func<bool>> messageRorawMeasurementsnumber = null, Expression<Func<bool>> messageRorawMeasurementsObject = null, Expression<Func<bool>> messageRorawMeasurementspojo = null, Expression<Func<bool>> messageRorawMeasurementsShort = null, Expression<Func<bool>> messageRorawMeasurementstextual = null, Expression<Func<bool>> messageRorawMeasurementsvalueNode = null, Expression<Func<string>> messageRothingdisplayName = null, Expression<Func<string>> messageRothingfixedName = null, Expression<Func<string>> messageRothingid = null, Expression<Func<int>> messageRothingnbAlerts = null, Expression<Func<ThingTagRo[]>> messageRothingtags = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var messageRo = new JObject();
            var messageRopropCount = 0;
            messageRopropCount++;
            messageRo["body"] = ExpressionConverter.ConvertO(messageRobody);
            messageRopropCount++;
            messageRo["creationDate"] = ExpressionConverter.ConvertO(messageRocreationDate);
            messageRopropCount++;
            messageRo["errorMessage"] = ExpressionConverter.ConvertO(messageRoerrorMessage);
            if (messageRoid != null)
            {
                messageRo["id"] = ExpressionConverter.ConvertO(messageRoid);
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["latitude"] = ExpressionConverter.ConvertO(messageRolatitude);
            var linkObject = new JObject();
            var linkObjectpropCount = 0;
            if (messageRolinkabsolute != null)
            {
                linkObject["absolute"] = ExpressionConverter.ConvertO(messageRolinkabsolute);
                linkObjectpropCount++;
            }

            if (messageRolinkauthority != null)
            {
                linkObject["authority"] = ExpressionConverter.ConvertO(messageRolinkauthority);
                linkObjectpropCount++;
            }

            if (messageRolinkfragment != null)
            {
                linkObject["fragment"] = ExpressionConverter.ConvertO(messageRolinkfragment);
                linkObjectpropCount++;
            }

            if (messageRolinkhost != null)
            {
                linkObject["host"] = ExpressionConverter.ConvertO(messageRolinkhost);
                linkObjectpropCount++;
            }

            if (messageRolinkopaque != null)
            {
                linkObject["opaque"] = ExpressionConverter.ConvertO(messageRolinkopaque);
                linkObjectpropCount++;
            }

            if (messageRolinkpath != null)
            {
                linkObject["path"] = ExpressionConverter.ConvertO(messageRolinkpath);
                linkObjectpropCount++;
            }

            if (messageRolinkport != null)
            {
                linkObject["port"] = ExpressionConverter.ConvertO(messageRolinkport);
                linkObjectpropCount++;
            }

            if (messageRolinkquery != null)
            {
                linkObject["query"] = ExpressionConverter.ConvertO(messageRolinkquery);
                linkObjectpropCount++;
            }

            if (messageRolinkrawAuthority != null)
            {
                linkObject["rawAuthority"] = ExpressionConverter.ConvertO(messageRolinkrawAuthority);
                linkObjectpropCount++;
            }

            if (messageRolinkrawFragment != null)
            {
                linkObject["rawFragment"] = ExpressionConverter.ConvertO(messageRolinkrawFragment);
                linkObjectpropCount++;
            }

            if (messageRolinkrawPath != null)
            {
                linkObject["rawPath"] = ExpressionConverter.ConvertO(messageRolinkrawPath);
                linkObjectpropCount++;
            }

            if (messageRolinkrawQuery != null)
            {
                linkObject["rawQuery"] = ExpressionConverter.ConvertO(messageRolinkrawQuery);
                linkObjectpropCount++;
            }

            if (messageRolinkrawSchemeSpecificPart != null)
            {
                linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkrawSchemeSpecificPart);
                linkObjectpropCount++;
            }

            if (messageRolinkrawUserInfo != null)
            {
                linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(messageRolinkrawUserInfo);
                linkObjectpropCount++;
            }

            if (messageRolinkscheme != null)
            {
                linkObject["scheme"] = ExpressionConverter.ConvertO(messageRolinkscheme);
                linkObjectpropCount++;
            }

            if (messageRolinkschemeSpecificPart != null)
            {
                linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkschemeSpecificPart);
                linkObjectpropCount++;
            }

            if (messageRolinkuserInfo != null)
            {
                linkObject["userInfo"] = ExpressionConverter.ConvertO(messageRolinkuserInfo);
                linkObjectpropCount++;
            }

            if (linkObjectpropCount > 0)
            {
                messageRo["link"] = linkObject;
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["longitude"] = ExpressionConverter.ConvertO(messageRolongitude);
            var measurementsObject = new JObject();
            var measurementsObjectpropCount = 0;
            if (messageRomeasurementsarray != null)
            {
                measurementsObject["array"] = ExpressionConverter.ConvertO(messageRomeasurementsarray);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsbigDecimal != null)
            {
                measurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(messageRomeasurementsbigDecimal);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsbigInteger != null)
            {
                measurementsObject["bigInteger"] = ExpressionConverter.ConvertO(messageRomeasurementsbigInteger);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsbinary != null)
            {
                measurementsObject["binary"] = ExpressionConverter.ConvertO(messageRomeasurementsbinary);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsboolean != null)
            {
                measurementsObject["boolean"] = ExpressionConverter.ConvertO(messageRomeasurementsboolean);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementscontainerNode != null)
            {
                measurementsObject["containerNode"] = ExpressionConverter.ConvertO(messageRomeasurementscontainerNode);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsdouble != null)
            {
                measurementsObject["double"] = ExpressionConverter.ConvertO(messageRomeasurementsdouble);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsfloat != null)
            {
                measurementsObject["float"] = ExpressionConverter.ConvertO(messageRomeasurementsfloat);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsfloatingPointNumber != null)
            {
                measurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsfloatingPointNumber);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsint != null)
            {
                measurementsObject["int"] = ExpressionConverter.ConvertO(messageRomeasurementsint);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsintegralNumber != null)
            {
                measurementsObject["integralNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsintegralNumber);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsLong != null)
            {
                measurementsObject["long"] = ExpressionConverter.ConvertO(messageRomeasurementsLong);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsmissingNode != null)
            {
                measurementsObject["missingNode"] = ExpressionConverter.ConvertO(messageRomeasurementsmissingNode);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsnodeType != null)
            {
                measurementsObject["nodeType"] = ExpressionConverter.ConvertO(messageRomeasurementsnodeType);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsnull != null)
            {
                measurementsObject["null"] = ExpressionConverter.ConvertO(messageRomeasurementsnull);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsnumber != null)
            {
                measurementsObject["number"] = ExpressionConverter.ConvertO(messageRomeasurementsnumber);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsObject != null)
            {
                measurementsObject["object"] = ExpressionConverter.ConvertO(messageRomeasurementsObject);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementspojo != null)
            {
                measurementsObject["pojo"] = ExpressionConverter.ConvertO(messageRomeasurementspojo);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsShort != null)
            {
                measurementsObject["short"] = ExpressionConverter.ConvertO(messageRomeasurementsShort);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementstextual != null)
            {
                measurementsObject["textual"] = ExpressionConverter.ConvertO(messageRomeasurementstextual);
                measurementsObjectpropCount++;
            }

            if (messageRomeasurementsvalueNode != null)
            {
                measurementsObject["valueNode"] = ExpressionConverter.ConvertO(messageRomeasurementsvalueNode);
                measurementsObjectpropCount++;
            }

            if (measurementsObjectpropCount > 0)
            {
                messageRo["measurements"] = measurementsObject;
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["metadata"] = ExpressionConverter.ConvertO(messageRometadata);
            messageRopropCount++;
            messageRo["number"] = ExpressionConverter.ConvertO(messageRonumber);
            messageRopropCount++;
            messageRo["processed"] = ExpressionConverter.ConvertO(messageRoprocessed);
            var rawMeasurementsObject = new JObject();
            var rawMeasurementsObjectpropCount = 0;
            if (messageRomeasurementsarray != null)
            {
                rawMeasurementsObject["array"] = ExpressionConverter.ConvertO(messageRomeasurementsarray);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsbigDecimal != null)
            {
                rawMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(messageRomeasurementsbigDecimal);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsbigInteger != null)
            {
                rawMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(messageRomeasurementsbigInteger);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsbinary != null)
            {
                rawMeasurementsObject["binary"] = ExpressionConverter.ConvertO(messageRomeasurementsbinary);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsboolean != null)
            {
                rawMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(messageRomeasurementsboolean);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementscontainerNode != null)
            {
                rawMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(messageRomeasurementscontainerNode);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsdouble != null)
            {
                rawMeasurementsObject["double"] = ExpressionConverter.ConvertO(messageRomeasurementsdouble);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsfloat != null)
            {
                rawMeasurementsObject["float"] = ExpressionConverter.ConvertO(messageRomeasurementsfloat);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsfloatingPointNumber != null)
            {
                rawMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsfloatingPointNumber);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsint != null)
            {
                rawMeasurementsObject["int"] = ExpressionConverter.ConvertO(messageRomeasurementsint);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsintegralNumber != null)
            {
                rawMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsintegralNumber);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsLong != null)
            {
                rawMeasurementsObject["long"] = ExpressionConverter.ConvertO(messageRomeasurementsLong);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsmissingNode != null)
            {
                rawMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(messageRomeasurementsmissingNode);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsnodeType != null)
            {
                rawMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(messageRomeasurementsnodeType);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsnull != null)
            {
                rawMeasurementsObject["null"] = ExpressionConverter.ConvertO(messageRomeasurementsnull);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsnumber != null)
            {
                rawMeasurementsObject["number"] = ExpressionConverter.ConvertO(messageRomeasurementsnumber);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsObject != null)
            {
                rawMeasurementsObject["object"] = ExpressionConverter.ConvertO(messageRomeasurementsObject);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementspojo != null)
            {
                rawMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(messageRomeasurementspojo);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsShort != null)
            {
                rawMeasurementsObject["short"] = ExpressionConverter.ConvertO(messageRomeasurementsShort);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementstextual != null)
            {
                rawMeasurementsObject["textual"] = ExpressionConverter.ConvertO(messageRomeasurementstextual);
                rawMeasurementsObjectpropCount++;
            }

            if (messageRomeasurementsvalueNode != null)
            {
                rawMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(messageRomeasurementsvalueNode);
                rawMeasurementsObjectpropCount++;
            }

            if (rawMeasurementsObjectpropCount > 0)
            {
                messageRo["rawMeasurements"] = rawMeasurementsObject;
                messageRopropCount++;
            }

            var thingObject = new JObject();
            var thingObjectpropCount = 0;
            if (messageRothingdisplayName != null)
            {
                thingObject["displayName"] = ExpressionConverter.ConvertO(messageRothingdisplayName);
                thingObjectpropCount++;
            }

            if (messageRothingfixedName != null)
            {
                thingObject["fixedName"] = ExpressionConverter.ConvertO(messageRothingfixedName);
                thingObjectpropCount++;
            }

            if (messageRothingid != null)
            {
                thingObject["id"] = ExpressionConverter.ConvertO(messageRothingid);
                thingObjectpropCount++;
            }

            thingObjectpropCount++;
            thingObject["name"] = ExpressionConverter.ConvertO(messageRothingname);
            if (messageRothingnbAlerts != null)
            {
                thingObject["nbAlerts"] = ExpressionConverter.ConvertO(messageRothingnbAlerts);
                thingObjectpropCount++;
            }

            if (messageRothingtags != null)
            {
                thingObject["tags"] = ExpressionConverter.ConvertO(messageRothingtags);
                thingObjectpropCount++;
            }

            if (thingObjectpropCount > 0)
            {
                messageRo["thing"] = thingObject;
                messageRopropCount++;
            }

            messageRopropCount++;
            messageRo["timestamp"] = ExpressionConverter.ConvertO(messageRotimestamp);
            messageRopropCount++;
            messageRo["topic"] = ExpressionConverter.ConvertO(messageRotopic);
            if (messageRopropCount > 0)
            {
                callPayload.Body = messageRo;
            }

            return new ApiConnectionAction<MessageRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo> GetThingModel(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/model", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ModelRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageOperationRo> GetThingOperations(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/operations", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PageOperationRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> ExecuteThingOperation(Expression<Func<string>> id, Expression<Func<string>> operationId, Expression<Func<bool>> placeholdersValuesarray = null, Expression<Func<bool>> placeholdersValuesbigDecimal = null, Expression<Func<bool>> placeholdersValuesbigInteger = null, Expression<Func<bool>> placeholdersValuesbinary = null, Expression<Func<bool>> placeholdersValuesboolean = null, Expression<Func<bool>> placeholdersValuescontainerNode = null, Expression<Func<bool>> placeholdersValuesdouble = null, Expression<Func<bool>> placeholdersValuesfloat = null, Expression<Func<bool>> placeholdersValuesfloatingPointNumber = null, Expression<Func<bool>> placeholdersValuesint = null, Expression<Func<bool>> placeholdersValuesintegralNumber = null, Expression<Func<bool>> placeholdersValuesLong = null, Expression<Func<bool>> placeholdersValuesmissingNode = null, Expression<Func<placeholdersValuesnodeTypeInput>> placeholdersValuesnodeType = null, Expression<Func<bool>> placeholdersValuesnull = null, Expression<Func<bool>> placeholdersValuesnumber = null, Expression<Func<bool>> placeholdersValuesObject = null, Expression<Func<bool>> placeholdersValuespojo = null, Expression<Func<bool>> placeholdersValuesShort = null, Expression<Func<bool>> placeholdersValuestextual = null, Expression<Func<bool>> placeholdersValuesvalueNode = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/operations/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(operationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var placeholdersValues = new JObject();
            var placeholdersValuespropCount = 0;
            if (placeholdersValuesarray != null)
            {
                placeholdersValues["array"] = ExpressionConverter.ConvertO(placeholdersValuesarray);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesbigDecimal != null)
            {
                placeholdersValues["bigDecimal"] = ExpressionConverter.ConvertO(placeholdersValuesbigDecimal);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesbigInteger != null)
            {
                placeholdersValues["bigInteger"] = ExpressionConverter.ConvertO(placeholdersValuesbigInteger);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesbinary != null)
            {
                placeholdersValues["binary"] = ExpressionConverter.ConvertO(placeholdersValuesbinary);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesboolean != null)
            {
                placeholdersValues["boolean"] = ExpressionConverter.ConvertO(placeholdersValuesboolean);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuescontainerNode != null)
            {
                placeholdersValues["containerNode"] = ExpressionConverter.ConvertO(placeholdersValuescontainerNode);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesdouble != null)
            {
                placeholdersValues["double"] = ExpressionConverter.ConvertO(placeholdersValuesdouble);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesfloat != null)
            {
                placeholdersValues["float"] = ExpressionConverter.ConvertO(placeholdersValuesfloat);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesfloatingPointNumber != null)
            {
                placeholdersValues["floatingPointNumber"] = ExpressionConverter.ConvertO(placeholdersValuesfloatingPointNumber);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesint != null)
            {
                placeholdersValues["int"] = ExpressionConverter.ConvertO(placeholdersValuesint);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesintegralNumber != null)
            {
                placeholdersValues["integralNumber"] = ExpressionConverter.ConvertO(placeholdersValuesintegralNumber);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesLong != null)
            {
                placeholdersValues["long"] = ExpressionConverter.ConvertO(placeholdersValuesLong);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesmissingNode != null)
            {
                placeholdersValues["missingNode"] = ExpressionConverter.ConvertO(placeholdersValuesmissingNode);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesnodeType != null)
            {
                placeholdersValues["nodeType"] = ExpressionConverter.ConvertO(placeholdersValuesnodeType);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesnull != null)
            {
                placeholdersValues["null"] = ExpressionConverter.ConvertO(placeholdersValuesnull);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesnumber != null)
            {
                placeholdersValues["number"] = ExpressionConverter.ConvertO(placeholdersValuesnumber);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesObject != null)
            {
                placeholdersValues["object"] = ExpressionConverter.ConvertO(placeholdersValuesObject);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuespojo != null)
            {
                placeholdersValues["pojo"] = ExpressionConverter.ConvertO(placeholdersValuespojo);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesShort != null)
            {
                placeholdersValues["short"] = ExpressionConverter.ConvertO(placeholdersValuesShort);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuestextual != null)
            {
                placeholdersValues["textual"] = ExpressionConverter.ConvertO(placeholdersValuestextual);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuesvalueNode != null)
            {
                placeholdersValues["valueNode"] = ExpressionConverter.ConvertO(placeholdersValuesvalueNode);
                placeholdersValuespropCount++;
            }

            if (placeholdersValuespropCount > 0)
            {
                callPayload.Body = placeholdersValues;
            }

            return new ApiConnectionAction<ResponseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> UpdateThingFixedPosition(Expression<Func<string>> id, Expression<Func<string>> thingRoname, Expression<Func<string>> thingRositeaddress, Expression<Func<string>> thingRositecity, Expression<Func<string>> thingRositename, Expression<Func<string>> thingRositepostalCode, Expression<Func<CustomFieldRo[]>> thingRocustomFields = null, Expression<Func<string>> thingRodescription = null, Expression<Func<string>> thingRodisplayName = null, Expression<Func<bool>> thingRodynamicGps = null, Expression<Func<double>> thingRofixedLatitude = null, Expression<Func<double>> thingRofixedLongitude = null, Expression<Func<string>> thingRofixedName = null, Expression<Func<string>> thingRoid = null, Expression<Func<int>> thingRolastActivityDate = null, Expression<Func<double>> thingRolastLatitude = null, Expression<Func<double>> thingRolastLongitude = null, Expression<Func<bool>> thingRolastMeasurementsarray = null, Expression<Func<bool>> thingRolastMeasurementsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsbinary = null, Expression<Func<bool>> thingRolastMeasurementsboolean = null, Expression<Func<bool>> thingRolastMeasurementscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsdouble = null, Expression<Func<bool>> thingRolastMeasurementsfloat = null, Expression<Func<bool>> thingRolastMeasurementsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsint = null, Expression<Func<bool>> thingRolastMeasurementsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsLong = null, Expression<Func<bool>> thingRolastMeasurementsmissingNode = null, Expression<Func<thingRolastMeasurementsnodeTypeInput>> thingRolastMeasurementsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsnull = null, Expression<Func<bool>> thingRolastMeasurementsnumber = null, Expression<Func<bool>> thingRolastMeasurementsObject = null, Expression<Func<bool>> thingRolastMeasurementspojo = null, Expression<Func<bool>> thingRolastMeasurementsShort = null, Expression<Func<bool>> thingRolastMeasurementstextual = null, Expression<Func<bool>> thingRolastMeasurementsvalueNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsarray = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbinary = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsboolean = null, Expression<Func<bool>> thingRolastMeasurementsTimestampscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsdouble = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloat = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsint = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsLong = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsmissingNode = null, Expression<Func<thingRolastMeasurementsTimestampsnodeTypeInput>> thingRolastMeasurementsTimestampsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnull = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsObject = null, Expression<Func<bool>> thingRolastMeasurementsTimestampspojo = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsShort = null, Expression<Func<bool>> thingRolastMeasurementsTimestampstextual = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsvalueNode = null, Expression<Func<int>> thingRolastMessageDate = null, Expression<Func<int>> thingRomessageActivityTimeoutPeriod = null, Expression<Func<int>> thingRonbAlerts = null, Expression<Func<string>> thingRositeid = null, Expression<Func<double>> thingRositelatitude = null, Expression<Func<double>> thingRositelongitude = null, Expression<Func<thingRostatusInput>> thingRostatus = null, Expression<Func<ThingTagRo[]>> thingRotags = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/positions", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var thingRo = new JObject();
            var thingRopropCount = 0;
            if (thingRocustomFields != null)
            {
                thingRo["customFields"] = ExpressionConverter.ConvertO(thingRocustomFields);
                thingRopropCount++;
            }

            if (thingRodescription != null)
            {
                thingRo["description"] = ExpressionConverter.ConvertO(thingRodescription);
                thingRopropCount++;
            }

            if (thingRodisplayName != null)
            {
                thingRo["displayName"] = ExpressionConverter.ConvertO(thingRodisplayName);
                thingRopropCount++;
            }

            if (thingRodynamicGps != null)
            {
                thingRo["dynamicGps"] = ExpressionConverter.ConvertO(thingRodynamicGps);
                thingRopropCount++;
            }

            if (thingRofixedLatitude != null)
            {
                thingRo["fixedLatitude"] = ExpressionConverter.ConvertO(thingRofixedLatitude);
                thingRopropCount++;
            }

            if (thingRofixedLongitude != null)
            {
                thingRo["fixedLongitude"] = ExpressionConverter.ConvertO(thingRofixedLongitude);
                thingRopropCount++;
            }

            if (thingRofixedName != null)
            {
                thingRo["fixedName"] = ExpressionConverter.ConvertO(thingRofixedName);
                thingRopropCount++;
            }

            if (thingRoid != null)
            {
                thingRo["id"] = ExpressionConverter.ConvertO(thingRoid);
                thingRopropCount++;
            }

            if (thingRolastActivityDate != null)
            {
                thingRo["lastActivityDate"] = ExpressionConverter.ConvertO(thingRolastActivityDate);
                thingRopropCount++;
            }

            if (thingRolastLatitude != null)
            {
                thingRo["lastLatitude"] = ExpressionConverter.ConvertO(thingRolastLatitude);
                thingRopropCount++;
            }

            if (thingRolastLongitude != null)
            {
                thingRo["lastLongitude"] = ExpressionConverter.ConvertO(thingRolastLongitude);
                thingRopropCount++;
            }

            var lastMeasurementsObject = new JObject();
            var lastMeasurementsObjectpropCount = 0;
            if (thingRolastMeasurementsarray != null)
            {
                lastMeasurementsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigDecimal != null)
            {
                lastMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigInteger != null)
            {
                lastMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsbinary != null)
            {
                lastMeasurementsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsboolean != null)
            {
                lastMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementscontainerNode != null)
            {
                lastMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsdouble != null)
            {
                lastMeasurementsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloat != null)
            {
                lastMeasurementsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloatingPointNumber != null)
            {
                lastMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsint != null)
            {
                lastMeasurementsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsintegralNumber != null)
            {
                lastMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsLong != null)
            {
                lastMeasurementsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsmissingNode != null)
            {
                lastMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsnodeType != null)
            {
                lastMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsnull != null)
            {
                lastMeasurementsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsnumber != null)
            {
                lastMeasurementsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsObject != null)
            {
                lastMeasurementsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementspojo != null)
            {
                lastMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsShort != null)
            {
                lastMeasurementsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementstextual != null)
            {
                lastMeasurementsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                lastMeasurementsObjectpropCount++;
            }

            if (thingRolastMeasurementsvalueNode != null)
            {
                lastMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                lastMeasurementsObjectpropCount++;
            }

            if (lastMeasurementsObjectpropCount > 0)
            {
                thingRo["lastMeasurements"] = lastMeasurementsObject;
                thingRopropCount++;
            }

            var lastMeasurementsTimestampsObject = new JObject();
            var lastMeasurementsTimestampsObjectpropCount = 0;
            if (thingRolastMeasurementsarray != null)
            {
                lastMeasurementsTimestampsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigDecimal != null)
            {
                lastMeasurementsTimestampsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsbigInteger != null)
            {
                lastMeasurementsTimestampsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsbinary != null)
            {
                lastMeasurementsTimestampsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsboolean != null)
            {
                lastMeasurementsTimestampsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementscontainerNode != null)
            {
                lastMeasurementsTimestampsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsdouble != null)
            {
                lastMeasurementsTimestampsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloat != null)
            {
                lastMeasurementsTimestampsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsfloatingPointNumber != null)
            {
                lastMeasurementsTimestampsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsint != null)
            {
                lastMeasurementsTimestampsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsintegralNumber != null)
            {
                lastMeasurementsTimestampsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsLong != null)
            {
                lastMeasurementsTimestampsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsmissingNode != null)
            {
                lastMeasurementsTimestampsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsnodeType != null)
            {
                lastMeasurementsTimestampsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsnull != null)
            {
                lastMeasurementsTimestampsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsnumber != null)
            {
                lastMeasurementsTimestampsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsObject != null)
            {
                lastMeasurementsTimestampsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementspojo != null)
            {
                lastMeasurementsTimestampsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsShort != null)
            {
                lastMeasurementsTimestampsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementstextual != null)
            {
                lastMeasurementsTimestampsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (thingRolastMeasurementsvalueNode != null)
            {
                lastMeasurementsTimestampsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                lastMeasurementsTimestampsObjectpropCount++;
            }

            if (lastMeasurementsTimestampsObjectpropCount > 0)
            {
                thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                thingRopropCount++;
            }

            if (thingRolastMessageDate != null)
            {
                thingRo["lastMessageDate"] = ExpressionConverter.ConvertO(thingRolastMessageDate);
                thingRopropCount++;
            }

            if (thingRomessageActivityTimeoutPeriod != null)
            {
                thingRo["messageActivityTimeoutPeriod"] = ExpressionConverter.ConvertO(thingRomessageActivityTimeoutPeriod);
                thingRopropCount++;
            }

            thingRopropCount++;
            thingRo["name"] = ExpressionConverter.ConvertO(thingRoname);
            if (thingRonbAlerts != null)
            {
                thingRo["nbAlerts"] = ExpressionConverter.ConvertO(thingRonbAlerts);
                thingRopropCount++;
            }

            var siteObject = new JObject();
            var siteObjectpropCount = 0;
            siteObjectpropCount++;
            siteObject["address"] = ExpressionConverter.ConvertO(thingRositeaddress);
            siteObjectpropCount++;
            siteObject["city"] = ExpressionConverter.ConvertO(thingRositecity);
            if (thingRositeid != null)
            {
                siteObject["id"] = ExpressionConverter.ConvertO(thingRositeid);
                siteObjectpropCount++;
            }

            if (thingRositelatitude != null)
            {
                siteObject["latitude"] = ExpressionConverter.ConvertO(thingRositelatitude);
                siteObjectpropCount++;
            }

            if (thingRositelongitude != null)
            {
                siteObject["longitude"] = ExpressionConverter.ConvertO(thingRositelongitude);
                siteObjectpropCount++;
            }

            siteObjectpropCount++;
            siteObject["name"] = ExpressionConverter.ConvertO(thingRositename);
            siteObjectpropCount++;
            siteObject["postalCode"] = ExpressionConverter.ConvertO(thingRositepostalCode);
            if (siteObjectpropCount > 0)
            {
                thingRo["site"] = siteObject;
                thingRopropCount++;
            }

            if (thingRostatus != null)
            {
                thingRo["status"] = ExpressionConverter.ConvertO(thingRostatus);
                thingRopropCount++;
            }

            if (thingRotags != null)
            {
                thingRo["tags"] = ExpressionConverter.ConvertO(thingRotags);
                thingRopropCount++;
            }

            if (thingRopropCount > 0)
            {
                callPayload.Body = thingRo;
            }

            return new ApiConnectionAction<SingleThingRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ProductRo> GetThingProduct(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProductRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> DissociateThingProduct(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SingleThingRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> AssociateThingProduct(Expression<Func<string>> id, Expression<Func<string>> productcertification = null, Expression<Func<productconnectivityTypesInputItem[]>> productconnectivityTypes = null, Expression<Func<string>> productdecoderid = null, Expression<Func<string>> productdecoderlink = null, Expression<Func<bool>> productdecodervisible = null, Expression<Func<string>> productdescription = null, Expression<Func<string>> productencoderid = null, Expression<Func<string>> productencoderlink = null, Expression<Func<bool>> productgenerateLinks = null, Expression<Func<bool>> producthasImage = null, Expression<Func<string>> productid = null, Expression<Func<string>> productimageLink = null, Expression<Func<string>> productinfoLink = null, Expression<Func<string>> productlink = null, Expression<Func<bool>> productmanufacturergenerateLinks = null, Expression<Func<string>> productmanufacturerid = null, Expression<Func<string>> productmanufacturerlink = null, Expression<Func<string>> productmanufacturername = null, Expression<Func<string>> productmanufacturerCategory = null, Expression<Func<string>> productmodelcolor = null, Expression<Func<bool>> productmodelgenerateLinks = null, Expression<Func<string>> productmodelicon = null, Expression<Func<string>> productmodelid = null, Expression<Func<bool>> productmodelisCustomModel = null, Expression<Func<bool>> productmodellinkabsolute = null, Expression<Func<string>> productmodellinkauthority = null, Expression<Func<string>> productmodellinkfragment = null, Expression<Func<string>> productmodellinkhost = null, Expression<Func<bool>> productmodellinkopaque = null, Expression<Func<string>> productmodellinkpath = null, Expression<Func<int>> productmodellinkport = null, Expression<Func<string>> productmodellinkquery = null, Expression<Func<string>> productmodellinkrawAuthority = null, Expression<Func<string>> productmodellinkrawFragment = null, Expression<Func<string>> productmodellinkrawPath = null, Expression<Func<string>> productmodellinkrawQuery = null, Expression<Func<string>> productmodellinkrawSchemeSpecificPart = null, Expression<Func<string>> productmodellinkrawUserInfo = null, Expression<Func<string>> productmodellinkscheme = null, Expression<Func<string>> productmodellinkschemeSpecificPart = null, Expression<Func<string>> productmodellinkuserInfo = null, Expression<Func<string>> productmodelname = null, Expression<Func<bool>> productmodelManufacturergenerateLinks = null, Expression<Func<string>> productmodelManufacturerid = null, Expression<Func<string>> productmodelManufacturerlink = null, Expression<Func<string>> productmodelManufacturername = null, Expression<Func<string>> productname = null, Expression<Func<bool>> productreadOnly = null, Expression<Func<string>> productreference = null, Expression<Func<TagRo[]>> producttags = null, Expression<Func<ThingTinyRo[]>> productthings = null)
        {
            var apiCallPath = String.Format("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var product = new JObject();
            var productpropCount = 0;
            if (productcertification != null)
            {
                product["certification"] = ExpressionConverter.ConvertO(productcertification);
                productpropCount++;
            }

            if (productconnectivityTypes != null)
            {
                product["connectivityTypes"] = ExpressionConverter.ConvertO(productconnectivityTypes);
                productpropCount++;
            }

            var decoderObject = new JObject();
            var decoderObjectpropCount = 0;
            if (productdecoderid != null)
            {
                decoderObject["id"] = ExpressionConverter.ConvertO(productdecoderid);
                decoderObjectpropCount++;
            }

            if (productdecoderlink != null)
            {
                decoderObject["link"] = ExpressionConverter.ConvertO(productdecoderlink);
                decoderObjectpropCount++;
            }

            if (productdecodervisible != null)
            {
                decoderObject["visible"] = ExpressionConverter.ConvertO(productdecodervisible);
                decoderObjectpropCount++;
            }

            if (decoderObjectpropCount > 0)
            {
                product["decoder"] = decoderObject;
                productpropCount++;
            }

            if (productdescription != null)
            {
                product["description"] = ExpressionConverter.ConvertO(productdescription);
                productpropCount++;
            }

            var encoderObject = new JObject();
            var encoderObjectpropCount = 0;
            if (productencoderid != null)
            {
                encoderObject["id"] = ExpressionConverter.ConvertO(productencoderid);
                encoderObjectpropCount++;
            }

            if (productencoderlink != null)
            {
                encoderObject["link"] = ExpressionConverter.ConvertO(productencoderlink);
                encoderObjectpropCount++;
            }

            if (encoderObjectpropCount > 0)
            {
                product["encoder"] = encoderObject;
                productpropCount++;
            }

            if (productgenerateLinks != null)
            {
                product["generateLinks"] = ExpressionConverter.ConvertO(productgenerateLinks);
                productpropCount++;
            }

            if (producthasImage != null)
            {
                product["hasImage"] = ExpressionConverter.ConvertO(producthasImage);
                productpropCount++;
            }

            if (productid != null)
            {
                product["id"] = ExpressionConverter.ConvertO(productid);
                productpropCount++;
            }

            if (productimageLink != null)
            {
                product["imageLink"] = ExpressionConverter.ConvertO(productimageLink);
                productpropCount++;
            }

            if (productinfoLink != null)
            {
                product["infoLink"] = ExpressionConverter.ConvertO(productinfoLink);
                productpropCount++;
            }

            if (productlink != null)
            {
                product["link"] = ExpressionConverter.ConvertO(productlink);
                productpropCount++;
            }

            var manufacturerObject = new JObject();
            var manufacturerObjectpropCount = 0;
            if (productmanufacturergenerateLinks != null)
            {
                manufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(productmanufacturergenerateLinks);
                manufacturerObjectpropCount++;
            }

            if (productmanufacturerid != null)
            {
                manufacturerObject["id"] = ExpressionConverter.ConvertO(productmanufacturerid);
                manufacturerObjectpropCount++;
            }

            if (productmanufacturerlink != null)
            {
                manufacturerObject["link"] = ExpressionConverter.ConvertO(productmanufacturerlink);
                manufacturerObjectpropCount++;
            }

            if (productmanufacturername != null)
            {
                manufacturerObject["name"] = ExpressionConverter.ConvertO(productmanufacturername);
                manufacturerObjectpropCount++;
            }

            if (manufacturerObjectpropCount > 0)
            {
                product["manufacturer"] = manufacturerObject;
                productpropCount++;
            }

            if (productmanufacturerCategory != null)
            {
                product["manufacturerCategory"] = ExpressionConverter.ConvertO(productmanufacturerCategory);
                productpropCount++;
            }

            var modelObject = new JObject();
            var modelObjectpropCount = 0;
            if (productmodelcolor != null)
            {
                modelObject["color"] = ExpressionConverter.ConvertO(productmodelcolor);
                modelObjectpropCount++;
            }

            if (productmodelgenerateLinks != null)
            {
                modelObject["generateLinks"] = ExpressionConverter.ConvertO(productmodelgenerateLinks);
                modelObjectpropCount++;
            }

            if (productmodelicon != null)
            {
                modelObject["icon"] = ExpressionConverter.ConvertO(productmodelicon);
                modelObjectpropCount++;
            }

            if (productmodelid != null)
            {
                modelObject["id"] = ExpressionConverter.ConvertO(productmodelid);
                modelObjectpropCount++;
            }

            if (productmodelisCustomModel != null)
            {
                modelObject["isCustomModel"] = ExpressionConverter.ConvertO(productmodelisCustomModel);
                modelObjectpropCount++;
            }

            var linkObject = new JObject();
            var linkObjectpropCount = 0;
            if (productmodellinkabsolute != null)
            {
                linkObject["absolute"] = ExpressionConverter.ConvertO(productmodellinkabsolute);
                linkObjectpropCount++;
            }

            if (productmodellinkauthority != null)
            {
                linkObject["authority"] = ExpressionConverter.ConvertO(productmodellinkauthority);
                linkObjectpropCount++;
            }

            if (productmodellinkfragment != null)
            {
                linkObject["fragment"] = ExpressionConverter.ConvertO(productmodellinkfragment);
                linkObjectpropCount++;
            }

            if (productmodellinkhost != null)
            {
                linkObject["host"] = ExpressionConverter.ConvertO(productmodellinkhost);
                linkObjectpropCount++;
            }

            if (productmodellinkopaque != null)
            {
                linkObject["opaque"] = ExpressionConverter.ConvertO(productmodellinkopaque);
                linkObjectpropCount++;
            }

            if (productmodellinkpath != null)
            {
                linkObject["path"] = ExpressionConverter.ConvertO(productmodellinkpath);
                linkObjectpropCount++;
            }

            if (productmodellinkport != null)
            {
                linkObject["port"] = ExpressionConverter.ConvertO(productmodellinkport);
                linkObjectpropCount++;
            }

            if (productmodellinkquery != null)
            {
                linkObject["query"] = ExpressionConverter.ConvertO(productmodellinkquery);
                linkObjectpropCount++;
            }

            if (productmodellinkrawAuthority != null)
            {
                linkObject["rawAuthority"] = ExpressionConverter.ConvertO(productmodellinkrawAuthority);
                linkObjectpropCount++;
            }

            if (productmodellinkrawFragment != null)
            {
                linkObject["rawFragment"] = ExpressionConverter.ConvertO(productmodellinkrawFragment);
                linkObjectpropCount++;
            }

            if (productmodellinkrawPath != null)
            {
                linkObject["rawPath"] = ExpressionConverter.ConvertO(productmodellinkrawPath);
                linkObjectpropCount++;
            }

            if (productmodellinkrawQuery != null)
            {
                linkObject["rawQuery"] = ExpressionConverter.ConvertO(productmodellinkrawQuery);
                linkObjectpropCount++;
            }

            if (productmodellinkrawSchemeSpecificPart != null)
            {
                linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(productmodellinkrawSchemeSpecificPart);
                linkObjectpropCount++;
            }

            if (productmodellinkrawUserInfo != null)
            {
                linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(productmodellinkrawUserInfo);
                linkObjectpropCount++;
            }

            if (productmodellinkscheme != null)
            {
                linkObject["scheme"] = ExpressionConverter.ConvertO(productmodellinkscheme);
                linkObjectpropCount++;
            }

            if (productmodellinkschemeSpecificPart != null)
            {
                linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(productmodellinkschemeSpecificPart);
                linkObjectpropCount++;
            }

            if (productmodellinkuserInfo != null)
            {
                linkObject["userInfo"] = ExpressionConverter.ConvertO(productmodellinkuserInfo);
                linkObjectpropCount++;
            }

            if (linkObjectpropCount > 0)
            {
                modelObject["link"] = linkObject;
                modelObjectpropCount++;
            }

            if (productmodelname != null)
            {
                modelObject["name"] = ExpressionConverter.ConvertO(productmodelname);
                modelObjectpropCount++;
            }

            if (modelObjectpropCount > 0)
            {
                product["model"] = modelObject;
                productpropCount++;
            }

            var modelManufacturerObject = new JObject();
            var modelManufacturerObjectpropCount = 0;
            if (productmanufacturergenerateLinks != null)
            {
                modelManufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(productmanufacturergenerateLinks);
                modelManufacturerObjectpropCount++;
            }

            if (productmanufacturerid != null)
            {
                modelManufacturerObject["id"] = ExpressionConverter.ConvertO(productmanufacturerid);
                modelManufacturerObjectpropCount++;
            }

            if (productmanufacturerlink != null)
            {
                modelManufacturerObject["link"] = ExpressionConverter.ConvertO(productmanufacturerlink);
                modelManufacturerObjectpropCount++;
            }

            if (productmanufacturername != null)
            {
                modelManufacturerObject["name"] = ExpressionConverter.ConvertO(productmanufacturername);
                modelManufacturerObjectpropCount++;
            }

            if (modelManufacturerObjectpropCount > 0)
            {
                product["modelManufacturer"] = modelManufacturerObject;
                productpropCount++;
            }

            if (productname != null)
            {
                product["name"] = ExpressionConverter.ConvertO(productname);
                productpropCount++;
            }

            if (productreadOnly != null)
            {
                product["readOnly"] = ExpressionConverter.ConvertO(productreadOnly);
                productpropCount++;
            }

            if (productreference != null)
            {
                product["reference"] = ExpressionConverter.ConvertO(productreference);
                productpropCount++;
            }

            if (producttags != null)
            {
                product["tags"] = ExpressionConverter.ConvertO(producttags);
                productpropCount++;
            }

            if (productthings != null)
            {
                product["things"] = ExpressionConverter.ConvertO(productthings);
                productpropCount++;
            }

            if (productpropCount > 0)
            {
                callPayload.Body = product;
            }

            return new ApiConnectionAction<SingleThingRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageFlowRo> GetFlowsRelatedToThing(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/related_flows", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PageFlowRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo> GetThingTags(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/things/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PageThingTagRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsAvg(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var apiCallPath = "/stats/avg";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo> GetStatsCount(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var apiCallPath = "/stats/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<StatsCountRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsLast(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = "/stats/last";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetThingStatsLast(Expression<Func<string>> thingId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var apiCallPath = String.Format("/stats/last/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMax(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var apiCallPath = "/stats/max";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsMeasurements(Expression<Func<int>> start, Expression<Func<int>> end, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> time = null, Expression<Func<string>> interval = null)
        {
            var apiCallPath = "/stats/measurements";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (time != null)
                callPayload.Queries["time"] = ExpressionConverter.Convert(time);
            if (interval != null)
                callPayload.Queries["interval"] = ExpressionConverter.Convert(interval);
            callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMin(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var apiCallPath = "/stats/min";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo[]> GetStatsRepartition(Expression<Func<string>> attribute, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var apiCallPath = "/stats/repartition";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["attribute"] = ExpressionConverter.Convert(attribute);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<StatsCountRo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsSum(Expression<Func<int>> start, Expression<Func<int>> end, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> time = null, Expression<Func<string>> interval = null)
        {
            var apiCallPath = "/stats/sum";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortValues != null)
                callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (orFilter != null)
                callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
            if (time != null)
                callPayload.Queries["time"] = ExpressionConverter.Convert(time);
            if (interval != null)
                callPayload.Queries["interval"] = ExpressionConverter.Convert(interval);
            callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
        }
    }

    public class PilotthingsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PageAlertRo
    {
        [JsonProperty("data")]
        public AlertRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class AlertRo
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("creationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("flowOrigin")]
        public FlowTinyRo FlowOrigin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("level")]
        public AlertRoLevelType Level { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public AlertRoStateType State { get; set; }

        [JsonProperty("thing")]
        public ThingTinyRo Thing { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class FlowTinyRo
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum AlertRoLevelType
    {
        INFO,
        WARNING,
        CRITICAL
    }

    public enum AlertRoStateType
    {
        OPENED,
        IGNORED,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        RESOLVED
    }

    public class ThingTinyRo
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("tags")]
        public ThingTagRo[] Tags { get; set; }
    }

    public class ThingTagRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public enum dirInput
    {
        ASC,
        DESC
    }

    public class PageMeasureRo
    {
        [JsonProperty("data")]
        public MeasureRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class MeasureRo
    {
        [JsonProperty("attribute")]
        public AttributeTinyRo Attribute { get; set; }

        [JsonProperty("dtype")]
        public string Dtype { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public ModelTinyRo Model { get; set; }

        [JsonProperty("product")]
        public ProductTinyRo Product { get; set; }

        [JsonProperty("thing")]
        public ThingTinyRo Thing { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AttributeTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public QuantityKindRo Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class QuantityKindRo
    {
        [JsonProperty("defaultUnit")]
        public string DefaultUnit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ModelTinyRo
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool IsCustomModel { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class URI
    {
        [JsonProperty("absolute")]
        public bool Absolute { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("fragment")]
        public string Fragment { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("opaque")]
        public bool Opaque { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("rawAuthority")]
        public string RawAuthority { get; set; }

        [JsonProperty("rawFragment")]
        public string RawFragment { get; set; }

        [JsonProperty("rawPath")]
        public string RawPath { get; set; }

        [JsonProperty("rawQuery")]
        public string RawQuery { get; set; }

        [JsonProperty("rawSchemeSpecificPart")]
        public string RawSchemeSpecificPart { get; set; }

        [JsonProperty("rawUserInfo")]
        public string RawUserInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("schemeSpecificPart")]
        public string SchemeSpecificPart { get; set; }

        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }

    public class ProductTinyRo
    {
        [JsonProperty("connectivityTypes")]
        public ProductTinyRoConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public ManufacturerTinyRo Manufacturer { get; set; }

        [JsonProperty("model")]
        public ModelTinyRo Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public enum ProductTinyRoConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class ManufacturerTinyRo
    {
        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CountRo
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class PageMessageRo
    {
        [JsonProperty("data")]
        public MessageRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class MessageRo
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("measurements")]
        public JsonNode Measurements { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("processed")]
        public MessageRoProcessedType Processed { get; set; }

        [JsonProperty("rawMeasurements")]
        public JsonNode RawMeasurements { get; set; }

        [JsonProperty("thing")]
        public ThingTinyRo Thing { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }

    public class JsonNode
    {
        [JsonProperty("array")]
        public bool Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool Binary { get; set; }

        [JsonProperty("boolean")]
        public bool Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool Double { get; set; }

        [JsonProperty("float")]
        public bool Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool Long { get; set; }

        [JsonProperty("missingNode")]
        public bool MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public JsonNodeNodeTypeType NodeType { get; set; }

        [JsonProperty("null")]
        public bool Null { get; set; }

        [JsonProperty("number")]
        public bool Number { get; set; }

        [JsonProperty("object")]
        public bool Object { get; set; }

        [JsonProperty("pojo")]
        public bool Pojo { get; set; }

        [JsonProperty("short")]
        public bool Short { get; set; }

        [JsonProperty("textual")]
        public bool Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool ValueNode { get; set; }
    }

    public enum JsonNodeNodeTypeType
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public enum MessageRoProcessedType
    {
        TODO,
        DONE,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        ASSOCIATED,
        [EnumMember(Value = "TO_BE_FORWARDED")]
        TOBEFORWARDED,
        [EnumMember(Value = "ERROR_CUSTOM")]
        ERRORCUSTOM,
        [EnumMember(Value = "TODO_CUSTOM")]
        TODOCUSTOM,
        ERROR
    }

    public enum messageRoprocessedInput
    {
        TODO,
        DONE,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        ASSOCIATED,
        [EnumMember(Value = "TO_BE_FORWARDED")]
        TOBEFORWARDED,
        [EnumMember(Value = "ERROR_CUSTOM")]
        ERRORCUSTOM,
        [EnumMember(Value = "TODO_CUSTOM")]
        TODOCUSTOM,
        ERROR
    }

    public enum messageRorawMeasurementsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public class PageSiteRo
    {
        [JsonProperty("data")]
        public SiteRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class SiteRo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public enum nodenodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public class PageThingTagRo
    {
        [JsonProperty("data")]
        public ThingTagRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class TagRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class PageSingleThingRo
    {
        [JsonProperty("data")]
        public SingleThingRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class SingleThingRo
    {
        [JsonProperty("application")]
        public ApplicationTinyRo Application { get; set; }

        [JsonProperty("connectivity")]
        public ConnectivityRo Connectivity { get; set; }

        [JsonProperty("customFields")]
        public CustomFieldRo[] CustomFields { get; set; }

        [JsonProperty("customModel")]
        public CustomModelTinyRo CustomModel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("device")]
        public DeviceRo Device { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public JsonNode LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public JsonNode LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("product")]
        public ProductTinyRo Product { get; set; }

        [JsonProperty("site")]
        public SiteRo Site { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("status")]
        public SingleThingRoStatusType Status { get; set; }

        [JsonProperty("tags")]
        public ThingTagRo[] Tags { get; set; }
    }

    public class ApplicationTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConnectivityRo
    {
        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rawStatus")]
        public string RawStatus { get; set; }

        [JsonProperty("status")]
        public ConnectivityRoStatusType Status { get; set; }

        [JsonProperty("type")]
        public ConnectivityRoTypeType Type { get; set; }
    }

    public enum ConnectivityRoStatusType
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

    public enum ConnectivityRoTypeType
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class CustomFieldRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public CustomFieldRoTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum CustomFieldRoTypeType
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class CustomModelTinyRo
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeviceRo
    {
        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }

        [JsonProperty("batteryStatus")]
        public DeviceRoBatteryStatusType BatteryStatus { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("memoryFree")]
        public int MemoryFree { get; set; }

        [JsonProperty("memoryTotal")]
        public int MemoryTotal { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public DeviceRoStatusType Status { get; set; }
    }

    public enum DeviceRoBatteryStatusType
    {
        NORMAL,
        CHARGING,
        [EnumMember(Value = "CHARGE_COMPLETE")]
        CHARGECOMPLETE,
        DAMAGED,
        [EnumMember(Value = "LOW_BATTERY")]
        LOWBATTERY,
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED,
        UNKNOWN
    }

    public enum DeviceRoStatusType
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

    public enum SingleThingRoStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class ResponseEntity
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("statusCode")]
        public ResponseEntityStatusCodeType StatusCode { get; set; }

        [JsonProperty("statusCodeValue")]
        public int StatusCodeValue { get; set; }
    }

    public enum ResponseEntityStatusCodeType
    {
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "102")]
        _102,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "201")]
        _201,
        [EnumMember(Value = "202")]
        _202,
        [EnumMember(Value = "203")]
        _203,
        [EnumMember(Value = "204")]
        _204,
        [EnumMember(Value = "205")]
        _205,
        [EnumMember(Value = "206")]
        _206,
        [EnumMember(Value = "207")]
        _207,
        [EnumMember(Value = "208")]
        _208,
        [EnumMember(Value = "226")]
        _226,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "301")]
        _301,
        [EnumMember(Value = "302")]
        _302,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "304")]
        _304,
        [EnumMember(Value = "305")]
        _305,
        [EnumMember(Value = "307")]
        _307,
        [EnumMember(Value = "308")]
        _308,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "402")]
        _402,
        [EnumMember(Value = "403")]
        _403,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "405")]
        _405,
        [EnumMember(Value = "406")]
        _406,
        [EnumMember(Value = "407")]
        _407,
        [EnumMember(Value = "408")]
        _408,
        [EnumMember(Value = "409")]
        _409,
        [EnumMember(Value = "410")]
        _410,
        [EnumMember(Value = "411")]
        _411,
        [EnumMember(Value = "412")]
        _412,
        [EnumMember(Value = "413")]
        _413,
        [EnumMember(Value = "414")]
        _414,
        [EnumMember(Value = "415")]
        _415,
        [EnumMember(Value = "416")]
        _416,
        [EnumMember(Value = "417")]
        _417,
        [EnumMember(Value = "418")]
        _418,
        [EnumMember(Value = "419")]
        _419,
        [EnumMember(Value = "420")]
        _420,
        [EnumMember(Value = "421")]
        _421,
        [EnumMember(Value = "422")]
        _422,
        [EnumMember(Value = "423")]
        _423,
        [EnumMember(Value = "424")]
        _424,
        [EnumMember(Value = "426")]
        _426,
        [EnumMember(Value = "428")]
        _428,
        [EnumMember(Value = "429")]
        _429,
        [EnumMember(Value = "431")]
        _431,
        [EnumMember(Value = "451")]
        _451,
        [EnumMember(Value = "500")]
        _500,
        [EnumMember(Value = "501")]
        _501,
        [EnumMember(Value = "502")]
        _502,
        [EnumMember(Value = "503")]
        _503,
        [EnumMember(Value = "504")]
        _504,
        [EnumMember(Value = "505")]
        _505,
        [EnumMember(Value = "506")]
        _506,
        [EnumMember(Value = "507")]
        _507,
        [EnumMember(Value = "508")]
        _508,
        [EnumMember(Value = "509")]
        _509,
        [EnumMember(Value = "510")]
        _510,
        [EnumMember(Value = "511")]
        _511
    }

    public enum jsonnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public class ThingRo
    {
        [JsonProperty("customFields")]
        public CustomFieldRo[] CustomFields { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public JsonNode LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public JsonNode LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("site")]
        public SiteRo Site { get; set; }

        [JsonProperty("status")]
        public ThingRoStatusType Status { get; set; }

        [JsonProperty("tags")]
        public ThingTagRo[] Tags { get; set; }
    }

    public enum ThingRoStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public enum thingRoconnectivitystatusInput
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

    public enum thingRoconnectivitytypeInput
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public enum thingRodevicebatteryStatusInput
    {
        NORMAL,
        CHARGING,
        [EnumMember(Value = "CHARGE_COMPLETE")]
        CHARGECOMPLETE,
        DAMAGED,
        [EnumMember(Value = "LOW_BATTERY")]
        LOWBATTERY,
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED,
        UNKNOWN
    }

    public enum thingRodevicestatusInput
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

    public enum thingRolastMeasurementsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public enum thingRolastMeasurementsTimestampsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public enum thingRoproductconnectivityTypesInputItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public enum thingRostatusInput
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class ModelRo
    {
        [JsonProperty("attributes")]
        public AttributeRo[] Attributes { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool IsCustomModel { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operations")]
        public OperationRo[] Operations { get; set; }
    }

    public class AttributeRo
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public QuantityKindRo Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class OperationRo
    {
        [JsonProperty("args")]
        public string Args { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PageCustomFieldRo
    {
        [JsonProperty("data")]
        public PageCustomFieldRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public enum customFieldRotypeInput
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class MeasureTinyRo
    {
        [JsonProperty("attribute")]
        public AttributeTinyRo Attribute { get; set; }

        [JsonProperty("dtype")]
        public string Dtype { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class MessageTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public enum messageRomeasurementsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public class PageOperationRo
    {
        [JsonProperty("data")]
        public OperationRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public enum placeholdersValuesnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        OBJECT,
        POJO,
        STRING
    }

    public class ProductRo
    {
        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("connectivityTypes")]
        public ProductRoConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("decoder")]
        public DecoderTinyRo Decoder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("encoder")]
        public EncoderTinyRo Encoder { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("hasImage")]
        public bool HasImage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("infoLink")]
        public string InfoLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public ManufacturerTinyRo Manufacturer { get; set; }

        [JsonProperty("manufacturerCategory")]
        public string ManufacturerCategory { get; set; }

        [JsonProperty("model")]
        public ModelTinyRo Model { get; set; }

        [JsonProperty("modelManufacturer")]
        public ManufacturerTinyRo ModelManufacturer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("tags")]
        public TagRo[] Tags { get; set; }

        [JsonProperty("things")]
        public ThingTinyRo[] Things { get; set; }
    }

    public enum ProductRoConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class DecoderTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public class EncoderTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public enum productconnectivityTypesInputItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class PageFlowRo
    {
        [JsonProperty("data")]
        public PageFlowRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class PageStatsMeasureRo
    {
        [JsonProperty("data")]
        public StatsMeasureRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class StatsMeasureRo
    {
        [JsonProperty("attribute")]
        public AttributeRo Attribute { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class StatsCountRo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class StatsGraphRo
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings;

    public partial class WorkflowManagedActions
    {
        public PilotthingsActions Pilotthings(string connectionId) => new PilotthingsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PilotthingsTriggers Pilotthings(string connectionId) => new PilotthingsTriggers(connectionId);
    }
}