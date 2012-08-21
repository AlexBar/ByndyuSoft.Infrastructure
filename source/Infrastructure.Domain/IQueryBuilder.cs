using System;

namespace ByndyuSoft.Infrastructure.Domain
{
    /// <summary>
    /// ��������� ��� ����������� ��������
    /// </summary>
    public interface IQueryBuilder
    {
        /// <summary>
        /// ������ ������� ������ ��� ����������
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        IQueryFor<TResult> For<TResult>();
    }
}