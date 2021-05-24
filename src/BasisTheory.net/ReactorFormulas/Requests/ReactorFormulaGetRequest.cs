using System.Collections.Generic;
using BasisTheory.net.Common.Requests;

namespace BasisTheory.net.ReactorFormulas.Requests
{
    public class ReactorFormulaGetRequest : PaginatedGetRequest
    {
        public string Name { get; set; }

        public string SourceTokenType { get; set; }

        public override string BuildQuery()
        {
            var queryParts = new List<string>();

            if (Page.HasValue)
                queryParts.Add($"page={Page}");

            if (PageSize.HasValue)
                queryParts.Add($"size={PageSize}");

            if(!string.IsNullOrWhiteSpace(Name))
                queryParts.Add($"name={Name}");

            if(!string.IsNullOrWhiteSpace(SourceTokenType))
                queryParts.Add($"source_token_type={SourceTokenType}");

            return string.Join("&", queryParts);
        }
    }
}
