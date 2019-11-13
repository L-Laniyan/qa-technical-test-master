Feature: UpdateProduct

Scenario: Updating the details of a requested product 
When I specify the product code 4 to be updated with these details
 | Name                  | Price |
 | Liverpool FC Home kit | 400   |
Then I should get a successful OK response
And the response should contain my specify product details 
 | Name                  | Price | Product_code |
 | Liverpool FC Home kit | 400   | 4            |
