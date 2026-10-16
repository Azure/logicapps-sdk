//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatamuseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datamuseip")]
        public IBodyWorkflowAction<WordsResponseItem[]> Words(Expression<Func<string>> ml = null, Expression<Func<string>> sl = null, Expression<Func<string>> sp = null, Expression<Func<string>> relJja = null, Expression<Func<string>> relJjb = null, Expression<Func<string>> relSyn = null, Expression<Func<string>> relTrg = null, Expression<Func<string>> relAnt = null, Expression<Func<string>> relSpc = null, Expression<Func<string>> relGen = null, Expression<Func<string>> relCom = null, Expression<Func<string>> relPar = null, Expression<Func<string>> relBga = null, Expression<Func<string>> relBgb = null, Expression<Func<string>> relRhy = null, Expression<Func<string>> relNry = null, Expression<Func<string>> relHom = null, Expression<Func<string>> relCns = null, Expression<Func<string>> v = null, Expression<Func<string>> topics = null, Expression<Func<string>> lc = null, Expression<Func<string>> rc = null, Expression<Func<int>> max = null, Expression<Func<string>> md = null)
        {
            var __workflow_ml = WorkflowExpression.Compile(ml, nameof(ml), required: false);
            var __workflow_sl = WorkflowExpression.Compile(sl, nameof(sl), required: false);
            var __workflow_sp = WorkflowExpression.Compile(sp, nameof(sp), required: false);
            var __workflow_relJja = WorkflowExpression.Compile(relJja, nameof(relJja), required: false);
            var __workflow_relJjb = WorkflowExpression.Compile(relJjb, nameof(relJjb), required: false);
            var __workflow_relSyn = WorkflowExpression.Compile(relSyn, nameof(relSyn), required: false);
            var __workflow_relTrg = WorkflowExpression.Compile(relTrg, nameof(relTrg), required: false);
            var __workflow_relAnt = WorkflowExpression.Compile(relAnt, nameof(relAnt), required: false);
            var __workflow_relSpc = WorkflowExpression.Compile(relSpc, nameof(relSpc), required: false);
            var __workflow_relGen = WorkflowExpression.Compile(relGen, nameof(relGen), required: false);
            var __workflow_relCom = WorkflowExpression.Compile(relCom, nameof(relCom), required: false);
            var __workflow_relPar = WorkflowExpression.Compile(relPar, nameof(relPar), required: false);
            var __workflow_relBga = WorkflowExpression.Compile(relBga, nameof(relBga), required: false);
            var __workflow_relBgb = WorkflowExpression.Compile(relBgb, nameof(relBgb), required: false);
            var __workflow_relRhy = WorkflowExpression.Compile(relRhy, nameof(relRhy), required: false);
            var __workflow_relNry = WorkflowExpression.Compile(relNry, nameof(relNry), required: false);
            var __workflow_relHom = WorkflowExpression.Compile(relHom, nameof(relHom), required: false);
            var __workflow_relCns = WorkflowExpression.Compile(relCns, nameof(relCns), required: false);
            var __workflow_v = WorkflowExpression.Compile(v, nameof(v), required: false);
            var __workflow_topics = WorkflowExpression.Compile(topics, nameof(topics), required: false);
            var __workflow_lc = WorkflowExpression.Compile(lc, nameof(lc), required: false);
            var __workflow_rc = WorkflowExpression.Compile(rc, nameof(rc), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_md = WorkflowExpression.Compile(md, nameof(md), required: false);
            return new DeferredBodyAction<WordsResponseItem[]>(() =>
            {
                var apiCallPath = "/words";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ml != null)
                    callPayload.Queries["ml"] = ExpressionConverter.Convert(__workflow_ml);
                if (__workflow_sl != null)
                    callPayload.Queries["sl"] = ExpressionConverter.Convert(__workflow_sl);
                if (__workflow_sp != null)
                    callPayload.Queries["sp"] = ExpressionConverter.Convert(__workflow_sp);
                if (__workflow_relJja != null)
                    callPayload.Queries["rel_jja"] = ExpressionConverter.Convert(__workflow_relJja);
                if (__workflow_relJjb != null)
                    callPayload.Queries["rel_jjb"] = ExpressionConverter.Convert(__workflow_relJjb);
                if (__workflow_relSyn != null)
                    callPayload.Queries["rel_syn"] = ExpressionConverter.Convert(__workflow_relSyn);
                if (__workflow_relTrg != null)
                    callPayload.Queries["rel_trg"] = ExpressionConverter.Convert(__workflow_relTrg);
                if (__workflow_relAnt != null)
                    callPayload.Queries["rel_ant"] = ExpressionConverter.Convert(__workflow_relAnt);
                if (__workflow_relSpc != null)
                    callPayload.Queries["rel_spc"] = ExpressionConverter.Convert(__workflow_relSpc);
                if (__workflow_relGen != null)
                    callPayload.Queries["rel_gen"] = ExpressionConverter.Convert(__workflow_relGen);
                if (__workflow_relCom != null)
                    callPayload.Queries["rel_com"] = ExpressionConverter.Convert(__workflow_relCom);
                if (__workflow_relPar != null)
                    callPayload.Queries["rel_par"] = ExpressionConverter.Convert(__workflow_relPar);
                if (__workflow_relBga != null)
                    callPayload.Queries["rel_bga"] = ExpressionConverter.Convert(__workflow_relBga);
                if (__workflow_relBgb != null)
                    callPayload.Queries["rel_bgb"] = ExpressionConverter.Convert(__workflow_relBgb);
                if (__workflow_relRhy != null)
                    callPayload.Queries["rel_rhy"] = ExpressionConverter.Convert(__workflow_relRhy);
                if (__workflow_relNry != null)
                    callPayload.Queries["rel_nry"] = ExpressionConverter.Convert(__workflow_relNry);
                if (__workflow_relHom != null)
                    callPayload.Queries["rel_hom"] = ExpressionConverter.Convert(__workflow_relHom);
                if (__workflow_relCns != null)
                    callPayload.Queries["rel_cns"] = ExpressionConverter.Convert(__workflow_relCns);
                if (__workflow_v != null)
                    callPayload.Queries["v"] = ExpressionConverter.Convert(__workflow_v);
                if (__workflow_topics != null)
                    callPayload.Queries["topics"] = ExpressionConverter.Convert(__workflow_topics);
                if (__workflow_lc != null)
                    callPayload.Queries["lc"] = ExpressionConverter.Convert(__workflow_lc);
                if (__workflow_rc != null)
                    callPayload.Queries["rc"] = ExpressionConverter.Convert(__workflow_rc);
                callPayload.Queries["max"] = Convert.ToString(100);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_md != null)
                    callPayload.Queries["md"] = ExpressionConverter.Convert(__workflow_md);
                return new ApiConnectionAction<WordsResponseItem[]>(callPayload);
            });
        }
    }

    public class DatamuseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class WordsResponseItem
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("numSyllables")]
        public int NumSyllables { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip;

    public partial class WorkflowManagedActions
    {
        public DatamuseipActions Datamuseip(string connectionId) => new DatamuseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DatamuseipTriggers Datamuseip(string connectionId) => new DatamuseipTriggers(connectionId);
    }
}
