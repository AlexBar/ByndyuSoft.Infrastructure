using System;
using System.Web.Routing;

namespace ByndyuSoft.Infrastructure.Web.Routing
{
	///<summary>
	/// ������ ���������� ��� ��������� ���������
	///</summary>
	public static class RouteCollectionExtensions
	{
		/// <summary>
		/// �������� �������, ������� ����� �������� ���������� ��������������� �� �������� �������
		/// </summary>
		/// <param name="routes">��������� ��������� ��� ASP.NET</param>
		/// <param name="url">������ URL ��� ��������� ��������</param>
		/// <param name="values"></param>
		public static void MapRedirectToRoutePermanent(this RouteCollection routes, string url, object values)
		{
			routes.Add(new Route(url, new RedirectToRoutePermanentHandler(values)));
		}
	}
}