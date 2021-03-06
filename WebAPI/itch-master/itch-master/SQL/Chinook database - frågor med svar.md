# SQL - Chinook database

Det som st�r inom parantes �r de kolumner som ska h�mtas. T.ex i fr�ga 3 s� ska bara ArtistName-kolumnen h�mtas.

## 1)

�ppna databasservern p� din dator:

 	(localdb)\mssqllocaldb

Detta kan du g�ra fr�n Visual Studio och v�lja *SQL Server Object Explorer*.

Alternativ: anv�nd programmet *SQL Management Studio*. V�lj File => Connect Object Explorer. 

K�r Chinook-scriptet f�r att skapa musik-databasen

## 2)

Lista all info om alla artister

    select * from Artist


## 3)

Lista alla artisters namn. Sortera p� namn. (ArtistName)

    select Name as ArtistName 
    from Artist 
    order by Name

## 4)

Lista de 10 f�rsta artisterna, sorterat p� namn. (ArtistId, Name)

    select top 10 ArtistId, Name 
    from Artist 
    order by Name

## 5)

Lista alla artister som b�rjar p� "Academy" (Name)

    select Name 
    from Artist 
    where Name like 'Academy%'

## 6)

Lista alla album d�r den andra bokstaven i titeln �r �a� och den tredje bokstaven �r �r�
(Title)

    select Name 
    from Album 
    where Name like '_ar%'

## 7)

Lista alla album d�r f�rsta bokstaven p� titeln �r en vokal

    select Name 
    from Album 
    where Name like '[aoueiy]%'

## 8)

Lista alla album tillsammans med artister f�r albumen (ArtistName, AlbumTitle)

    select artist.Name ArtistName, album.Title AlbumTitle 
    from Album album inner join Artist artist 
    on album.ArtistId = artist.ArtistId
    order by artist.Name


## 9)

F�rklara skillnaden mellan
- inner join
- left join
- right join
- full join

        Inner join ger bara rader d�r matchningen �r uppfylld
        Left join ger alltid alla rader fr�n v�nster tabell (�ven om det inte blir match)
        Right join ger alltid alla rader fr�n h�ger tabell (�ven om det inte blir match)
        Full join ger alltid alla rader fr�n b�de v�nster och h�ger tabell


## 10)

Lista de 10 artister som sl�ppt flest album (NrOfAlbums, ArtistName)

    select top 10 Count(*) NrOfAlbums, artist.Name 
    from Artist artist join Album album on artist.ArtistId=Album.ArtistId
    group by artist.name
    order by NrOfAlbums desc

    (kan �ven anv�nda �with tie�)

## 11)

Lista namn p� alla album som �r Jazz eller Blues. Ett album ska bara finnas i listan en g�ng. (AlbumTitle)

    select distinct Album.Title AlbumTitle
    from Album album 
    join Track track on album.AlbumId = track.AlbumId
    where GenreId in (2,6)

alternativ om man inte vet ID�s i f�rv�g:

    select distinct Album.Title AlbumTitle, Genre.Name Genre
    from Track
    inner join Album on Album.AlbumId = Track.AlbumId
    inner join Genre on Genre.GenreId = Track.GenreId
    where Genre.Name in ('Jazz', 'Blues')

## 12)

Albumet "Let There Be Rock" (av AC/DC) inneh�ller 8 l�tar. Modifiera databasen s� det g�r att ordna l�tar i nummerordning. 

Uppdatera sedan databasen s� l�tarna i "Let There Be Rock" �r numrerade fr�n 1 till 8.

    alter table Track add OrderInAlbum tinyint;
    go
    update Track set OrderInAlbum=1 where TrackId=15;
    update Track set OrderInAlbum=2 where TrackId=16;
    update Track set OrderInAlbum=3 where TrackId=17;
    update Track set OrderInAlbum=4 where TrackId=18;
    update Track set OrderInAlbum=5 where TrackId=19;
    update Track set OrderInAlbum=6 where TrackId=20;
    update Track set OrderInAlbum=8 where TrackId=21;
    update Track set OrderInAlbum=7 where TrackId=22;

    select * 
    from Track 
    WHERE AlbumId=4

(kan �ven automatisera numreringen, men det �r r�tt sv�rt)



## 13)

Skriv en sqlfr�ga som visar de genres som �r mest popul�ra. 

