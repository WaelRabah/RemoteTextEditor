using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Text_Editor_Backend.Models;

namespace Text_Editor_Backend.Data
{
    public class TextRepo : ITextRepo
    {
        private readonly AppDbContext _context;

        public TextRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddText(Text t)
        {
            _context.Texts.Add(t);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteText(int Id)
        {
            var text = await _context.Texts.FirstOrDefaultAsync(item => item.Id == Id);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Text[]> GetAllTexts()
        {
            var texts = await _context.Texts.ToArrayAsync();

            return texts;
        }

        public async Task<Text> GetText(int Id)
        {
            return await _context.Texts.FirstOrDefaultAsync(item => item.Id == Id);
        }

        public async Task<Text> UpdateText(int Id, Text t)
        {
            _context.Texts.Attach(t).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return await _context.Texts.FirstOrDefaultAsync(item => item.Id == Id);
        }
    }
}