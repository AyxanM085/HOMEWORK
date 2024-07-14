using System;
using static From_HoME_wORK.brand;

namespace From_HoME_wORK
{
	public class From_Home_Work
	{
        public From_Home_Work()
        {

        }  

public class BrandService
        {
            private readonly ApplicationDbContext _context;

            public object EntityState { get; private set; }

            public BrandService(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<brand_service> CreateAsync(Brand brand)
            {
                _context.Brands.Add(brand);
                await _context.SaveChangesAsync();
                return brand;
            }

            public async Task<Brand> GetByIdAsync(int id)
            {
                return await _context.Brands.FindAsync(id);
            }

            public async Task<List<Brand>> GetAllAsync()
            {
                return await _context.Brands.ToListAsync();
            }

            public async Task UpdateAsync(Brand brand)
            {
                _context.Entry(brand).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var brand = await _context.Brands.FindAsync(id);
                if (brand != null)
                {
                    _context.Brands.Remove(brand);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
	}


