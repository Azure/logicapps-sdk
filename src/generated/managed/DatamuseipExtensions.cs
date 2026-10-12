//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatamuseipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datamuseip")]
        [WorkflowExpressionFactory(nameof(__BuildWords))]
        public IBodyWorkflowAction<WordsResponseItem[]> Words([WorkflowExpression] Func<string> ml = null, [WorkflowExpression] Func<string> sl = null, [WorkflowExpression] Func<string> sp = null, [WorkflowExpression] Func<string> relJja = null, [WorkflowExpression] Func<string> relJjb = null, [WorkflowExpression] Func<string> relSyn = null, [WorkflowExpression] Func<string> relTrg = null, [WorkflowExpression] Func<string> relAnt = null, [WorkflowExpression] Func<string> relSpc = null, [WorkflowExpression] Func<string> relGen = null, [WorkflowExpression] Func<string> relCom = null, [WorkflowExpression] Func<string> relPar = null, [WorkflowExpression] Func<string> relBga = null, [WorkflowExpression] Func<string> relBgb = null, [WorkflowExpression] Func<string> relRhy = null, [WorkflowExpression] Func<string> relNry = null, [WorkflowExpression] Func<string> relHom = null, [WorkflowExpression] Func<string> relCns = null, [WorkflowExpression] Func<string> v = null, [WorkflowExpression] Func<string> topics = null, [WorkflowExpression] Func<string> lc = null, [WorkflowExpression] Func<string> rc = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<string> md = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WordsResponseItem[]> __BuildWords(WorkflowExpression<string> ml = null, WorkflowExpression<string> sl = null, WorkflowExpression<string> sp = null, WorkflowExpression<string> relJja = null, WorkflowExpression<string> relJjb = null, WorkflowExpression<string> relSyn = null, WorkflowExpression<string> relTrg = null, WorkflowExpression<string> relAnt = null, WorkflowExpression<string> relSpc = null, WorkflowExpression<string> relGen = null, WorkflowExpression<string> relCom = null, WorkflowExpression<string> relPar = null, WorkflowExpression<string> relBga = null, WorkflowExpression<string> relBgb = null, WorkflowExpression<string> relRhy = null, WorkflowExpression<string> relNry = null, WorkflowExpression<string> relHom = null, WorkflowExpression<string> relCns = null, WorkflowExpression<string> v = null, WorkflowExpression<string> topics = null, WorkflowExpression<string> lc = null, WorkflowExpression<string> rc = null, WorkflowExpression<int> max = null, WorkflowExpression<string> md = null)
        {
            WorkflowExpression.Validate(ml, nameof(ml), required: false);
            WorkflowExpression.Validate(sl, nameof(sl), required: false);
            WorkflowExpression.Validate(sp, nameof(sp), required: false);
            WorkflowExpression.Validate(relJja, nameof(relJja), required: false);
            WorkflowExpression.Validate(relJjb, nameof(relJjb), required: false);
            WorkflowExpression.Validate(relSyn, nameof(relSyn), required: false);
            WorkflowExpression.Validate(relTrg, nameof(relTrg), required: false);
            WorkflowExpression.Validate(relAnt, nameof(relAnt), required: false);
            WorkflowExpression.Validate(relSpc, nameof(relSpc), required: false);
            WorkflowExpression.Validate(relGen, nameof(relGen), required: false);
            WorkflowExpression.Validate(relCom, nameof(relCom), required: false);
            WorkflowExpression.Validate(relPar, nameof(relPar), required: false);
            WorkflowExpression.Validate(relBga, nameof(relBga), required: false);
            WorkflowExpression.Validate(relBgb, nameof(relBgb), required: false);
            WorkflowExpression.Validate(relRhy, nameof(relRhy), required: false);
            WorkflowExpression.Validate(relNry, nameof(relNry), required: false);
            WorkflowExpression.Validate(relHom, nameof(relHom), required: false);
            WorkflowExpression.Validate(relCns, nameof(relCns), required: false);
            WorkflowExpression.Validate(v, nameof(v), required: false);
            WorkflowExpression.Validate(topics, nameof(topics), required: false);
            WorkflowExpression.Validate(lc, nameof(lc), required: false);
            WorkflowExpression.Validate(rc, nameof(rc), required: false);
            WorkflowExpression.Validate(max, nameof(max), required: false);
            WorkflowExpression.Validate(md, nameof(md), required: false);
            return new DeferredBodyAction<WordsResponseItem[]>(() =>
            {
                var apiCallPath = "/words";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ml != null)
                    callPayload.Queries["ml"] = ExpressionConverter.Convert(ml);
                if (sl != null)
                    callPayload.Queries["sl"] = ExpressionConverter.Convert(sl);
                if (sp != null)
                    callPayload.Queries["sp"] = ExpressionConverter.Convert(sp);
                if (relJja != null)
                    callPayload.Queries["rel_jja"] = ExpressionConverter.Convert(relJja);
                if (relJjb != null)
                    callPayload.Queries["rel_jjb"] = ExpressionConverter.Convert(relJjb);
                if (relSyn != null)
                    callPayload.Queries["rel_syn"] = ExpressionConverter.Convert(relSyn);
                if (relTrg != null)
                    callPayload.Queries["rel_trg"] = ExpressionConverter.Convert(relTrg);
                if (relAnt != null)
                    callPayload.Queries["rel_ant"] = ExpressionConverter.Convert(relAnt);
                if (relSpc != null)
                    callPayload.Queries["rel_spc"] = ExpressionConverter.Convert(relSpc);
                if (relGen != null)
                    callPayload.Queries["rel_gen"] = ExpressionConverter.Convert(relGen);
                if (relCom != null)
                    callPayload.Queries["rel_com"] = ExpressionConverter.Convert(relCom);
                if (relPar != null)
                    callPayload.Queries["rel_par"] = ExpressionConverter.Convert(relPar);
                if (relBga != null)
                    callPayload.Queries["rel_bga"] = ExpressionConverter.Convert(relBga);
                if (relBgb != null)
                    callPayload.Queries["rel_bgb"] = ExpressionConverter.Convert(relBgb);
                if (relRhy != null)
                    callPayload.Queries["rel_rhy"] = ExpressionConverter.Convert(relRhy);
                if (relNry != null)
                    callPayload.Queries["rel_nry"] = ExpressionConverter.Convert(relNry);
                if (relHom != null)
                    callPayload.Queries["rel_hom"] = ExpressionConverter.Convert(relHom);
                if (relCns != null)
                    callPayload.Queries["rel_cns"] = ExpressionConverter.Convert(relCns);
                if (v != null)
                    callPayload.Queries["v"] = ExpressionConverter.Convert(v);
                if (topics != null)
                    callPayload.Queries["topics"] = ExpressionConverter.Convert(topics);
                if (lc != null)
                    callPayload.Queries["lc"] = ExpressionConverter.Convert(lc);
                if (rc != null)
                    callPayload.Queries["rc"] = ExpressionConverter.Convert(rc);
                callPayload.Queries["max"] = Convert.ToString(100);
                if (max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(max);
                if (md != null)
                    callPayload.Queries["md"] = ExpressionConverter.Convert(md);
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