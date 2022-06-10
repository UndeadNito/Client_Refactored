# To set up the client app you will need

  + .Net compiler

## Before compilation you should

  + specify the ip address of a server <br />
    to make it open [program.cs](./Client_Refactored/Program.cs) and insert `IPAddress.Parse({server address})` after `_address = `
    <br /><br />
    ```
    private static readonly IPAddress _address = 
            Dns.GetHostEntry(IPAddress.Loopback).AddressList.Last();
    ```
    > by default it uses local address

## Now it ready to compilation

  + use any .Net compiler to produce `exe` file
  + run the file 
