Feature: DeleteProduct

Scenario: Verifying I can delete product from application using product code
When I specify product code 4 to delete 
Then I should get a OK response status
And the response should contain my specify product details  
 | Name             | Price  |
 | Liverpool FC kit | 800.00 |  


Scenario: Verifying I can't delete products from the application with an invalided product code
When I specify product code -1 to delete 
Then I should get a NotFound response status


Scenario: Verifying I can't delete products from the application with entering a product code
When I don,t specify a product code
Then I should get a NotFound response status