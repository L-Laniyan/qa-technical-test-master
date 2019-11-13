Feature: AddProduct

Scenario: Adding product to application 
When I specify product I want to add
 | Name             | Price  |
 | Liverpool FC kit | 800.00 |
Then I should get a successful OK response
And the response should contain my specify product details 
 | Name             | Price  |
 | Liverpool FC kit | 800.00 |

