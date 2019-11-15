Feature: AddProduct

Scenario: Adding a product to the application 
When I specify product I want to add
 | Name             | Price  |
 | Liverpool FC kit | 800.00 |
Then I should get a OK response status
And the response should contain my specify product details 
 | Name             | Price  |
 | Liverpool FC kit | 800.00 |


Scenario: Verifying I can not add a product with specifying no name by pressing the space bar 
When I specify product I want to add
 | Name | Price  |
 |      | 50.00  |
Then I should get a BadRequest response status


Scenario: Verifying that I can't set price to a negtive value 
When I specify product I want to add
 | Name  | Price   |
 | Table | -100.00 |
Then I should get a BadRequest response status


Scenario: Verifying I can't add a product without specifying a name price 
When I dont specify either product Name Price or both 
| Price |
| 400   |
Then I should get a BadRequest response status


Scenario: Verifying I can't add a product without specifying a price 
When I dont specify either product Name Price or both 
| Name       |
| Headphones |
Then I should get a BadRequest response status


Scenario: Verifying I can't add a product without specifying a name and a price 
When I dont specify either product Name Price or both 
|Name|Price|
Then I should get a BadRequest response status