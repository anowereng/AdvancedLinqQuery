using EF_Practices.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace EF_Practices.Helpers
{
    public static class QueryableExtensions
    {
        //RequestHelperModel()
        //{
        //    OrderBy = "Modified";
        //}
        //public int PerPageCount { get; set; } = 10;
        //public int Page { get; set; }
        //public string OrderBy { get; set; }

        //public IQueryable<TModel> SkipAndTake(IQueryable<TModel> queryable)
        //{
        //    if (Page != -1)
        //    {
        //        queryable = queryable.Skip((Page - 1) * PerPageCount).Take(PerPageCount);
        //    }

        //    return queryable;
        //}

        public static IQueryable<T> PageBy<T>([NotNull] this IQueryable<T> query, BaseRequestDTO pagedRequest)
        {
            if (query == null || pagedRequest == null)
            {
                throw new ArgumentException($"{query} can not be null!", nameof(query));
            }

            if (!string.IsNullOrEmpty(pagedRequest.SortColumn))
            {
                var sortColumn = pagedRequest.SortColumn;

                if (!pagedRequest.IsAscending)
                    sortColumn += " desc";

                query = query.OrderBy(sortColumn);
            }

            if (pagedRequest.PageNo == 0)
                return query;

            int pageSize = pagedRequest.PageSize == 0 ? 10 : pagedRequest.PageSize;
            int pageNo = pagedRequest.PageNo - 1;

            return query.PageBy(pageNo * pageSize, pageSize);
        }
        public static IQueryable<T> PageBy<T>([NotNull] this IQueryable<T> query, int skipCount, int maxResultCount)
        {
            if (query == null)
            {
                throw new ArgumentException($"{query} can not be null!", nameof(query));
            }

            return query.Skip(skipCount).Take(maxResultCount);
        }

    }
}
