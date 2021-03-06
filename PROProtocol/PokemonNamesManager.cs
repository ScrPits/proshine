﻿namespace PROProtocol
{
    public class PokemonNamesManager
    {
        private static PokemonNamesManager _instance;

        public PokemonNamesManager()
        {
            Names = new string[776];
            Names[0] = "???";
            Names[1] = "Bulbasaur";
            Names[2] = "Ivysaur";
            Names[3] = "Venusaur";
            Names[4] = "Charmander";
            Names[5] = "Charmeleon";
            Names[6] = "Charizard";
            Names[7] = "Squirtle";
            Names[8] = "Wartortle";
            Names[9] = "Blastoise";
            Names[10] = "Caterpie";
            Names[11] = "Metapod";
            Names[12] = "Butterfree";
            Names[13] = "Weedle";
            Names[14] = "Kakuna";
            Names[15] = "Beedrill";
            Names[16] = "Pidgey";
            Names[17] = "Pidgeotto";
            Names[18] = "Pidgeot";
            Names[19] = "Rattata";
            Names[20] = "Raticate";
            Names[21] = "Spearow";
            Names[22] = "Fearow";
            Names[23] = "Ekans";
            Names[24] = "Arbok";
            Names[25] = "Pikachu";
            Names[26] = "Raichu";
            Names[27] = "Sandshrew";
            Names[28] = "Sandslash";
            Names[29] = "Nidoran F";
            Names[30] = "Nidorina";
            Names[31] = "Nidoqueen";
            Names[32] = "Nidoran M";
            Names[33] = "Nidorino";
            Names[34] = "Nidoking";
            Names[35] = "Clefairy";
            Names[36] = "Clefable";
            Names[37] = "Vulpix";
            Names[38] = "Ninetales";
            Names[39] = "Jigglypuff";
            Names[40] = "Wigglytuff";
            Names[41] = "Zubat";
            Names[42] = "Golbat";
            Names[43] = "Oddish";
            Names[44] = "Gloom";
            Names[45] = "Vileplume";
            Names[46] = "Paras";
            Names[47] = "Parasect";
            Names[48] = "Venonat";
            Names[49] = "Venomoth";
            Names[50] = "Diglett";
            Names[51] = "Dugtrio";
            Names[52] = "Meowth";
            Names[53] = "Persian";
            Names[54] = "Psyduck";
            Names[55] = "Golduck";
            Names[56] = "Mankey";
            Names[57] = "Primeape";
            Names[58] = "Growlithe";
            Names[59] = "Arcanine";
            Names[60] = "Poliwag";
            Names[61] = "Poliwhirl";
            Names[62] = "Poliwrath";
            Names[63] = "Abra";
            Names[64] = "Kadabra";
            Names[65] = "Alakazam";
            Names[66] = "Machop";
            Names[67] = "Machoke";
            Names[68] = "Machamp";
            Names[69] = "Bellsprout";
            Names[70] = "Weepinbell";
            Names[71] = "Victreebel";
            Names[72] = "Tentacool";
            Names[73] = "Tentacruel";
            Names[74] = "Geodude";
            Names[75] = "Graveler";
            Names[76] = "Golem";
            Names[77] = "Ponyta";
            Names[78] = "Rapidash";
            Names[79] = "Slowpoke";
            Names[80] = "Slowbro";
            Names[81] = "Magnemite";
            Names[82] = "Magneton";
            Names[83] = "Farfetch 'd";
            Names[84] = "Doduo";
            Names[85] = "Dodrio";
            Names[86] = "Seel";
            Names[87] = "Dewgong";
            Names[88] = "Grimer";
            Names[89] = "Muk";
            Names[90] = "Shellder";
            Names[91] = "Cloyster";
            Names[92] = "Gastly";
            Names[93] = "Haunter";
            Names[94] = "Gengar";
            Names[95] = "Onix";
            Names[96] = "Drowzee";
            Names[97] = "Hypno";
            Names[98] = "Krabby";
            Names[99] = "Kingler";
            Names[100] = "Voltorb";
            Names[101] = "Electrode";
            Names[102] = "Exeggcute";
            Names[103] = "Exeggutor";
            Names[104] = "Cubone";
            Names[105] = "Marowak";
            Names[106] = "Hitmonlee";
            Names[107] = "Hitmonchan";
            Names[108] = "Lickitung";
            Names[109] = "Koffing";
            Names[110] = "Weezing";
            Names[111] = "Rhyhorn";
            Names[112] = "Rhydon";
            Names[113] = "Chansey";
            Names[114] = "Tangela";
            Names[115] = "Kangaskhan";
            Names[116] = "Horsea";
            Names[117] = "Seadra";
            Names[118] = "Goldeen";
            Names[119] = "Seaking";
            Names[120] = "Staryu";
            Names[121] = "Starmie";
            Names[122] = "Mr. Mime";
            Names[123] = "Scyther";
            Names[124] = "Jynx";
            Names[125] = "Electabuzz";
            Names[126] = "Magmar";
            Names[127] = "Pinsir";
            Names[128] = "Tauros";
            Names[129] = "Magikarp";
            Names[130] = "Gyarados";
            Names[131] = "Lapras";
            Names[132] = "Ditto";
            Names[133] = "Eevee";
            Names[134] = "Vaporeon";
            Names[135] = "Jolteon";
            Names[136] = "Flareon";
            Names[137] = "Porygon";
            Names[138] = "Omanyte";
            Names[139] = "Omastar";
            Names[140] = "Kabuto";
            Names[141] = "Kabutops";
            Names[142] = "Aerodactyl";
            Names[143] = "Snorlax";
            Names[144] = "Articuno";
            Names[145] = "Zapdos";
            Names[146] = "Moltres";
            Names[147] = "Dratini";
            Names[148] = "Dragonair";
            Names[149] = "Dragonite";
            Names[150] = "Mewtwo";
            Names[151] = "Mew";
            Names[152] = "Chikorita";
            Names[153] = "Bayleef";
            Names[154] = "Meganium";
            Names[155] = "Cyndaquil";
            Names[156] = "Quilava";
            Names[157] = "Typhlosion";
            Names[158] = "Totodile";
            Names[159] = "Croconaw";
            Names[160] = "Feraligatr";
            Names[161] = "Sentret";
            Names[162] = "Furret";
            Names[163] = "Hoothoot";
            Names[164] = "Noctowl";
            Names[165] = "Ledyba";
            Names[166] = "Ledian";
            Names[167] = "Spinarak";
            Names[168] = "Ariados";
            Names[169] = "Crobat";
            Names[170] = "Chinchou";
            Names[171] = "Lanturn";
            Names[172] = "Pichu";
            Names[173] = "Cleffa";
            Names[174] = "Igglybuff";
            Names[175] = "Togepi";
            Names[176] = "Togetic";
            Names[177] = "Natu";
            Names[178] = "Xatu";
            Names[179] = "Mareep";
            Names[180] = "Flaaffy";
            Names[181] = "Ampharos";
            Names[182] = "Bellossom";
            Names[183] = "Marill";
            Names[184] = "Azumarill";
            Names[185] = "Sudowoodo";
            Names[186] = "Politoed";
            Names[187] = "Hoppip";
            Names[188] = "Skiploom";
            Names[189] = "Jumpluff";
            Names[190] = "Aipom";
            Names[191] = "Sunkern";
            Names[192] = "Sunflora";
            Names[193] = "Yanma";
            Names[194] = "Wooper";
            Names[195] = "Quagsire";
            Names[196] = "Espeon";
            Names[197] = "Umbreon";
            Names[198] = "Murkrow";
            Names[199] = "Slowking";
            Names[200] = "Misdreavus";
            Names[201] = "Unown";
            Names[202] = "Wobbuffet";
            Names[203] = "Girafarig";
            Names[204] = "Pineco";
            Names[205] = "Forretress";
            Names[206] = "Dunsparce";
            Names[207] = "Gligar";
            Names[208] = "Steelix";
            Names[209] = "Snubbull";
            Names[210] = "Granbull";
            Names[211] = "Qwilfish";
            Names[212] = "Scizor";
            Names[213] = "Shuckle";
            Names[214] = "Heracross";
            Names[215] = "Sneasel";
            Names[216] = "Teddiursa";
            Names[217] = "Ursaring";
            Names[218] = "Slugma";
            Names[219] = "Magcargo";
            Names[220] = "Swinub";
            Names[221] = "Piloswine";
            Names[222] = "Corsola";
            Names[223] = "Remoraid";
            Names[224] = "Octillery";
            Names[225] = "Delibird";
            Names[226] = "Mantine";
            Names[227] = "Skarmory";
            Names[228] = "Houndour";
            Names[229] = "Houndoom";
            Names[230] = "Kingdra";
            Names[231] = "Phanpy";
            Names[232] = "Donphan";
            Names[233] = "Porygon2";
            Names[234] = "Stantler";
            Names[235] = "Smeargle";
            Names[236] = "Tyrogue";
            Names[237] = "Hitmontop";
            Names[238] = "Smoochum";
            Names[239] = "Elekid";
            Names[240] = "Magby";
            Names[241] = "Miltank";
            Names[242] = "Blissey";
            Names[243] = "Raikou";
            Names[244] = "Entei";
            Names[245] = "Suicune";
            Names[246] = "Larvitar";
            Names[247] = "Pupitar";
            Names[248] = "Tyranitar";
            Names[249] = "Lugia";
            Names[250] = "Ho-oh";
            Names[251] = "Celebi";
            Names[252] = "Treecko";
            Names[253] = "Grovyle";
            Names[254] = "Sceptile";
            Names[255] = "Torchic";
            Names[256] = "Combusken";
            Names[257] = "Blaziken";
            Names[258] = "Mudkip";
            Names[259] = "Marshtomp";
            Names[260] = "Swampert";
            Names[261] = "Poochyena";
            Names[262] = "Mightyena";
            Names[263] = "Zigzagoon";
            Names[264] = "Linoone";
            Names[265] = "Wurmple";
            Names[266] = "Silcoon";
            Names[267] = "Beautifly";
            Names[268] = "Cascoon";
            Names[269] = "Dustox";
            Names[270] = "Lotad";
            Names[271] = "Lombre";
            Names[272] = "Ludicolo";
            Names[273] = "Seedot";
            Names[274] = "Nuzleaf";
            Names[275] = "Shiftry";
            Names[276] = "Taillow";
            Names[277] = "Swellow";
            Names[278] = "Wingull";
            Names[279] = "Pelipper";
            Names[280] = "Ralts";
            Names[281] = "Kirlia";
            Names[282] = "Gardevoir";
            Names[283] = "Surskit";
            Names[284] = "Masquerain";
            Names[285] = "Shroomish";
            Names[286] = "Breloom";
            Names[287] = "Slakoth";
            Names[288] = "Vigoroth";
            Names[289] = "Slaking";
            Names[290] = "Nincada";
            Names[291] = "Ninjask";
            Names[292] = "Shedinja";
            Names[293] = "Whismur";
            Names[294] = "Loudred";
            Names[295] = "Exploud";
            Names[296] = "Makuhita";
            Names[297] = "Hariyama";
            Names[298] = "Azurill";
            Names[299] = "Nosepass";
            Names[300] = "Skitty";
            Names[301] = "Delcatty";
            Names[302] = "Sableye";
            Names[303] = "Mawile";
            Names[304] = "Aron";
            Names[305] = "Lairon";
            Names[306] = "Aggron";
            Names[307] = "Meditite";
            Names[308] = "Medicham";
            Names[309] = "Electrike";
            Names[310] = "Manectric";
            Names[311] = "Plusle";
            Names[312] = "Minun";
            Names[313] = "Volbeat";
            Names[314] = "Illumise";
            Names[315] = "Roselia";
            Names[316] = "Gulpin";
            Names[317] = "Swalot";
            Names[318] = "Carvanha";
            Names[319] = "Sharpedo";
            Names[320] = "Wailmer";
            Names[321] = "Wailord";
            Names[322] = "Numel";
            Names[323] = "Camerupt";
            Names[324] = "Torkoal";
            Names[325] = "Spoink";
            Names[326] = "Grumpig";
            Names[327] = "Spinda";
            Names[328] = "Trapinch";
            Names[329] = "Vibrava";
            Names[330] = "Flygon";
            Names[331] = "Cacnea";
            Names[332] = "Cacturne";
            Names[333] = "Swablu";
            Names[334] = "Altaria";
            Names[335] = "Zangoose";
            Names[336] = "Seviper";
            Names[337] = "Lunatone";
            Names[338] = "Solrock";
            Names[339] = "Barboach";
            Names[340] = "Whiscash";
            Names[341] = "Corphish";
            Names[342] = "Crawdaunt";
            Names[343] = "Baltoy";
            Names[344] = "Claydol";
            Names[345] = "Lileep";
            Names[346] = "Cradily";
            Names[347] = "Anorith";
            Names[348] = "Armaldo";
            Names[349] = "Feebas";
            Names[350] = "Milotic";
            Names[351] = "Castform";
            Names[352] = "Kecleon";
            Names[353] = "Shuppet";
            Names[354] = "Banette";
            Names[355] = "Duskull";
            Names[356] = "Dusclops";
            Names[357] = "Tropius";
            Names[358] = "Chimecho";
            Names[359] = "Absol";
            Names[360] = "Wynaut";
            Names[361] = "Snorunt";
            Names[362] = "Glalie";
            Names[363] = "Spheal";
            Names[364] = "Sealeo";
            Names[365] = "Walrein";
            Names[366] = "Clamperl";
            Names[367] = "Huntail";
            Names[368] = "Gorebyss";
            Names[369] = "Relicanth";
            Names[370] = "Luvdisc";
            Names[371] = "Bagon";
            Names[372] = "Shelgon";
            Names[373] = "Salamence";
            Names[374] = "Beldum";
            Names[375] = "Metang";
            Names[376] = "Metagross";
            Names[377] = "Regirock";
            Names[378] = "Regice";
            Names[379] = "Registeel";
            Names[380] = "Latias";
            Names[381] = "Latios";
            Names[382] = "Kyogre";
            Names[383] = "Groudon";
            Names[384] = "Rayquaza";
            Names[385] = "Jirachi";
            Names[386] = "Deoxys";
            Names[387] = "Turtwig";
            Names[388] = "Grotle";
            Names[389] = "Torterra";
            Names[390] = "Chimchar";
            Names[391] = "Monferno";
            Names[392] = "Infernape";
            Names[393] = "Piplup";
            Names[394] = "Prinplup";
            Names[395] = "Empoleon";
            Names[396] = "Starly";
            Names[397] = "Staravia";
            Names[398] = "Staraptor";
            Names[399] = "Bidoof";
            Names[400] = "Bibarel";
            Names[401] = "Kricketot";
            Names[402] = "Kricketune";
            Names[403] = "Shinx";
            Names[404] = "Luxio";
            Names[405] = "Luxray";
            Names[406] = "Budew";
            Names[407] = "Roserade";
            Names[408] = "Cranidos";
            Names[409] = "Rampardos";
            Names[410] = "Shieldon";
            Names[411] = "Bastiodon";
            Names[412] = "Burmy";
            Names[413] = "Wormadam";
            Names[414] = "Mothim";
            Names[415] = "Combee";
            Names[416] = "Vespiquen";
            Names[417] = "Pachirisu";
            Names[418] = "Buizel";
            Names[419] = "Floatzel";
            Names[420] = "Cherubi";
            Names[421] = "Cherrim";
            Names[422] = "Shellos";
            Names[423] = "Gastrodon";
            Names[424] = "Ambipom";
            Names[425] = "Drifloon";
            Names[426] = "Drifblim";
            Names[427] = "Buneary";
            Names[428] = "Lopunny";
            Names[429] = "Mismagius";
            Names[430] = "Honchkrow";
            Names[431] = "Glameow";
            Names[432] = "Purugly";
            Names[433] = "Chingling";
            Names[434] = "Stunky";
            Names[435] = "Skuntank";
            Names[436] = "Bronzor";
            Names[437] = "Bronzong";
            Names[438] = "Bonsly";
            Names[439] = "Mime Jr.";
            Names[440] = "Happiny";
            Names[441] = "Chatot";
            Names[442] = "Spiritomb";
            Names[443] = "Gible";
            Names[444] = "Gabite";
            Names[445] = "Garchomp";
            Names[446] = "Munchlax";
            Names[447] = "Riolu";
            Names[448] = "Lucario";
            Names[449] = "Hippopotas";
            Names[450] = "Hippowdon";
            Names[451] = "Skorupi";
            Names[452] = "Drapion";
            Names[453] = "Croagunk";
            Names[454] = "Toxicroak";
            Names[455] = "Carnivine";
            Names[456] = "Finneon";
            Names[457] = "Lumineon";
            Names[458] = "Mantyke";
            Names[459] = "Snover";
            Names[460] = "Abomasnow";
            Names[461] = "Weavile";
            Names[462] = "Magnezone";
            Names[463] = "Lickilicky";
            Names[464] = "Rhyperior";
            Names[465] = "Tangrowth";
            Names[466] = "Electivire";
            Names[467] = "Magmortar";
            Names[468] = "Togekiss";
            Names[469] = "Yanmega";
            Names[470] = "Leafeon";
            Names[471] = "Glaceon";
            Names[472] = "Gliscor";
            Names[473] = "Mamoswine";
            Names[474] = "Porygon-Z";
            Names[475] = "Gallade";
            Names[476] = "Probopass";
            Names[477] = "Dusknoir";
            Names[478] = "Froslass";
            Names[479] = "Rotom";
            Names[480] = "Uxie";
            Names[481] = "Mesprit";
            Names[482] = "Azelf";
            Names[483] = "Dialga";
            Names[484] = "Palkia";
            Names[485] = "Heatran";
            Names[486] = "Regigigas";
            Names[487] = "Giratina";
            Names[488] = "Cresselia";
            Names[489] = "Phione";
            Names[490] = "Manaphy";
            Names[491] = "Darkrai";
            Names[492] = "Shaymin";
            Names[493] = "Arceus";
            Names[494] = "Victini";
            Names[495] = "Snivy";
            Names[496] = "Servine";
            Names[497] = "Serperior";
            Names[498] = "Tepig";
            Names[499] = "Pignite";
            Names[500] = "Emboar";
            Names[501] = "Oshawott";
            Names[502] = "Dewott";
            Names[503] = "Samurott";
            Names[504] = "Patrat";
            Names[505] = "Watchog";
            Names[506] = "Lillipup";
            Names[507] = "Herdier";
            Names[508] = "Stoutland";
            Names[509] = "Purrloin";
            Names[510] = "Liepard";
            Names[511] = "Pansage";
            Names[512] = "Simisage";
            Names[513] = "Pansear";
            Names[514] = "Simisear";
            Names[515] = "Panpour";
            Names[516] = "Simipour";
            Names[517] = "Munna";
            Names[518] = "Musharna";
            Names[519] = "Pidove";
            Names[520] = "Tranquill";
            Names[521] = "Unfezant";
            Names[522] = "Blitzle";
            Names[523] = "Zebstrika";
            Names[524] = "Roggenrola";
            Names[525] = "Boldore";
            Names[526] = "Gigalith";
            Names[527] = "Woobat";
            Names[528] = "Swoobat";
            Names[529] = "Drilbur";
            Names[530] = "Excadrill";
            Names[531] = "Audino";
            Names[532] = "Timburr";
            Names[533] = "Gurdurr";
            Names[534] = "Conkeldurr";
            Names[535] = "Tympole";
            Names[536] = "Palpitoad";
            Names[537] = "Seismitoad";
            Names[538] = "Throh";
            Names[539] = "Sawk";
            Names[540] = "Sewaddle";
            Names[541] = "Swadloon";
            Names[542] = "Leavanny";
            Names[543] = "Venipede";
            Names[544] = "Whirlipede";
            Names[545] = "Scolipede";
            Names[546] = "Cottonee";
            Names[547] = "Whimsicott";
            Names[548] = "Petilil";
            Names[549] = "Lilligant";
            Names[550] = "Basculin";
            Names[551] = "Sandile";
            Names[552] = "Krokorok";
            Names[553] = "Krookodile";
            Names[554] = "Darumaka";
            Names[555] = "Darmanitan";
            Names[556] = "Maractus";
            Names[557] = "Dwebble";
            Names[558] = "Crustle";
            Names[559] = "Scraggy";
            Names[560] = "Scrafty";
            Names[561] = "Sigilyph";
            Names[562] = "Yamask";
            Names[563] = "Cofagrigus";
            Names[564] = "Tirtouga";
            Names[565] = "Carracosta";
            Names[566] = "Archen";
            Names[567] = "Archeops";
            Names[568] = "Trubbish";
            Names[569] = "Garbodor";
            Names[570] = "Zorua";
            Names[571] = "Zoroark";
            Names[572] = "Minccino";
            Names[573] = "Cinccino";
            Names[574] = "Gothita";
            Names[575] = "Gothorita";
            Names[576] = "Gothitelle";
            Names[577] = "Solosis";
            Names[578] = "Duosion";
            Names[579] = "Reuniclus";
            Names[580] = "Ducklett";
            Names[581] = "Swanna";
            Names[582] = "Vanillite";
            Names[583] = "Vanillish";
            Names[584] = "Vanilluxe";
            Names[585] = "Deerling";
            Names[586] = "Sawsbuck";
            Names[587] = "Emolga";
            Names[588] = "Karrablast";
            Names[589] = "Escavalier";
            Names[590] = "Foongus";
            Names[591] = "Amoonguss";
            Names[592] = "Frillish";
            Names[593] = "Jellicent";
            Names[594] = "Alomomola";
            Names[595] = "Joltik";
            Names[596] = "Galvantula";
            Names[597] = "Ferroseed";
            Names[598] = "Ferrothorn";
            Names[599] = "Klink";
            Names[600] = "Klang";
            Names[601] = "Klinklang";
            Names[602] = "Tynamo";
            Names[603] = "Eelektrik";
            Names[604] = "Eelektross";
            Names[605] = "Elgyem";
            Names[606] = "Beheeyem";
            Names[607] = "Litwick";
            Names[608] = "Lampent";
            Names[609] = "Chandelure";
            Names[610] = "Axew";
            Names[611] = "Fraxure";
            Names[612] = "Haxorus";
            Names[613] = "Cubchoo";
            Names[614] = "Beartic";
            Names[615] = "Cryogonal";
            Names[616] = "Shelmet";
            Names[617] = "Accelgor";
            Names[618] = "Stunfisk";
            Names[619] = "Mienfoo";
            Names[620] = "Mienshao";
            Names[621] = "Druddigon";
            Names[622] = "Golett";
            Names[623] = "Golurk";
            Names[624] = "Pawniard";
            Names[625] = "Bisharp";
            Names[626] = "Bouffalant";
            Names[627] = "Rufflet";
            Names[628] = "Braviary";
            Names[629] = "Vullaby";
            Names[630] = "Mandibuzz";
            Names[631] = "Heatmor";
            Names[632] = "Durant";
            Names[633] = "Deino";
            Names[634] = "Zweilous";
            Names[635] = "Hydreigon";
            Names[636] = "Larvesta";
            Names[637] = "Volcarona";
            Names[638] = "Cobalion";
            Names[639] = "Terrakion";
            Names[640] = "Virizion";
            Names[641] = "Tornadus";
            Names[642] = "Thundurus";
            Names[643] = "Reshiram";
            Names[644] = "Zekrom";
            Names[645] = "Landorus";
            Names[646] = "Kyurem";
            Names[647] = "Keldeo";
            Names[648] = "Meloetta";
            Names[649] = "Genesect";
            Names[650] = "Chespin";
            Names[651] = "Quilladin";
            Names[652] = "Chesnaught";
            Names[653] = "Fennekin";
            Names[654] = "Braixen";
            Names[655] = "Delphox";
            Names[656] = "Froakie";
            Names[657] = "Frogadier";
            Names[658] = "Greninja";
            Names[659] = "Bunnelby";
            Names[660] = "Diggersby";
            Names[661] = "Fletchling";
            Names[662] = "Fletchinder";
            Names[663] = "Talonflame";
            Names[664] = "Scatterbug";
            Names[665] = "Spewpa";
            Names[666] = "Vivillon";
            Names[667] = "Litleo";
            Names[668] = "Pyroar";
            Names[669] = "Flabebe";
            Names[670] = "Floette";
            Names[671] = "Florges";
            Names[672] = "Skiddo";
            Names[673] = "Gogoat";
            Names[674] = "Pancham";
            Names[675] = "Pangoro";
            Names[676] = "Furfrou";
            Names[677] = "Espurr";
            Names[678] = "Meowstic";
            Names[679] = "Honedge";
            Names[680] = "Doublade";
            Names[681] = "Aegislash";
            Names[682] = "Spritzee";
            Names[683] = "Aromatisse";
            Names[684] = "Swirlix";
            Names[685] = "Slurpuff";
            Names[686] = "Inkay";
            Names[687] = "Malamar";
            Names[688] = "Binacle";
            Names[689] = "Barbaracle";
            Names[690] = "Skrelp";
            Names[691] = "Dragalge";
            Names[692] = "Clauncher";
            Names[693] = "Clawitzer";
            Names[694] = "Helioptile";
            Names[695] = "Heliolisk";
            Names[696] = "Tyrunt";
            Names[697] = "Tyrantrum";
            Names[698] = "Amaura";
            Names[699] = "Aurorus";
            Names[700] = "Sylveon";
            Names[701] = "Hawlucha";
            Names[702] = "Dedenne";
            Names[703] = "Carbink";
            Names[704] = "Goomy";
            Names[705] = "Sliggoo";
            Names[706] = "Goodra";
            Names[707] = "Klefki";
            Names[708] = "Phantump";
            Names[709] = "Trevenant";
            Names[710] = "Pumpkaboo";
            Names[711] = "Gourgeist";
            Names[712] = "Bergmite";
            Names[713] = "Avalugg";
            Names[714] = "Noibat";
            Names[715] = "Noivern";
            Names[716] = "Xerneas";
            Names[717] = "Yveltal";
            Names[718] = "Zygarde";
            Names[719] = "Diancie";
            Names[720] = "Hoopa";
            Names[721] = "Volcanion";
            Names[722] = "Mega Fushigibana";
            Names[723] = "Mega Charizard X";
            Names[724] = "Mega Charizard Y";
            Names[725] = "Mega Blastoise";
            Names[726] = "Mega Alakazam";
            Names[727] = "Mega Gengar";
            Names[728] = "Mega Kangaskhan";
            Names[729] = "Mega Pinsir";
            Names[730] = "Mega Gyarados";
            Names[731] = "Mega Aerodactyl";
            Names[732] = "Mega Mewtwo X";
            Names[733] = "Mega Mewtwo Y";
            Names[734] = "Mega Ampharos";
            Names[735] = "Mega Scizor";
            Names[736] = "Mega Heracross";
            Names[737] = "Mega Houndoom";
            Names[738] = "Mega Tyranitar";
            Names[739] = "Mega Blaziken";
            Names[740] = "Mega Gardevoir";
            Names[741] = "Mega Mawile";
            Names[742] = "Mega Aggron";
            Names[743] = "Mega Medicham";
            Names[744] = "Mega Manectric";
            Names[745] = "Mega Banette";
            Names[746] = "Mega Absol";
            Names[747] = "Mega Garchomp";
            Names[748] = "Mega Lucario";
            Names[749] = "Mega Abomasnow";
            Names[750] = "Mega Beedrill";
            Names[751] = "Mega Pidgeot";
            Names[752] = "Mega Slowbro";
            Names[753] = "Mega Steelix";
            Names[754] = "Mega Sceptile";
            Names[755] = "Mega Swampert";
            Names[756] = "Mega Sableye";
            Names[757] = "Mega Sharpedo";
            Names[758] = "Mega Camerrupt";
            Names[759] = "Mega Altaria";
            Names[760] = "Mega Glalie";
            Names[761] = "Mega Salamence";
            Names[762] = "Mega Metagross";
            Names[763] = "Mega Latias";
            Names[764] = "Mega Latios";
            Names[765] = "Mega Rayquaza";
            Names[766] = "Mega Lopunny";
            Names[767] = "Mega Gallade";
            Names[768] = "Mega Audino";
            Names[769] = "Mega Diancie";
            Names[770] = "Primal Kyogre";
            Names[771] = "Primal Groudon";
            Names[772] = "SomePoke";
            Names[773] = "Mewtwo";
            Names[774] = "Crystal Onix";
            Names[775] = "XD001";
        }

        public static PokemonNamesManager Instance => _instance ?? (_instance = new PokemonNamesManager());

        public string[] Names { get; }
    }
}