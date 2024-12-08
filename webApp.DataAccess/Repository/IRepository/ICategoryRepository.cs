﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.Models;

namespace WebApp.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository:IRepository<Category>
	{
		void Update(Category obj);
		void Save( );
	}
}
