namespace EF_Practices.DTO
{
    public class BaseRequestDTO
    {
        public virtual string Keyword { get; set; }
        public virtual bool IsAscending { get; set; } = false;
        public virtual string SortColumn { get; set; }
        public virtual int PageNo { get; set; } = 1;
        public virtual int PageSize { get; set; } = 10;
    }
}