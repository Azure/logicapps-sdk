//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;

    internal static class ExpressionExtensions
    {
        public static TReturn Visit<TReturn, TParam>(this Expression e, IExpressionVisitor<TReturn, TParam> visitor, TParam p)
        {
            switch (e.NodeType)
            {
                // BinaryExpression
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
                    return visitor.Visit((BinaryExpression)e, p);

                // UnaryExpression
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
                    return visitor.Visit((UnaryExpression)e, p);

                // ConstantExpression
                case ExpressionType.Constant:
                    return visitor.Visit((ConstantExpression)e, p);

                // ParameterExpression
                case ExpressionType.Parameter:
                    return visitor.Visit((ParameterExpression)e, p);

                // MethodCallExpression
                case ExpressionType.Call:
                    return visitor.Visit((MethodCallExpression)e, p);

                // ConditionalExpression
                case ExpressionType.Conditional:
                    return visitor.Visit((ConditionalExpression)e, p);

                // InvocationExpression
                case ExpressionType.Invoke:
                    return visitor.Visit((InvocationExpression)e, p);

                // LambdaExpression
                case ExpressionType.Lambda:
                    return visitor.Visit((LambdaExpression)e, p);

                // ListInitExpression
                case ExpressionType.ListInit:
                    return visitor.Visit((ListInitExpression)e, p);

                // MemberExpression
                case ExpressionType.MemberAccess:
                    return visitor.Visit((MemberExpression)e, p);

                // MemberInitExpression
                case ExpressionType.MemberInit:
                    return visitor.Visit((MemberInitExpression)e, p);

                // NewExpression
                case ExpressionType.New:
                    return visitor.Visit((NewExpression)e, p);

                // NewArrayExpression
                case ExpressionType.NewArrayInit:
                case ExpressionType.NewArrayBounds:
                    return visitor.Visit((NewArrayExpression)e, p);

                // TypeBinaryExpression
                case ExpressionType.TypeIs:
                    return visitor.Visit((TypeBinaryExpression)e, p);

                // BlockExpression
                case ExpressionType.Block:
                    return visitor.Visit((BlockExpression)e, p);

                // DebugInfoExpression
                case ExpressionType.DebugInfo:
                    return visitor.Visit((DebugInfoExpression)e, p);

                // DefaultExpression
                case ExpressionType.Default:
                    return visitor.Visit((DefaultExpression)e, p);

                // DynamicExpression
                case ExpressionType.Dynamic:
                    return visitor.Visit((DynamicExpression)e, p);

                /*
                            // Extension (base Expression)
                            case ExpressionType.Extension:
                                return visitor.Visit((Expression)e, p);
                */

                // GotoExpression
                case ExpressionType.Goto:
                    return visitor.Visit((GotoExpression)e, p);

                // IndexExpression
                case ExpressionType.Index:
                    return visitor.Visit((IndexExpression)e, p);

                // LabelExpression
                case ExpressionType.Label:
                    return visitor.Visit((LabelExpression)e, p);

                // RuntimeVariablesExpression
                case ExpressionType.RuntimeVariables:
                    return visitor.Visit((RuntimeVariablesExpression)e, p);

                // SwitchExpression
                case ExpressionType.Switch:
                    return visitor.Visit((SwitchExpression)e, p);

                // TryExpression
                case ExpressionType.Try:
                    return visitor.Visit((TryExpression)e, p);

                default:
                    throw new NotSupportedException($"Expression type {e.NodeType} not supported.");
            }
        }

    }
}