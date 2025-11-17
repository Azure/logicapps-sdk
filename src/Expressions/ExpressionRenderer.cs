//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Text;

    internal class LogicExpressionRenderer : ILogicExpressionVisitor<string, object>
    {
        public string Visit(PartialFunctionCallNode node, object param)
        {
            throw new NotSupportedException($"PartialFunctionCallNode rendering not supported. ({node.FunctionName})");
        }

        public string Visit(ArrayNode node, object param)
        {
            throw new NotSupportedException("ArrayNode rendering not supported.");
        }
        
        public string Visit(NullableNode node, object param)
        {
            return node.Inner.Accept(this, param) + "?";
        }

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

        public string Visit(MemberAccessNode node, object param)
        {
            return $"{node.Target.Accept(this, param)}['{node.MemberName}']";
        }

        public string Visit(IndexNode node, object param)
        {
            return $"{node.Target.Accept(this, param)}[{node.Index.Accept(this, param)}]";
        }
    }

    internal static class LogicExpressionExtensions
    {
        public static string Render(this LogicAppExpressionNode node, bool forceInline = false)
        {
            
            Console.WriteLine($"Rendering expression of type {node.GetType().Name}");

            if (node is FunctionCallNode asdf)
            {
                Console .WriteLine($"FunctionCallNode: {asdf.FunctionName} with {asdf.Arguments.Length} arguments"); ;
            }

            if (node is FunctionCallNode fn && fn.FunctionName == "concat")
                {
                    Console.WriteLine("Rendering concat function with special handling.");
                    var sb = new StringBuilder();
                    // Special case: if top-level function is concat, render literals directly
                    foreach (var arg in fn.Arguments)
                    {
                        Console.WriteLine($"Concat argument type: {arg.GetType().Name}");
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

                    Console.WriteLine("Rendered concat expression: " + sb.ToString());
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
