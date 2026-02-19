//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Text;

    /// <summary>
    /// Renders Logic App expression nodes to their string representation.
    /// </summary>
    internal class LogicExpressionRenderer : ILogicExpressionVisitor<string, object>
    {
        /// <summary>
        /// Visits a partial function call node.
        /// </summary>
        public string Visit(PartialFunctionCallNode node, object param)
        {
            throw new NotSupportedException($"PartialFunctionCallNode rendering not supported. ({node.FunctionName})");
        }

        /// <summary>
        /// Visits an array node.
        /// </summary>
        public string Visit(ArrayNode node, object param)
        {
            throw new NotSupportedException("ArrayNode rendering not supported.");
        }

        /// <summary>
        /// Visits a nullable node. The null-safe dereference operator '?' is not appended here;
        /// it is emitted by the consuming node (MemberAccessNode, IndexNode) when appropriate.
        /// </summary>
        public string Visit(NullableNode node, object param)
        {
            return node.Inner.Accept(this, param);
        }

        /// <summary>
        /// Renders a function call node with its arguments.
        /// </summary>
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
        /// Renders a literal node with appropriate formatting based on its type.
        /// </summary>
        public string Visit(LiteralNode node, object param)
        {
            if (node.Value == null)
            {
                return "null";
            }
            else if (node.Value is string str)
            {
                return $"'{str}'"; // Escape single quotes if necessary
            }
            else if (node.Value is bool b)
            {
                return b ? "true" : "false";
            }
            else if (node.Value is int || node.Value is double || node.Value is float || node.Value is long)
            {
                return node.Value.ToString();
            }
            else if (node.Value is DateTime dt)
            {
                return dt.ToString("o"); // ISO 8601 format
            }
            else
            {
                return node.Value.ToString();
            }
        }

        /// <summary>
        /// Renders a member access node with bracket notation.
        /// Prepends the null-safe dereference operator '?' if the target is a nullable node.
        /// </summary>
        public string Visit(MemberAccessNode node, object param)
        {
            var nullSafe = node.Target is NullableNode ? "?" : "";
            return $"{node.Target.Accept(this, param)}{nullSafe}['{node.MemberName}']";
        }

        /// <summary>
        /// Renders an index access node.
        /// Prepends the null-safe dereference operator '?' if the target is a nullable node.
        /// </summary>
        public string Visit(IndexNode node, object param)
        {
            var nullSafe = node.Target is NullableNode ? "?" : "";
            return $"{node.Target.Accept(this, param)}{nullSafe}[{node.Index.Accept(this, param)}]";
        }
    }

    /// <summary>
    /// Extension methods for rendering Logic App expression nodes.
    /// </summary>
    internal static class LogicExpressionExtensions
    {
        /// <summary>
        /// Renders a Logic App expression node to its string representation.
        /// </summary>
        public static string Render(this LogicAppExpressionNode node, bool forceInline = false)
        {
            // Special case: handle concat functions by rendering literals directly and other arguments as inline expressions
            if (node is FunctionCallNode fn && fn.FunctionName == "concat")
            {
                var sb = new StringBuilder();
                foreach (var arg in fn.Arguments)
                {
                    if (arg is LiteralNode literal)
                    {
                        // Render literal values directly without expression markers
                        sb.Append(literal.Value);
                    }
                    else
                    {
                        // Render non-literal arguments as inline expressions
                        var expr = arg.Accept(new LogicExpressionRenderer(), null);
                        sb.Append("@{");
                        sb.Append(expr);
                        sb.Append("}");
                    }
                }

                return sb.ToString();
            }

            // Special case: if top-level node is a string literal, return the string directly
            if (node is LiteralNode lit)
            {
                return lit.Value?.ToString() ?? string.Empty;
            }

            // Render the expression with appropriate notation based on forceInline flag
            if (forceInline)
            {
                return "@{" + node.Accept(new LogicExpressionRenderer(), null) + "}";
            }

            return "@" + node.Accept(new LogicExpressionRenderer(), null);
        }
    }
}
