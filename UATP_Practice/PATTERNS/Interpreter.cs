using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Here's an example of how the Interpreter pattern can be applied to implement a simple SQL query evaluator in C#:
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // We start by defining the SqlExpression class, which is the abstract base class for
    // all SQL expressions. It declares an abstract method Interpret that will be
    // implemented by its subclasses.
    // ------------------------------------------------------------------------------------

    // The abstract expression class
    public abstract class SqlExpression
    {
        public abstract void Interpret(StringBuilder sb);
    }

    // ------------------------------------------------------------------------------------
    // Next, we define several concrete expression classes:
    // - SelectExpression represents the SELECT clause of the SQL query.It takes an array of
    //   column names and overrides the Interpret method to append the SELECT snippet to the query.
    // - FromExpression represents the FROM clause of the SQL query. It takes a table name
    //   and appends the FROM snippet to the query in its Interpret method.
    // - WhereExpression represents the WHERE clause of the SQL query.It takes a condition
    //   and appends the WHERE snippet to the query in its Interpret method.
    // - OrderByExpression represents the ORDER BY clause of the SQL query. It takes a column
    //   name and appends the ORDER BY snippet to the query in its Interpret method.
    // ------------------------------------------------------------------------------------

    // The terminal expression class for selecting columns
    public class SelectExpression : SqlExpression
    {
        private string[] columns;

        public SelectExpression(string[] columns)
        {
            this.columns = columns;
        }

        public override void Interpret(StringBuilder sb)
        {
            sb.Append("SELECT ");
            sb.Append(string.Join(", ", columns));
        }
    }

    // The terminal expression class for specifying the table
    public class FromExpression : SqlExpression
    {
        private string table;

        public FromExpression(string table)
        {
            this.table = table;
        }

        public override void Interpret(StringBuilder sb)
        {
            sb.Append(" FROM ");
            sb.Append(table);
        }
    }

    // The terminal expression class for applying a WHERE condition
    public class WhereExpression : SqlExpression
    {
        private string condition;

        public WhereExpression(string condition)
        {
            this.condition = condition;
        }

        public override void Interpret(StringBuilder sb)
        {
            sb.Append(" WHERE ");
            sb.Append(condition);
        }
    }

    // The terminal expression class for specifying the ORDER BY clause
    public class OrderByExpression : SqlExpression
    {
        private string column;

        public OrderByExpression(string column)
        {
            this.column = column;
        }

        public override void Interpret(StringBuilder sb)
        {
            sb.Append(" ORDER BY ");
            sb.Append(column);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // By using the Interpreter pattern, we can break down the construction of a complex SQL query into individual expression objects.
    // Each expression represents a specific part of the query and is responsible for interpreting and appending its corresponding SQL
    // snippet. This approach allows us to build and modify SQL queries flexibly and dynamically by combining different expressions based
    // on our requirements.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In summary, the Interpreter pattern helps you define a language, break it down into manageable parts, and create rules for
    // interpreting and evaluating those parts. It allows you to build complex expressions or sentences and execute them based on the
    // defined language rules.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
