﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class EFBowlersRepository : IBowlerRepository
    {
        private BowlersDbContext _context { get; set; }
        public EFBowlersRepository (BowlersDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        public void SaveChanges(Bowler b)
        {
            _context.SaveChanges();
        }

        public void AddBowler(Bowler b)
        {
            _context.Add(b);
            _context.SaveChanges();
        }
        
        public void DeleteBowler(Bowler b)
        {
            _context.Remove(b);
            _context.SaveChanges();
        }

    }
}
