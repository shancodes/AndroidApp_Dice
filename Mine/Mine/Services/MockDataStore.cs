﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Golden Hand", Description="Sharp and Shining Sword" , Value=2 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Wind Fire", Description="Ice Flames and Fire over wind" , Value=5 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Thunder Bird", Description="Powerful Bird" , Value=3 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Sky Line", Description="Magic Blue Knife" , Value=4 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Dragon glass", Description="Glass knife" , Value=7 }
            };
        }

        public async Task<bool> CreateAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> ReadAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> IndexAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}