A demo showcase project for automated website testing using Playwright C#.

This project demonstrates a complete purchase flow on the Swag Labs demo site. It includes secret handling and automation of common actions like logging in, adding items to the cart, and completing checkout.


CI / GitHub Actions
The GitHub Actions workflow that ran the tests in a virtual machine has been disabled due to environment inconsistencies. It can be re-enabled if a reliable CI solution is found.


Debugging Locally
Tests can be debugged locally by running them in headed mode (headless: false) and selecting a browser (chromium, firefox, or webkit) to observe test execution.

********************************************************************
Example Test: Buying the Shirt
Location: D:\Code\SwagLabs\SwagLabsDemo\Tests\BuyingTshirt.cs

Test flow:
Navigate to the website and log in.
Add a T-shirt to the cart and verify the cart count.
Proceed to checkout and fill in required information.
Verify the item appears correctly in the checkout overview.
Complete the checkout and verify confirmation.
********************************************************************