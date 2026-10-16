//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Linq.Expressions;

    internal static class ExpressionExtensions
    {
        internal static TReturn Dispatch<TReturn>(
            this Expression expression,
            IExpressionVisitor<TReturn> visitor)
        {
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            if (visitor == null) throw new ArgumentNullException(nameof(visitor));

            switch (expression.NodeType)
            {
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                case ExpressionType.ArrayIndex:
                case ExpressionType.Coalesce:
                case ExpressionType.Divide:
                case ExpressionType.Equal:
                case ExpressionType.ExclusiveOr:
                case ExpressionType.LeftShift:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.Modulo:
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                case ExpressionType.NotEqual:
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                case ExpressionType.Power:
                case ExpressionType.RightShift:
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                case ExpressionType.Assign:
                case ExpressionType.AddAssign:
                case ExpressionType.AndAssign:
                case ExpressionType.DivideAssign:
                case ExpressionType.ExclusiveOrAssign:
                case ExpressionType.LeftShiftAssign:
                case ExpressionType.ModuloAssign:
                case ExpressionType.MultiplyAssign:
                case ExpressionType.OrAssign:
                case ExpressionType.PowerAssign:
                case ExpressionType.RightShiftAssign:
                case ExpressionType.SubtractAssign:
                    return visitor.Visit((BinaryExpression)expression);

                case ExpressionType.ArrayLength:
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                case ExpressionType.Negate:
                case ExpressionType.UnaryPlus:
                case ExpressionType.NegateChecked:
                case ExpressionType.Not:
                case ExpressionType.Quote:
                case ExpressionType.TypeAs:
                case ExpressionType.Throw:
                case ExpressionType.Unbox:
                case ExpressionType.PreIncrementAssign:
                case ExpressionType.PreDecrementAssign:
                case ExpressionType.PostIncrementAssign:
                case ExpressionType.PostDecrementAssign:
                    return visitor.Visit((UnaryExpression)expression);

                case ExpressionType.Constant: return visitor.Visit((ConstantExpression)expression);
                case ExpressionType.Parameter: return visitor.Visit((ParameterExpression)expression);
                case ExpressionType.Call: return visitor.Visit((MethodCallExpression)expression);
                case ExpressionType.Conditional: return visitor.Visit((ConditionalExpression)expression);
                case ExpressionType.Invoke: return visitor.Visit((InvocationExpression)expression);
                case ExpressionType.Lambda: return visitor.Visit((LambdaExpression)expression);
                case ExpressionType.ListInit: return visitor.Visit((ListInitExpression)expression);
                case ExpressionType.MemberAccess: return visitor.Visit((MemberExpression)expression);
                case ExpressionType.MemberInit: return visitor.Visit((MemberInitExpression)expression);
                case ExpressionType.New: return visitor.Visit((NewExpression)expression);
                case ExpressionType.NewArrayInit:
                case ExpressionType.NewArrayBounds:
                    return visitor.Visit((NewArrayExpression)expression);
                case ExpressionType.TypeIs: return visitor.Visit((TypeBinaryExpression)expression);
                case ExpressionType.Block: return visitor.Visit((BlockExpression)expression);
                case ExpressionType.DebugInfo: return visitor.Visit((DebugInfoExpression)expression);
                case ExpressionType.Default: return visitor.Visit((DefaultExpression)expression);
                case ExpressionType.Dynamic: return visitor.Visit((DynamicExpression)expression);
                case ExpressionType.Goto: return visitor.Visit((GotoExpression)expression);
                case ExpressionType.Index: return visitor.Visit((IndexExpression)expression);
                case ExpressionType.Label: return visitor.Visit((LabelExpression)expression);
                case ExpressionType.RuntimeVariables: return visitor.Visit((RuntimeVariablesExpression)expression);
                case ExpressionType.Switch: return visitor.Visit((SwitchExpression)expression);
                case ExpressionType.Try: return visitor.Visit((TryExpression)expression);
                default:
                    throw new NotSupportedException($"Expression type {expression.NodeType} is unsupported.");
            }
        }
    }
}
