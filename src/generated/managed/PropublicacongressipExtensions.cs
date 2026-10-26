//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Propublicacongressip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PropublicacongressipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetResponse, ApiConnectionActionConfiguration> MemberGet(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<bool>> inOffice = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_inOffice = WorkflowExpression.Compile(inOffice, nameof(inOffice), required: false);
            return new DeferredBodyAction<MemberGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/members.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_inOffice != null)
                    callPayload.Queries["in_office"] = ExpressionConverter.Convert(__workflow_inOffice);
                return new ApiConnectionAction<MemberGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetAResponse, ApiConnectionActionConfiguration> MemberGetA(Expression<Func<string>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<MemberGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}.json", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetNewResponse, ApiConnectionActionConfiguration> MemberGetNew()
        {
            return new DeferredBodyAction<MemberGetNewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/members/new.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetNewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetStateResponse, ApiConnectionActionConfiguration> MemberGetState(Expression<Func<chamberInput>> chamber, Expression<Func<string>> state)
        {
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: true);
            return new DeferredBodyAction<MemberGetStateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/{1}/current.json", __workflow_chamber.WithUrlEncoding(1), __workflow_state.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetLeavingResponse, ApiConnectionActionConfiguration> MemberGetLeaving(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            return new DeferredBodyAction<MemberGetLeavingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/members/leaving.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetLeavingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetVoteResponse, ApiConnectionActionConfiguration> MemberGetVote(Expression<Func<string>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<MemberGetVoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/votes.json", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetVoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetVotePositionsResponse, ApiConnectionActionConfiguration> MemberGetVotePositions(Expression<Func<string>> firstMemberId, Expression<Func<string>> secondMemberId, Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber)
        {
            var __workflow_firstMemberId = WorkflowExpression.Compile(firstMemberId, nameof(firstMemberId), required: true);
            var __workflow_secondMemberId = WorkflowExpression.Compile(secondMemberId, nameof(secondMemberId), required: true);
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            return new DeferredBodyAction<MemberGetVotePositionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/votes/{1}/{2}/{3}.json", __workflow_firstMemberId.WithUrlEncoding(1), __workflow_secondMemberId.WithUrlEncoding(1), __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetVotePositionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<MemberGetBillResponse, ApiConnectionActionConfiguration> MemberGetBill(Expression<Func<string>> firstMemberId, Expression<Func<string>> secondMemberId, Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber)
        {
            var __workflow_firstMemberId = WorkflowExpression.Compile(firstMemberId, nameof(firstMemberId), required: true);
            var __workflow_secondMemberId = WorkflowExpression.Compile(secondMemberId, nameof(secondMemberId), required: true);
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            return new DeferredBodyAction<MemberGetBillResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/bills/{1}/{2}/{3}.json", __workflow_firstMemberId.WithUrlEncoding(1), __workflow_secondMemberId.WithUrlEncoding(1), __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberGetBillResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillRecentMemberResponse, ApiConnectionActionConfiguration> BillRecentMember(Expression<Func<string>> memberId, Expression<Func<typeInput>> type)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<BillRecentMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/bills/{1}.json", __workflow_memberId.WithUrlEncoding(1), __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillRecentMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<HouseOfficeExpenseResponse, ApiConnectionActionConfiguration> HouseOfficeExpense(Expression<Func<string>> memberId, Expression<Func<string>> year, Expression<Func<string>> quarter)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_quarter = WorkflowExpression.Compile(quarter, nameof(quarter), required: true);
            return new DeferredBodyAction<HouseOfficeExpenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/office_expenses/{1}/{2}.json", __workflow_memberId.WithUrlEncoding(1), __workflow_year.WithUrlEncoding(1), __workflow_quarter.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HouseOfficeExpenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<HouseOfficeCategoryResponse, ApiConnectionActionConfiguration> HouseOfficeCategory(Expression<Func<string>> memberId, Expression<Func<categoryInput>> category)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            return new DeferredBodyAction<HouseOfficeCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/office_expenses/category/{1}.json", __workflow_memberId.WithUrlEncoding(1), __workflow_category.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HouseOfficeCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<HouseOfficeQuarterCategoryResponse, ApiConnectionActionConfiguration> HouseOfficeQuarterCategory(Expression<Func<categoryInput>> category, Expression<Func<string>> year, Expression<Func<string>> quarter)
        {
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_quarter = WorkflowExpression.Compile(quarter, nameof(quarter), required: true);
            return new DeferredBodyAction<HouseOfficeQuarterCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/office_expenses/category/{0}/{1}/{2}.json", __workflow_category.WithUrlEncoding(1), __workflow_year.WithUrlEncoding(1), __workflow_quarter.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HouseOfficeQuarterCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<TripPrivateGetResponse, ApiConnectionActionConfiguration> TripPrivateGet(Expression<Func<string>> congress)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            return new DeferredBodyAction<TripPrivateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/private-trips.json", __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TripPrivateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<TripPrivateGetAResponse, ApiConnectionActionConfiguration> TripPrivateGetA(Expression<Func<string>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<TripPrivateGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/private-trips.json", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TripPrivateGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillSearchResponse, ApiConnectionActionConfiguration> BillSearch(Expression<Func<string>> query = null, Expression<Func<sortInput>> sort = null, Expression<Func<dirInput>> dir = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<BillSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bills/search.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["sort"] = Convert.ToString("date");
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Queries["dir"] = Convert.ToString("asc");
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                return new ApiConnectionAction<BillSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillRecentResponse, ApiConnectionActionConfiguration> BillRecent(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<typeInput>> type)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<BillRecentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/bills/{2}.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1), __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillRecentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillRecentSubjectResponse, ApiConnectionActionConfiguration> BillRecentSubject(Expression<Func<string>> subject)
        {
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: true);
            return new DeferredBodyAction<BillRecentSubjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bills/subjects/{0}.json", __workflow_subject.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillRecentSubjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillUpcomingResponse, ApiConnectionActionConfiguration> BillUpcoming(Expression<Func<chamberInput>> chamber)
        {
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            return new DeferredBodyAction<BillUpcomingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bills/upcoming/{0}.json", __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillUpcomingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillGetResponse, ApiConnectionActionConfiguration> BillGet(Expression<Func<string>> congress, Expression<Func<string>> billId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_billId = WorkflowExpression.Compile(billId, nameof(billId), required: true);
            return new DeferredBodyAction<BillGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bills/{1}.json", __workflow_congress.WithUrlEncoding(1), __workflow_billId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillAmendmentsResponse, ApiConnectionActionConfiguration> BillAmendments(Expression<Func<string>> congress, Expression<Func<string>> billId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_billId = WorkflowExpression.Compile(billId, nameof(billId), required: true);
            return new DeferredBodyAction<BillAmendmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bills/{1}/amendments.json", __workflow_congress.WithUrlEncoding(1), __workflow_billId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillAmendmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillSubjectResponse, ApiConnectionActionConfiguration> BillSubject(Expression<Func<string>> congress, Expression<Func<string>> billId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_billId = WorkflowExpression.Compile(billId, nameof(billId), required: true);
            return new DeferredBodyAction<BillSubjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bills/{1}/subjects.json", __workflow_congress.WithUrlEncoding(1), __workflow_billId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillSubjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillRelatedResponse, ApiConnectionActionConfiguration> BillRelated(Expression<Func<string>> congress, Expression<Func<string>> billId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_billId = WorkflowExpression.Compile(billId, nameof(billId), required: true);
            return new DeferredBodyAction<BillRelatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bills/{1}/related.json", __workflow_congress.WithUrlEncoding(1), __workflow_billId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillRelatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<BillCosponsorResponse, ApiConnectionActionConfiguration> BillCosponsor(Expression<Func<string>> congress, Expression<Func<string>> billId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_billId = WorkflowExpression.Compile(billId, nameof(billId), required: true);
            return new DeferredBodyAction<BillCosponsorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bills/{1}/cosponsors.json", __workflow_congress.WithUrlEncoding(1), __workflow_billId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BillCosponsorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<VoteRecentResponse, ApiConnectionActionConfiguration> VoteRecent(Expression<Func<chamberInput>> chamber, Expression<Func<int>> offset = null)
        {
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<VoteRecentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/votes/recent.json", __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<VoteRecentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<VoteRollCallResponse, ApiConnectionActionConfiguration> VoteRollCall(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<string>> sessionNumber, Expression<Func<int>> rollCallNumber)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_sessionNumber = WorkflowExpression.Compile(sessionNumber, nameof(sessionNumber), required: true);
            var __workflow_rollCallNumber = WorkflowExpression.Compile(rollCallNumber, nameof(rollCallNumber), required: true);
            return new DeferredBodyAction<VoteRollCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/sessions/{2}/votes/{3}.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1), __workflow_sessionNumber.WithUrlEncoding(1), __workflow_rollCallNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VoteRollCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<VoteTypeResponse, ApiConnectionActionConfiguration> VoteType(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<voteTypeInput>> voteType)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_voteType = WorkflowExpression.Compile(voteType, nameof(voteType), required: true);
            return new DeferredBodyAction<VoteTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/votes/{2}.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1), __workflow_voteType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VoteTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<VoteDateResponse, ApiConnectionActionConfiguration> VoteDate(Expression<Func<chamberInput>> chamber, Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<VoteDateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/votes/{1}/{2}.json", __workflow_chamber.WithUrlEncoding(1), __workflow_startDate.WithUrlEncoding(1), __workflow_endDate.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VoteDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<VoteNominationResponse, ApiConnectionActionConfiguration> VoteNomination(Expression<Func<string>> congress)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            return new DeferredBodyAction<VoteNominationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/nominations.json", __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VoteNominationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<ExplanationRecentResponse, ApiConnectionActionConfiguration> ExplanationRecent(Expression<Func<string>> congress, Expression<Func<int>> offset = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ExplanationRecentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/explanations.json", __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ExplanationRecentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<ExplanationRecentGetResponse, ApiConnectionActionConfiguration> ExplanationRecentGet(Expression<Func<string>> memberId, Expression<Func<string>> congress, Expression<Func<int>> offset = null)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ExplanationRecentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/members/{0}/explanations/{1}.json", __workflow_memberId.WithUrlEncoding(1), __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ExplanationRecentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommitteeGetResponse, ApiConnectionActionConfiguration> CommitteeGet(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            return new DeferredBodyAction<CommitteeGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/committees.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommitteeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommitteeGetAResponse, ApiConnectionActionConfiguration> CommitteeGetA(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<string>> committeeId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_committeeId = WorkflowExpression.Compile(committeeId, nameof(committeeId), required: true);
            return new DeferredBodyAction<CommitteeGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/committees/{2}.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1), __workflow_committeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommitteeGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommitteeHearingRecentResponse, ApiConnectionActionConfiguration> CommitteeHearingRecent(Expression<Func<string>> congress)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            return new DeferredBodyAction<CommitteeHearingRecentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/committees/hearings.json", __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommitteeHearingRecentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommitteeHearingAResponse, ApiConnectionActionConfiguration> CommitteeHearingA(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<string>> committeeId, Expression<Func<int>> offset = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_committeeId = WorkflowExpression.Compile(committeeId, nameof(committeeId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CommitteeHearingAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/committees/{2}/hearings.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1), __workflow_committeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<CommitteeHearingAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<SubcommitteeGetResponse, ApiConnectionActionConfiguration> SubcommitteeGet(Expression<Func<string>> congress, Expression<Func<chamberInput>> chamber, Expression<Func<string>> committeeId, Expression<Func<string>> subcommitteeId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_committeeId = WorkflowExpression.Compile(committeeId, nameof(committeeId), required: true);
            var __workflow_subcommitteeId = WorkflowExpression.Compile(subcommitteeId, nameof(subcommitteeId), required: true);
            return new DeferredBodyAction<SubcommitteeGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/committees/{2}/subcommittees/{3}.json", __workflow_congress.WithUrlEncoding(1), __workflow_chamber.WithUrlEncoding(1), __workflow_committeeId.WithUrlEncoding(1), __workflow_subcommitteeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubcommitteeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommunicationRecentResponse, ApiConnectionActionConfiguration> CommunicationRecent(Expression<Func<string>> congress)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            return new DeferredBodyAction<CommunicationRecentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/communications.json", __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommunicationRecentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommunicationRecentCategoryResponse, ApiConnectionActionConfiguration> CommunicationRecentCategory(Expression<Func<string>> congress, Expression<Func<categoryInput>> category)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            return new DeferredBodyAction<CommunicationRecentCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/communications/category/{1}.json", __workflow_congress.WithUrlEncoding(1), __workflow_category.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommunicationRecentCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<CommunicationDateResponse, ApiConnectionActionConfiguration> CommunicationDate(Expression<Func<string>> date)
        {
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            return new DeferredBodyAction<CommunicationDateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/communications/date/{0}.json", __workflow_date.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommunicationDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<NominationGetResponse, ApiConnectionActionConfiguration> NominationGet(Expression<Func<string>> congress, Expression<Func<string>> nomineeId)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_nomineeId = WorkflowExpression.Compile(nomineeId, nameof(nomineeId), required: true);
            return new DeferredBodyAction<NominationGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/nominees/{1}.json", __workflow_congress.WithUrlEncoding(1), __workflow_nomineeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NominationGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<FloorActionResponse, ApiConnectionActionConfiguration> FloorAction(Expression<Func<chamberInput>> chamber, Expression<Func<int>> offset = null)
        {
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FloorActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/floor_updates.json", __workflow_chamber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<FloorActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<FloorActionDateResponse, ApiConnectionActionConfiguration> FloorActionDate(Expression<Func<chamberInput>> chamber, Expression<Func<string>> year, Expression<Func<string>> month, Expression<Func<string>> day)
        {
            var __workflow_chamber = WorkflowExpression.Compile(chamber, nameof(chamber), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: true);
            var __workflow_day = WorkflowExpression.Compile(day, nameof(day), required: true);
            return new DeferredBodyAction<FloorActionDateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/floor_updates/{1}/{2}/{3}.json", __workflow_chamber.WithUrlEncoding(1), __workflow_year.WithUrlEncoding(1), __workflow_month.WithUrlEncoding(1), __workflow_day.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FloorActionDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<LobbyingResponse, ApiConnectionActionConfiguration> Lobbying(Expression<Func<int>> offset = null)
        {
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LobbyingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lobbying/latest.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LobbyingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<LobbyingSearchResponse, ApiConnectionActionConfiguration> LobbyingSearch(Expression<Func<string>> query = null, Expression<Func<int>> offset = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LobbyingSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lobbying/search.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LobbyingSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacongressip")]
        public IBodyWorkflowAction<LobbyingGetAResponse, ApiConnectionActionConfiguration> LobbyingGetA(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LobbyingGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lobbying/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LobbyingGetAResponse>(callPayload);
            });
        }
    }

    public class PropublicacongressipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MemberGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("members")]
        public MemberGetResponseResultsTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class MemberGetResponseResultsTypeItemMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("leadership_role")]
        public string LeadershipRole { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("facebook_account")]
        public string FacebookAccount { get; set; }

        [JsonProperty("youtube_account")]
        public string YoutubeAccount { get; set; }

        [JsonProperty("govtrack_id")]
        public string GovtrackId { get; set; }

        [JsonProperty("cspan_id")]
        public string CspanId { get; set; }

        [JsonProperty("votesmart_id")]
        public string VotesmartId { get; set; }

        [JsonProperty("icpsr_id")]
        public string IcpsrId { get; set; }

        [JsonProperty("crp_id")]
        public string CrpId { get; set; }

        [JsonProperty("google_entity_id")]
        public string GoogleEntityId { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rss_url")]
        public string RssUrl { get; set; }

        [JsonProperty("contact_form")]
        public string ContactForm { get; set; }

        [JsonProperty("in_office")]
        public bool InOffice { get; set; }

        [JsonProperty("cook_pvi")]
        public string CookPvi { get; set; }

        [JsonProperty("dw_nominate")]
        public double DwNominate { get; set; }

        [JsonProperty("ideal_point")]
        public string IdealPoint { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("next_election")]
        public string NextElection { get; set; }

        [JsonProperty("total_votes")]
        public int TotalVotes { get; set; }

        [JsonProperty("missed_votes")]
        public int MissedVotes { get; set; }

        [JsonProperty("total_present")]
        public int TotalPresent { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("ocd_id")]
        public string OcdId { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("senate_class")]
        public string SenateClass { get; set; }

        [JsonProperty("state_rank")]
        public string StateRank { get; set; }

        [JsonProperty("lis_id")]
        public string LisId { get; set; }

        [JsonProperty("missed_votes_pct")]
        public double MissedVotesPct { get; set; }

        [JsonProperty("votes_with_party_pct")]
        public double VotesWithPartyPct { get; set; }

        [JsonProperty("votes_against_party_pct")]
        public double VotesAgainstPartyPct { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum chamberInput
    {
        [EnumMember(Value = "house")]
        House,
        [EnumMember(Value = "senate")]
        Senate
    }

    public class MemberGetAResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetAResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetAResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("times_topics_url")]
        public string TimesTopicsUrl { get; set; }

        [JsonProperty("times_tag")]
        public string TimesTag { get; set; }

        [JsonProperty("govtrack_id")]
        public string GovtrackId { get; set; }

        [JsonProperty("cspan_id")]
        public string CspanId { get; set; }

        [JsonProperty("votesmart_id")]
        public string VotesmartId { get; set; }

        [JsonProperty("icpsr_id")]
        public string IcpsrId { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("facebook_account")]
        public string FacebookAccount { get; set; }

        [JsonProperty("youtube_account")]
        public string YoutubeAccount { get; set; }

        [JsonProperty("crp_id")]
        public string CrpId { get; set; }

        [JsonProperty("google_entity_id")]
        public string GoogleEntityId { get; set; }

        [JsonProperty("rss_url")]
        public string RssUrl { get; set; }

        [JsonProperty("in_office")]
        public bool InOffice { get; set; }

        [JsonProperty("current_party")]
        public string CurrentParty { get; set; }

        [JsonProperty("most_recent_vote")]
        public string MostRecentVote { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("roles")]
        public MemberGetAResponseResultsTypeItemRolesTypeItem[] Roles { get; set; }
    }

    public class MemberGetAResponseResultsTypeItemRolesTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("leadership_role")]
        public string LeadershipRole { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("at_large")]
        public bool AtLarge { get; set; }

        [JsonProperty("ocd_id")]
        public string OcdId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("contact_form")]
        public string ContactForm { get; set; }

        [JsonProperty("cook_pvi")]
        public string CookPvi { get; set; }

        [JsonProperty("dw_nominate")]
        public double DwNominate { get; set; }

        [JsonProperty("ideal_point")]
        public string IdealPoint { get; set; }

        [JsonProperty("next_election")]
        public string NextElection { get; set; }

        [JsonProperty("total_votes")]
        public int TotalVotes { get; set; }

        [JsonProperty("missed_votes")]
        public int MissedVotes { get; set; }

        [JsonProperty("total_present")]
        public int TotalPresent { get; set; }

        [JsonProperty("senate_class")]
        public string SenateClass { get; set; }

        [JsonProperty("state_rank")]
        public string StateRank { get; set; }

        [JsonProperty("lis_id")]
        public string LisId { get; set; }

        [JsonProperty("bills_sponsored")]
        public int BillsSponsored { get; set; }

        [JsonProperty("bills_cosponsored")]
        public int BillsCosponsored { get; set; }

        [JsonProperty("missed_votes_pct")]
        public double MissedVotesPct { get; set; }

        [JsonProperty("votes_with_party_pct")]
        public double VotesWithPartyPct { get; set; }

        [JsonProperty("votes_against_party_pct")]
        public double VotesAgainstPartyPct { get; set; }

        [JsonProperty("committees")]
        public MemberGetAResponseResultsTypeItemRolesTypeItemCommitteesTypeItem[] Committees { get; set; }

        [JsonProperty("subcommittees")]
        public MemberGetAResponseResultsTypeItemRolesTypeItemSubcommitteesTypeItem[] Subcommittees { get; set; }
    }

    public class MemberGetAResponseResultsTypeItemRolesTypeItemCommitteesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rank_in_party")]
        public int RankInParty { get; set; }

        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class MemberGetAResponseResultsTypeItemRolesTypeItemSubcommitteesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parent_committee_id")]
        public string ParentCommitteeId { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rank_in_party")]
        public int RankInParty { get; set; }

        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class MemberGetNewResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetNewResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetNewResponseResultsTypeItem
    {
        [JsonProperty("num_results")]
        public string NumResults { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("members")]
        public MemberGetNewResponseResultsTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class MemberGetNewResponseResultsTypeItemMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class MemberGetStateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetStateResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetStateResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("times_topics_url")]
        public string TimesTopicsUrl { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }

        [JsonProperty("facebook_account")]
        public string FacebookAccount { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("next_election")]
        public string NextElection { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }
    }

    public class MemberGetLeavingResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetLeavingResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetLeavingResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("members")]
        public MemberGetLeavingResponseResultsTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class MemberGetLeavingResponseResultsTypeItemMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class MemberGetVoteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetVoteResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetVoteResponseResultsTypeItem
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("total_votes")]
        public string TotalVotes { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("votes")]
        public MemberGetVoteResponseResultsTypeItemVotesTypeItem[] Votes { get; set; }
    }

    public class MemberGetVoteResponseResultsTypeItemVotesTypeItem
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("session")]
        public string Session { get; set; }

        [JsonProperty("roll_call")]
        public string RollCall { get; set; }

        [JsonProperty("vote_uri")]
        public string VoteUri { get; set; }

        [JsonProperty("bill")]
        public MemberGetVoteResponseResultsTypeItemVotesTypeItemBillType Bill { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("total")]
        public MemberGetVoteResponseResultsTypeItemVotesTypeItemTotalType Total { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class MemberGetVoteResponseResultsTypeItemVotesTypeItemBillType
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }
    }

    public class MemberGetVoteResponseResultsTypeItemVotesTypeItemTotalType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class MemberGetVotePositionsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetVotePositionsResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetVotePositionsResponseResultsTypeItem
    {
        [JsonProperty("first_member_id")]
        public string FirstMemberId { get; set; }

        [JsonProperty("first_member_api_uri")]
        public string FirstMemberApiUri { get; set; }

        [JsonProperty("second_member_id")]
        public string SecondMemberId { get; set; }

        [JsonProperty("second_member_api_uri")]
        public string SecondMemberApiUri { get; set; }

        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("common_votes")]
        public string CommonVotes { get; set; }

        [JsonProperty("disagree_votes")]
        public string DisagreeVotes { get; set; }

        [JsonProperty("agree_percent")]
        public string AgreePercent { get; set; }

        [JsonProperty("disagree_percent")]
        public string DisagreePercent { get; set; }
    }

    public class MemberGetBillResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public MemberGetBillResponseResultsTypeItem[] Results { get; set; }
    }

    public class MemberGetBillResponseResultsTypeItem
    {
        [JsonProperty("first_member_api_uri")]
        public string FirstMemberApiUri { get; set; }

        [JsonProperty("second_member_api_uri")]
        public string SecondMemberApiUri { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("common_bills")]
        public string CommonBills { get; set; }

        [JsonProperty("bills")]
        public MemberGetBillResponseResultsTypeItemBillsTypeItem[] Bills { get; set; }
    }

    public class MemberGetBillResponseResultsTypeItemBillsTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("cosponsors")]
        public string Cosponsors { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("first_member_date")]
        public string FirstMemberDate { get; set; }

        [JsonProperty("second_member_date")]
        public string SecondMemberDate { get; set; }
    }

    public class BillRecentMemberResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillRecentMemberResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillRecentMemberResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("member_uri")]
        public string MemberUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("bills")]
        public BillRecentMemberResponseResultsTypeItemBillsTypeItem[] Bills { get; set; }
    }

    public class BillRecentMemberResponseResultsTypeItemBillsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("last_vote")]
        public string LastVote { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string SenatePassage { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public BillRecentMemberResponseResultsTypeItemBillsTypeItemCosponsorsByPartyType CosponsorsByParty { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }

    public class BillRecentMemberResponseResultsTypeItemBillsTypeItemCosponsorsByPartyType
    {
        public int D { get; set; }
        public int R { get; set; }
        public int I { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "cosponsored")]
        Cosponsored,
        [EnumMember(Value = "withdrawn")]
        Withdrawn
    }

    public class HouseOfficeExpenseResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_uri")]
        public string MemberUri { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("quarter")]
        public int Quarter { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("results")]
        public HouseOfficeExpenseResponseResultsTypeItem[] Results { get; set; }
    }

    public class HouseOfficeExpenseResponseResultsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_slug")]
        public string CategorySlug { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("year_to_date")]
        public double YearToDate { get; set; }

        [JsonProperty("change_from_previous_quarter")]
        public double ChangeFromPreviousQuarter { get; set; }
    }

    public class HouseOfficeCategoryResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_uri")]
        public string MemberUri { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("results")]
        public HouseOfficeCategoryResponseResultsTypeItem[] Results { get; set; }
    }

    public class HouseOfficeCategoryResponseResultsTypeItem
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("quarter")]
        public int Quarter { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("year_to_date")]
        public double YearToDate { get; set; }

        [JsonProperty("change_from_previous_quarter")]
        public int ChangeFromPreviousQuarter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum categoryInput
    {
        [EnumMember(Value = "ec")]
        Ec,
        [EnumMember(Value = "pm")]
        Pm,
        [EnumMember(Value = "pom")]
        Pom
    }

    public class HouseOfficeQuarterCategoryResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public HouseOfficeQuarterCategoryResponseResultsTypeItem[] Results { get; set; }
    }

    public class HouseOfficeQuarterCategoryResponseResultsTypeItem
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("quarter")]
        public int Quarter { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_uri")]
        public string MemberUri { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("year_to_date")]
        public double YearToDate { get; set; }

        [JsonProperty("change_from_previous_quarter")]
        public double ChangeFromPreviousQuarter { get; set; }
    }

    public class TripPrivateGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public TripPrivateGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class TripPrivateGetResponseResultsTypeItem
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("filing_type")]
        public string FilingType { get; set; }

        [JsonProperty("traveler")]
        public string Traveler { get; set; }

        [JsonProperty("is_member")]
        public int IsMember { get; set; }

        [JsonProperty("departure_date")]
        public string DepartureDate { get; set; }

        [JsonProperty("return_date")]
        public string ReturnDate { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("pdf_url")]
        public string PdfUrl { get; set; }
    }

    public class TripPrivateGetAResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("results")]
        public TripPrivateGetAResponseResultsTypeItem[] Results { get; set; }
    }

    public class TripPrivateGetAResponseResultsTypeItem
    {
        [JsonProperty("filing_type")]
        public string FilingType { get; set; }

        [JsonProperty("traveler")]
        public string Traveler { get; set; }

        [JsonProperty("is_member")]
        public int IsMember { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("departure_date")]
        public string DepartureDate { get; set; }

        [JsonProperty("return_date")]
        public string ReturnDate { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("pdf_url")]
        public string PdfUrl { get; set; }
    }

    public class BillSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillSearchResponseResultsTypeItem
    {
        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("bills")]
        public BillSearchResponseResultsTypeItemBillsTypeItem[] Bills { get; set; }
    }

    public class BillSearchResponseResultsTypeItemBillsTypeItem
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string SenatePassage { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public string[] CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public string[] SubcommitteeCodes { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInput
    {
        [EnumMember(Value = "_score")]
        Score,
        [EnumMember(Value = "date")]
        Date
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dirInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class BillRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillRecentResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("bills")]
        public BillRecentResponseResultsTypeItemBillsTypeItem[] Bills { get; set; }
    }

    public class BillRecentResponseResultsTypeItemBillsTypeItem
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("last_vote")]
        public string LastVote { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string SenatePassage { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public BillRecentResponseResultsTypeItemBillsTypeItemCosponsorsByPartyType CosponsorsByParty { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public string[] CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public string[] SubcommitteeCodes { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }

    public class BillRecentResponseResultsTypeItemBillsTypeItemCosponsorsByPartyType
    {
        public int D { get; set; }
        public int R { get; set; }
        public int I { get; set; }
    }

    public class BillRecentSubjectResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("results")]
        public BillRecentSubjectResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillRecentSubjectResponseResultsTypeItem
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public BillRecentSubjectResponseResultsTypeItemCosponsorsByPartyType CosponsorsByParty { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public string[] CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public string[] SubcommitteeCodes { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("last_vote")]
        public string LastVote { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string SenatePassage { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }
    }

    public class BillRecentSubjectResponseResultsTypeItemCosponsorsByPartyType
    {
        public int R { get; set; }
        public int D { get; set; }
        public int I { get; set; }
    }

    public class BillUpcomingResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillUpcomingResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillUpcomingResponseResultsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("bills")]
        public BillUpcomingResponseResultsTypeItemBillsTypeItem[] Bills { get; set; }
    }

    public class BillUpcomingResponseResultsTypeItemBillsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("bill_number")]
        public string BillNumber { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("legislative_day")]
        public string LegislativeDay { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("bill_url")]
        public string BillUrl { get; set; }

        [JsonProperty("consideration")]
        public string Consideration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BillGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillGetResponseResultsTypeItem
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill")]
        public string Bill { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("last_vote")]
        public string LastVote { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string SenatePassage { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public BillGetResponseResultsTypeItemCosponsorsByPartyType CosponsorsByParty { get; set; }

        [JsonProperty("withdrawn_cosponsors")]
        public int WithdrawnCosponsors { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public string[] CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public string[] SubcommitteeCodes { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("house_passage_vote")]
        public string HousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public string SenatePassageVote { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("cbo_estimate_url")]
        public string CboEstimateUrl { get; set; }

        [JsonProperty("versions")]
        public BillGetResponseResultsTypeItemVersionsTypeItem[] Versions { get; set; }

        [JsonProperty("actions")]
        public BillGetResponseResultsTypeItemActionsTypeItem[] Actions { get; set; }

        [JsonProperty("presidential_statements")]
        public string[] PresidentialStatements { get; set; }

        [JsonProperty("votes")]
        public BillGetResponseResultsTypeItemVotesTypeItem[] Votes { get; set; }
    }

    public class BillGetResponseResultsTypeItemCosponsorsByPartyType
    {
        public int R { get; set; }
        public int D { get; set; }
        public int I { get; set; }
    }

    public class BillGetResponseResultsTypeItemVersionsTypeItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }
    }

    public class BillGetResponseResultsTypeItemActionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class BillGetResponseResultsTypeItemVotesTypeItem
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("roll_call")]
        public string RollCall { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("total_yes")]
        public int TotalYes { get; set; }

        [JsonProperty("total_no")]
        public int TotalNo { get; set; }

        [JsonProperty("total_not_voting")]
        public int TotalNotVoting { get; set; }

        [JsonProperty("api_url")]
        public string ApiUrl { get; set; }
    }

    public class BillAmendmentsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillAmendmentsResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillAmendmentsResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amendments")]
        public BillAmendmentsResponseResultsTypeItemAmendmentsTypeItem[] Amendments { get; set; }
    }

    public class BillAmendmentsResponseResultsTypeItemAmendmentsTypeItem
    {
        [JsonProperty("amendment_number")]
        public string AmendmentNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }

    public class BillSubjectResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public BillSubjectResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillSubjectResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("url_number")]
        public string UrlNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("number_of_cosponsors")]
        public int NumberOfCosponsors { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("house_passage_vote")]
        public string HousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public string SenatePassageVote { get; set; }

        [JsonProperty("subjects")]
        public BillSubjectResponseResultsTypeItemSubjectsTypeItem[] Subjects { get; set; }
    }

    public class BillSubjectResponseResultsTypeItemSubjectsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url_name")]
        public string UrlName { get; set; }
    }

    public class BillRelatedResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public BillRelatedResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillRelatedResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("url_number")]
        public string UrlNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("number_of_cosponsors")]
        public int NumberOfCosponsors { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("house_passage_vote")]
        public string HousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public string SenatePassageVote { get; set; }

        [JsonProperty("related_bills")]
        public BillRelatedResponseResultsTypeItemRelatedBillsTypeItem[] RelatedBills { get; set; }
    }

    public class BillRelatedResponseResultsTypeItemRelatedBillsTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("last_vote")]
        public string LastVote { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public string SenatePassage { get; set; }

        [JsonProperty("enacted")]
        public string Enacted { get; set; }

        [JsonProperty("vetoed")]
        public string Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public BillRelatedResponseResultsTypeItemRelatedBillsTypeItemCosponsorsByPartyType CosponsorsByParty { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public string[] CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public string[] SubcommitteeCodes { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }
    }

    public class BillRelatedResponseResultsTypeItemRelatedBillsTypeItemCosponsorsByPartyType
    {
        public int R { get; set; }
        public int D { get; set; }
        public int I { get; set; }
    }

    public class BillCosponsorResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public BillCosponsorResponseResultsTypeItem[] Results { get; set; }
    }

    public class BillCosponsorResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill")]
        public string Bill { get; set; }

        [JsonProperty("url_number")]
        public string UrlNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("number_of_cosponsors")]
        public int NumberOfCosponsors { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("house_passage_vote")]
        public string HousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public string SenatePassageVote { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public BillCosponsorResponseResultsTypeItemCosponsorsByPartyTypeItem[] CosponsorsByParty { get; set; }

        [JsonProperty("cosponsors")]
        public BillCosponsorResponseResultsTypeItemCosponsorsTypeItem[] Cosponsors { get; set; }
    }

    public class BillCosponsorResponseResultsTypeItemCosponsorsByPartyTypeItem
    {
        [JsonProperty("party")]
        public BillCosponsorResponseResultsTypeItemCosponsorsByPartyTypeItemPartyType Party { get; set; }
    }

    public class BillCosponsorResponseResultsTypeItemCosponsorsByPartyTypeItemPartyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sponsors")]
        public string Sponsors { get; set; }
    }

    public class BillCosponsorResponseResultsTypeItemCosponsorsTypeItem
    {
        [JsonProperty("cosponsor_id")]
        public string CosponsorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cosponsor_title")]
        public string CosponsorTitle { get; set; }

        [JsonProperty("cosponsor_state")]
        public string CosponsorState { get; set; }

        [JsonProperty("cosponsor_party")]
        public string CosponsorParty { get; set; }

        [JsonProperty("cosponsor_uri")]
        public string CosponsorUri { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class VoteRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public VoteRecentResponseResultsType Results { get; set; }
    }

    public class VoteRecentResponseResultsType
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("votes")]
        public VoteRecentResponseResultsTypeVotesTypeItem[] Votes { get; set; }
    }

    public class VoteRecentResponseResultsTypeVotesTypeItem
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("roll_call")]
        public int RollCall { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("vote_uri")]
        public string VoteUri { get; set; }

        [JsonProperty("bill")]
        public VoteRecentResponseResultsTypeVotesTypeItemBillType Bill { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vote_type")]
        public string VoteType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("democratic")]
        public VoteRecentResponseResultsTypeVotesTypeItemDemocraticType Democratic { get; set; }

        [JsonProperty("republican")]
        public VoteRecentResponseResultsTypeVotesTypeItemRepublicanType Republican { get; set; }

        [JsonProperty("independent")]
        public VoteRecentResponseResultsTypeVotesTypeItemIndependentType Independent { get; set; }

        [JsonProperty("total")]
        public VoteRecentResponseResultsTypeVotesTypeItemTotalType Total { get; set; }
    }

    public class VoteRecentResponseResultsTypeVotesTypeItemBillType
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }
    }

    public class VoteRecentResponseResultsTypeVotesTypeItemDemocraticType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteRecentResponseResultsTypeVotesTypeItemRepublicanType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteRecentResponseResultsTypeVotesTypeItemIndependentType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteRecentResponseResultsTypeVotesTypeItemTotalType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteRollCallResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public VoteRollCallResponseResultsType Results { get; set; }
    }

    public class VoteRollCallResponseResultsType
    {
        [JsonProperty("votes")]
        public VoteRollCallResponseResultsTypeVotesType Votes { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesType
    {
        [JsonProperty("vote")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteType Vote { get; set; }

        [JsonProperty("vacant_seats")]
        public string[] VacantSeats { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteType
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("roll_call")]
        public int RollCall { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("bill")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteTypeBillType Bill { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vote_type")]
        public string VoteType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("tie_breaker")]
        public string TieBreaker { get; set; }

        [JsonProperty("tie_breaker_vote")]
        public string TieBreakerVote { get; set; }

        [JsonProperty("document_number")]
        public string DocumentNumber { get; set; }

        [JsonProperty("document_title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("democratic")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteTypeDemocraticType Democratic { get; set; }

        [JsonProperty("republican")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteTypeRepublicanType Republican { get; set; }

        [JsonProperty("independent")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteTypeIndependentType Independent { get; set; }

        [JsonProperty("total")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteTypeTotalType Total { get; set; }

        [JsonProperty("positions")]
        public VoteRollCallResponseResultsTypeVotesTypeVoteTypePositionsTypeItem[] Positions { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteTypeBillType
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteTypeDemocraticType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteTypeRepublicanType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteTypeIndependentType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteTypeTotalType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteRollCallResponseResultsTypeVotesTypeVoteTypePositionsTypeItem
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("vote_position")]
        public string VotePosition { get; set; }

        [JsonProperty("dw_nominate")]
        public double DwNominate { get; set; }
    }

    public class VoteTypeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public VoteTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class VoteTypeResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public string NumResults { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("members")]
        public VoteTypeResponseResultsTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class VoteTypeResponseResultsTypeItemMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("total_votes")]
        public string TotalVotes { get; set; }

        [JsonProperty("missed_votes")]
        public string MissedVotes { get; set; }

        [JsonProperty("missed_votes_pct")]
        public double MissedVotesPct { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum voteTypeInput
    {
        [EnumMember(Value = "missed")]
        Missed,
        [EnumMember(Value = "party")]
        Party,
        [EnumMember(Value = "loneno")]
        Loneno,
        [EnumMember(Value = "perfect")]
        Perfect
    }

    public class VoteDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public VoteDateResponseResultsType Results { get; set; }
    }

    public class VoteDateResponseResultsType
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("votes")]
        public VoteDateResponseResultsTypeVotesTypeItem[] Votes { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItem
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("roll_call")]
        public int RollCall { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("vote_uri")]
        public string VoteUri { get; set; }

        [JsonProperty("bill")]
        public VoteDateResponseResultsTypeVotesTypeItemBillType Bill { get; set; }

        [JsonProperty("nomination")]
        public VoteDateResponseResultsTypeVotesTypeItemNominationType Nomination { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("question_text")]
        public string QuestionText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vote_type")]
        public string VoteType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("democratic")]
        public VoteDateResponseResultsTypeVotesTypeItemDemocraticType Democratic { get; set; }

        [JsonProperty("republican")]
        public VoteDateResponseResultsTypeVotesTypeItemRepublicanType Republican { get; set; }

        [JsonProperty("independent")]
        public VoteDateResponseResultsTypeVotesTypeItemIndependentType Independent { get; set; }

        [JsonProperty("total")]
        public VoteDateResponseResultsTypeVotesTypeItemTotalType Total { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItemBillType
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItemNominationType
    {
        [JsonProperty("nomination_id")]
        public string NominationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItemDemocraticType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItemRepublicanType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItemIndependentType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteDateResponseResultsTypeVotesTypeItemTotalType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteNominationResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public VoteNominationResponseResultsTypeItem[] Results { get; set; }
    }

    public class VoteNominationResponseResultsTypeItem
    {
        [JsonProperty("total_votes")]
        public string TotalVotes { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("votes")]
        public VoteNominationResponseResultsTypeItemVotesTypeItem[] Votes { get; set; }
    }

    public class VoteNominationResponseResultsTypeItemVotesTypeItem
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("session")]
        public int Session { get; set; }

        [JsonProperty("roll_call")]
        public int RollCall { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("vote_uri")]
        public string VoteUri { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vote_type")]
        public string VoteType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("nominee_uri")]
        public string NomineeUri { get; set; }

        [JsonProperty("democratic")]
        public VoteNominationResponseResultsTypeItemVotesTypeItemDemocraticType Democratic { get; set; }

        [JsonProperty("republican")]
        public VoteNominationResponseResultsTypeItemVotesTypeItemRepublicanType Republican { get; set; }

        [JsonProperty("independent")]
        public VoteNominationResponseResultsTypeItemVotesTypeItemIndependentType Independent { get; set; }

        [JsonProperty("total")]
        public VoteNominationResponseResultsTypeItemVotesTypeItemTotalType Total { get; set; }
    }

    public class VoteNominationResponseResultsTypeItemVotesTypeItemDemocraticType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteNominationResponseResultsTypeItemVotesTypeItemRepublicanType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("majority_position")]
        public string MajorityPosition { get; set; }
    }

    public class VoteNominationResponseResultsTypeItemVotesTypeItemIndependentType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class VoteNominationResponseResultsTypeItemVotesTypeItemTotalType
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }

        [JsonProperty("margin")]
        public int Margin { get; set; }
    }

    public class ExplanationRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public ExplanationRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExplanationRecentResponseResultsTypeItem
    {
        [JsonProperty("member")]
        public string Member { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("roll_call")]
        public string RollCall { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("parsed")]
        public bool Parsed { get; set; }

        [JsonProperty("vote_api_uri")]
        public string VoteApiUri { get; set; }
    }

    public class ExplanationRecentGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("results")]
        public ExplanationRecentGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExplanationRecentGetResponseResultsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CommitteeGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public CommitteeGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeGetResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("committees")]
        public CommitteeGetResponseResultsTypeItemCommitteesTypeItem[] Committees { get; set; }
    }

    public class CommitteeGetResponseResultsTypeItemCommitteesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("chair")]
        public string Chair { get; set; }

        [JsonProperty("chair_id")]
        public string ChairId { get; set; }

        [JsonProperty("chair_party")]
        public string ChairParty { get; set; }

        [JsonProperty("chair_state")]
        public string ChairState { get; set; }

        [JsonProperty("chair_uri")]
        public string ChairUri { get; set; }

        [JsonProperty("ranking_member_id")]
        public string RankingMemberId { get; set; }

        [JsonProperty("subcommittees")]
        public CommitteeGetResponseResultsTypeItemCommitteesTypeItemSubcommitteesTypeItem[] Subcommittees { get; set; }
    }

    public class CommitteeGetResponseResultsTypeItemCommitteesTypeItemSubcommitteesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }
    }

    public class CommitteeGetAResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public CommitteeGetAResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeGetAResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("chair")]
        public string Chair { get; set; }

        [JsonProperty("chair_id")]
        public string ChairId { get; set; }

        [JsonProperty("chair_party")]
        public string ChairParty { get; set; }

        [JsonProperty("chair_state")]
        public string ChairState { get; set; }

        [JsonProperty("ranking_member_id")]
        public string RankingMemberId { get; set; }

        [JsonProperty("current_members")]
        public CommitteeGetAResponseResultsTypeItemCurrentMembersTypeItem[] CurrentMembers { get; set; }

        [JsonProperty("former_members")]
        public CommitteeGetAResponseResultsTypeItemFormerMembersTypeItem[] FormerMembers { get; set; }

        [JsonProperty("subcommittees")]
        public CommitteeGetAResponseResultsTypeItemSubcommitteesTypeItem[] Subcommittees { get; set; }
    }

    public class CommitteeGetAResponseResultsTypeItemCurrentMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("rank_in_party")]
        public int RankInParty { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
    }

    public class CommitteeGetAResponseResultsTypeItemFormerMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CommitteeGetAResponseResultsTypeItemSubcommitteesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }
    }

    public class CommitteeHearingRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public CommitteeHearingRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeHearingRecentResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("hearings")]
        public CommitteeHearingRecentResponseResultsTypeItemHearingsTypeItem[] Hearings { get; set; }
    }

    public class CommitteeHearingRecentResponseResultsTypeItemHearingsTypeItem
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("committee_code")]
        public string CommitteeCode { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("bill_ids")]
        public string[] BillIds { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("meeting_type")]
        public string MeetingType { get; set; }
    }

    public class CommitteeHearingAResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public CommitteeHearingAResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeHearingAResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("hearings")]
        public CommitteeHearingAResponseResultsTypeItemHearingsTypeItem[] Hearings { get; set; }
    }

    public class CommitteeHearingAResponseResultsTypeItemHearingsTypeItem
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("committee_code")]
        public string CommitteeCode { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("bill_ids")]
        public string[] BillIds { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("meeting_type")]
        public string MeetingType { get; set; }
    }

    public class SubcommitteeGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public SubcommitteeGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class SubcommitteeGetResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("committee_id")]
        public string CommitteeId { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("committee_url")]
        public string CommitteeUrl { get; set; }

        [JsonProperty("chair")]
        public string Chair { get; set; }

        [JsonProperty("chair_id")]
        public string ChairId { get; set; }

        [JsonProperty("chair_party")]
        public string ChairParty { get; set; }

        [JsonProperty("chair_state")]
        public string ChairState { get; set; }

        [JsonProperty("ranking_member_id")]
        public string RankingMemberId { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("current_members")]
        public SubcommitteeGetResponseResultsTypeItemCurrentMembersTypeItem[] CurrentMembers { get; set; }

        [JsonProperty("former_members")]
        public string[] FormerMembers { get; set; }
    }

    public class SubcommitteeGetResponseResultsTypeItemCurrentMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("api_uri")]
        public string ApiUri { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("rank_in_party")]
        public int RankInParty { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
    }

    public class CommunicationRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public CommunicationRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommunicationRecentResponseResultsTypeItem
    {
        [JsonProperty("communication_id")]
        public string CommunicationId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("requirement_number")]
        public string RequirementNumber { get; set; }

        [JsonProperty("requirement_url")]
        public string RequirementUrl { get; set; }

        [JsonProperty("committee_code")]
        public string CommitteeCode { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }
    }

    public class CommunicationRecentCategoryResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public CommunicationRecentCategoryResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommunicationRecentCategoryResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("requirement_number")]
        public string RequirementNumber { get; set; }

        [JsonProperty("requirement_url")]
        public string RequirementUrl { get; set; }

        [JsonProperty("committee_code")]
        public string CommitteeCode { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }
    }

    public class CommunicationDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("results")]
        public CommunicationDateResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommunicationDateResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("requirement_number")]
        public string RequirementNumber { get; set; }

        [JsonProperty("requirement_url")]
        public string RequirementUrl { get; set; }

        [JsonProperty("committee_code")]
        public string CommitteeCode { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }
    }

    public class NominationGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public NominationGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class NominationGetResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("nominee_state")]
        public string NomineeState { get; set; }

        [JsonProperty("committee_uri")]
        public string CommitteeUri { get; set; }

        [JsonProperty("latest_action_date")]
        public string LatestActionDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("actions")]
        public NominationGetResponseResultsTypeItemActionsTypeItem[] Actions { get; set; }

        [JsonProperty("votes")]
        public NominationGetResponseResultsTypeItemVotesTypeItem[] Votes { get; set; }
    }

    public class NominationGetResponseResultsTypeItemActionsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class NominationGetResponseResultsTypeItemVotesTypeItem
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("roll_call")]
        public int RollCall { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("total_yes")]
        public int TotalYes { get; set; }

        [JsonProperty("total_no")]
        public int TotalNo { get; set; }

        [JsonProperty("total_not_voting")]
        public int TotalNotVoting { get; set; }
    }

    public class FloorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public FloorActionResponseResultsTypeItem[] Results { get; set; }
    }

    public class FloorActionResponseResultsTypeItem
    {
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("floor_actions")]
        public FloorActionResponseResultsTypeItemFloorActionsTypeItem[] FloorActions { get; set; }
    }

    public class FloorActionResponseResultsTypeItemFloorActionsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("bill_ids")]
        public string[] BillIds { get; set; }
    }

    public class FloorActionDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public FloorActionDateResponseResultsTypeItem[] Results { get; set; }
    }

    public class FloorActionDateResponseResultsTypeItem
    {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("num_results")]
        public string NumResults { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("floor_actions")]
        public FloorActionDateResponseResultsTypeItemFloorActionsTypeItem[] FloorActions { get; set; }
    }

    public class FloorActionDateResponseResultsTypeItemFloorActionsTypeItem
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class LobbyingResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public LobbyingResponseResultsTypeItem[] Results { get; set; }
    }

    public class LobbyingResponseResultsTypeItem
    {
        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("lobbying_representations")]
        public LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItem[] LobbyingRepresentations { get; set; }
    }

    public class LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItem
    {
        [JsonProperty("lobbying_client")]
        public LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingClientType LobbyingClient { get; set; }

        [JsonProperty("lobbying_registrant")]
        public LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingRegistrantType LobbyingRegistrant { get; set; }

        [JsonProperty("inhouse")]
        public string Inhouse { get; set; }

        [JsonProperty("signed_date")]
        public string SignedDate { get; set; }

        [JsonProperty("effective_date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("xml_filename")]
        public string XmlFilename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("specific_issues")]
        public string[] SpecificIssues { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        [JsonProperty("report_year")]
        public string ReportYear { get; set; }

        [JsonProperty("senate_id")]
        public string SenateId { get; set; }

        [JsonProperty("house_id")]
        public string HouseId { get; set; }

        [JsonProperty("latest_filing")]
        public LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLatestFilingType LatestFiling { get; set; }

        [JsonProperty("lobbyists")]
        public LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyistsTypeItem[] Lobbyists { get; set; }
    }

    public class LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingClientType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string GeneralDescription { get; set; }
    }

    public class LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingRegistrantType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string GeneralDescription { get; set; }
    }

    public class LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLatestFilingType
    {
        [JsonProperty("filing_date")]
        public string FilingDate { get; set; }

        [JsonProperty("report_year")]
        public string ReportYear { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        [JsonProperty("pdf_url")]
        public string PdfUrl { get; set; }
    }

    public class LobbyingResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyistsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("covered_position")]
        public string CoveredPosition { get; set; }
    }

    public class LobbyingSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public LobbyingSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class LobbyingSearchResponseResultsTypeItem
    {
        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("lobbying_representations")]
        public LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItem[] LobbyingRepresentations { get; set; }
    }

    public class LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItem
    {
        [JsonProperty("lobbying_client")]
        public LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingClientType LobbyingClient { get; set; }

        [JsonProperty("lobbying_registrant")]
        public LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingRegistrantType LobbyingRegistrant { get; set; }

        [JsonProperty("inhouse")]
        public string Inhouse { get; set; }

        [JsonProperty("signed_date")]
        public string SignedDate { get; set; }

        [JsonProperty("effective_date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("xml_filename")]
        public string XmlFilename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("specific_issues")]
        public string[] SpecificIssues { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        [JsonProperty("report_year")]
        public string ReportYear { get; set; }

        [JsonProperty("senate_id")]
        public string SenateId { get; set; }

        [JsonProperty("house_id")]
        public string HouseId { get; set; }

        [JsonProperty("lobbyists")]
        public LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyistsTypeItem[] Lobbyists { get; set; }
    }

    public class LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingClientType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string GeneralDescription { get; set; }
    }

    public class LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyingRegistrantType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string GeneralDescription { get; set; }
    }

    public class LobbyingSearchResponseResultsTypeItemLobbyingRepresentationsTypeItemLobbyistsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("covered_position")]
        public string CoveredPosition { get; set; }
    }

    public class LobbyingGetAResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public LobbyingGetAResponseResultsTypeItem[] Results { get; set; }
    }

    public class LobbyingGetAResponseResultsTypeItem
    {
        [JsonProperty("lobbying_client")]
        public LobbyingGetAResponseResultsTypeItemLobbyingClientType LobbyingClient { get; set; }

        [JsonProperty("lobbying_registrant")]
        public LobbyingGetAResponseResultsTypeItemLobbyingRegistrantType LobbyingRegistrant { get; set; }

        [JsonProperty("inhouse")]
        public string Inhouse { get; set; }

        [JsonProperty("signed_date")]
        public string SignedDate { get; set; }

        [JsonProperty("effective_date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("xml_filename")]
        public string XmlFilename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("specific_issues")]
        public string[] SpecificIssues { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        [JsonProperty("report_year")]
        public string ReportYear { get; set; }

        [JsonProperty("senate_id")]
        public string SenateId { get; set; }

        [JsonProperty("house_id")]
        public string HouseId { get; set; }

        [JsonProperty("filings")]
        public LobbyingGetAResponseResultsTypeItemFilingsTypeItem[] Filings { get; set; }

        [JsonProperty("lobbyists")]
        public LobbyingGetAResponseResultsTypeItemLobbyistsTypeItem[] Lobbyists { get; set; }
    }

    public class LobbyingGetAResponseResultsTypeItemLobbyingClientType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string GeneralDescription { get; set; }
    }

    public class LobbyingGetAResponseResultsTypeItemLobbyingRegistrantType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string GeneralDescription { get; set; }
    }

    public class LobbyingGetAResponseResultsTypeItemFilingsTypeItem
    {
        [JsonProperty("filing_date")]
        public string FilingDate { get; set; }

        [JsonProperty("report_year")]
        public string ReportYear { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        [JsonProperty("pdf_url")]
        public string PdfUrl { get; set; }
    }

    public class LobbyingGetAResponseResultsTypeItemLobbyistsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("covered_position")]
        public string CoveredPosition { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Propublicacongressip;

    public partial class WorkflowManagedActions
    {
        public PropublicacongressipActions Propublicacongressip(string connectionId) => new PropublicacongressipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PropublicacongressipTriggers Propublicacongressip(string connectionId) => new PropublicacongressipTriggers(connectionId);
    }
}