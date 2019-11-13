Feature: GetProductByProductCode

Scenario: Requesting a specified product from the application
When I specify product code 1
Then I should get a successful OK response
And the response should contain my specify product details  
 | Name           | Price | Product_code |
 | Lavender heart | 9.95  | 1            |