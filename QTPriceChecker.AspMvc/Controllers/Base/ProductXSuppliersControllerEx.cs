using Microsoft.AspNetCore.Mvc;

namespace QTPriceChecker.AspMvc.Controllers.Base
{
    partial class ProductXSuppliersController
    {
        public override IActionResult BackToIndex()
        {
            var backController = SessionWrapper.GetStringValue($"{ControllerName}.BackController", "Restaurants");
            var backAction = SessionWrapper.GetStringValue($"{ControllerName}.BackAction", "Index");
            var backParam = SessionWrapper.GetStringValue($"{ControllerName}.BackParam", string.Empty);

            return string.IsNullOrEmpty(backParam) ? RedirectToAction(backAction, backController) : RedirectToAction(backAction, backController, new { id = Convert.ToInt32(backParam) });
        }
        protected override RedirectToActionResult RedirectAfterAction(ActionMode actionMode, Logic.Entities.Base.ProductXSupplier accessModel)
        {
            return RedirectToAction("Edit", "Products", new { id = accessModel.ProductId });
        }
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
            SessionWrapper.SetStringValue($"{ControllerName}.BackController", "Products");
            SessionWrapper.SetStringValue($"{ControllerName}.BackAction", "Edit");
            SessionWrapper.SetStringValue($"{ControllerName}.BackParam", productId.ToString());
            return View("Create", model);
        }
    }
}
