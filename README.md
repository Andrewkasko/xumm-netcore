# xumm-netcore

xumm-netcore is a C# client library that allows executing payloads and managing websockets on xumm easier in .net.

**Application** **sign** **in** 

```
Request signInRequest = new Request() { txjson = new TxJson() { TransactionType = "SignIn" }};

RequestResponse signInResponse = INFToken.TokenAction(signInRequest)
```
