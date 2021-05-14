# Boardgame WebApi


## Project BoardGame WebAPI
De ontwikkeling van deze API heeft vooral het doel om: 
 - een lijst van gespeelde BoardGames bij te houden;
 - een lijst van tegenspelers bij te houden;
 - een lijst van je scores bij te houden;
 - totale aantal uren gameplay bij te houden;

Boardgames kunnen bekeken worden om info te verschaffen van het spel.

Volgende info over een boardgame wordt bijgehouden in aparte tabellen:
 - Category van boardgame; (veel-veel) || BoardGameCategoryTable
 - Artist van boardgame; (veel-veel)   || BoardGameArtistTable

Geregistreerde leden zullen volgende zaken kunnen bijhouden: 
 - Een lijst van **Welk** boardgames men heeft gespeeld;
 - Een lijst van hun **tegenspelers** per gespeelde boardgame; 
 - Een lijst van hun **Scores** van de gespeelde boardgames;
 - Een totale **Playtime** van de gespeelde boardgames;
 - en voor de moment niets anders..

Er werd een endpoint voorzien in de API om statistieken op te vragen. 
 - Top x **Boardgame** Playtime;
 - Top x Highest rated **Boardgame**;
 - Top x **Artist** with most Artwork;
 - Top x **Player** with most Played games;
 - Top x **Player** with longest Playtime;
 - Top x First **Player**;
 - Totaal hours Playtime of all available **Boardgames**.

Eventueel nog uitbreiden met een toernooi gedeelte. 
> Maar zal niet voor nu zijn wss.. ¯\\__(ツ)_/¯


## Extra info
Plaats hier de nodig informatie om het
project te kunnen uitvoeren:

- API keys of nodige secrets
- Logingegevens
- Database configuraties
> Categories -|--< BC >--|- Boardgames
> 
> Artists -|--< BA >--|- BoardGames
> 
> Players -|--< GameScores >--|- PlayedGames
> 
> PlayeGames >--|- BoardGame


## Identity Info
UserManager is volledig geintegreerd in PlayerRepository.
> Overal waar een speler opgevraagd wordt, is dit via PlayerService.

RoleManager voor de RolesController gebruikt ook PlayerService.

Nieuwe geregistreerde gebruikers krijgen standaard de **Player** Role toegekend.


## Policies
**OnlyUserAccess** => Kunnen enkel de Gets uitvoeren van de API (behalve Stats)            || **Player** Role

**BoardGameEditors** => Kunnen alles zoals 'OnlyUsersAccess' en Boardgames CRUD operaties. || **BoardGameEditor** Role

**ArtistEditors** => Kunnen alles zoals 'OnlyUsersAccess' en Artist CRUD operaties.        || **ArtistEditor** Role

**Administrators** => Kunnen alles zoals 'OnlyUsersAcces', 'BoardGameEditors' en ArtistEditors.

Zij beheren ook de Categories, Players en Roles CRUD operaties + zie Algemene Info.        || **Admin** Role

**AccesFor8And5Users** => Kunnen alles zoals 'OnlyUserAccess' en Stats opvragen.           || Based on **firstletter** Claim

**OlderThen50** => Wordt niet gebruikt, maar is een logica die kan gebruikt worden.        || Based on **dob** Claim


## Algemene info
Leden en Boardgames worden niet verwijderd uit de databank. 

Deze dienen om de geschiedenis bij te kunnen houden van de gespeelde games met gamescores. 

Als **Admin user** zal je echter de optie krijgen om deze leden en boardgames terug te activeren of zichtbaar te maken.

In het API.Core project zitten reeds "Publisher" en "Country".
> Deze zijn puur bedoelt om eventuele uitbreidingsdoeleinden.

> In het API.Infrastructure.Data werd ook seeding voorzien voor deze entiteiten. 
