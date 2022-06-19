## TestBankApi - Aplicação de Web Api desenvolvido em Net Core 6 
  Simula operações bancárias em contas correntes, tais como depósito, resgate e transferência de valores monetários.
  
![image](https://user-images.githubusercontent.com/4015482/174405289-4929d788-550c-468d-9e21-c4231a0f4c36.png)


Esta API consiste de 3 endpoints
 - Post/Reset
 - GET /balance
 - POST /event

Foram usadas as ferramentas Ngrok e Ipkiss Tester para expor a aplicação para a internet e a execução dos testes das rotas com vários cenários.

 Link do Ipkiss Tester(https://ipkiss.pragmazero.com/test?url=https%3A%2F%2F532b-2804-29b8-5098-63a-a1e4-21e1-43e5-bb56.sa.ngrok.io&script=--%0D%0A%23+Reset+state+before+starting+tests%0D%0A%0D%0APOST+%2Freset%0D%0A%0D%0A200+OK%0D%0A%0D%0A%0D%0A--%0D%0A%23+Get+balance+for+non-existing+account%0D%0A%0D%0AGET+%2Fbalance%3Faccount_id%3D1234%0D%0A%0D%0A404+0%0D%0A%0D%0A%0D%0A--%0D%0A%23+Create+account+with+initial+balance%0D%0A%0D%0APOST+%2Fevent+%7B%22type%22%3A%22deposit%22%2C+%22destination%22%3A%22100%22%2C+%22amount%22%3A10%7D%0D%0A%0D%0A201+%7B%22destination%22%3A+%7B%22id%22%3A%22100%22%2C+%22balance%22%3A10%7D%7D%0D%0A%0D%0A%0D%0A--%0D%0A%23+Deposit+into+existing+account%0D%0A%0D%0APOST+%2Fevent+%7B%22type%22%3A%22deposit%22%2C+%22destination%22%3A%22100%22%2C+%22amount%22%3A10%7D%0D%0A%0D%0A201+%7B%22destination%22%3A+%7B%22id%22%3A%22100%22%2C+%22balance%22%3A20%7D%7D%0D%0A%0D%0A%0D%0A--%0D%0A%23+Get+balance+for+existing+account%0D%0A%0D%0AGET+%2Fbalance%3Faccount_id%3D100%0D%0A%0D%0A200+20%0D%0A%0D%0A--%0D%0A%23+Withdraw+from+non-existing+account%0D%0A%0D%0APOST+%2Fevent+%7B%22type%22%3A%22withdraw%22%2C+%22origin%22%3A%22200%22%2C+%22amount%22%3A10%7D%0D%0A%0D%0A404+0%0D%0A%0D%0A--%0D%0A%23+Withdraw+from+existing+account%0D%0A%0D%0APOST+%2Fevent+%7B%22type%22%3A%22withdraw%22%2C+%22origin%22%3A%22100%22%2C+%22amount%22%3A5%7D%0D%0A%0D%0A201+%7B%22origin%22%3A+%7B%22id%22%3A%22100%22%2C+%22balance%22%3A15%7D%7D%0D%0A%0D%0A--%0D%0A%23+Transfer+from+existing+account%0D%0A%0D%0APOST+%2Fevent+%7B%22type%22%3A%22transfer%22%2C+%22origin%22%3A%22100%22%2C+%22amount%22%3A15%2C+%22destination%22%3A%22300%22%7D%0D%0A%0D%0A201+%7B%22origin%22%3A+%7B%22id%22%3A%22100%22%2C+%22balance%22%3A0%7D%2C+%22destination%22%3A+%7B%22id%22%3A%22300%22%2C+%22balance%22%3A15%7D%7D%0D%0A%0D%0A--%0D%0A%23+Transfer+from+non-existing+account%0D%0A%0D%0APOST+%2Fevent+%7B%22type%22%3A%22transfer%22%2C+%22origin%22%3A%22200%22%2C+%22amount%22%3A15%2C+%22destination%22%3A%22300%22%7D%0D%0A%0D%0A404+0%0D%0A%0D%0A)
 
 Obs: O endereço do Ngrok.io muda com frequência, e portanto, a URL deve ser alterado no link acima.
 
![image](https://user-images.githubusercontent.com/4015482/174451472-5da4748e-43ff-492c-916f-13b05060c84a.png)

Outra alternativa, seria usar o Converyor(https://conveyor.cloud/) que tem um extensão do Visual Studio 2022, e fornece uma URL fixa para aplicação.

Deve-se utilizar a URL(https://bankapi.conveyor.cloud/) no IpKiss Test(https://ipkiss.pragmazero.com/), conforme visto abaixo.

![image](https://user-images.githubusercontent.com/4015482/174461440-2de952a8-e8b5-4789-b577-c5768b322c27.png)



  
