## TestBankApi - Aplicação de Web Api desenvolvido em Net Core 6 
  Simula operações bancárias em contas correntes, tais como depósito, resgate e transferência de valores monetários.
  
 ![image](https://user-images.githubusercontent.com/4015482/174461859-9c4ae363-e4ca-4404-981b-1b8f6be5ea3f.png)



Esta API consiste de 3 endpoints
 - Post/Reset
 - GET /balance
 - POST /event

Foram usadas as ferramentas Ngrok e Ipkiss Tester para expor a aplicação para a internet e a execução dos testes das rotas com vários cenários.

 Link do Ipkiss Tester(https://ipkiss.pragmazero.com/)
 
 Obs: Deve-se criar uma counta no Ngrok e que vai fornecer uma URL que pode ser usada na internet.
 
![image](https://user-images.githubusercontent.com/4015482/174451472-5da4748e-43ff-492c-916f-13b05060c84a.png)

Outra alternativa, seria usar o Converyor(https://conveyor.cloud/) que tem um extensão do Visual Studio 2022, e fornece uma URL fixa para aplicação.

Deve-se utilizar a URL(https://bankapi.conveyor.cloud/) no IpKiss Test(https://ipkiss.pragmazero.com/), conforme visto abaixo.

![image](https://user-images.githubusercontent.com/4015482/174461440-2de952a8-e8b5-4789-b577-c5768b322c27.png)



  
