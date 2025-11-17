namespace Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.Expressions;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;
internal class ExpressionConverter
{
    public static string Convert(Expression<Func<string>> e)
    {
        if (e == null) return string.Empty;
        var converter = new LogicConverter();
        var expr = e.Body.Visit(converter, null);
        return expr.Render();
    }

    public static string Convert(Expression<Func<Uri>> e)
    {
        if (e == null) return string.Empty;
        var converter = new LogicConverter();
        var expr = e.Body.Visit(converter, null);
        return expr.Render();
    }

    public static string Convert(Expression<Func<HttpMethod>> e)
    {
        if (e == null) return string.Empty;
        var converter = new LogicConverter();
        var expr = e.Body.Visit(converter, null);
        return expr.Render();
    }

    public static string ConvertWithUrlEncoding(Expression<Func<string>> e, int times)
    {
        if (e == null) return string.Empty;
        var converter = new LogicConverter();
        var expr = e.Body.Visit(converter, null);

        while (times > 0)
        {
            expr = new FunctionCallNode
            {
                FunctionName = "encodeURIComponent",
                Arguments = [expr]
            };

            times--;
        }

        return expr.Render(true);
    }

    public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> e, int times) where T : Enum
    {
        var value = e.Compile().Invoke();
        var converted = Utility.GetEnumMemberValue(value);
        return ConvertWithUrlEncoding(() => converted, times);
    }

    public static string Convert(Expression<Func<int>> e)
    {
        var visitor = new Visitor();
        visitor.Visit(e.Body);
        return visitor.Result;
    }

    public static string Convert(Expression<Func<double>> e)
    {
        var visitor = new Visitor();
        visitor.Visit(e.Body);
        return visitor.Result;
    }

    public static string Convert<T>(Expression<Func<T>> e) where T : Enum
    {
        var value = e.Compile().Invoke();
        var converted = Utility.GetEnumMemberValue(value);
        Console.WriteLine("Converted enum value: " + converted + " from " + value);
        return converted;
    }

    public static string Convert(Expression<Func<bool>> e)
    {
        var visitor = new Visitor();
        visitor.Visit(e.Body);
        return visitor.Result;
    }

    public static JToken ConvertO<T>(Expression<Func<T>> e) where T : class
    {
        var converter = new ComplexObjectConverter();
        return e.Body.Visit(converter, null);
    }

    public static TResult ConvertObject<TResult>(Expression<Func<TResult>> e)
    {
        var objConvert = new ObjectExpressionConverter();
        var converted = objConvert.Visit(e.Body);

        Console.WriteLine("Converted: " + converted);

        var newLambda = Expression.Lambda<Func<TResult>>(converted, e.Parameters);
        var compiled = newLambda.Compile();
        return compiled();
    }

    class ObjectExpressionConverter : ExpressionVisitor
    {
        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            var shouldConvert =
                (node.Member is System.Reflection.PropertyInfo propertyInfo && propertyInfo.PropertyType == typeof(string)) ||
                (node.Member is System.Reflection.FieldInfo fieldInfo && fieldInfo.FieldType == typeof(string));

            if (shouldConvert)
            {
                Console.WriteLine("Assigned member is a string field: " + node.Member.Name);
                var logicConverter = new LogicConverter();
                var newExpression = node.Expression.Visit(logicConverter, null);
                return Expression.Bind(
                    node.Member,
                    Expression.Constant(newExpression.Render(), typeof(string))
                );
            }
            return base.VisitMemberAssignment(node);
        }
    }
    

    class Visitor : ExpressionVisitor
    {
        public string Result { get; private set; }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Visit(node.Left);
            var left = Result;
            Visit(node.Right);
            var right = Result;

            Result = left + right;
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            Result = node.Value?.ToString();
            return node;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            throw new NotSupportedException("ParameterExpression not supported in this context.");
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            throw new NotSupportedException("MemberExpression not supported in this context.");
        }

        public override Expression Visit(Expression node)
        {
            Console.WriteLine("Unhandled Expression : " + node.NodeType + " - " + node.Type.Name);
            return base.Visit(node);
        }
    }
}
