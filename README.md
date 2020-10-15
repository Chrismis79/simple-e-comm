# simple-e-comm
.Net core API that returns client information

- This web API uses .Net core webapi template with C# to return a list of clients and their information. 

- To run the server fork and clone this repository to your local machine.
- Run the following commands in your terminal to install packages:
  > `git clone https://github.com/Chrismis79/simple-e-comm.git`
  > `cd Clients`
  > `dotnet restore`
  
- Once completed run the following command:
  > `dotnet run` or `dotnet watch run`
  
- This will start the local development server.

## Endpoints
baseurl: "https://localhost:5001"


### Requests
- GET url: "/clients"
  > Returns a list of clients and their information.
- GET url: "/clients/:id"
  > Returns client by id



