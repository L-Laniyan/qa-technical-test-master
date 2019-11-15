Feature: UpdateProduct

Scenario: validating I can update the details of a requested product 
When I specify the product code 4 to be updated with these details
 | Name                  | Price |
 | Liverpool FC Home kit | 400   |
Then I should get a OK response status
And the response should contain my specify product details 
 | Name                  | Price | Product_code |
 | Liverpool FC Home kit | 400   | 4            |


Scenario: Verifying I can't update the details of a requested product without a product code 
When I dont specify the product code
 | Name   | Price |
 | Jumper | 150   |
Then I should get a NotFound response status


Scenario: Verifying I can't update the details of a requested product without a valid product code  
When I specify the product code -1 to be updated with these details
 | Name                  | Price |
 | Liverpool FC Home kit | 400   |
Then I should get a NotFound response status


Scenario: Verifying I can't update the details of a requested product without entering a Name or Price
When I specify the product code 4 to be updated with these details
 | Name | Price |
Then I should get a BadRequest response status

Scenario: Verifying I can't update the details of a requested product entering a negtive Price
When I specify the product code 4 to be updated with these details
 | Price |
 | -1    |
Then I should get a BadRequest response status