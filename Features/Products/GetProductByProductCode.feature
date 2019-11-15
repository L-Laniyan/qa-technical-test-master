Feature: GetProductByProductCode

Scenario: Requesting a specified product from the application
When I specify product code 1
Then I should get a OK response status
And the response should contain my specify product details  
 | Name           | Price | Product_code |
 | Lavender heart | 9.95  | 1            |


Scenario: Verifying I can't get a product from the application with an invalided product code
When I specify product code -1 
Then I should get a NotFound response status