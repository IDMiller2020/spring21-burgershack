using System.Collections.Generic;
using System.Data;
using burgershack.Interfaces;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class BurgersRepository : IRepo<Burger>
  {
    private readonly IDbConnection _db;
    public BurgersRepository(IDbConnection db)
    {
      _db = db;
    }

    public Burger Create(Burger newBurger)
    {
      string sql = @"
            INSERT INTO burgers
            (name, cost, quantity, modifications)
            VALUES
            (@Name, @Cost, @Quantity, @Modifications);
            SELECT LAST_INSERT_ID()";
      newBurger.Id = _db.ExecuteScalar<int>(sql, newBurger);
      return newBurger;
    }
    public IEnumerable<Burger> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public Burger GetById(int id)
    {
      throw new System.NotImplementedException();
    }

    public Burger Update(Burger data)
    {
      throw new System.NotImplementedException();
    }
  }

}