using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQueryBuilderWithBackendConfiguration.Models
{
    [Serializable]
    public class QueryBuilderSettings
    {
        public List<QueryBuilderFilter> filters { get; set; }
    }
    public class QueryBuilderFilter
    {
        public string id { get; set; }
        public string label { get; set; }
        public string type { get; set; }
        public List<string> operators { get; set; }
        public string input { get; set; }
        public string optgroup { get; set; }//ms
        public Dictionary<string, string> values { get; set; }

        public QueryBuilderFilter()
        {

        }
    }

    public static class Operators
    {
        public static List<QueryBuilderFilterOperators> DefaultTextOperators = new List<QueryBuilderFilterOperators>
        {
            QueryBuilderFilterOperators.equal,
            QueryBuilderFilterOperators.not_equal,
            QueryBuilderFilterOperators.@in,
            QueryBuilderFilterOperators.not_in,
            QueryBuilderFilterOperators.less,
            QueryBuilderFilterOperators.less_or_equal,
            QueryBuilderFilterOperators.greater,
            QueryBuilderFilterOperators.greater_or_equal,
            QueryBuilderFilterOperators.between,
            QueryBuilderFilterOperators.not_between,
            QueryBuilderFilterOperators.begins_with,
            QueryBuilderFilterOperators.not_begins_with,
            QueryBuilderFilterOperators.contains,
            QueryBuilderFilterOperators.not_contains,
            QueryBuilderFilterOperators.ends_with,
            QueryBuilderFilterOperators.not_ends_with,
            QueryBuilderFilterOperators.is_empty,
            QueryBuilderFilterOperators.is_not_empty,
            QueryBuilderFilterOperators.is_null,
            QueryBuilderFilterOperators.is_not_null
        };

        public static List<QueryBuilderFilterOperators> DefaultTextAreaOperators = new List<QueryBuilderFilterOperators>
        {
            QueryBuilderFilterOperators.equal,
            QueryBuilderFilterOperators.not_equal,
            QueryBuilderFilterOperators.@in,
            QueryBuilderFilterOperators.not_in,
            QueryBuilderFilterOperators.less,
            QueryBuilderFilterOperators.less_or_equal,
            QueryBuilderFilterOperators.greater,
            QueryBuilderFilterOperators.greater_or_equal,
            QueryBuilderFilterOperators.between,
            QueryBuilderFilterOperators.not_between,
            QueryBuilderFilterOperators.begins_with,
            QueryBuilderFilterOperators.not_begins_with,
            QueryBuilderFilterOperators.contains,
            QueryBuilderFilterOperators.not_contains,
            QueryBuilderFilterOperators.ends_with,
            QueryBuilderFilterOperators.not_ends_with,
            QueryBuilderFilterOperators.is_empty,
            QueryBuilderFilterOperators.is_not_empty,
            QueryBuilderFilterOperators.is_null,
            QueryBuilderFilterOperators.is_not_null
        };

        public static List<QueryBuilderFilterOperators> DefaultRadioOperators = new List<QueryBuilderFilterOperators>
        {
            QueryBuilderFilterOperators.equal,
            QueryBuilderFilterOperators.not_equal,
            QueryBuilderFilterOperators.is_empty,
            QueryBuilderFilterOperators.is_not_empty,
            QueryBuilderFilterOperators.is_null,
            QueryBuilderFilterOperators.is_not_null
        };


        public static List<QueryBuilderFilterOperators> DefaultCheckBoxOperators = new List<QueryBuilderFilterOperators>
        {
            QueryBuilderFilterOperators.@in,
            QueryBuilderFilterOperators.not_in,
            QueryBuilderFilterOperators.is_empty,
            QueryBuilderFilterOperators.is_not_empty,
            QueryBuilderFilterOperators.is_null,
            QueryBuilderFilterOperators.is_not_null
        };

        public static List<QueryBuilderFilterOperators> DefaultSelectOperators = new List<QueryBuilderFilterOperators>
        {
            QueryBuilderFilterOperators.equal,
            QueryBuilderFilterOperators.not_equal,
            QueryBuilderFilterOperators.is_empty,
            QueryBuilderFilterOperators.is_not_empty,
            QueryBuilderFilterOperators.is_null,
            QueryBuilderFilterOperators.is_not_null
        };

        public static List<QueryBuilderFilterOperators> DefaultBlankOperators = new List<QueryBuilderFilterOperators>();

        public static List<QueryBuilderFilterOperators> DefaultAllOperators = new List<QueryBuilderFilterOperators>
        {
            QueryBuilderFilterOperators.equal,
            QueryBuilderFilterOperators.not_equal,
            QueryBuilderFilterOperators.@in,
            QueryBuilderFilterOperators.not_in,
            QueryBuilderFilterOperators.less,
            QueryBuilderFilterOperators.less_or_equal,
            QueryBuilderFilterOperators.greater,
            QueryBuilderFilterOperators.greater_or_equal,
            QueryBuilderFilterOperators.between,
            QueryBuilderFilterOperators.not_between,
            QueryBuilderFilterOperators.begins_with,
            QueryBuilderFilterOperators.not_begins_with,
            QueryBuilderFilterOperators.contains,
            QueryBuilderFilterOperators.not_contains,
            QueryBuilderFilterOperators.ends_with,
            QueryBuilderFilterOperators.not_ends_with,
            QueryBuilderFilterOperators.is_empty,
            QueryBuilderFilterOperators.is_not_empty,
            QueryBuilderFilterOperators.is_null,
            QueryBuilderFilterOperators.is_not_null
        };



    }

    #region Enums

    public enum QueryBuilderDataType
    {
        @string,
        @integer,
        @double,
        @date,
        @time,
        @datetime,
        @boolean
    }

    public enum QueryBuilderFilterOperators
    {
        equal,
        not_equal,
        @in,
        not_in,
        less,
        less_or_equal,
        greater,
        greater_or_equal,
        between,
        not_between,
        begins_with,
        not_begins_with,
        contains,
        not_contains,
        ends_with,
        not_ends_with,
        is_empty,
        is_not_empty,
        is_null,
        is_not_null
    }

    public enum QueryBuilderInputType
    {
        text,
        textarea,
        radio,
        checkbox,
        select
    }

    #endregion
}