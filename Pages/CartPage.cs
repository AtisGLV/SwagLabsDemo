using Microsoft.Playwright; 

namespace SwagLabsDemo.Pages
{
    public class CartPage
    {
        private readonly IPage _page;
        public CartPage(IPage page)
        {
            _page = page;
        }
        public async Task GoToCheckout()
        {
            await CheckoutButton.ClickAsync();
        }

        // Locators

        private ILocator CartItemNames => _page.Locator(".cart_item .inventory_item_name");
        private ILocator CheckoutButton => _page.Locator("#checkout");
        private ILocator ContinueShoppingButton => _page.Locator("#continue-shopping");
    }
}
