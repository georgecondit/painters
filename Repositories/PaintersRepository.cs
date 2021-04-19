using System;
using System.Collections.Generic;
using System.Data;
using painters.Models;
using Dapper;

namespace paintes.Repositories
{
    public class PaintersRepository
    {
     public readonly IDbConnection _db;

     public PaintersRepository(IDbConnection db)
     {
         _db = db;
     }   
    }

    internal IEnumerable<Painter> Get()
    {
        string sql = "SELECT * FROM painters;";
        return _db.Query<Painter>(sql);
    }

}