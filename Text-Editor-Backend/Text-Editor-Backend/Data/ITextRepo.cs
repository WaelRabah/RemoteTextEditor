using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Text_Editor_Backend.Models;

namespace Text_Editor_Backend.Data
{
    internal interface ITextRepo
    {
        public Task<Text> GetText(int Id);

        public Task<Text[]> GetAllTexts();

        public Task<bool> AddText(Text t);

        public Task<Text> UpdateText(int Id, Text t);

        public Task<bool> DeleteText(int Id);
    }
}