using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataAccess.Data;
using WebApp.DataAccess.Repository.IRepository;
namespace WebApp.DataAccess.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		public ApplicationDbContext _db;
		internal DbSet<T> DbSet;
		public Repository(ApplicationDbContext db)
		{
			_db = db;
			DbSet = _db.Set<T>();
		}
		public void Add(T entity)
		{
			DbSet.Add(entity);
		}

		public void Remove(T entity)
		{
			DbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entity)
		{
			DbSet.RemoveRange(entity);
		}

		public IEnumerable<T> GetAll()
		{
			return DbSet.ToList();
		}

		public T GetOne(Expression<Func<T,bool>> filter)
		{
			IQueryable<T> query = DbSet;
			query = query.Where(filter);
			return query.FirstOrDefault();
		}


	}
}
