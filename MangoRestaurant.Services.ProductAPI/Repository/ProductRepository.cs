using AutoMapper;
using MangoRestaurant.Services.ProductAPI.Contexts;
using MangoRestaurant.Services.ProductAPI.Models.DTO;
using MangoRestaurant.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoRestaurant.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO)
        {
            Product product = _mapper.Map<ProductDTO, Product>(productDTO);
            
            if (product.ProductID > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                _db.Products.Add(product);
            }

            await _db.SaveChangesAsync();
            
            return _mapper.Map<Product, ProductDTO>(product);
        }

        public async Task<bool> DeleteProduct(int productID)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductID == productID);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDTO> GetProductByID(int productID)
        {
            Product product = await _db.Products.Where(x => x.ProductID == productID).FirstOrDefaultAsync();

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();

            return _mapper.Map<List<ProductDTO>>(productList);

        }
    }
}