Lista genre och antal tracks i den genren. Visa den genre som har flest tracks f�rst och sedan i ned�tstigande ordning. Visa endast de genres som har fler �n 100 tracks.
(GenreName, NrOfTracks)

    select genre.Name GenreName, Count(genre.Name) as NrOfAlbums
    from Genre genre 
    join Track track on genre.GenreId = track.GenreId
    group by genre.Name
    having Count(*) >100 
    order by NrOfAlbums desc


## 14)

Skapa en variabel som sparar CustomerId utifr�n kunden "Leonie K�hler"

Anv�nd denna variabel f�r att lista alla datum n�r en faktura till Leonie K�hler g�tt iv�g
(InvoiceDate)

    declare @MyCustomer int = 
    (
	    select CustomerId 
	    from Customer 
	    where FirstName='Leonie' and LastName='K�hler'
    )

    select cast(InvoiceDate as date) 
    from Invoice 
    where CustomerId=@MyCustomer


## 15)

Skapa en tempor�r tabell #CustomerWithSupport som inneh�ller f�rnamn och efternamn p� en kund och dess supportpersonal 
(CustomerFirstName, CustomerLastName, SupportFirstName, SupportLastName)

    drop table #CustomerWithSupport 

    select c.FirstName CustomerFirstName, c.LastName CustomerLastName, e.FirstName SupportFirstName, e.LastName SupportLastName
    into #CustomerWithSupport
    from 
    Customer c join Employee e on c.SupportRepId=e.EmployeeId

    select * from #CustomerWithSupport

    alternativ med variabel (f�rdel: slipper ha en tabell som ligger och skvalpar):

    declare @CustomerWithSupport table
    (
      CustomerFirstName varchar(30), 
      CustomerLastName varchar(30),
      SupportFirstName varchar(30),
      SupportLastName varchar(30)
    )
    insert into @CustomerWithSupport
     (CustomerFirstName, CustomerLastName, SupportFirstName, SupportLastName)
    select Customer.FirstName, Customer.LastName, Employee.FirstName, Employee.LastName from Customer
    inner join Employee on Employee.EmployeeId=Customer.SupportRepId;

    select * from @CustomerWithSupport;

## 16)

Lista alla anst�llda som har en chef och deras chef.

Resultatet ska vara tv� kolumner (ej 4) med den anst�lldes och chefens fullst�ndiga namn

(EmployeeName, BossName)

    select e1.FirstName + ' ' + e1.LastName as EmployeeName, e2.FirstName + ' ' + e2.LastName as BossName
    from 
    Employee e1 join Employee e2 on e1.ReportsTo=e2.EmployeeId

## 17)

Ta reda p� hur m�nga tecken den l�ngsta epostadressen har bland alla kunder
(LongestMail)

    select Max(Len(Email)) LongestMail 
    from Customer

## 18)

Ta reda p� den eller de l�tar som p�g�r l�ngst tid
Resultatet ska vara en rad med l�ttitel och l�ngden p� l�ten
(Name, Minutes)

    select Name, Milliseconds/60000 Minutes
    from Track t where t.Milliseconds = 
	    (select Max(Milliseconds) from Track) 

## 19)

Skriv ett script som g�r en av kolumner i Customer unique. Motivera ditt val 

    alter table Customer 
    add unique(Email);  



## 20)

Lista hur mycket som har fakturerat f�r varje �r (2009-2013). Sortera s� senaste �ren visas f�rst (2013)
(Year, Sum)

    select year(InvoiceDate) as [Year], sum(total) as [Sum] 
    from Invoice
    group by year(InvoiceDate) order by year(InvoiceDate) desc


## 21)
 
Ta fram l�ngsta spellistan. (Name, TotalLengthInHours)

    SELECT TOP 1 PlayList.Name as Name, SUM(track.Milliseconds)/(1000*60*60) AS TotalLengthInHours
    FROM ((PlayListTrack
    INNER JOIN Playlist ON PlaylistTrack.PlaylistId=PlayList.PlaylistId)
    INNER JOIN Track ON Track.TrackId=PlaylistTrack.TrackId)
    GROUP BY Playlist.Name
    ORDER BY TotalLengthInHours DESC

## 22)

Lista alla anst�llda som har en chef och deras chefs chef. (EmployeeName, BossesBossName)

    SELECT emp.FirstName + ' ' + emp.LastName AS EmployeeName, bossesboss.FirstName + ' ' + bossesboss.LastName AS BossesBossName
    FROM ((Employee emp
    INNER JOIN Employee boss ON emp.ReportsTo=boss.EmployeeId)
    INNER JOIN Employee bossesboss ON boss.ReportsTo=bossesboss.EmployeeId)

