using Microsoft.AspNetCore.Mvc;

namespace QTPriceChecker.AspMvc.Controllers.Base
{
    partial class ProductXSuppliersController
    {
        public async Task<IActionResult> AddSupplier(int productId)
        {
            using var supCtrl = new Logic.Controllers.Base.SuppliersController();
            using var prodCtrl = new Logic.Controllers.Base.ProductsController(supCtrl);
            var product = await prodCtrl.GetByIdAsync(productId);
            var suppliers = await supCtrl.GetAllAsync();

            var model = new Models.Base.ProductXSupplier
            {
                ProductId = productId,
                ProductText =  product != null ? product.Designation : string.Empty,
                Suppliers = suppliers.Select(e => Models.Base.Supplier.Create(e)).ToList(),
            };
            return View("Create", model);
        }

        protected override RedirectToActionResult RedirectAfterAction(ActionMode actionMode, Logic.Entities.Base.ProductXSupplier accessModel)
        {
            return RedirectToAction("Edit", "Products", new { id = accessModel.ProductId });
        }
    }
}
