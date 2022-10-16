using Microsoft.AspNetCore.Mvc;

namespace QTPriceChecker.AspMvc.Controllers.App
{
    partial class PriceHistoriesController
    {
        public override IActionResult BackToIndex()
        {
            var backController = SessionWrapper.GetStringValue($"{ControllerName}.BackController", "Restaurants");
            var backAction = SessionWrapper.GetStringValue($"{ControllerName}.BackAction", "Index");
            var backParam = SessionWrapper.GetStringValue($"{ControllerName}.BackParam", string.Empty);

            return string.IsNullOrEmpty(backParam) ? RedirectToAction(backAction, backController) : RedirectToAction(backAction, backController, new { id = Convert.ToInt32(backParam) });
        }
        protected override RedirectToActionResult RedirectAfterAction(ActionMode actionMode, Logic.Entities.App.PriceHistory accessModel)
        {
            var backController = SessionWrapper.GetStringValue($"{ControllerName}.BackController", "Restaurants");
            var backAction = SessionWrapper.GetStringValue($"{ControllerName}.BackAction", "Index");
            var backParam = SessionWrapper.GetStringValue($"{ControllerName}.BackParam", string.Empty);

            return string.IsNullOrEmpty(backParam) ? RedirectToAction(backAction, backController) : RedirectToAction(backAction, backController, new { id = Convert.ToInt32(backParam) });
        }
        public async Task<IActionResult> AddPrice(int productId, int productXSupplierId)
        {
            using var prodXsuppCtrl = new Logic.Controllers.Base.ProductXSuppliersController();
            var prodXsupp = await prodXsuppCtrl.GetByIdAsync(productXSupplierId);

            var model = new Models.App.PriceHistory
            {
                ProductXSupplierId = productXSupplierId,
                From = DateTime.Now,
                ProductText = prodXsupp!.Product!.Designation,
                SupplierText = prodXsupp!.Supplier!.Name,
            };
            SessionWrapper.SetStringValue($"{ControllerName}.BackController", "Products");
            SessionWrapper.SetStringValue($"{ControllerName}.BackAction", "Edit");
            SessionWrapper.SetStringValue($"{ControllerName}.BackParam", productId.ToString());
            return View("Create", model);
        }
    }
}
