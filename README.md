Pontozólap:

Név: Kratochwill Balázs
Neptun: TAAYQB

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Rövid leírás:

Az alkalmazás egy Stock elemző alkalmazás. A főmenüből két ablak nyitható, az egyikben megadhatjuk az általunk kiválasztott api url-t, majd megszemlélhetjük, hogy milyen formában sikerült lekérni, ha a JSON forma megegyezik a mellette lévő mintával, akkor tudjuk, hogy az alkalmazás többi részében is működnie kell.

A másik ablakban megadhatunk egy stock api request url-t, ami ( ha megfelelő az url, különben közli, hogy rossz url) megjeleníti az adatokat egy datagridviewban, ezután elkézíti a dátumokkal együtt a grafikon, melyen ábrázolja, hoogyan változott az ár. További features: Egy gomb megnyomásával pár elemző statisztikai adatot kapunk az árfolyam mozgásról.

Egy másik gombbal kiírathatjuk a datagridview, vagyis a stock adatait egy csv formában.

Továbbá van egy asp.net web api is, ami saját adatbázisból dolgozik, melybe az IBM stock adatai vannak feltöltve havi bontásban 2020-tól. Lehet a swaggeren keresztül Get metódussal lekérni az adatbázist és lehet ugyanitt a POST metódussal új rekordot rögzíteni.

Van egy index html oldal, ahol js segítségével be lehet tlteni egy táblázatot az IBM stock price adatbázissal, majd ebbe új rekordot lehet felvenni. (A képeken az itthoni verzóm látható, ZH-n a kinézettel nem foglalkoztam, más betűtípus stb)

![image](https://github.com/user-attachments/assets/8389efdc-2af8-4e79-95f3-569f3ba5287e)


------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
URL-k, amikkel ki lehet próbálni a programot.

https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol=IBM&apikey=demo

https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol=TSCO.LON&apikey=demo

A demo-ban sajnos csak ez a két stock van :(

Alkalmazás tovább fejlesztése:

Nem egy textbox-ba kell bemásolni az url-t, hanem külön url építő rész listbox segítségével, mely cseréli az url-ben a TIME_SERIES-t a megfelelőre és a Symbolt is.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Windows Forms Application:

1x2p Az alkalmazásból a kilépés csak megerősítő kérdés után lehetséges. 2p

3x1p Többablakos alkalmazás legalább két felugró ablakkal. Minden Form-nak saját osztályon kell alapulnia, és funcionalitással kell rendelkeznie. Az ablakok nyílhatnak gombokkal vagy felső menüből is. 3p

1x2p Adatok megjelenítése 2p

1x2p Ha a tábla adatforrása saját osztály. 2p

1x5p Tetszőleges diagram rajzolása 5p

1x2p A diagram adatforrása tetszőleges módszerrel szűrhető 2p

1x7p Excel munkafüzet generálása kódból, adatbázstába tartalmának megjelenítésével, legalább egy formázással  7p  ( itt formázás alatt nem tudom, mit értünk, mert én API requesttel dolgoztam )

a Stock árak elemzése algoritmus:

1x1p Az algoritmus egy önállóan értelmezhető egységet képez, az alkalmazástól függetlenül (értsd: könnyen újra lehetne használni máshol hasonló paraméterekkel)

1x1p Az algoritmus értelmes szerepet kap az alkalmazásban és nem lehet beépített megoldásokra kicserélni, nincs túlbonyolítva

1x1p Az algoritmus az adatbázis adataira épít 

Ez nem szerepel a pontozólapon, de a Tanár úr azt mondta elszámolhatom:

Az alkalmazás visszakap egy json objectumot a weboldaltol webrequesten keresztül 2p, majd ezeket a saját osztályainak megfelelően eltárolja. 3p

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
ASP.NET


1x2p program.cs beállítása wwwroot mappában tárolt statikus tartalmak megosztására 2p

1x3p Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 3p

1x5p Új rekord felvétele HttpPost metóduson keresztül SQL táblába 5p

3x1p Az alkalmazásban használt táblánként pont 1p (egy tábla)

1x1p Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan 1p

1x2p Az adatbázis saját Azure SQL szerveren van 2p

![image](https://github.com/user-attachments/assets/67e0d7b0-766f-4f63-82c0-40638ee38958)

A táblát és az adatokat is egy-egy querry-vel vittem fel SSMS-ből:

CREATE TABLE IBMPrices (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Date DATE,
    OpenPrice DECIMAL(18, 4),
    HighPrice DECIMAL(18, 4),
    LowPrice DECIMAL(18, 4),
    ClosePrice DECIMAL(18, 4),
    Volume BIGINT
);


INSERT INTO dbo.IBMPrices (Date, OpenPrice, HighPrice, LowPrice, ClosePrice, Volume)

VALUES



Az adatokat chatgpt-vel json-ből vagy csv-ből átírattam, hogy insert-be lehessen tenni.

1x1p A weboldalnak van egy értelmezhető struktúrája 1p

1x1p A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül 1p

1x1p A weboldal javascriptet használ API végpont által szolgáltatott adatok betöltésére, hozott anyagként 1p

1x1p A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése 1p (Lehet új rekordot rögzíteni js-es megoldással)

2x1p Scaffold-DbContext használata (ajándék) 1p (mivel csak egyszer használtam)

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Összesen 50p;




