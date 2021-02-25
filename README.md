# Boardgame WebApi

## Project
De website zal verschillende **categorien** van boardgames bevatten die elk een lijst van **boardgames** heeft.

Boardgames kunnen bekeken worden om info te verschaffen van het spel.
>voor zowel niet geregistreerde als geregistreerde leden.

Volgende info over een boardgame wordt bijgehouden in aparte tabellen:
 - Category van boardgame; (veel-veel)
 - Publisher van de boardgame; (1-veel)
   >1 publisher kan meerdere boardgames uitbrengen.
 - Artist van boardgame; (veel-veel)

Publisher en Boardgame zullen ook een tabel delen met Countries.
>Beide zullen een 1-1 relatie hebben met deze tabel.

Geregistreerde leden zullen volgende zaken kunnen bijhouden: 
 - **Welk** boardgames men heeft gespeeld;
 - Een lijst van hun **tegenspelers** per gespeelde boardgame; 
   >spelers dienen niet gekend te zijn in de database
 - **Scores** van de gespeelde boardgames;
 - **Playtime** van de gespeelde boardgames;
 - ...


Eventueel nog uitbreiden met een toernooi gedeelte.

Dit om de **top 10 spelers, top 10 scores**, ... van het toernooi te kunnen bevragen. 


## Extra info
Plaats hier de nodig informatie om het
project te kunnen uitvoeren:

- API keys of nodige secrets
- Logingegevens
- Database configuraties
- ...
