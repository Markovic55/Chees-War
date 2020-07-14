Kill The King 2D unity game



Projekat: Unity 2d igra(povezivanje sa bazom)

Potrebno je napraviti 2d igru u Unity engine-u i povezati je sa bazom podataka(po izboru).
Potrebno je da korisnik moze da se registruje u bazi.
Samo korisnici koji se uloguju mogu da igraju igru.(znaci login/registracija) je prva scena.
Kada se uloguje pojavljuje mu se meni:
1. play game
2. see score
3. exit

1. Kada klikne na play game ulazi u igru.
Igra je strateska/sah igra na cijoj sceni se nalazi 7x7 board kvadratica.
u prvom redu se nalazi 7 crvenih vojnika(4 vojnika, 2 strelca i kralj) u poslednjem redu se nalazi 7 plavih vojnika(4 vojnika, 2 strelca i kralj).
Svaki vojnik ima 2 attack i 3 health, strelac 3 attack i 4 health, dok kralj ima 2 attack i 8 health.
Vojnikov pattern kretanja i napadanja:(samo tri polja ispred sebe)
xxx
 O
Strelcov pattern kretanja i napadanja:(kao konj u sahu)
 x   x
x     x
   o
x     x
 x   x

Kraljev pattern kretanja i napadanja:(kao kralj u sahu)
xxx
xox
xxx

Sve figure se mogu pomerati jedanput u potezu. Treba da postoji dugme koje kaze end turn i tada igra plavi player.
Sve je u lokalu na jednoj tabli(nista multiplayer).
Osencaj polja na koja figura moze da stane.
Ukoliko je protivnicka figura u range-u playerove desava se bitka:
figura1 atk se oduzima od figura2 health i figura2 atk se oduzima od figura1 atk.
Ako figura1 unisti figura2, prelazi na njegovo polje. Ako figura2 unisti figura1 ostaje na svom(posto je izvrsena odbrana).
Ako obe figure dodju do 0 obe se unistavaju. Ako niko nije unisten niko se ne pomera.
Promena healtha se cuva(ako je izgubio 2 a imao je 3 sad ima 1 health).
Pobednik je onaj koji prvi unisti protivnickog kralja.

2. see score scena treba da cuva informacije u bazi o pobedama/izgubljenim partijama.
Ako je ulogovani player(crveni) pobedio upisi mu +1 u pobeda polju.
Ako je izgubio upisi mu +1 u izgubljeno polju i to prikazi u unitiju kada se klikne na see score scenu kao i score ostalih registrovanih usera.

3. exit dugme izlazi iz igrice
