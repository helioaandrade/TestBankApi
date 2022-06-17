## TestBankApi - Aplicação de Web Api desenvolvido em Net Core 6 
  Simula operações bancárias dem contas correntes, tais como depósito, resgate e transferência de valores monetários.
  
![image](https://user-images.githubusercontent.com/4015482/174405289-4929d788-550c-468d-9e21-c4231a0f4c36.png)


Esta API consiste de 3 endpoints
 - Post/Reset
 - GET /balance
 - POST /event
 
Exemplos de requests e seus respectivos responses:

#1 Reset state before starting tests
POST /reset												
200 OK
 
#2 Get balance for non-existing account					 
GET /balance?account_id=1234	
404 0
  
#3 Create account with initial balance					 
POST /event
{"type":"deposit", "destination":"100", "amount":10}
201 {"destination": {"id":"100", "balance":10}}
  
#4 Deposit into existing account
POST /event 
{"type":"deposit", "destination":"100", "amount":10}	
201 {"destination": {"id":"100", "balance":20}}

#5 Get balance for existing account
GET /balance?account_id=100
200 20

#6 Withdraw from non-existing account
POST /event
{"type":"withdraw", "origin":"200", "amount":10}
404 0

#7 Withdraw from existing account
POST /event
{"type":"withdraw", "origin":"100", "amount":5}
201 {"origin": {"id":"100", "balance":15}}

#8 Transfer from existing account
 POST /event
 {"type":"transfer", "origin":"100", "amount":15, "destination":"300"}
 201 {"origin": {"id":"100", "balance":0}, "destination": {"id":"300", "balance":15}}

#9 Transfer from non-existing account
POST /event 
404 0
