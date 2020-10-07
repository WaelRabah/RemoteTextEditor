using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Text_Editor_Backend.Models;

namespace Text_Editor_Backend.Data
{
    public class WriterRepo : IWriterRepo
    {
        private readonly AppDbContext _context;

        public WriterRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool AddWriter(Writer w)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWriter(int Id)
        {
            throw new NotImplementedException();
        }

        public Writer GetWriter(int Id)
        {
            throw new NotImplementedException();
        }

        public Writer UpdateWriter(int Id, Writer w)
        {
            throw new NotImplementedException();
        }
    }
}