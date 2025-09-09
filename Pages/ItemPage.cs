using Microsoft.Playwright; 

namespace SwagLabsDemo.Pages
{
    public class ItemPage
    {
        private readonly IPage _page;

        public ItemPage(IPage page)
        {
            _page = page;
        }


        public async Task AddToCart()
        {
            await AddToCartButton.ClickAsync();
        }

        // Locators

        private ILocator ItemName => _page.Locator(".inventory_details_name");
        private ILocator ItemDescription => _page.Locator(".inventory_details_desc");
        private ILocator ItemPrice => _page.Locator(".inventory_details_price");
        private ILocator AddToCartButton => _page.Locator("button:has-text('Add to cart')");
        private ILocator RemoveButton => _page.Locator("button:has-text('Remove')");
        private ILocator BackToProducts => _page.Locator("#back-to-products");

    }
}
