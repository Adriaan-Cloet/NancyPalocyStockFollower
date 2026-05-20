# Nancy Pelosi Stock Follower
 
Een ASP.NET Core MVC applicatie die de aandelenhandel van Nancy Pelosi bijhoudt op basis van publiek beschikbare STOCK Act-meldingen.
 
Alle leden van het Amerikaanse Congres zijn wettelijk verplicht om aandelentransacties binnen 45 dagen openbaar te maken. Deze app haalt die data op via de QuiverQuant API en toont een overzicht van aankopen en verkopen.
 
## Technologieën
 
- ASP.NET Core MVC (.NET 10)
- C#
- QuiverQuant API
- Razor Views
## Lokaal uitvoeren
 
### 1. Vereisten
 
- - [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 of hoger
- Een gratis QuiverQuant account
### 2. API-key aanmaken
 
1. Ga naar [quiverquant.com](https://www.quiverquant.com) en maak een gratis account aan
2. Navigeer naar je accountinstellingen en kopieer je API-key
### 3. API-key instellen
 
De API-key wordt **nooit** in de code of op GitHub opgeslagen. Gebruik hiervoor User Secrets:
 
**Via Visual Studio:**
- Rechtsklik op het project in Solution Explorer
- Kies **Manage User Secrets**
- Voeg het volgende toe aan `secrets.json`:
```json
{
  "QuiverQuant": {
    "ApiKey": "jouw_api_key_hier"
  }
}
```
 
**Via terminal:**
```bash
dotnet user-secrets set "QuiverQuant:ApiKey" "jouw_api_key_hier"
```
 
### 4. Project starten
 
Open de `.sln` in Visual Studio en druk op **F5**, of via terminal:
 
```bash
dotnet run
```
 
## Opmerking
 
Door de 45-daagse rapporteringstermijn van de STOCK Act zijn de weergegeven trades nooit real-time — er zit altijd een vertraging op van maximaal 45 dagen.
