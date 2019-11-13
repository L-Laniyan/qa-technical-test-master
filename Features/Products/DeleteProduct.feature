Feature: DeleteProduct

Scenario: Deleting product from application
When I specify product code 4 to delete 
Then I should get a successful OK response
And the response should contain my specify product details  
 | Name             | Price  |
 | Liverpool FC kit | 800.00 |  

