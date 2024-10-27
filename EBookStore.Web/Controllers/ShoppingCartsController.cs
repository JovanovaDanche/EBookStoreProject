using EBookStore.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EBookStore.Web.Controllers
{
    public class ShoppingCartsController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartsController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;

            return View(_shoppingCartService.getShoppingCartDetails(userId ?? ""));
        }
        public async Task<IActionResult> DeleteProductFromShoppingCart(Guid? productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? null;

            var result = _shoppingCartService.deleteFromShoppingCart(userId, productId);

            return RedirectToAction("Index", "ShoppingCarts");
        }
    }
}
