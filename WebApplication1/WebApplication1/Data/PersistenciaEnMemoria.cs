using Dsw2025Ej14.Api.Domain;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {
        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }

        public Product GetProduct(string Sku)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products.Where(p = p => p.isActive);
        }

        public void LoadProducts ()
        {
            var json = File.ReadAllText("Data\\products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions {
                    PropertyNameCaseInsensitive=true, 
                )) ?? [];

              }
        );

    }
    }





