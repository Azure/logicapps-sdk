//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Text;

    interface ILogicExpressionVisitor<TOutput, TParam>
    {
        TOutput Visit(PartialFunctionCallNode node, TParam param);
        TOutput Visit(FunctionCallNode node, TParam param);
        TOutput Visit(LiteralNode node, TParam param);
        TOutput Visit(MemberAccessNode node, TParam param);

        TOutput Visit(ArrayNode node, TParam param);
        TOutput Visit(NullableNode node, TParam param);
        TOutput Visit(IndexNode node, TParam param);
    }

    internal abstract class LogicAppExpressionNode
    {
        public Type Type { get; set; }
    
        public abstract TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param);
    }

    internal class PartialFunctionCallNode : LogicAppExpressionNode
    {
        public string FunctionName { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }

    internal class NullableNode : LogicAppExpressionNode
    {
        public LogicAppExpressionNode Inner { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }

    internal class ArrayNode : LogicAppExpressionNode
    {
        public LogicAppExpressionNode[] Items { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }

    internal class FunctionCallNode : LogicAppExpressionNode
    {
        public string FunctionName { get; set; }
        public LogicAppExpressionNode[] Arguments { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }

    internal class IndexNode : LogicAppExpressionNode
    {
        public LogicAppExpressionNode Target { get; set; }
        public LogicAppExpressionNode Index { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }

    internal class LiteralNode : LogicAppExpressionNode
    {
        public object Value { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }

    internal class MemberAccessNode : LogicAppExpressionNode
    {
        public LogicAppExpressionNode Target { get; set; }
        public string MemberName { get; set; }

        public override TOutput Accept<TOutput, TParam>(ILogicExpressionVisitor<TOutput, TParam> visitor, TParam param)
        {
            return visitor.Visit(this, param);
        }
    }
}