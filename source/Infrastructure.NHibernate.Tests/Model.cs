﻿using System;
using System.Collections.Generic;

namespace ByndyuSoft.Infrastructure.NHibernate.Tests
{
	public class CustomerCategory
	{
	}

	public class Customer
	{
		public virtual CustomerCategory CustomerCategory { get; set; }
	}

	public class Invoice
	{
		public virtual Customer Customer { get; set; }

		public virtual IList<InvoiceItem> Items { get; set; }
	}

	public class InvoiceItem
	{
		public virtual Product Product { get; set; }
	}

	public class Product
	{
	}
}