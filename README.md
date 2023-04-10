# Hammerhead

C# .NET utility for reading/writing cheat device firmware dumps (GameShark, Action Replay, Code Breaker, Xplorer64, etc.).

This project was forked from the fantastic [BacteriaMage/n64-gameshark-data-model repo](https://github.com/BacteriaMage/n64-gameshark-data-model).

## Usage

1. [Install the .NET 7 SDK](https://learn.microsoft.com/en-us/dotnet/core/install/)

2. [Download N64 GameShark firmware images](https://github.com/LibreShark/sharkdumps)

3. Run the app:

    ```bash
    $ dotnet run --project dotnet/src/src.csproj -- ~/dev/libreshark/sharkdumps/n64/*.bin
    ```

You should see output like this:

```
--------------------------------------------

ar-1.11-19980415.bin

v1.11 (AR), built on 1998-04-15 14:56 ('14:56 Apr 15 98')

25 7E F2 25 7A 41 13 C0 BF - Mario World 64 & Others [ACTIVE]
A7 4E 5A 33 DC B4 DB EE FB - Diddy Kong Racing & 1080
BD 6E 59 15 94 28 CB FF EE - Yoshi Story

258 cheats for 26 games

--------------------------------------------

arpro-3.0-19990324.bin

v3.00 (AR), built on 1999-03-24 15:50 ('15:50 Mar 24 99')

F1 29 7B C9 42 CD AE 9D 80 18 00 00 30 - Mario World 64 & Others [ACTIVE]
73 8B 63 5D 6C 38 3A 7C 80 20 10 00 A3 - Diddy, 1080, Banjo, Griffey
C2 FA 71 8A 60 EE B8 C4 80 20 04 00 18 - Yoshis, F-Zero, C'World
17 CB CD 32 43 9C 2D 88 80 19 00 00 84 - Zelda

506 cheats for 49 games

--------------------------------------------

arpro-3.3-20000418.bin

v3.30 (AR), built on 2000-04-18 16:08 ('16:08 Apr 18 ')

A8 D1 DA F2 31 20 6B 53 80 18 00 00 44 - Mario World 64 & Others [ACTIVE]
9B D7 F2 70 03 01 02 09 80 20 10 00 78 - Diddy, 1080, Banjo, Griffey
A1 73 D6 30 7E 69 C7 EA 80 20 04 00 19 - Yoshis, F-Zero, C'World
96 74 63 AC DF AF D2 13 80 19 00 00 BE - Zelda

2,043 cheats for 181 games

--------------------------------------------

gs-1.04-19970819.bin

v1.04, built on 1997-08-19 10:35 ('10:35 Aug 19 97')

No key codes found.

142 cheats for 22 games

--------------------------------------------

gs-1.05-19970904.bin

v1.05, built on 1997-09-04 16:25 ('16:25 Sep 4 97')

No key codes found.

133 cheats for 23 games

--------------------------------------------

gs-1.06-19970919.bin

v1.06, built on 1997-09-19 14:25 ('14:25 Sep 19 97')

No key codes found.

76 cheats for 21 games

--------------------------------------------

gs-1.07-19971107.bin

v1.07, built on 1997-11-07 10:24 ('10:24 Nov 7 97')

No key codes found.

169 cheats for 27 games

--------------------------------------------

gs-1.08-19971124.bin

v1.08 (November), built on 1997-11-24 11:58 ('11:58 Nov 24 97')

96 21 73 83 8C 8E 33 4F AA - Mario World 64 & Others [ACTIVE]
4E F8 4D D6 0A B3 D6 0A B8 - Diddy Kong Racing

69 cheats for 7 games

--------------------------------------------

gs-1.08-19971208.bin

v1.08 (December), built on 1997-12-08 11:10 ('11:10 Dec 8 97')

AF 71 AE CD 45 A8 7F 75 F8 - Mario World 64 & Others [ACTIVE]
35 37 8C 4B 1C F7 BF BC BD - Diddy Kong Racing

109 cheats for 20 games

--------------------------------------------

gs-1.09-19980105-cart1.bin

v1.09, built on 1998-01-05 17:40 ('17:40 Jan 5 98')

40 16 18 06 4E CF CD 4A 05 - Mario World 64 & Others [ACTIVE]
59 A6 31 F5 13 B3 DA 50 FA - Diddy Kong Racing
05 63 14 98 D5 E4 CF CD 1A - Yoshi Story

166 cheats for 37 games

--------------------------------------------

gs-1.09-19980105-cart2.bin

v1.09, built on 1998-01-05 17:40 ('17:40 Jan 5 98')

40 16 18 06 4E CF CD 4A 05 - Mario World 64 & Others [ACTIVE]
59 A6 31 F5 13 B3 DA 50 FA - Diddy Kong Racing
05 63 14 98 D5 E4 CF CD 1A - Yoshi Story

189 cheats for 39 games

--------------------------------------------

gs-1.09-19980105-cart3.bin

v1.09, built on 1998-01-05 17:40 ('17:40 Jan 5 98')

40 16 18 06 4E CF CD 4A 05 - Mario World 64 & Others [ACTIVE]
59 A6 31 F5 13 B3 DA 50 FA - Diddy Kong Racing
05 63 14 98 D5 E4 CF CD 1A - Yoshi Story

171 cheats for 36 games

--------------------------------------------

gs-2.00-19980305-cart1.bin

v2.00 (March), built on 1998-03-05 08:06 ('08:06 Mar 5 98')

63 34 F1 61 A7 2C 20 1C 2E - Mario World 64 & Others [ACTIVE]
50 F2 49 08 7C 07 EE 6C 25 - Diddy Kong Racing
8D 9A 8C DA F5 F2 B6 07 92 - Yoshi Story

165 cheats for 36 games

--------------------------------------------

gs-2.00-19980305-cart2.bin

v2.00 (March), built on 1998-03-05 08:06 ('08:06 Mar 5 98')

63 34 F1 61 A7 2C 20 1C 2E - Mario World 64 & Others [ACTIVE]
50 F2 49 08 7C 07 EE 6C 25 - Diddy Kong Racing
8D 9A 8C DA F5 F2 B6 07 92 - Yoshi Story

165 cheats for 38 games

--------------------------------------------

gs-2.00-19980305-cart3.bin

v2.00 (March), built on 1998-03-05 08:06 ('08:06 Mar 5 98')

63 34 F1 61 A7 2C 20 1C 2E - Mario World 64 & Others [ACTIVE]
50 F2 49 08 7C 07 EE 6C 25 - Diddy Kong Racing
8D 9A 8C DA F5 F2 B6 07 92 - Yoshi Story

168 cheats for 36 games

--------------------------------------------

gs-2.00-19980406.bin

v2.00 (April), built on 1998-04-06 10:05 ('10:05 Apr 6 98')

16 FB 52 A4 7A ED 1F B3 17 - Mario World 64 & Others [ACTIVE]
93 AA 74 23 FF 7C 32 FB DE - Diddy Kong Racing
20 55 38 42 DC 8E E1 C7 C9 - Yoshi Story

165 cheats for 36 games

--------------------------------------------

gs-2.10-19980825-cart1.bin

v2.10, built on 1998-08-25 13:57 ('13:57 Aug 25 98')

EB 03 0C 2C D2 3A AF C3 CE - Mario World 64 & Others [ACTIVE]
78 69 4F BD AC EF E9 DD 79 - Diddy, 1080, Banjo, Griffey
85 A2 B3 44 44 4C F1 C1 E4 - Yoshis Story

338 cheats for 61 games

--------------------------------------------

gs-2.10-19980825-cart2.bin

v2.10, built on 1998-08-25 13:57 ('13:57 Aug 25 98')

EB 03 0C 2C D2 3A AF C3 CE - Mario World 64 & Others [ACTIVE]
78 69 4F BD AC EF E9 DD 79 - Diddy, 1080, Banjo, Griffey
85 A2 B3 44 44 4C F1 C1 E4 - Yoshis Story

348 cheats for 61 games

--------------------------------------------

gs-2.21-19981218-cart1.bin

v2.21, built on 1998-12-18 12:47 ('12:47 Dec 18 98')

1E B8 7C F0 86 12 C2 A2 80 20 10 00 63 - Mario World 64 & Others [ACTIVE]
46 01 56 4E 26 01 D2 BC 80 20 10 00 DB - Diddy, 1080, Banjo, Griffey
EA 25 09 0A 40 69 FB C9 80 20 10 00 A4 - Yoshis, F-Zero, C'World
79 5E 19 BA 53 7F 71 DA 80 19 00 00 65 - Zelda

618 cheats for 106 games

--------------------------------------------

gs-2.21-19981218-cart2.bin

v2.21, built on 1998-12-18 12:47 ('12:47 Dec 18 98')

1E B8 7C F0 86 12 C2 A2 80 20 10 00 63 - Mario World 64 & Others [ACTIVE]
46 01 56 4E 26 01 D2 BC 80 20 10 00 DB - Diddy, 1080, Banjo, Griffey
EA 25 09 0A 40 69 FB C9 80 20 10 00 A4 - Yoshis, F-Zero, C'World
79 5E 19 BA 53 7F 71 DA 80 19 00 00 65 - Zelda

675 cheats for 112 games

--------------------------------------------

gs-2.21-19981218-cart3.bin

v2.21, built on 1998-12-18 12:47 ('12:47 Dec 18 98')

1E B8 7C F0 86 12 C2 A2 80 20 10 00 63 - Mario World 64 & Others [ACTIVE]
46 01 56 4E 26 01 D2 BC 80 20 10 00 DB - Diddy, 1080, Banjo, Griffey
EA 25 09 0A 40 69 FB C9 80 20 10 00 A4 - Yoshis, F-Zero, C'World
79 5E 19 BA 53 7F 71 DA 80 19 00 00 65 - Zelda

621 cheats for 106 games

--------------------------------------------

gs-2.50-19980504.bin

v2.50, built on 1998-12-18 12:58 ('12:58 May 4 ')

CD 78 7C FD 55 BB BF 05 80 18 00 00 BA - Mario World 64 & Others [ACTIVE]
9A 3B D6 6C 37 2E 4C DA 80 20 10 00 FE - Diddy, 1080, Banjo, Griffey
F7 26 1E CC 3A 9D 64 0C 80 20 04 00 90 - Yoshis, F-Zero, C'World
E6 95 89 4B 80 86 C1 F7 80 19 00 00 FA - Zelda

0 cheats for 0 games

--------------------------------------------

gspro-3.00-19990401.bin

v3.00, built on 1999-04-01 15:05 ('15:05 Apr 1 99')

70 14 FF AB 1A 91 14 49 80 18 00 00 B4 - Mario World 64 & Others [ACTIVE]
5B E5 5F CE 93 89 D7 11 80 20 10 00 9F - Diddy, 1080, Banjo, Griffey
33 31 66 BD 04 ED E3 62 80 20 04 00 DF - Yoshis, F-Zero, C'World
56 72 19 E1 9D 62 82 28 80 19 00 00 C9 - Zelda

1,125 cheats for 120 games

--------------------------------------------

gspro-3.10-19990609-cart1.bin

v3.10, built on 1999-06-09 16:50 ('16:50 Jun 9 99')

A9 25 39 DA 0C D8 E5 48 80 18 00 00 EC - Mario World 64 & Others [ACTIVE]
1F 94 99 78 94 F6 B7 55 80 20 10 00 97 - Diddy, 1080, Banjo, Griffey
07 78 28 4A A7 CA 56 C3 80 20 04 00 D7 - Yoshis, F-Zero, C'World
53 C8 DF 37 69 74 59 DB 80 19 00 00 DC - Zelda

1,124 cheats for 120 games

--------------------------------------------

gspro-3.10-19990609-cart2.bin

v3.10, built on 1999-06-09 16:50 ('16:50 Jun 9 99')

A9 25 39 DA 0C D8 E5 48 80 18 00 00 EC - Mario World 64 & Others [ACTIVE]
1F 94 99 78 94 F6 B7 55 80 20 10 00 97 - Diddy, 1080, Banjo, Griffey
07 78 28 4A A7 CA 56 C3 80 20 04 00 D7 - Yoshis, F-Zero, C'World
53 C8 DF 37 69 74 59 DB 80 19 00 00 DC - Zelda

1,124 cheats for 120 games

--------------------------------------------

gspro-3.20-19990622-cart1.bin

v3.20, built on 1999-06-22 18:45 ('18:45 Jun 22 99')

AF FA 90 67 C2 49 22 D0 80 18 00 00 12 - Mario World 64 & Others [ACTIVE]
BD B8 AF 1A E9 C2 8B 3B 80 20 10 00 30 - Diddy, 1080, Banjo, Griffey
B6 F4 6A E1 8B 0F C8 AB 80 20 04 00 67 - Yoshis, F-Zero, C'World
85 87 29 C5 3A 85 F7 50 80 19 00 00 F0 - Zelda

1,192 cheats for 125 games

--------------------------------------------

gspro-3.20-19990622-cart2.bin

v3.20, built on 1999-06-22 18:45 ('18:45 Jun 22 99')

AF FA 90 67 C2 49 22 D0 80 18 00 00 12 - Mario World 64 & Others [ACTIVE]
BD B8 AF 1A E9 C2 8B 3B 80 20 10 00 30 - Diddy, 1080, Banjo, Griffey
B6 F4 6A E1 8B 0F C8 AB 80 20 04 00 67 - Yoshis, F-Zero, C'World
85 87 29 C5 3A 85 F7 50 80 19 00 00 F0 - Zelda

1,146 cheats for 123 games

--------------------------------------------

gspro-3.20-19990622-cart3.bin

v3.20, built on 1999-06-22 18:45 ('18:45 Jun 22 99')

AF FA 90 67 C2 49 22 D0 80 18 00 00 12 - Mario World 64 & Others [ACTIVE]
BD B8 AF 1A E9 C2 8B 3B 80 20 10 00 30 - Diddy, 1080, Banjo, Griffey
B6 F4 6A E1 8B 0F C8 AB 80 20 04 00 67 - Yoshis, F-Zero, C'World
85 87 29 C5 3A 85 F7 50 80 19 00 00 F0 - Zelda

1,163 cheats for 126 games

--------------------------------------------

gspro-3.21-20000104.bin

v3.21, built on 2000-01-04 14:26 ('14:26 Jan 4 ')

F5 0A 8A 93 42 3E 44 F5 80 18 00 00 3D - Mario World 64 & Others [ACTIVE]
E3 08 64 EA F5 15 E0 4A 80 20 10 00 E9 - Diddy, 1080, Banjo, Griffey
8F B7 7D 16 09 E6 49 7E 80 20 04 00 49 - Yoshis, F-Zero, C'World
DF 56 F3 35 C6 8A 9B A9 80 19 00 00 93 - Zelda

1,143 cheats for 122 games

--------------------------------------------

gspro-3.30-20000327-pristine.bin

v3.30 (March), built on 2000-03-27 09:54 ('09:54 Mar 27 ')

8F 89 AB A0 C3 4C 26 10 80 18 00 00 A4 - Mario World 64 & Others [ACTIVE]
95 AC 21 BE 58 B0 4E F6 80 20 10 00 A8 - Diddy, 1080, Banjo, Griffey
C4 6F 1B C2 6C 6C 1F 67 80 20 04 00 1D - Yoshis, F-Zero, C'World
A9 24 53 52 5F 73 77 37 80 19 00 00 7D - Zelda

2,093 cheats for 188 games

--------------------------------------------

gspro-3.30-20000404-pristine.bin

v3.30 (April), built on 2000-04-04 15:56 ('15:56 Apr 4 ')

EA 6D 5B F8 E2 B4 69 6C 80 18 00 00 2B - Mario World 64 & Others [ACTIVE]
C3 5B B1 82 D0 4C A8 E9 80 20 10 00 32 - Diddy, 1080, Banjo, Griffey
96 EA 31 6E 54 70 CB AF 80 20 04 00 E4 - Yoshis, F-Zero, C'World
F0 03 23 12 77 F8 87 1C 80 19 00 00 F5 - Zelda

2,093 cheats for 188 games

--------------------------------------------

perfect_trainer-1.0b-20030618.bin

v1.00 (Perfect Trainer 1.0b), built on 2003-06-18 00:00 ('2003 iCEMARi0  ')

No key codes found.

0 cheats for 0 games
```
