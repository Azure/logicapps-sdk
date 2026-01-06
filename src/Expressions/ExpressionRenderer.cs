//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Text;

    /// <summary>
    /// Renders logic expression nodes to their string representation.
    /// </summary>
    internal class LogicExpressionRenderer : ILogicExpressionVisitor<string, object>
    {
        /// <summary>
        /// Visits a partial function call node.
        /// </summary>
        /// <param name="node">The partial function call node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(PartialFunctionCallNode node, object param)
        {
            throw new NotSupportedException($"PartialFunctionCallNode rendering not supported. ({node.FunctionName})");
        }

        /// <summary>
        /// Visits an array node.
        /// </summary>
        /// <param name="node">The array node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(ArrayNode node, object param)
        {
            throw new NotSupportedException("ArrayNode rendering not supported.");
        }
        
        /// <summary>
        /// Visits a nullable node.
        /// </summary>
        /// <param name="node">The nullable node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(NullableNode node, object param)
        {
            return node.Inner.Accept(this, param) + "?";
        }

        /// <summary>
        /// Visits a function call node.
        /// </summary>
        /// <param name="node">The function call node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(FunctionCallNode node, object param)
        {
            var sb = new StringBuilder();

            if (node.Arguments != null && node.Arguments.Any())
            {
                var args = string.Join(", ", node.Arguments.Select(a => a.Accept(this, param)));
                sb.Append(node.FunctionName);
                sb.Append('(');
                sb.Append(args);
                sb.Append(')');
            }
            else
            {
                sb.Append(node.FunctionName);
                sb.Append("()");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Visits a literal node.
        /// </summary>
        /// <param name="node">The literal node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(LiteralNode node, object param)
        {
            if (node.Value == null)
                return "null";
            else if (node.Value is string str)
            {
                return $"'{str}'"; // Escape single quotes if necessary
            }
            else if (node.Value is bool b)
                return b ? "true" : "false";
            else if (node.Value is int || node.Value is double || node.Value is float || node.Value is long)
                return node.Value.ToString();
            else if (node.Value is DateTime dt)
                return dt.ToString("o"); // ISO 8601 format
            else
                return node.Value.ToString();
        }

        /// <summary>
        /// Visits a member access node.
        /// </summary>
        /// <param name="node">The member access node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(MemberAccessNode node, object param)
        {
            return $"{node.Target.Accept(this, param)}['{node.MemberName}']";
        }

        /// <summary>
        /// Visits an index node.
        /// </summary>
        /// <param name="node">The index node to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public string Visit(IndexNode node, object param)
        {
            return $"{node.Target.Accept(this, param)}[{node.Index.Accept(this, param)}]";
        }
    }

    /// <summary>
    /// Extension methods for rendering logic expression nodes.
    /// </summary>
    internal static class LogicExpressionExtensions
    {
        /// <summary>
        /// Renders a logic app expression node to its string representation.
        /// </summary>
        /// <param name="node">The expression node to render.</param>
        /// <param name="forceInline">Whether to force inline rendering with @ prefix.</param>
        public static string Render(this LogicAppExpressionNode node, bool forceInline = false)
        {
            if (node is FunctionCallNode fn && fn.FunctionName == "concat")
            {
                var sb = new StringBuilder();
                // Special case: if top-level function is concat, render literals directly
                foreach (var arg in fn.Arguments)
                {
                    if (arg is LiteralNode lit)
                    {
                        sb.Append(lit.Value);
                        // Just return the string value directly
                    }
                    else
                    {
                        var expr = arg.Accept(new LogicExpressionRenderer(), null);
                        sb.Append("@{");
                        sb.Append(expr);
                        sb.Append("}");
                    }
                }

                return sb.ToString();
            }
            else if (node is LiteralNode lit)
            {
                // Special case: if top-level node is a string literal, return the string directly
                return lit.Value?.ToString() ?? string.Empty;
            }

            if (forceInline)
                return "@{" + node.Accept(new LogicExpressionRenderer(), null) + "}";

            return "@" + node.Accept(new LogicExpressionRenderer(), null);
        }
    }
}
