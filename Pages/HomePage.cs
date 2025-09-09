using Microsoft.Playwright; 

namespace SwagLabsDemo.Pages
{
    public class HomePage
    {
        private readonly IPage _page;
        public HomePage(IPage page)
        {
            _page = page;
        }

        public async Task GoToItemTshirt()
        {
            await NameTshirt.ClickAsync();
        }

        public async Task GoToItemBackpack()
        {
            await NameBackpack.ClickAsync();
        }
        public async Task GoToItemBikeLight()
        {
            await NameBikeLight.ClickAsync();
        }

        public async Task GoToItemFleeceJacket()
        {
            await NameFleeceJacket.ClickAsync();
        }

        public async Task GoToItemOnesie()
        {
            await NameOnesie.ClickAsync();
        }

        public async Task GoToItemTshirtRed()
        {
            await NameTshirtRed.ClickAsync();
        }

        public async Task GoToShoppingCart()
        {
            await ShoppingCartButton.ClickAsync();
        }

        public async Task<int> GetCartCount()
        {
            if (await CartBadge.CountAsync() == 0) return 0; // no badge = empty cart
            var text = await CartBadge.InnerTextAsync();
            return int.Parse(text);
        }

        // Locators

        // Links
        private ILocator Menu => _page.Locator("#react-burger-menu-btn");
        private ILocator ShoppingCartButton => _page.Locator(".shopping_cart_link");
        private ILocator CartBadge => _page.Locator(".shopping_cart_badge");

        // Names
        private ILocator NameBackpack => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Sauce Labs Backpack" });
        private ILocator NameTshirt => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Bolt T-Shirt" });
        private ILocator NameOnesie => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Onesie" });
        private ILocator NameBikeLight => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Bike Light" });
        private ILocator NameFleeceJacket => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Fleece Jacket" });
        private ILocator NameTshirtRed => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Test.allTheThings() T-Shirt (Red)" });


        // Add to cart
        private ILocator AddToCartBackpack => _page.Locator("#add-to-cart-sauce-labs-backpack");
        private ILocator AddToCartShirt => _page.Locator("#add-to-cart-sauce-labs-bolt-t-shirt");
        private ILocator AddToCartOnesie => _page.Locator("#add-to-cart-sauce-labs-onesie");
        private ILocator AddToCartBikeLight => _page.Locator("#add-to-cart-sauce-labs-bike-light");
        private ILocator AddToCartJacket => _page.Locator("#add-to-cart-sauce-labs-fleece-jacket");
        private ILocator AddToCartRedShirt => _page.Locator("#add-to-cart-test.allthethings()-t-shirt-(red)");

        // Remove from cart

        private ILocator RemoveFromCartBackpack => _page.Locator("#remove-sauce-labs-backpack");
        private ILocator RemoveFromCartShirt => _page.Locator("#remove-sauce-labs-bolt-t-shirt");
        private ILocator RemoveFromCartOnesie => _page.Locator("#remove-sauce-labs-onesie");
        private ILocator RemoveFromCartBikeLight => _page.Locator("#remove-sauce-labs-bike-light");
        private ILocator RemoveFromCartJacket => _page.Locator("#remove-sauce-labs-fleece-jacket");
        private ILocator RemoveFromCartRedShirt => _page.Locator("#remove-test.allthethings()-t-shirt-(red)");
    }
}
