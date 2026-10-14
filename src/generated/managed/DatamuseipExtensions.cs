//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DatamuseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datamuseip")]
        public IBodyWorkflowAction<WordsResponseItem[]> Words(Expression<Func<string>> ml = null, Expression<Func<string>> sl = null, Expression<Func<string>> sp = null, Expression<Func<string>> relJja = null, Expression<Func<string>> relJjb = null, Expression<Func<string>> relSyn = null, Expression<Func<string>> relTrg = null, Expression<Func<string>> relAnt = null, Expression<Func<string>> relSpc = null, Expression<Func<string>> relGen = null, Expression<Func<string>> relCom = null, Expression<Func<string>> relPar = null, Expression<Func<string>> relBga = null, Expression<Func<string>> relBgb = null, Expression<Func<string>> relRhy = null, Expression<Func<string>> relNry = null, Expression<Func<string>> relHom = null, Expression<Func<string>> relCns = null, Expression<Func<string>> v = null, Expression<Func<string>> topics = null, Expression<Func<string>> lc = null, Expression<Func<string>> rc = null, Expression<Func<int>> max = null, Expression<Func<string>> md = null)
        {
            var __workflow_ml = ml == null ? null : WorkflowExpression.Compile(ml);
            WorkflowExpression.Validate(__workflow_ml, nameof(ml), required: false);
            var __workflow_sl = sl == null ? null : WorkflowExpression.Compile(sl);
            WorkflowExpression.Validate(__workflow_sl, nameof(sl), required: false);
            var __workflow_sp = sp == null ? null : WorkflowExpression.Compile(sp);
            WorkflowExpression.Validate(__workflow_sp, nameof(sp), required: false);
            var __workflow_relJja = relJja == null ? null : WorkflowExpression.Compile(relJja);
            WorkflowExpression.Validate(__workflow_relJja, nameof(relJja), required: false);
            var __workflow_relJjb = relJjb == null ? null : WorkflowExpression.Compile(relJjb);
            WorkflowExpression.Validate(__workflow_relJjb, nameof(relJjb), required: false);
            var __workflow_relSyn = relSyn == null ? null : WorkflowExpression.Compile(relSyn);
            WorkflowExpression.Validate(__workflow_relSyn, nameof(relSyn), required: false);
            var __workflow_relTrg = relTrg == null ? null : WorkflowExpression.Compile(relTrg);
            WorkflowExpression.Validate(__workflow_relTrg, nameof(relTrg), required: false);
            var __workflow_relAnt = relAnt == null ? null : WorkflowExpression.Compile(relAnt);
            WorkflowExpression.Validate(__workflow_relAnt, nameof(relAnt), required: false);
            var __workflow_relSpc = relSpc == null ? null : WorkflowExpression.Compile(relSpc);
            WorkflowExpression.Validate(__workflow_relSpc, nameof(relSpc), required: false);
            var __workflow_relGen = relGen == null ? null : WorkflowExpression.Compile(relGen);
            WorkflowExpression.Validate(__workflow_relGen, nameof(relGen), required: false);
            var __workflow_relCom = relCom == null ? null : WorkflowExpression.Compile(relCom);
            WorkflowExpression.Validate(__workflow_relCom, nameof(relCom), required: false);
            var __workflow_relPar = relPar == null ? null : WorkflowExpression.Compile(relPar);
            WorkflowExpression.Validate(__workflow_relPar, nameof(relPar), required: false);
            var __workflow_relBga = relBga == null ? null : WorkflowExpression.Compile(relBga);
            WorkflowExpression.Validate(__workflow_relBga, nameof(relBga), required: false);
            var __workflow_relBgb = relBgb == null ? null : WorkflowExpression.Compile(relBgb);
            WorkflowExpression.Validate(__workflow_relBgb, nameof(relBgb), required: false);
            var __workflow_relRhy = relRhy == null ? null : WorkflowExpression.Compile(relRhy);
            WorkflowExpression.Validate(__workflow_relRhy, nameof(relRhy), required: false);
            var __workflow_relNry = relNry == null ? null : WorkflowExpression.Compile(relNry);
            WorkflowExpression.Validate(__workflow_relNry, nameof(relNry), required: false);
            var __workflow_relHom = relHom == null ? null : WorkflowExpression.Compile(relHom);
            WorkflowExpression.Validate(__workflow_relHom, nameof(relHom), required: false);
            var __workflow_relCns = relCns == null ? null : WorkflowExpression.Compile(relCns);
            WorkflowExpression.Validate(__workflow_relCns, nameof(relCns), required: false);
            var __workflow_v = v == null ? null : WorkflowExpression.Compile(v);
            WorkflowExpression.Validate(__workflow_v, nameof(v), required: false);
            var __workflow_topics = topics == null ? null : WorkflowExpression.Compile(topics);
            WorkflowExpression.Validate(__workflow_topics, nameof(topics), required: false);
            var __workflow_lc = lc == null ? null : WorkflowExpression.Compile(lc);
            WorkflowExpression.Validate(__workflow_lc, nameof(lc), required: false);
            var __workflow_rc = rc == null ? null : WorkflowExpression.Compile(rc);
            WorkflowExpression.Validate(__workflow_rc, nameof(rc), required: false);
            var __workflow_max = max == null ? null : WorkflowExpression.Compile(max);
            WorkflowExpression.Validate(__workflow_max, nameof(max), required: false);
            var __workflow_md = md == null ? null : WorkflowExpression.Compile(md);
            WorkflowExpression.Validate(__workflow_md, nameof(md), required: false);
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
