# ProjectManagementTool
 
## Structurizr Documentatie en Gebruik
In dit project wordt Structurizr gebruikt voor het maken en beheren van architectuurdiagrammen. Deze diagrammen bieden een visueel overzicht van de structuur en relaties binnen het project.

### Vereisten
Om Structurizr lokaal te draaien, heb je de volgende benodigdheden:
- **Docker**: Zorg dat Docker is geïnstalleerd en correct geconfigureerd.
- **Structurizr bestanden**: De diagrammen worden lokaal opgeslagen in de map `./Documentation/Structurizr.`

### Structurizr Diagrams Lokaal Bekijken
Gebruik het batchbestand `ViewStructurizrDiagrams.bat` om de Structurizr Lite instance lokaal op te starten. Dit bestand start een Docker-container die de diagrammen publiceert en beschikbaar maakt in de browser.

#### Instructies
1. Navigeer naar de map ./Documentation.
2. Dubbelklik op het batchbestand `ViewStructurizrDiagrams.bat` of voer het uit via de command-line:
```cmd
cd ./Documentation
ViewStructurizrDiagrams.bat
```
3. Zodra de Docker-container draait, kun je de diagrammen bekijken door naar de volgende URL te gaan in je browser:
```arduino
http://localhost:5092
```
#### Batchbestand Uitleg
Het batchbestand bevat de volgende commandoregel:

```cmd
docker run -it --rm -p 5092:8080 -v "%~dp0\Structurizr":/usr/local/structurizr -e STRUCTURIZR_WORKSPACE_FILENAME=ProjectManagementTool structurizr/lite
@pause
```
- `-p 5092:8080`: Publiceert de Structurizr Lite server op poort 5092.
- `-v "%~dp0\Structurizr":/usr/local/structurizr`: Maakt de lokale Structurizr-bestanden toegankelijk in de Docker-container.
- `-e STRUCTURIZR_WORKSPACE_FILENAME=ProjectManagementTool`: Specificeert de naam van de Structurizr-workspace die moet worden geladen.
- `@pause`: Houdt de command-line open zodat je de uitvoer kunt bekijken.

#### Tips en Aanvullende Informatie
- **Diagrammen Updaten**: Zorg dat de Structurizr-bestanden in de map `./Documentation/Structurizr` actueel zijn voordat je de server start.
- **Opgeslagen Bestanden**: Het batchbestand wijzigt geen bestanden, maar maakt ze alleen zichtbaar via de Docker-container.
- **Git Beheer**: De map `./Documentation/Structurizr` bevat de configuratiebestanden die je nodig hebt voor versiebeheer. Plaats gegenereerde bestanden zoals `.png` of `.svg` in `.gitignore` om de repository schoon te houden.