## 23)


L�gg till en tabell Review kopplad till Album

    CREATE TABLE Review 
    (
        ReviewId int IDENTITY(1,1) PRIMARY KEY,
        AlbumId int NOT NULL FOREIGN KEY REFERENCES Album(AlbumID),
        ReviewText nvarchar(1000),
    )

L�gg till en review p� albumet "Black Sabbath"

    INSERT INTO Review (AlbumId, ReviewText)
    VALUES ((SELECT AlbumId FROM ALBUM WHERE TITLE LIKE 'Black Sabbath'),'Kanske en av de b�sta n�gonsin...')




## Extra

## 1)

Hitta p� tv� egna uppgifter som bygger p� att data ska h�mtas (via SELECT)

L�s uppgifterna.

Visa f�r din l�rare.

## 2)

Hitta p� tv� egna uppgifter som bygger p� att data ska modifieras (via INSERT, UPDATE, DELETE)

L�s uppgifterna.

Visa f�r din l�rare.

## 3)

G�r en backup av databasen Chinook till en fil. Ta bort alla spellistor.
Skriv en sql-fr�ga f�r att visa att spellistorna �r borta

G�r sedan en restore av databasen s� spellistorna kommer tillbaka.
Skriv en sql-fr�ga f�r att visa att spellistorna �r tillbaka


    ---- backup

    use Chinook
    backup database Chinook to disk='c:\TMP\Chinook.bak'

    delete from PlaylistTrack
    delete from Playlist 

    select * from PlaylistTrack
    select * from Playlist

    ---- restore 

    use master
    alter database Chinook set single_user with rollback immediate
    -- eller ALTER DATABASE Chinook SET OFFLINE WITH ROLLBACK AFTER 10
    -- eller ALTER DATABASE Chinook SET RECOVERY SIMPLE
    restore database Chinook from disk='c:\TMP\Chinook.bak'

    ----
    use Chinook
    select * from PlaylistTrack
    select * from Playlist


## 4)

Anv�nd transaktioner f�r att l�sa denna uppgift.

L�gg till 5 artister i Artist-tabellen.

�ngra sedan transaktionen s� de 5 artisterna inte l�ggs in. (anv�nd allts� inte "delete" i denna uppgift)


    begin transaction

    insert into Artist(Name) values ('Kalle1')
    insert into Artist(Name) values ('Kalle2')
    insert into Artist(Name) values ('Kalle3')
    insert into Artist(Name) values ('Kalle4')
    insert into Artist(Name) values ('Kalle5')

    select * from Artist

    rollback transaction

    select * from Artist

## 5) 

(Sv�r!)

Kolumnen AlbumId har datatypen int, vilket kan vara on�digt gener�st.

V�lj en annan datatyp som �r mer begr�nsande.

Skriv ett script som �ndrar datatypen (och tar h�nsyn till index och nycklar)

    ---- ta bort contraint

    ALTER TABLE [Track] DROP CONSTRAINT [FK_TrackAlbumId]
    ALTER TABLE [Album] DROP CONSTRAINT [PK_Album]

    DROP INDEX [IFK_TrackAlbumId] ON [Track]

    ---- modifiera kolumn

    ALTER TABLE Track
    ALTER COLUMN AlbumId smallint

    ALTER TABLE Album
    ALTER COLUMN AlbumId smallint

    ---- l�gg till contraint

    ALTER TABLE [Album] 
    ADD CONSTRAINT [PK_Album] PRIMARY KEY  ([AlbumId]) 

    ALTER TABLE [Track]
    ADD CONSTRAINT [FK_TrackAlbumId] FOREIGN KEY([AlbumId])
    REFERENCES [Album] ([AlbumId])

    CREATE INDEX [IFK_TrackAlbumId] 
    ON [Track]([AlbumId])

## 6)

(Sv�r!)

Lista alla artister och hur m�nga spellistor de �r med i.

    select Artist.Name, count(distinct Playlist.PlaylistId) as PlaylistCount
    from Artist 
    join Album on Artist.ArtistId = Album.ArtistId
    join Track on Album.AlbumId=Track.AlbumId
    join PlaylistTrack on PlaylistTrack.TrackId = track.TrackId
    join Playlist on playlist.PlaylistId = PlaylistTrack.PlaylistId
    group by Artist.Name
