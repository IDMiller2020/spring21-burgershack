using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;

namespace burgershack.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _repo;
    public BurgersService(BurgersRepository repo)
    {
      _repo = repo;
    }
    internal Burger Create(Burger newBurger)
    {
      return _repo.Create(newBurger);
    }
    internal IEnumerable<Burger> GetAll()
    {

      // TODO do this thing
      throw new NotImplementedException();
    }

  }
}