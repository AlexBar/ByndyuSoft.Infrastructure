using System;
using JetBrains.Annotations;

namespace ByndyuSoft.Infrastructure.Domain
{
	///<summary>
	/// ��������� �����������
	///</summary>
	///<typeparam name="TEntity">��� �������� �������� ������</typeparam>
	public interface IRepository<TEntity>
		where TEntity : IEntity
	{
	    ///<summary>
		/// �������� �������� �� ��������������. � ���� ������� ������������� Load ����� ���������������.
		/// ��������� http://ayende.com/Blog/archive/2009/04/30/nhibernate-ndash-the-difference-between-get-load-and-querying-by.aspx
		///</summary>
		///<param name="id"></param>
		///<returns>�������� � ��������� Id, ���� ����������. ����� - null.</returns>
		[CanBeNull]
		TEntity Get(int id);

	    ///<summary>
		/// ��������� ��������
		///</summary>
		///<param name="entity"></param>
		void Add([NotNull] TEntity entity);

		/// <summary>
		/// ������� ��������
		/// </summary>
		/// <param name="entity"></param>
		void Remove([NotNull] TEntity entity);
	}
}