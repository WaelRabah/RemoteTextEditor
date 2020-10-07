using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Text_Editor_Backend.Models;

namespace Text_Editor_Backend.Data
{
    internal interface IWriterRepo
    {
        public Writer GetWriter(int Id);

        public bool AddWriter(Writer w);

        public Writer UpdateWriter(int Id, Writer w);

        public bool DeleteWriter(int Id);
    }
}