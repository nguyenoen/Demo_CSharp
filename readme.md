## Kiến trúc đề xuất
Front-end: ReactJS + Redux + Material UI 
Back-end: ASP.NET Core với Serilog, hỗ trợ Redis Cache, Cosmos DB hoặc Azure SQL.
Containerization & Cloud: Docker + Azure với Azure DevOps cho CI/CD.
Bổ sung: Azure Service Bus (MQ), Azure Monitor (Logging & Monitoring).
Aspire
CI/CD (Tích hợp và triển khai liên tục)
GitHub Actions

Front-end: ReactJS + Redux + Material UI
Authentication: JWT hoặc OAuth2.
Back-end: ASP.NET Core với các tính năng REST API hoặc GraphQL.
Caching: Redis
Database: SQL Server hoặc MongoDB.
Message Queue: RabbitMQ
Loging: Serilog
Testing: XUnit hoặc NUnit; Selenium hoặc Playwright; Postman: Testing API
Testing web APIs by using the .NET HTTP REPL tool
Monitoring: Application Insights + ELK Stack.
Infrastructure: Docker (hoặc Kubernetes nếu cần)
DevOps: CI/CD: GitHub Actions.

## VSCode Extension Setup
.NET 8 SDK
C# Dev Kit
REST Client

## Project Info
Web app: server-side web UI development Razor Pages
Web API: RESTful HTTP services
gRPC service: Remote Procedure Call app using Protocol Buffers
Real-time app: SignalR - Bidirectional communication between servers and connected clients

#### Create a web app project.
dotnet new webapp --output aspnetcoreapp --no-https
#### Run the app.
cd aspnetcoreapp
dotnet run
#### Edit a Razor page.


## Create OpenAPI Project
dotnet add package Microsoft.AspNetCore.OpenApi
dotnet new webapi -controllers
#### Add Swagger UI
dotnet add package Swashbuckle.AspNetCore




#### Check HTTPS
dotnet --info
dotnet dev-certs https --clean
dotnet dev-certs https --trust
dotnet dev-certs https --help

#### Explore APIs with HTTP REPL
dotnet tool install -g Microsoft.dotnet-httprepl
httprepl https://localhost:{PORT}
httprepl https://localhost:7075
connect https://localhost:7075