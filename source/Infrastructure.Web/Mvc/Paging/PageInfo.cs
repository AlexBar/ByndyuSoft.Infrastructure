using System;

namespace ByndyuSoft.Infrastructure.Web.Mvc.Paging
{
    /// <summary>
    /// ��������� � ��������
    /// </summary>
    public class PageInfo
    {
        /// <summary>
        /// ���������� ���������� � ������ ��������
        /// </summary>
        public static PageInfo Empty
        {
            get { return new PageInfo(0, 1, 0); }
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="index">������ ��������</param>
        /// <param name="pageSize">������ ��������</param>
        /// <param name="totalItemsCount">���������� ���������</param>
        public PageInfo(int index, int pageSize, int totalItemsCount)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index", @"Index cannot be below 0.");

            if (pageSize < 1)
                throw new ArgumentOutOfRangeException("pageSize", @"PageSize cannot be less than 1.");

            Index = index;
            PageSize = pageSize;
            TotalItemsCount = totalItemsCount;
        }

        /// <summary>
        /// ���������� �������
        /// </summary>
        public int PagesCount
        {
            get { return TotalItemsCount / PageSize + (TotalItemsCount % PageSize != 0 ? 1 : 0); }
        }

        /// <summary>
        /// ����� ���������
        /// </summary>
        public int TotalItemsCount { get; private set; }

        /// <summary>
        /// ������ ��������
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        /// ����� �������� <see cref="Index"/>+1
        /// </summary>
        public int Number
        {
            get { return Index + 1; }
        }

        /// <summary>
        /// ������ ��������
        /// </summary>
        public int PageSize { get; private set; }
    }
}