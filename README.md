# ContactManager

**Inhaltsverzeichnis:**  
1. [Einleitung](#einleitung)  
2. [Datenmodell und Datenbank](#datenmodell-und-datenbank)  
  - [Definition von Contact](#definition-von-contact)  
3. [Aufgaben](#aufgaben)  
  - [Backend-System](#backend-system)  
    - [Business-Logik](#business-logik)  
    - [Unit-Tests](#unit-tests)  
    - [RESTful-Service](#restful-service)  
  - [MVVM-Frontend](#mvvm-frontend)  

## Einleitung  

Das Projekt ***ContactManager*** ist eine datenzentrierte Anwendung zur Verwaltung von Kontakten.  

Zu entwickeln ist das Backend-System mit der Datenbank-Anbindung, eine Web-Anwendung zur Verwaltung der Stammdaten der Projekte. Zusätzlich soll ein mobiler Client zum Ansehen und Bearbeiten einer Aufgabe erstellt werden.  

## Datenmodell und Datenbank  

Das Datenmodell für ***ContactManager*** hat folgenden Aufbau:

```txt

+-------+--------+ 
|                | 
|    Contact     + 
|                | 
+-------+--------+ 

```

| Name         | Type   | MaxLength | Nullable | Unique | Db-Field | Access |  
|--------------|--------|-----------|----------|--------|----------|--------|  
| Id           | int    | ---       | ---      | ---    | Yes      | R      |  
| FirstName    | String | 64        | No       | No     | Yes      | RW     |  
| LastName     | String | 64        | No       | No     | Yes      | RW     |  
| Company      | String | 128       | No       | No     | Yes      | RW     |  
| Email*       | String | 128       | Yes      | Yes    | Yes+     | RW     |  
| PhoneNumber* | String | 32        | Yes      | Yes    | Yes+     | RW     |  
| Address      | String | 256       | Yes      | No     | Yes      | RW     |  
| Note         | String | 1024      | Yes      | No     | Yes      | RW     |  

*...einer von beiden darf leer sein.  
+...wenn der Wert gesetzt ist, muss dieser eindeutig sein.  

## Aufgaben  

### Backend-System  

Entwickeln Sie ein **Backend-System** nach der vorgestellten [Software-Architektur](https://github.com/leoggehrer/SEArchitecture).

#### Business-Logik  

Das System muss einige Geschäftsregeln umsetzen. Diese Regeln werden im Backend implementiert und müssen mit UnitTests überprüft werden.

> **HINWEIS:** Unter **Geschäftsregeln** (Business-Rules) versteht man **elementare technische Sachverhalte** im Zusammenhang mit Computerprogrammen. Mit *WENN* *DANN* Scenarien werden die einzelnen Regeln beschrieben.  

Für den ***ContactManager*** sind folgende Regeln definiert:

| Rule | Subject | Type   | Operation | Description | Note |
|------|---------|--------|-----------|-------------|------|
|**A1**| Contact |        |           |             |      |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, | |
|      |         |**DANN**|           | muss `FirstName` und `LastName` festgelegt sein, | |
|      |         |        | ODER      | `Company` muss definiert sein. | |
|**A2**| Contact |        |           |             |      |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird und `FirstName` und `LastName` definiert ist, | |
|      |         |**DANN**|           | muss die Länge von `FirstName` >= 2 und die Länge von `LastName` >= 2 sein. | |
|**A3**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird und `Company` definiert ist, |  |
|      |         |**DANN**|           | muss die Länge von `Company` >= 2 sein | |
|**B1**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, |  |
|      |         |**DANN**|           | darf der Wert für `Email` leer sein. | |
|**B2**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, |  |
|      |         |**DANN**|           | darf der Wert für `Email` nicht leer sein | |
|      |         |        | UND       | und das Format muss einer Email enstprechen. |  |
|**B3**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, |  |
|      |         |**DANN**|           | darf der Wert für `PhoneNumber` leer sein. | |
|**B4**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, |  |
|      |         |**DANN**|           | darf der Wert für `PhoneNumber` nicht leer sein | |
|      |         |        | UND       | und das Format muss einer Telefonnummer enstprechen. |  |
|**B5**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, |  |
|      |         |**DANN**|           | muss der Wert für `Email` definiert sein | |
|      |         |        | ODER      | es muss der Wert für `PhoneNumber` definiert sein |  |
|      |         |        | ODER      | beide Werte müssen definiert sein. |  |
|**B6**| Contact |        |           | | |
|      |         |**WENN**|           | eine Kontakt erstellt oder bearbeitet wird, |  |
|      |         |**DANN**|           | muss der Wert für `Email` und er Wert für `PhoneNumber` eindeutig sein. | |

#### Unit-Tests  

All diese Geschäftsregeln müssen mit **UnitTests** überprüft werden. Fügen Sie dazu zur Lösung (Solution) ein Projekt mit dem Namen ***'ContactManager.Logic.UnitTest'*** hinzu und implementieren Sie die Tests.

#### RESTful-Service  

Erstellen Sie einen REST-Service Zugriff für die Entität ***'Contact'*** mit folgende Komponenten:

- Ein ***Model*** für die Entität ***'Contact'***.
- Einen ***Kontroller*** mit den folgenden Operationen
  - Abfrage alle Kontakte
  - Abfrage eines Kontaktes mit der Id
  - Erstellen eines Kontaktes (FirstName, LastName, Company, Email, PhoneNumber, Address)
  - Änderung eines Kontaktes (FirstName, LastName, Company, Email, PhoneNumber, Address)
  - Löschen eines Kontaktes

Prüfen Sie mit dem Werkzeug Swagger oder Postman die REST-Schnittstelle.

### MVVM-Fontend  
  
Erstellen Sie für die folgenden Entität Formulare im MVVM-Projekt:  
  
- List   - Übersicht der Kontakte  
- Create - Erstellen eines Kontaktes  
- Edit   - Bearbeiten eines Kontaktes  
- Delete - Löschen eines Kontaktes mit Rückfrage  

**Viel Spaß beim Umsetzen der Aufgabe!**
