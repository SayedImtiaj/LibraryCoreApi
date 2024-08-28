﻿using LibraryCoreApi.DAL.Interfaces;
using LibraryCoreApi.Data;
using LibraryCoreApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryCoreApi.DAL.Repositories
{
    public class PublisherRepository : IRepository<Publisher>
    {
        readonly ApplicationDbContext _context;

        public PublisherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Publisher>> Get()
        {
            return await _context.Publishers.ToListAsync();
        }

        public async Task<Publisher> Get(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            return publisher;
        }

        public async Task<object> Post(Publisher entity)
        {
            if (_context.Publishers.Any(c => c.PublisherName == entity.PublisherName))
            {
                return null;
            }

            _context.Publishers.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Publisher entity)
        {
            var publisher = _context.Publishers.Find(id);
            publisher.PublisherName = entity.PublisherName;
            publisher.IsActive = entity.IsActive;
            await _context.SaveChangesAsync();
            return entity;
        }


        public async Task<object> Delete(int id)
        {
            var publisher = _context.Publishers.Find(id);
            if (publisher != null)
            {
                _context.Publishers.Remove(publisher);
                await _context.SaveChangesAsync();
                return publisher;
            }
            return null;
        }
    }
}
