using Microsoft.Playwright;

namespace SwagLabsDemo.Pages
{
    public static class Flows
    {
        public static async Task CheckoutFlow(HomePage homePage, CartPage cartPage, CheckoutPage checkoutPage)
        {
            await homePage.GoToShoppingCart();
            await cartPage.GoToCheckout();
            await checkoutPage.FillCheckoutWithTestData();
            await checkoutPage.Continue();
        }
    }
}