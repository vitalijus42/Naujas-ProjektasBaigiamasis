# Naujas-Projektas
Scenarijus: pasitelkiant windows visual studio automatiniu testavimu metodu,naudojantis Nunit ir Selenium, buvo testuojami sie puslapio www.autobusubilietai.lt pagrindinio puslapio funkcionalumo testavimo atvejai. Isankstines salygos: interneto narsykleje google chrome wind 10 aplinkoje atsidaryti puslpapi https://www.autobusubilietai.lt.
1. Autobuso bilieto paieskos i viena puse funckionalumo testas:
 Zingsniai:
 ivesti i laukeli "Į" reiksme "Vilnius"
 ivesti i laukeli "Iš reiksme "Kaunas"
 paspausti mygtuka "Ieškoti kelionės"
 patikrinti paieškos funkcionalumą lyginant aktualia reiksme ir tiketiną reiksmę pagal elemento reiksme, kuria grazina testo metodas
 
 2. Autobuso bilieto paieskos su gryzimu fukcionalumo testas
 Zingsniai:
 ivesti i laukeli ivesti i laukeli "Į" reiksme "Vilnius"
 ivesti i laukeli "Iš reiksme "Ignalina"
 paspausti mygtuka "Įsigyčiau bilietą atgal"
 paspausti mygtuka "Ieškoti kelionės"
 patikrinti paieškos funkcionalumą lyginant aktualia reiksme ir tiketiną reiksmę pagal elemento reiksm, kuria grazina testo metodas
 
 3. Bilieto grazinimo neturint bilieto numerio testo atvejis gaunat klaidos pranesima
 Zingsniai:
 Paspausti mygtuka "neturiu blieto numerio"
 Įvesti į laukelį "Į" reiksme "Alytus"
 Įvesti i laukeli "vardas pavarde" reiskme "nznznz"
 Paspausti paieskos mygtuka
 patikrinti, ar tiketinas rezultatas atitinka aktulia reiksme ir tai yra klaidos pranesimas
 
 4. Kalbos keitimo funkcija i anglu kalb testo atvejisa
 Paspausti mygtuka headeryje "Lt" kalba
 Is issokancio "dropdown" meniu pasirinkti anglu kalba
 patikrinti, ar pasikeite kalba lyginant aktualia reiskme ir tiketina rezultata kad testas grazintu rezultata "EN"
 
 5. Siusti pranesima funkcionalumo testo atvejis
 Paspausti ant laukelio headeryje siusti pranesima
 Is issokancio laukelio ivesti validu elektroninio pasto adresa
 Parasyti zinute
 Pazymeti laukelyje "gauti siunciamo pranesimo kopija el pastu"
 Paspausti mygtuka siusti
 Patikrinti, ar tiketinas rezultatas atitinka aktualu rezultata, kad pranesimas butu issiustas
 
 
 
 
 
 



