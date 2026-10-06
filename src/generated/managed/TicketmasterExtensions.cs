//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ticketmaster
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TicketmasterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<EventsGetResponse> EventsGet([WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> attractionId = null, [WorkflowExpression] Func<string> venueId = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> latlong = null, [WorkflowExpression] Func<string> radius = null, [WorkflowExpression] Func<unitInput> unit = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<marketIdInput> marketId = null, [WorkflowExpression] Func<string> startDateTime = null, [WorkflowExpression] Func<string> endDateTime = null, [WorkflowExpression] Func<includeTBAInput> includeTBA = null, [WorkflowExpression] Func<includeTBDInput> includeTBD = null, [WorkflowExpression] Func<includeTestInput> includeTest = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> onsaleStartDateTime = null, [WorkflowExpression] Func<string> onsaleEndDateTime = null, [WorkflowExpression] Func<string[]> city = null, [WorkflowExpression] Func<countryCodeInput> countryCode = null, [WorkflowExpression] Func<string> stateCode = null, [WorkflowExpression] Func<string[]> classificationName = null, [WorkflowExpression] Func<string[]> classificationId = null, [WorkflowExpression] Func<string> dmaId = null, [WorkflowExpression] Func<string[]> localStartDateTime = null, [WorkflowExpression] Func<string[]> localStartEndDateTime = null, [WorkflowExpression] Func<string[]> startEndDateTime = null, [WorkflowExpression] Func<string[]> publicVisibilityStartDateTime = null, [WorkflowExpression] Func<string[]> preSaleDateTime = null, [WorkflowExpression] Func<string> onsaleOnStartDate = null, [WorkflowExpression] Func<string> onsaleOnAfterStartDate = null, [WorkflowExpression] Func<string[]> collectionId = null, [WorkflowExpression] Func<string[]> segmentId = null, [WorkflowExpression] Func<string[]> segmentName = null, [WorkflowExpression] Func<includeFamilyInput> includeFamily = null, [WorkflowExpression] Func<string> promoterId = null, [WorkflowExpression] Func<string[]> genreId = null, [WorkflowExpression] Func<string[]> subGenreId = null, [WorkflowExpression] Func<string[]> typeId = null, [WorkflowExpression] Func<string[]> subTypeId = null, [WorkflowExpression] Func<string> geoPoint = null, [WorkflowExpression] Func<preferredCountryInput> preferredCountry = null, [WorkflowExpression] Func<includeSpellcheckInput> includeSpellcheck = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/discovery/v2/events.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (attractionId != null)
                    callPayload.Queries["attractionId"] = SourceExpressionConverter.ConvertO(attractionId);
                if (venueId != null)
                    callPayload.Queries["venueId"] = SourceExpressionConverter.ConvertO(venueId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (latlong != null)
                    callPayload.Queries["latlong"] = SourceExpressionConverter.ConvertO(latlong);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                callPayload.Queries["unit"] = Convert.ToString("miles");
                if (unit != null)
                    callPayload.Queries["unit"] = SourceExpressionConverter.Convert(unit);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.Convert(source);
                callPayload.Queries["locale"] = Convert.ToString("en");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (marketId != null)
                    callPayload.Queries["marketId"] = SourceExpressionConverter.Convert(marketId);
                if (startDateTime != null)
                    callPayload.Queries["startDateTime"] = SourceExpressionConverter.ConvertO(startDateTime);
                if (endDateTime != null)
                    callPayload.Queries["endDateTime"] = SourceExpressionConverter.ConvertO(endDateTime);
                if (includeTBA != null)
                    callPayload.Queries["includeTBA"] = SourceExpressionConverter.Convert(includeTBA);
                if (includeTBD != null)
                    callPayload.Queries["includeTBD"] = SourceExpressionConverter.Convert(includeTBD);
                callPayload.Queries["includeTest"] = Convert.ToString("no");
                if (includeTest != null)
                    callPayload.Queries["includeTest"] = SourceExpressionConverter.Convert(includeTest);
                callPayload.Queries["page"] = Convert.ToString("0");
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("relevance,desc");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (onsaleStartDateTime != null)
                    callPayload.Queries["onsaleStartDateTime"] = SourceExpressionConverter.ConvertO(onsaleStartDateTime);
                if (onsaleEndDateTime != null)
                    callPayload.Queries["onsaleEndDateTime"] = SourceExpressionConverter.ConvertO(onsaleEndDateTime);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.Convert(countryCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (classificationName != null)
                    callPayload.Queries["classificationName"] = SourceExpressionConverter.ConvertO(classificationName);
                if (classificationId != null)
                    callPayload.Queries["classificationId"] = SourceExpressionConverter.ConvertO(classificationId);
                if (dmaId != null)
                    callPayload.Queries["dmaId"] = SourceExpressionConverter.ConvertO(dmaId);
                if (localStartDateTime != null)
                    callPayload.Queries["localStartDateTime"] = SourceExpressionConverter.ConvertO(localStartDateTime);
                if (localStartEndDateTime != null)
                    callPayload.Queries["localStartEndDateTime"] = SourceExpressionConverter.ConvertO(localStartEndDateTime);
                if (startEndDateTime != null)
                    callPayload.Queries["startEndDateTime"] = SourceExpressionConverter.ConvertO(startEndDateTime);
                if (publicVisibilityStartDateTime != null)
                    callPayload.Queries["publicVisibilityStartDateTime"] = SourceExpressionConverter.ConvertO(publicVisibilityStartDateTime);
                if (preSaleDateTime != null)
                    callPayload.Queries["preSaleDateTime"] = SourceExpressionConverter.ConvertO(preSaleDateTime);
                if (onsaleOnStartDate != null)
                    callPayload.Queries["onsaleOnStartDate"] = SourceExpressionConverter.ConvertO(onsaleOnStartDate);
                if (onsaleOnAfterStartDate != null)
                    callPayload.Queries["onsaleOnAfterStartDate"] = SourceExpressionConverter.ConvertO(onsaleOnAfterStartDate);
                if (collectionId != null)
                    callPayload.Queries["collectionId"] = SourceExpressionConverter.ConvertO(collectionId);
                if (segmentId != null)
                    callPayload.Queries["segmentId"] = SourceExpressionConverter.ConvertO(segmentId);
                if (segmentName != null)
                    callPayload.Queries["segmentName"] = SourceExpressionConverter.ConvertO(segmentName);
                callPayload.Queries["includeFamily"] = Convert.ToString("yes");
                if (includeFamily != null)
                    callPayload.Queries["includeFamily"] = SourceExpressionConverter.Convert(includeFamily);
                if (promoterId != null)
                    callPayload.Queries["promoterId"] = SourceExpressionConverter.ConvertO(promoterId);
                if (genreId != null)
                    callPayload.Queries["genreId"] = SourceExpressionConverter.ConvertO(genreId);
                if (subGenreId != null)
                    callPayload.Queries["subGenreId"] = SourceExpressionConverter.ConvertO(subGenreId);
                if (typeId != null)
                    callPayload.Queries["typeId"] = SourceExpressionConverter.ConvertO(typeId);
                if (subTypeId != null)
                    callPayload.Queries["subTypeId"] = SourceExpressionConverter.ConvertO(subTypeId);
                if (geoPoint != null)
                    callPayload.Queries["geoPoint"] = SourceExpressionConverter.ConvertO(geoPoint);
                callPayload.Queries["preferredCountry"] = Convert.ToString("us");
                if (preferredCountry != null)
                    callPayload.Queries["preferredCountry"] = SourceExpressionConverter.Convert(preferredCountry);
                callPayload.Queries["includeSpellcheck"] = Convert.ToString("no");
                if (includeSpellcheck != null)
                    callPayload.Queries["includeSpellcheck"] = SourceExpressionConverter.Convert(includeSpellcheck);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<EventsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<EventGetResponse> EventGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<EventGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<EventImagesGetResponse> EventImagesGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/events/{0}/images", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<EventImagesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<AttractionsGetResponse> AttractionsGet([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<includeTestInput> includeTest = null, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string[]> classificationName = null, [WorkflowExpression] Func<string[]> classificationId = null, [WorkflowExpression] Func<includeFamilyInput> includeFamily = null, [WorkflowExpression] Func<string[]> segmentId = null, [WorkflowExpression] Func<string[]> genreId = null, [WorkflowExpression] Func<string[]> subGenreId = null, [WorkflowExpression] Func<string[]> typeId = null, [WorkflowExpression] Func<string[]> subTypeId = null, [WorkflowExpression] Func<countryCodeInput> countryCode = null, [WorkflowExpression] Func<preferredCountryInput> preferredCountry = null, [WorkflowExpression] Func<includeSpellcheckInput> includeSpellcheck = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/discovery/v2/attractions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.Convert(source);
                callPayload.Queries["locale"] = Convert.ToString("en");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["includeTest"] = Convert.ToString("no");
                if (includeTest != null)
                    callPayload.Queries["includeTest"] = SourceExpressionConverter.Convert(includeTest);
                callPayload.Queries["size"] = Convert.ToString("20");
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["page"] = Convert.ToString("0");
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("relevance,desc");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (classificationName != null)
                    callPayload.Queries["classificationName"] = SourceExpressionConverter.ConvertO(classificationName);
                if (classificationId != null)
                    callPayload.Queries["classificationId"] = SourceExpressionConverter.ConvertO(classificationId);
                callPayload.Queries["includeFamily"] = Convert.ToString("yes");
                if (includeFamily != null)
                    callPayload.Queries["includeFamily"] = SourceExpressionConverter.Convert(includeFamily);
                if (segmentId != null)
                    callPayload.Queries["segmentId"] = SourceExpressionConverter.ConvertO(segmentId);
                if (genreId != null)
                    callPayload.Queries["genreId"] = SourceExpressionConverter.ConvertO(genreId);
                if (subGenreId != null)
                    callPayload.Queries["subGenreId"] = SourceExpressionConverter.ConvertO(subGenreId);
                if (typeId != null)
                    callPayload.Queries["typeId"] = SourceExpressionConverter.ConvertO(typeId);
                if (subTypeId != null)
                    callPayload.Queries["subTypeId"] = SourceExpressionConverter.ConvertO(subTypeId);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["preferredCountry"] = Convert.ToString("us");
                if (preferredCountry != null)
                    callPayload.Queries["preferredCountry"] = SourceExpressionConverter.Convert(preferredCountry);
                callPayload.Queries["includeSpellcheck"] = Convert.ToString("no");
                if (includeSpellcheck != null)
                    callPayload.Queries["includeSpellcheck"] = SourceExpressionConverter.Convert(includeSpellcheck);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<AttractionsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<AttractionGetResponse> AttractionGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/attractions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<AttractionGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<ClassificationsGetResponse> ClassificationsGet([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<includeTestInput> includeTest = null, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<countryCodeInput> countryCode = null, [WorkflowExpression] Func<preferredCountryInput> preferredCountry = null, [WorkflowExpression] Func<includeSpellcheckInput> includeSpellcheck = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/discovery/v2/classifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.Convert(source);
                callPayload.Queries["locale"] = Convert.ToString("en");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["includeTest"] = Convert.ToString("no");
                if (includeTest != null)
                    callPayload.Queries["includeTest"] = SourceExpressionConverter.Convert(includeTest);
                callPayload.Queries["size"] = Convert.ToString("20");
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["page"] = Convert.ToString("0");
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("name,asc");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.Convert(countryCode);
                callPayload.Queries["preferredCountry"] = Convert.ToString("us");
                if (preferredCountry != null)
                    callPayload.Queries["preferredCountry"] = SourceExpressionConverter.Convert(preferredCountry);
                callPayload.Queries["includeSpellcheck"] = Convert.ToString("no");
                if (includeSpellcheck != null)
                    callPayload.Queries["includeSpellcheck"] = SourceExpressionConverter.Convert(includeSpellcheck);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<ClassificationGetResponse> ClassificationGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/classifications/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<GenreGetResponse> GenreGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/classifications/genres/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<GenreGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<SegmentGetResponse> SegmentGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/classifications/segments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<SegmentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<SubGenreGetResponse> SubGenreGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/classifications/subgenres/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<SubGenreGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<VenuesGetResponse> VenuesGet([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> latlong = null, [WorkflowExpression] Func<string> radius = null, [WorkflowExpression] Func<unitInput> unit = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<includeTestInput> includeTest = null, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<countryCodeInput> countryCode = null, [WorkflowExpression] Func<string> stateCode = null, [WorkflowExpression] Func<string> geoPoint = null, [WorkflowExpression] Func<preferredCountryInput> preferredCountry = null, [WorkflowExpression] Func<includeSpellcheckInput> includeSpellcheck = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/discovery/v2/venues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (latlong != null)
                    callPayload.Queries["latlong"] = SourceExpressionConverter.ConvertO(latlong);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                callPayload.Queries["unit"] = Convert.ToString("miles");
                if (unit != null)
                    callPayload.Queries["unit"] = SourceExpressionConverter.Convert(unit);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.Convert(source);
                callPayload.Queries["locale"] = Convert.ToString("en");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["includeTest"] = Convert.ToString("no");
                if (includeTest != null)
                    callPayload.Queries["includeTest"] = SourceExpressionConverter.Convert(includeTest);
                callPayload.Queries["size"] = Convert.ToString("20");
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["page"] = Convert.ToString("0");
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("relevance,desc");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.Convert(countryCode);
                if (stateCode != null)
                    callPayload.Queries["stateCode"] = SourceExpressionConverter.ConvertO(stateCode);
                if (geoPoint != null)
                    callPayload.Queries["geoPoint"] = SourceExpressionConverter.ConvertO(geoPoint);
                callPayload.Queries["preferredCountry"] = Convert.ToString("us");
                if (preferredCountry != null)
                    callPayload.Queries["preferredCountry"] = SourceExpressionConverter.Convert(preferredCountry);
                callPayload.Queries["includeSpellcheck"] = Convert.ToString("no");
                if (includeSpellcheck != null)
                    callPayload.Queries["includeSpellcheck"] = SourceExpressionConverter.Convert(includeSpellcheck);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<VenuesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<VenueGetResponse> VenueGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discovery/v2/venues/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("*");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<VenueGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketmaster")]
        public IBodyWorkflowAction<SuggestionsGetResponse> SuggestionsGet([WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> latlong = null, [WorkflowExpression] Func<string> radius = null, [WorkflowExpression] Func<unitInput> unit = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<includeTBAInput> includeTBA = null, [WorkflowExpression] Func<includeTBDInput> includeTBD = null, [WorkflowExpression] Func<includeTestInput> includeTest = null, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<countryCodeInput> countryCode = null, [WorkflowExpression] Func<string[]> segmentId = null, [WorkflowExpression] Func<string> geoPoint = null, [WorkflowExpression] Func<string[]> resource = null, [WorkflowExpression] Func<preferredCountryInput> preferredCountry = null, [WorkflowExpression] Func<string[]> startEndDateTime = null, [WorkflowExpression] Func<string[]> localStartEndDateTime = null, [WorkflowExpression] Func<includeSpellcheckInput> includeSpellcheck = null, [WorkflowExpression] Func<string[]> domain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/discovery/v2/suggest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (latlong != null)
                    callPayload.Queries["latlong"] = SourceExpressionConverter.ConvertO(latlong);
                callPayload.Queries["radius"] = Convert.ToString("100");
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                callPayload.Queries["unit"] = Convert.ToString("miles");
                if (unit != null)
                    callPayload.Queries["unit"] = SourceExpressionConverter.Convert(unit);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.Convert(source);
                callPayload.Queries["locale"] = Convert.ToString("en");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (includeTBA != null)
                    callPayload.Queries["includeTBA"] = SourceExpressionConverter.Convert(includeTBA);
                if (includeTBD != null)
                    callPayload.Queries["includeTBD"] = SourceExpressionConverter.Convert(includeTBD);
                callPayload.Queries["includeTest"] = Convert.ToString("no");
                if (includeTest != null)
                    callPayload.Queries["includeTest"] = SourceExpressionConverter.Convert(includeTest);
                callPayload.Queries["size"] = Convert.ToString("5");
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.Convert(countryCode);
                if (segmentId != null)
                    callPayload.Queries["segmentId"] = SourceExpressionConverter.ConvertO(segmentId);
                if (geoPoint != null)
                    callPayload.Queries["geoPoint"] = SourceExpressionConverter.ConvertO(geoPoint);
                if (resource != null)
                    callPayload.Queries["resource"] = SourceExpressionConverter.ConvertO(resource);
                callPayload.Queries["preferredCountry"] = Convert.ToString("us");
                if (preferredCountry != null)
                    callPayload.Queries["preferredCountry"] = SourceExpressionConverter.Convert(preferredCountry);
                if (startEndDateTime != null)
                    callPayload.Queries["startEndDateTime"] = SourceExpressionConverter.ConvertO(startEndDateTime);
                if (localStartEndDateTime != null)
                    callPayload.Queries["localStartEndDateTime"] = SourceExpressionConverter.ConvertO(localStartEndDateTime);
                callPayload.Queries["includeSpellcheck"] = Convert.ToString("no");
                if (includeSpellcheck != null)
                    callPayload.Queries["includeSpellcheck"] = SourceExpressionConverter.Convert(includeSpellcheck);
                if (domain != null)
                    callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<SuggestionsGetResponse>(BuildSourceInput);
        }
    }

    public class TicketmasterTriggers([ConnectionName] string connectionId)
    {
    }

    public class EventsGetResponse
    {
        [JsonProperty("_links")]
        public EventsGetResponseLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public EventsGetResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("page")]
        public EventsGetResponsePageType Page { get; set; }
    }

    public class EventsGetResponseLinksType
    {
        [JsonProperty("self")]
        public EventsGetResponseLinksTypeSelfType Self { get; set; }

        [JsonProperty("next")]
        public EventsGetResponseLinksTypeNextType Next { get; set; }
    }

    public class EventsGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }

    public class EventsGetResponseLinksTypeNextType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }

    public class EventsGetResponseEmbeddedType
    {
        [JsonProperty("events")]
        public EventsGetResponseEmbeddedTypeEventsTypeItem[] Events { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("sales")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemSalesType Sales { get; set; }

        [JsonProperty("dates")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemDatesType Dates { get; set; }

        [JsonProperty("classifications")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("promoter")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemPromoterType Promoter { get; set; }

        [JsonProperty("_links")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedType Embedded { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemSalesType
    {
        [JsonProperty("public")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemSalesTypePublicType Public { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemSalesTypePublicType
    {
        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("startTBD")]
        public bool StartTBD { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemDatesType
    {
        [JsonProperty("start")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStartType Start { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("status")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStatusType Status { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStartType
    {
        [JsonProperty("localDate")]
        public string LocalDate { get; set; }

        [JsonProperty("dateTBD")]
        public bool DateTBD { get; set; }

        [JsonProperty("dateTBA")]
        public bool DateTBA { get; set; }

        [JsonProperty("timeTBA")]
        public bool TimeTBA { get; set; }

        [JsonProperty("noSpecificTime")]
        public bool NoSpecificTime { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemPromoterType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemLinksType
    {
        [JsonProperty("self")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemLinksTypeSelfType Self { get; set; }

        [JsonProperty("attractions")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemLinksTypeAttractionsTypeItem[] Attractions { get; set; }

        [JsonProperty("venues")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemLinksTypeVenuesTypeItem[] Venues { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemLinksTypeAttractionsTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemLinksTypeVenuesTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedType
    {
        [JsonProperty("venues")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItem[] Venues { get; set; }

        [JsonProperty("attractions")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItem[] Attractions { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCityType City { get; set; }

        [JsonProperty("state")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemStateType State { get; set; }

        [JsonProperty("country")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCountryType Country { get; set; }

        [JsonProperty("address")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemAddressType Address { get; set; }

        [JsonProperty("location")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLocationType Location { get; set; }

        [JsonProperty("markets")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemMarketsTypeItem[] Markets { get; set; }

        [JsonProperty("_links")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksType Links { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemAddressType
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemMarketsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksType
    {
        [JsonProperty("self")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("classifications")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("_links")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksType Links { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksType
    {
        [JsonProperty("self")]
        public EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class EventsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventsGetResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public enum unitInput
    {
        [EnumMember(Value = "miles")]
        Miles,
        [EnumMember(Value = "km")]
        Km
    }

    public enum sourceInput
    {
        [EnumMember(Value = "ticketmaster")]
        Ticketmaster,
        [EnumMember(Value = "universe")]
        Universe,
        [EnumMember(Value = "frontgate")]
        Frontgate,
        [EnumMember(Value = "tmr")]
        Tmr
    }

    public enum marketIdInput
    {
        [EnumMember(Value = "1")]
        BirminghamMore,
        [EnumMember(Value = "2")]
        Charlotte,
        [EnumMember(Value = "3")]
        ChicagolandNorthernIL,
        [EnumMember(Value = "4")]
        CincinnatiDayton,
        [EnumMember(Value = "5")]
        DallasFortWorthMore,
        [EnumMember(Value = "6")]
        DenverMore,
        [EnumMember(Value = "7")]
        DetroitToledoMore,
        [EnumMember(Value = "8")]
        ElPasoNewMexico,
        [EnumMember(Value = "9")]
        GrandRapidsMore,
        [EnumMember(Value = "10")]
        GreaterAtlantaArea,
        [EnumMember(Value = "11")]
        GreaterBostonArea,
        [EnumMember(Value = "12")]
        ClevelandYoungstownMore,
        [EnumMember(Value = "13")]
        GreaterColumbusArea,
        [EnumMember(Value = "14")]
        GreaterLasVegasArea,
        [EnumMember(Value = "15")]
        GreaterMiamiArea,
        [EnumMember(Value = "16")]
        MinneapolisStPaulMore,
        [EnumMember(Value = "17")]
        GreaterOrlandoArea,
        [EnumMember(Value = "18")]
        GreaterPhiladelphiaArea,
        [EnumMember(Value = "19")]
        GreaterPittsburghArea,
        [EnumMember(Value = "20")]
        GreaterSanDiegoArea,
        [EnumMember(Value = "21")]
        GreaterTampaArea,
        [EnumMember(Value = "22")]
        HoustonMore,
        [EnumMember(Value = "23")]
        IndianapolisMore,
        [EnumMember(Value = "24")]
        Iowa,
        [EnumMember(Value = "25")]
        JacksonvilleMore,
        [EnumMember(Value = "26")]
        KansasCityMore,
        [EnumMember(Value = "27")]
        GreaterLosAngelesArea,
        [EnumMember(Value = "28")]
        LouisvilleLexington,
        [EnumMember(Value = "29")]
        MemphisLittleRockMore,
        [EnumMember(Value = "30")]
        MilwaukeeWI,
        [EnumMember(Value = "31")]
        NashvilleKnoxvilleMore,
        [EnumMember(Value = "33")]
        NewEngland,
        [EnumMember(Value = "34")]
        NewOrleansMore,
        [EnumMember(Value = "35")]
        NewYorkTriStateArea,
        [EnumMember(Value = "36")]
        PhoenixTucson,
        [EnumMember(Value = "37")]
        PortlandMore,
        [EnumMember(Value = "38")]
        RaleighDurham,
        [EnumMember(Value = "39")]
        SaintLouisMore,
        [EnumMember(Value = "40")]
        SanAntonioAustin,
        [EnumMember(Value = "41")]
        NCaliforniaNNevada,
        [EnumMember(Value = "42")]
        GreaterSeattleArea,
        [EnumMember(Value = "43")]
        NorthSouthDakota,
        [EnumMember(Value = "44")]
        UpstateNewYork,
        [EnumMember(Value = "45")]
        UtahMontana,
        [EnumMember(Value = "46")]
        Virginia,
        [EnumMember(Value = "47")]
        WashingtonDCAndMaryland,
        [EnumMember(Value = "48")]
        WestVirginia,
        [EnumMember(Value = "49")]
        Hawaii,
        [EnumMember(Value = "50")]
        Alaska,
        [EnumMember(Value = "52")]
        Nebraska,
        [EnumMember(Value = "53")]
        Springfield,
        [EnumMember(Value = "54")]
        CentralIllinois,
        [EnumMember(Value = "55")]
        NorthernNewJersey,
        [EnumMember(Value = "121")]
        SouthCarolina,
        [EnumMember(Value = "122")]
        SouthTexas,
        [EnumMember(Value = "123")]
        Beaumont,
        [EnumMember(Value = "124")]
        Connecticut,
        [EnumMember(Value = "125")]
        Oklahoma,
        [EnumMember(Value = "102")]
        TorontoHamiltonArea,
        [EnumMember(Value = "103")]
        OttawaEasternOntario,
        [EnumMember(Value = "106")]
        Manitoba,
        [EnumMember(Value = "107")]
        EdmontonNorthernAlberta,
        [EnumMember(Value = "108")]
        CalgarySouthernAlberta,
        [EnumMember(Value = "110")]
        BCInterior,
        [EnumMember(Value = "111")]
        VancouverArea,
        [EnumMember(Value = "112")]
        Saskatchewan,
        [EnumMember(Value = "120")]
        MontrealArea,
        [EnumMember(Value = "202")]
        LondonUK,
        [EnumMember(Value = "203")]
        SouthUK,
        [EnumMember(Value = "204")]
        MidlandsAndCentralUK,
        [EnumMember(Value = "205")]
        WalesAndNorthWestUK,
        [EnumMember(Value = "206")]
        NorthAndNorthEastUK,
        [EnumMember(Value = "207")]
        Scotland,
        [EnumMember(Value = "208")]
        Ireland,
        [EnumMember(Value = "209")]
        NorthernIreland,
        [EnumMember(Value = "210")]
        Germany,
        [EnumMember(Value = "211")]
        Netherlands,
        [EnumMember(Value = "500")]
        Sweden,
        [EnumMember(Value = "501")]
        Spain,
        [EnumMember(Value = "502")]
        BarcelonaSpain,
        [EnumMember(Value = "503")]
        MadridSpain,
        [EnumMember(Value = "600")]
        Turkey,
        [EnumMember(Value = "302")]
        NewSouthWalesAustralianCapitalTerritory,
        [EnumMember(Value = "303")]
        Queensland,
        [EnumMember(Value = "304")]
        WesternAustralia,
        [EnumMember(Value = "305")]
        VictoriaTasmania,
        [EnumMember(Value = "306")]
        WesternAustralia2,
        [EnumMember(Value = "351")]
        NorthIsland,
        [EnumMember(Value = "352")]
        SouthIsland,
        [EnumMember(Value = "402")]
        MexicoCityAndMetropolitanArea,
        [EnumMember(Value = "403")]
        Monterrey,
        [EnumMember(Value = "404")]
        Guadalajara
    }

    public enum includeTBAInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "only")]
        Only
    }

    public enum includeTBDInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "only")]
        Only
    }

    public enum includeTestInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "only")]
        Only
    }

    public enum countryCodeInput
    {
        [EnumMember(Value = "US")]
        UnitedStatesOfAmerica,
        [EnumMember(Value = "AD")]
        Andorra,
        [EnumMember(Value = "AI")]
        Anguilla,
        [EnumMember(Value = "AR")]
        Argentina,
        [EnumMember(Value = "AU")]
        Australia,
        [EnumMember(Value = "AT")]
        Austria,
        [EnumMember(Value = "AZ")]
        Azerbaijan,
        [EnumMember(Value = "BS")]
        Bahamas,
        [EnumMember(Value = "BH")]
        Bahrain,
        [EnumMember(Value = "BB")]
        Barbados,
        [EnumMember(Value = "BE")]
        Belgium,
        [EnumMember(Value = "BM")]
        Bermuda,
        [EnumMember(Value = "BR")]
        Brazil,
        [EnumMember(Value = "BG")]
        Bulgaria,
        [EnumMember(Value = "CA")]
        Canada,
        [EnumMember(Value = "CL")]
        Chile,
        [EnumMember(Value = "CN")]
        China,
        [EnumMember(Value = "CO")]
        Colombia,
        [EnumMember(Value = "CR")]
        CostaRica,
        [EnumMember(Value = "HR")]
        Croatia,
        [EnumMember(Value = "CY")]
        Cyprus,
        [EnumMember(Value = "CZ")]
        CzechRepublic,
        [EnumMember(Value = "DK")]
        Denmark,
        [EnumMember(Value = "DO")]
        DominicanRepublic,
        [EnumMember(Value = "EC")]
        Ecuador,
        [EnumMember(Value = "EE")]
        Estonia,
        [EnumMember(Value = "FO")]
        FaroeIslands,
        [EnumMember(Value = "FI")]
        Finland,
        [EnumMember(Value = "FR")]
        France,
        [EnumMember(Value = "GE")]
        Georgia,
        [EnumMember(Value = "DE")]
        Germany,
        [EnumMember(Value = "GH")]
        Ghana,
        [EnumMember(Value = "GI")]
        Gibraltar,
        [EnumMember(Value = "GB")]
        GreatBritain,
        [EnumMember(Value = "GR")]
        Greece,
        [EnumMember(Value = "HK")]
        HongKong,
        [EnumMember(Value = "HU")]
        Hungary,
        [EnumMember(Value = "IS")]
        Iceland,
        [EnumMember(Value = "IN")]
        India,
        [EnumMember(Value = "IE")]
        Ireland,
        [EnumMember(Value = "IL")]
        Israel,
        [EnumMember(Value = "IT")]
        Italy,
        [EnumMember(Value = "JM")]
        Jamaica,
        [EnumMember(Value = "JP")]
        Japan,
        [EnumMember(Value = "KR")]
        KoreaRepublicOf,
        [EnumMember(Value = "LV")]
        Latvia,
        [EnumMember(Value = "LB")]
        Lebanon,
        [EnumMember(Value = "LT")]
        Lithuania,
        [EnumMember(Value = "LU")]
        Luxembourg,
        [EnumMember(Value = "MY")]
        Malaysia,
        [EnumMember(Value = "MT")]
        Malta,
        [EnumMember(Value = "MX")]
        Mexico,
        [EnumMember(Value = "MC")]
        Monaco,
        [EnumMember(Value = "ME")]
        Montenegro,
        [EnumMember(Value = "MA")]
        Morocco,
        [EnumMember(Value = "NL")]
        Netherlands,
        [EnumMember(Value = "AN")]
        NetherlandsAntilles,
        [EnumMember(Value = "NZ")]
        NewZealand,
        [EnumMember(Value = "ND")]
        NorthernIreland,
        [EnumMember(Value = "NO")]
        Norway,
        [EnumMember(Value = "PE")]
        Peru,
        [EnumMember(Value = "PL")]
        Poland,
        [EnumMember(Value = "PT")]
        Portugal,
        [EnumMember(Value = "RO")]
        Romania,
        [EnumMember(Value = "RU")]
        RussianFederation,
        [EnumMember(Value = "LC")]
        SaintLucia,
        [EnumMember(Value = "SA")]
        SaudiArabia,
        [EnumMember(Value = "RS")]
        Serbia,
        [EnumMember(Value = "SG")]
        Singapore,
        [EnumMember(Value = "SK")]
        Slovakia,
        [EnumMember(Value = "SI")]
        Slovenia,
        [EnumMember(Value = "ZA")]
        SouthAfrica,
        [EnumMember(Value = "ES")]
        Spain,
        [EnumMember(Value = "SE")]
        Sweden,
        [EnumMember(Value = "CH")]
        Switzerland,
        [EnumMember(Value = "TW")]
        Taiwan,
        [EnumMember(Value = "TH")]
        Thailand,
        [EnumMember(Value = "TT")]
        TrinidadAndTobago,
        [EnumMember(Value = "TR")]
        Turkey,
        [EnumMember(Value = "UA")]
        Ukraine,
        [EnumMember(Value = "AE")]
        UnitedArabEmirates,
        [EnumMember(Value = "UY")]
        Uruguay,
        [EnumMember(Value = "VE")]
        Venezuela
    }

    public enum includeFamilyInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "only")]
        Only
    }

    public enum preferredCountryInput
    {
        [EnumMember(Value = "us")]
        Us,
        [EnumMember(Value = "ca")]
        Ca
    }

    public enum includeSpellcheckInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public class EventGetResponse
    {
        [JsonProperty("_embedded")]
        public EventGetResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public EventGetResponseLinksType Links { get; set; }

        [JsonProperty("classifications")]
        public EventGetResponseClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("dates")]
        public EventGetResponseDatesType Dates { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public EventGetResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pleaseNote")]
        public string PleaseNote { get; set; }

        [JsonProperty("priceRanges")]
        public EventGetResponsePriceRangesTypeItem[] PriceRanges { get; set; }

        [JsonProperty("promoter")]
        public EventGetResponsePromoterType Promoter { get; set; }

        [JsonProperty("sales")]
        public EventGetResponseSalesType Sales { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EventGetResponseEmbeddedType
    {
        [JsonProperty("venues")]
        public EventGetResponseEmbeddedTypeVenuesTypeItem[] Venues { get; set; }

        [JsonProperty("attractions")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItem[] Attractions { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemCityType City { get; set; }

        [JsonProperty("state")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemStateType State { get; set; }

        [JsonProperty("country")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemCountryType Country { get; set; }

        [JsonProperty("address")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemAddressType Address { get; set; }

        [JsonProperty("location")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemLocationType Location { get; set; }

        [JsonProperty("markets")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemMarketsTypeItem[] Markets { get; set; }

        [JsonProperty("dmas")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemDmasTypeItem[] Dmas { get; set; }

        [JsonProperty("_links")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemLinksType Links { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemAddressType
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemMarketsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemDmasTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemLinksType
    {
        [JsonProperty("self")]
        public EventGetResponseEmbeddedTypeVenuesTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class EventGetResponseEmbeddedTypeVenuesTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("classifications")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("_links")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemLinksType Links { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemLinksType
    {
        [JsonProperty("self")]
        public EventGetResponseEmbeddedTypeAttractionsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class EventGetResponseEmbeddedTypeAttractionsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventGetResponseLinksType
    {
        [JsonProperty("self")]
        public EventGetResponseLinksTypeSelfType Self { get; set; }

        [JsonProperty("attractions")]
        public EventGetResponseLinksTypeAttractionsTypeItem[] Attractions { get; set; }

        [JsonProperty("venues")]
        public EventGetResponseLinksTypeVenuesTypeItem[] Venues { get; set; }
    }

    public class EventGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventGetResponseLinksTypeAttractionsTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventGetResponseLinksTypeVenuesTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class EventGetResponseClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public EventGetResponseClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public EventGetResponseClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public EventGetResponseClassificationsTypeItemSubGenreType SubGenre { get; set; }
    }

    public class EventGetResponseClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventGetResponseDatesType
    {
        [JsonProperty("start")]
        public EventGetResponseDatesTypeStartType Start { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("status")]
        public EventGetResponseDatesTypeStatusType Status { get; set; }
    }

    public class EventGetResponseDatesTypeStartType
    {
        [JsonProperty("localDate")]
        public string LocalDate { get; set; }

        [JsonProperty("localTime")]
        public string LocalTime { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("dateTBD")]
        public bool DateTBD { get; set; }

        [JsonProperty("dateTBA")]
        public bool DateTBA { get; set; }

        [JsonProperty("timeTBA")]
        public bool TimeTBA { get; set; }

        [JsonProperty("noSpecificTime")]
        public bool NoSpecificTime { get; set; }
    }

    public class EventGetResponseDatesTypeStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class EventGetResponseImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class EventGetResponsePriceRangesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class EventGetResponsePromoterType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventGetResponseSalesType
    {
        [JsonProperty("public")]
        public EventGetResponseSalesTypePublicType Public { get; set; }
    }

    public class EventGetResponseSalesTypePublicType
    {
        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("startTBD")]
        public bool StartTBD { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }
    }

    public class EventImagesGetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public EventImagesGetResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("_links")]
        public EventImagesGetResponseLinksType Links { get; set; }
    }

    public class EventImagesGetResponseImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class EventImagesGetResponseLinksType
    {
        [JsonProperty("self")]
        public EventImagesGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class EventImagesGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class AttractionsGetResponse
    {
        [JsonProperty("_links")]
        public AttractionsGetResponseLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public AttractionsGetResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("page")]
        public AttractionsGetResponsePageType Page { get; set; }
    }

    public class AttractionsGetResponseLinksType
    {
        [JsonProperty("self")]
        public AttractionsGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class AttractionsGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class AttractionsGetResponseEmbeddedType
    {
        [JsonProperty("attractions")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItem[] Attractions { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public JToken[] Images { get; set; }

        [JsonProperty("classifications")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("_links")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItemLinksType Links { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItemLinksType
    {
        [JsonProperty("self")]
        public AttractionsGetResponseEmbeddedTypeAttractionsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class AttractionsGetResponseEmbeddedTypeAttractionsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class AttractionsGetResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class AttractionGetResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public AttractionGetResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("classifications")]
        public AttractionGetResponseClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("_links")]
        public AttractionGetResponseLinksType Links { get; set; }
    }

    public class AttractionGetResponseImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class AttractionGetResponseClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public AttractionGetResponseClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public AttractionGetResponseClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public AttractionGetResponseClassificationsTypeItemSubGenreType SubGenre { get; set; }
    }

    public class AttractionGetResponseClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AttractionGetResponseClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AttractionGetResponseClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AttractionGetResponseLinksType
    {
        [JsonProperty("self")]
        public AttractionGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class AttractionGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationsGetResponse
    {
        [JsonProperty("_links")]
        public ClassificationsGetResponseLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public ClassificationsGetResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("page")]
        public ClassificationsGetResponsePageType Page { get; set; }
    }

    public class ClassificationsGetResponseLinksType
    {
        [JsonProperty("self")]
        public ClassificationsGetResponseLinksTypeSelfType Self { get; set; }

        [JsonProperty("next")]
        public ClassificationsGetResponseLinksTypeNextType Next { get; set; }
    }

    public class ClassificationsGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }

    public class ClassificationsGetResponseLinksTypeNextType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedType
    {
        [JsonProperty("classifications")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItem[] Classifications { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItem
    {
        [JsonProperty("_links")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemLinksType Links { get; set; }

        [JsonProperty("segment")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentType Segment { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemLinksType
    {
        [JsonProperty("self")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedType Embedded { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeLinksType
    {
        [JsonProperty("self")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedType
    {
        [JsonProperty("genres")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItem[] Genres { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedType Embedded { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedType
    {
        [JsonProperty("subgenres")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItem[] Subgenres { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksType Links { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationsGetResponseEmbeddedTypeClassificationsTypeItemSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationsGetResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class ClassificationGetResponse
    {
        [JsonProperty("_links")]
        public ClassificationGetResponseLinksType Links { get; set; }

        [JsonProperty("segment")]
        public ClassificationGetResponseSegmentType Segment { get; set; }
    }

    public class ClassificationGetResponseLinksType
    {
        [JsonProperty("self")]
        public ClassificationGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationGetResponseSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public ClassificationGetResponseSegmentTypeLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public ClassificationGetResponseSegmentTypeEmbeddedType Embedded { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeLinksType
    {
        [JsonProperty("self")]
        public ClassificationGetResponseSegmentTypeLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedType
    {
        [JsonProperty("genres")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItem[] Genres { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedType Embedded { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedType
    {
        [JsonProperty("subgenres")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItem[] Subgenres { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksType Links { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class ClassificationGetResponseSegmentTypeEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GenreGetResponse
    {
        [JsonProperty("_embedded")]
        public GenreGetResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public GenreGetResponseLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GenreGetResponseEmbeddedType
    {
        [JsonProperty("subgenres")]
        public GenreGetResponseEmbeddedTypeSubgenresTypeItem[] Subgenres { get; set; }
    }

    public class GenreGetResponseEmbeddedTypeSubgenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public GenreGetResponseEmbeddedTypeSubgenresTypeItemLinksType Links { get; set; }
    }

    public class GenreGetResponseEmbeddedTypeSubgenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public GenreGetResponseEmbeddedTypeSubgenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class GenreGetResponseEmbeddedTypeSubgenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GenreGetResponseLinksType
    {
        [JsonProperty("self")]
        public GenreGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class GenreGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SegmentGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public SegmentGetResponseLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public SegmentGetResponseEmbeddedType Embedded { get; set; }
    }

    public class SegmentGetResponseLinksType
    {
        [JsonProperty("self")]
        public SegmentGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class SegmentGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SegmentGetResponseEmbeddedType
    {
        [JsonProperty("genres")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItem[] Genres { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItemLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedType Embedded { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedType
    {
        [JsonProperty("subgenres")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItem[] Subgenres { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_links")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksType Links { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksType
    {
        [JsonProperty("self")]
        public SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SegmentGetResponseEmbeddedTypeGenresTypeItemEmbeddedTypeSubgenresTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SubGenreGetResponse
    {
        [JsonProperty("_links")]
        public SubGenreGetResponseLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class SubGenreGetResponseLinksType
    {
        [JsonProperty("self")]
        public SubGenreGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class SubGenreGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class VenuesGetResponse
    {
        [JsonProperty("_embedded")]
        public VenuesGetResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public VenuesGetResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public VenuesGetResponsePageType Page { get; set; }
    }

    public class VenuesGetResponseEmbeddedType
    {
        [JsonProperty("venues")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItem[] Venues { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItem
    {
        [JsonProperty("_links")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemLinksType Links { get; set; }

        [JsonProperty("address")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemAddressType Address { get; set; }

        [JsonProperty("city")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemCityType City { get; set; }

        [JsonProperty("country")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemCountryType Country { get; set; }

        [JsonProperty("dmas")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemDmasTypeItem[] Dmas { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("location")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemLocationType Location { get; set; }

        [JsonProperty("markets")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemMarketsTypeItem[] Markets { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemStateType State { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemLinksType
    {
        [JsonProperty("self")]
        public VenuesGetResponseEmbeddedTypeVenuesTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemAddressType
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemDmasTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemMarketsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class VenuesGetResponseEmbeddedTypeVenuesTypeItemStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class VenuesGetResponseLinksType
    {
        [JsonProperty("self")]
        public VenuesGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class VenuesGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }

    public class VenuesGetResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public enum sortInput
    {
        [EnumMember(Value = "name,asc")]
        NameAsc,
        [EnumMember(Value = "name,desc")]
        NameDesc,
        [EnumMember(Value = "relevance,asc")]
        RelevanceAsc,
        [EnumMember(Value = "relevance,desc")]
        RelevanceDesc,
        [EnumMember(Value = "distance,asc")]
        DistanceAsc,
        [EnumMember(Value = "distance,desc")]
        DistanceDesc,
        [EnumMember(Value = "random")]
        Random
    }

    public class VenueGetResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public VenueGetResponseCityType City { get; set; }

        [JsonProperty("state")]
        public VenueGetResponseStateType State { get; set; }

        [JsonProperty("country")]
        public VenueGetResponseCountryType Country { get; set; }

        [JsonProperty("address")]
        public VenueGetResponseAddressType Address { get; set; }

        [JsonProperty("location")]
        public VenueGetResponseLocationType Location { get; set; }

        [JsonProperty("markets")]
        public VenueGetResponseMarketsTypeItem[] Markets { get; set; }

        [JsonProperty("_links")]
        public VenueGetResponseLinksType Links { get; set; }
    }

    public class VenueGetResponseCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class VenueGetResponseStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class VenueGetResponseCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class VenueGetResponseAddressType
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }
    }

    public class VenueGetResponseLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class VenueGetResponseMarketsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class VenueGetResponseLinksType
    {
        [JsonProperty("self")]
        public VenueGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class VenueGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponse
    {
        [JsonProperty("_links")]
        public SuggestionsGetResponseLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public SuggestionsGetResponseEmbeddedType Embedded { get; set; }
    }

    public class SuggestionsGetResponseLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedType
    {
        [JsonProperty("venues")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItem[] Venues { get; set; }

        [JsonProperty("attractions")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItem[] Attractions { get; set; }

        [JsonProperty("events")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItem[] Events { get; set; }

        [JsonProperty("products")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItem[] Products { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemCityType City { get; set; }

        [JsonProperty("state")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemStateType State { get; set; }

        [JsonProperty("country")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemCountryType Country { get; set; }

        [JsonProperty("address")]
        public JToken Address { get; set; }

        [JsonProperty("location")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemLocationType Location { get; set; }

        [JsonProperty("upcomingEvents")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemUpcomingEventsType UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemLinksType Links { get; set; }

        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemUpcomingEventsType
    {
        [JsonProperty("ticketmaster")]
        public int Ticketmaster { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_filtered")]
        public int Filtered { get; set; }

        [JsonProperty("archtics")]
        public int Archtics { get; set; }

        [JsonProperty("tmr")]
        public int Tmr { get; set; }

        [JsonProperty("universe")]
        public int Universe { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeVenuesTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeVenuesTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("externalLinks")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksType ExternalLinks { get; set; }

        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("classifications")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("upcomingEvents")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemUpcomingEventsType UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemLinksType Links { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksType
    {
        [JsonProperty("youtube")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeYoutubeTypeItem[] Youtube { get; set; }

        [JsonProperty("twitter")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeTwitterTypeItem[] Twitter { get; set; }

        [JsonProperty("itunes")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeItunesTypeItem[] Itunes { get; set; }

        [JsonProperty("lastfm")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeLastfmTypeItem[] Lastfm { get; set; }

        [JsonProperty("spotify")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeSpotifyTypeItem[] Spotify { get; set; }

        [JsonProperty("wiki")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeWikiTypeItem[] Wiki { get; set; }

        [JsonProperty("facebook")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeFacebookTypeItem[] Facebook { get; set; }

        [JsonProperty("musicbrainz")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeMusicbrainzTypeItem[] Musicbrainz { get; set; }

        [JsonProperty("instagram")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeInstagramTypeItem[] Instagram { get; set; }

        [JsonProperty("homepage")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeHomepageTypeItem[] Homepage { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeYoutubeTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeTwitterTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeItunesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeLastfmTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeSpotifyTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeWikiTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeFacebookTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeMusicbrainzTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeInstagramTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemExternalLinksTypeHomepageTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }

        [JsonProperty("type")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemTypeType Type { get; set; }

        [JsonProperty("subType")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubTypeType SubType { get; set; }

        [JsonProperty("family")]
        public bool Family { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemUpcomingEventsType
    {
        [JsonProperty("tmr")]
        public int Tmr { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_filtered")]
        public int Filtered { get; set; }

        [JsonProperty("mfx-fi")]
        public int MfxFi { get; set; }

        [JsonProperty("mfx-nl")]
        public int MfxNl { get; set; }

        [JsonProperty("ticketmaster")]
        public int Ticketmaster { get; set; }

        [JsonProperty("ticketweb")]
        public int Ticketweb { get; set; }

        [JsonProperty("mfx-no")]
        public int MfxNo { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeAttractionsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("dates")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemDatesType Dates { get; set; }

        [JsonProperty("classifications")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("location")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemLocationType Location { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedType Embedded { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemDatesType
    {
        [JsonProperty("start")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStartType Start { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("status")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStatusType Status { get; set; }

        [JsonProperty("spanMultipleDays")]
        public bool SpanMultipleDays { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStartType
    {
        [JsonProperty("localDate")]
        public string LocalDate { get; set; }

        [JsonProperty("localTime")]
        public string LocalTime { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("dateTBD")]
        public bool DateTBD { get; set; }

        [JsonProperty("dateTBA")]
        public bool DateTBA { get; set; }

        [JsonProperty("timeTBA")]
        public bool TimeTBA { get; set; }

        [JsonProperty("noSpecificTime")]
        public bool NoSpecificTime { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemDatesTypeStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }

        [JsonProperty("type")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemTypeType Type { get; set; }

        [JsonProperty("subType")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSubTypeType SubType { get; set; }

        [JsonProperty("family")]
        public bool Family { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemClassificationsTypeItemSubTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksTypeSelfType Self { get; set; }

        [JsonProperty("attractions")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksTypeAttractionsTypeItem[] Attractions { get; set; }

        [JsonProperty("venues")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksTypeVenuesTypeItem[] Venues { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksTypeAttractionsTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemLinksTypeVenuesTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedType
    {
        [JsonProperty("venues")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItem[] Venues { get; set; }

        [JsonProperty("attractions")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItem[] Attractions { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCityType City { get; set; }

        [JsonProperty("state")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemStateType State { get; set; }

        [JsonProperty("country")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCountryType Country { get; set; }

        [JsonProperty("address")]
        public JToken Address { get; set; }

        [JsonProperty("location")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLocationType Location { get; set; }

        [JsonProperty("parkingDetail")]
        public string ParkingDetail { get; set; }

        [JsonProperty("accessibleSeatingDetail")]
        public string AccessibleSeatingDetail { get; set; }

        [JsonProperty("upcomingEvents")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemUpcomingEventsType UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksType Links { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemUpcomingEventsType
    {
        [JsonProperty("archtics")]
        public int Archtics { get; set; }

        [JsonProperty("ticketmaster")]
        public int Ticketmaster { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_filtered")]
        public int Filtered { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeVenuesTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("externalLinks")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksType ExternalLinks { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("classifications")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("upcomingEvents")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemUpcomingEventsType UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksType Links { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksType
    {
        [JsonProperty("twitter")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeTwitterTypeItem[] Twitter { get; set; }

        [JsonProperty("facebook")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeFacebookTypeItem[] Facebook { get; set; }

        [JsonProperty("wiki")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeWikiTypeItem[] Wiki { get; set; }

        [JsonProperty("instagram")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeInstagramTypeItem[] Instagram { get; set; }

        [JsonProperty("homepage")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeHomepageTypeItem[] Homepage { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeTwitterTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeFacebookTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeWikiTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeInstagramTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeHomepageTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }

        [JsonProperty("type")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemTypeType Type { get; set; }

        [JsonProperty("subType")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubTypeType SubType { get; set; }

        [JsonProperty("family")]
        public bool Family { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemUpcomingEventsType
    {
        [JsonProperty("ticketmaster")]
        public int Ticketmaster { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_filtered")]
        public int Filtered { get; set; }

        [JsonProperty("tmr")]
        public int Tmr { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeEventsTypeItemEmbeddedTypeAttractionsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("dates")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemDatesType Dates { get; set; }

        [JsonProperty("classifications")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("location")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemLocationType Location { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksType Links { get; set; }

        [JsonProperty("_embedded")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedType Embedded { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemDatesType
    {
        [JsonProperty("start")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemDatesTypeStartType Start { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("status")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemDatesTypeStatusType Status { get; set; }

        [JsonProperty("spanMultipleDays")]
        public bool SpanMultipleDays { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemDatesTypeStartType
    {
        [JsonProperty("localDate")]
        public string LocalDate { get; set; }

        [JsonProperty("localTime")]
        public string LocalTime { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("dateTBD")]
        public bool DateTBD { get; set; }

        [JsonProperty("dateTBA")]
        public bool DateTBA { get; set; }

        [JsonProperty("timeTBA")]
        public bool TimeTBA { get; set; }

        [JsonProperty("noSpecificTime")]
        public bool NoSpecificTime { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemDatesTypeStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }

        [JsonProperty("type")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemTypeType Type { get; set; }

        [JsonProperty("subType")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemSubTypeType SubType { get; set; }

        [JsonProperty("family")]
        public bool Family { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemClassificationsTypeItemSubTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksTypeSelfType Self { get; set; }

        [JsonProperty("attractions")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksTypeAttractionsTypeItem[] Attractions { get; set; }

        [JsonProperty("venues")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksTypeVenuesTypeItem[] Venues { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksTypeAttractionsTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemLinksTypeVenuesTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedType
    {
        [JsonProperty("venues")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItem[] Venues { get; set; }

        [JsonProperty("attractions")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItem[] Attractions { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemCityType City { get; set; }

        [JsonProperty("state")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemStateType State { get; set; }

        [JsonProperty("country")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemCountryType Country { get; set; }

        [JsonProperty("address")]
        public JToken Address { get; set; }

        [JsonProperty("location")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemLocationType Location { get; set; }

        [JsonProperty("parkingDetail")]
        public string ParkingDetail { get; set; }

        [JsonProperty("accessibleSeatingDetail")]
        public string AccessibleSeatingDetail { get; set; }

        [JsonProperty("upcomingEvents")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemUpcomingEventsType UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemLinksType Links { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemCityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemStateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemUpcomingEventsType
    {
        [JsonProperty("archtics")]
        public int Archtics { get; set; }

        [JsonProperty("ticketmaster")]
        public int Ticketmaster { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_filtered")]
        public int Filtered { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeVenuesTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("externalLinks")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksType ExternalLinks { get; set; }

        [JsonProperty("images")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("classifications")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItem[] Classifications { get; set; }

        [JsonProperty("upcomingEvents")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemUpcomingEventsType UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemLinksType Links { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksType
    {
        [JsonProperty("twitter")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeTwitterTypeItem[] Twitter { get; set; }

        [JsonProperty("facebook")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeFacebookTypeItem[] Facebook { get; set; }

        [JsonProperty("wiki")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeWikiTypeItem[] Wiki { get; set; }

        [JsonProperty("instagram")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeInstagramTypeItem[] Instagram { get; set; }

        [JsonProperty("homepage")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeHomepageTypeItem[] Homepage { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeTwitterTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeFacebookTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeWikiTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeInstagramTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemExternalLinksTypeHomepageTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemImagesTypeItem
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType Segment { get; set; }

        [JsonProperty("genre")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType Genre { get; set; }

        [JsonProperty("subGenre")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType SubGenre { get; set; }

        [JsonProperty("type")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemTypeType Type { get; set; }

        [JsonProperty("subType")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubTypeType SubType { get; set; }

        [JsonProperty("family")]
        public bool Family { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubGenreType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemClassificationsTypeItemSubTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemUpcomingEventsType
    {
        [JsonProperty("ticketmaster")]
        public int Ticketmaster { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_filtered")]
        public int Filtered { get; set; }

        [JsonProperty("tmr")]
        public int Tmr { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemLinksType
    {
        [JsonProperty("self")]
        public SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SuggestionsGetResponseEmbeddedTypeProductsTypeItemEmbeddedTypeAttractionsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ticketmaster;

    public partial class WorkflowManagedActions
    {
        public TicketmasterActions Ticketmaster(string connectionId) => new TicketmasterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TicketmasterTriggers Ticketmaster(string connectionId) => new TicketmasterTriggers(connectionId);
    }
}