# ReactProj
FAQ for VY 
-----------------------
Dette er den individuelle oppgaven i Webapplikasjoner for Cato Hilmi Akay ~s326326
Oppgaven er gjort i React og Node. 

Projectet er strukturert på følgende måte: 

Model - Alle modell klasser
Controllers - Alle controller klasser 
Clitentapp -> src -> components - Her ligger alle javascript filene som bruker react. 
Clitentapp består også av .css filer og andre .js som er nødvending for at programmet skal kjøre. 

Når applikasjonen kjøres er det Home.js som kommer først, her vil det vises 7 spørsmål med svar. (Ofte stilte spørsmål)
Disse spørsmålene er lagret i en database, og hentes derifra. Databasen består av 2 tabller, en for 
innsendte spørsmål og en for ofte stilte spørsmål. 

Hvis man trykker på "send inn" øverst til høyre kommer man til siden for å sende inn spørmsål. Første gang
man går inn her vil siden være tom, grunnet at databasen er resettet før innlevering av oppgaven. 
Når testpersonen fyller ut skjemaet skal spørmsålet dukke opp under "innsednte spørsmål" på "send inn"
siden. 

Sist endret 
Cato H. Akay 12.11.2019 21:04 