# Nancy Pelosi Stock Follower
 
Een ASP.NET Core MVC applicatie die de aandelenhandel van Nancy Pelosi bijhoudt op basis van publiek beschikbare STOCK Act-meldingen.
 
Alle leden van het Amerikaanse Congres zijn wettelijk verplicht om aandelentransacties binnen 45 dagen openbaar te maken. Deze app haalt die data op via de gratis House Stock Watcher API en toont een overzicht van aankopen en verkopen.
 
## Technologieën
 
- ASP.NET Core MVC (.NET 10)
- C#
- [House Stock Watcher API](https://housestockwatcher.com) (gratis, geen registratie vereist)
- Razor Views
## Lokaal uitvoeren
 
### 1. Vereisten
 
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 of hoger
### 2. API
 
Deze applicatie gebruikt de **House Stock Watcher API**. Dit is een volledig gratis en open API — geen account, geen API-key, geen registratie vereist.
 
De data wordt opgehaald via:
```
GET https://house-stock-watcher-data.s3-us-west-2.amazonaws.com/data/all_transactions.json
```
 
### 3. Project starten
 
Open de `.sln` in Visual Studio en druk op **F5**, of via terminal:
 
```bash
dotnet run
```
 
## Opmerking
 
Door de 45-daagse rapporteringstermijn van de STOCK Act zijn de weergegeven trades nooit real-time — er zit altijd een vertraging op van maximaal 45 dagen.
