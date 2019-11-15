Feature: GetAllProduct

Scenario: Retrieving a list of all products from application
When I makes a requset to retrieve all products
Then I should get a OK response status
And the response should contain the list of all 4 products 
 | Name             | Price | Product_code |
 | Liverpool FC kit | 800   | 4            |
