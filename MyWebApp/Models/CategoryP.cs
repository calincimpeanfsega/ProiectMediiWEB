using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Data;
namespace MyWebApp.Models
{
    public class ProductCategoriesPM : PageModel
    {
        public List<CategoryData> CategoryDataList;
        public void PopulateAssignedCategoryData(MyWebAppContext context, Product product)
        {
            var allCategories = context.Product;
            var productCategories = new HashSet<int>(
                product.ProductCategories.Select(c => c.CategoryID));

            CategoryDataList = new List<CategoryData>();
            foreach (var cat in allCategories)
            {
                CategoryDataList.Add(new CategoryData
                {
                    CategoryID = cat.ProductID,
                    Name = cat.Category,
                    Assigned = productCategories.Contains(cat.ProductID)
                });
            }
        }
        public void UpdateProductCategories(MyWebAppContext context, string[] selectedCategories, Product productToUpdate)
        {
            if (selectedCategories == null)
            {
                productToUpdate.ProductCategories = new List<ProductCategory>();
                return;
            }
            var selectedCategoriesHS = new HashSet<string>(selectedCategories);
            var productCategories = new HashSet<int>(
                productToUpdate.ProductCategories.Select(c => c.Category.Id));


           
        }

    }
}


