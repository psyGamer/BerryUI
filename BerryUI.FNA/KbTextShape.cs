using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BerryUI.FNA;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_language : uint
{
    DONT_KNOW = 0,
    A_HMAO = ((uint)('H') | ((uint)('M') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    AARI = ((uint)('A') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    ABAZA = ((uint)('A') | ((uint)('B') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ABKHAZIAN = ((uint)('A') | ((uint)('B') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    ACHI = ((uint)('A') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    ACHOLI = ((uint)('A') | ((uint)('C') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    ADYGHE = ((uint)('A') | ((uint)('D') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    AFAR = ((uint)('A') | ((uint)('F') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    AFRIKAANS = ((uint)('A') | ((uint)('F') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    AGAW = ((uint)('A') | ((uint)('G') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    AITON = ((uint)('A') | ((uint)('I') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    AKAN = ((uint)('A') | ((uint)('K') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ALBANIAN = ((uint)('S') | ((uint)('Q') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    ALSATIAN = ((uint)('A') | ((uint)('L') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    ALTAI = ((uint)('A') | ((uint)('L') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    ALUO = ((uint)('Y') | ((uint)('N') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    AMERICAN_PHONETIC = ((uint)('A') | ((uint)('P') << 8) | ((uint)('P') << 16) | ((uint)('H') << 24)),
    AMHARIC = ((uint)('A') | ((uint)('M') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    ANGLO_SAXON = ((uint)('A') | ((uint)('N') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    ARABIC = ((uint)('A') | ((uint)('R') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ARAGONESE = ((uint)('A') | ((uint)('R') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    ARAKANESE = ((uint)('A') | ((uint)('R') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    ARAKWAL = ((uint)('R') | ((uint)('K') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    ARMENIAN = ((uint)('H') | ((uint)('Y') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    ARMENIAN_EAST = ((uint)('H') | ((uint)('Y') << 8) | ((uint)('E') << 16) | ((uint)('0') << 24)),
    AROMANIAN = ((uint)('R') | ((uint)('U') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    ARPITAN = ((uint)('F') | ((uint)('R') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    ASSAMESE = ((uint)('A') | ((uint)('S') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    ASTURIAN = ((uint)('A') | ((uint)('S') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    ATHAPASKAN = ((uint)('A') | ((uint)('T') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    ATSINA = ((uint)('A') | ((uint)('T') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    AVAR = ((uint)('A') | ((uint)('V') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    AVATIME = ((uint)('A') | ((uint)('V') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    AWADHI = ((uint)('A') | ((uint)('W') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    AYMARA = ((uint)('A') | ((uint)('Y') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    AZERBAIDJANI = ((uint)('A') | ((uint)('Z') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    BADAGA = ((uint)('B') | ((uint)('A') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    BAGHELKHANDI = ((uint)('B') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    BAGRI = ((uint)('B') | ((uint)('G') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    BALANTE = ((uint)('B') | ((uint)('L') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    BALINESE = ((uint)('B') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    BALKAR = ((uint)('B') | ((uint)('A') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    BALTI = ((uint)('B') | ((uint)('L') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    BALUCHI = ((uint)('B') | ((uint)('L') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    BAMBARA = ((uint)('B') | ((uint)('M') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    BAMILEKE = ((uint)('B') | ((uint)('M') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    BANDA = ((uint)('B') | ((uint)('A') << 8) | ((uint)('D') << 16) | ((uint)('0') << 24)),
    BANDJALANG = ((uint)('B') | ((uint)('D') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    BANGLA = ((uint)('B') | ((uint)('E') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    BASHKIR = ((uint)('B') | ((uint)('S') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    BASQUE = ((uint)('E') | ((uint)('U') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    BATAK = ((uint)('B') | ((uint)('T') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    BATAK_ALAS_KLUET = ((uint)('B') | ((uint)('T') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    BATAK_ANGKOLA = ((uint)('A') | ((uint)('K') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    BATAK_DAIRI = ((uint)('B') | ((uint)('T') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    BATAK_KARO = ((uint)('B') | ((uint)('T') << 8) | ((uint)('X') << 16) | ((uint)(' ') << 24)),
    BATAK_MANDAILING = ((uint)('B') | ((uint)('T') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    BATAK_SIMALUNGUN = ((uint)('B') | ((uint)('T') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    BATAK_TOBA = ((uint)('B') | ((uint)('B') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    BAULE = ((uint)('B') | ((uint)('A') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    BAVARIAN = ((uint)('B') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    BELARUSIAN = ((uint)('B') | ((uint)('E') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    BEMBA = ((uint)('B') | ((uint)('E') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    BENCH = ((uint)('B') | ((uint)('C') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    BERBER = ((uint)('B') | ((uint)('B') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    BETI = ((uint)('B') | ((uint)('T') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    BETTE_KURUMA = ((uint)('X') | ((uint)('U') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    BHILI = ((uint)('B') | ((uint)('H') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    BHOJPURI = ((uint)('B') | ((uint)('H') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    BHUTANESE = ((uint)('D') | ((uint)('Z') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    BIBLE_CREE = ((uint)('B') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    BIKOL = ((uint)('B') | ((uint)('I') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    BILEN = ((uint)('B') | ((uint)('I') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    BISHNUPRIYA_MANIPURI = ((uint)('B') | ((uint)('P') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    BISLAMA = ((uint)('B') | ((uint)('I') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    BLACKFOOT = ((uint)('B') | ((uint)('K') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    BODO = ((uint)('B') | ((uint)('R') << 8) | ((uint)('X') << 16) | ((uint)(' ') << 24)),
    BOSNIAN = ((uint)('B') | ((uint)('O') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    BOUYEI = ((uint)('P') | ((uint)('C') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    BRAHUI = ((uint)('B') | ((uint)('R') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    BRAJ_BHASHA = ((uint)('B') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    BRETON = ((uint)('B') | ((uint)('R') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    BUGIS = ((uint)('B') | ((uint)('U') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    BULGARIAN = ((uint)('B') | ((uint)('G') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    BUMTHANGKHA = ((uint)('K') | ((uint)('J') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    BURMESE = ((uint)('B') | ((uint)('R') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    BURUSHASKI = ((uint)('B') | ((uint)('S') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    CAJUN_FRENCH = ((uint)('F') | ((uint)('R') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    CARRIER = ((uint)('C') | ((uint)('R') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    CATALAN = ((uint)('C') | ((uint)('A') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    CAYUGA = ((uint)('C') | ((uint)('A') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    CEBUANO = ((uint)('C') | ((uint)('E') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    CENTRAL_YUPIK = ((uint)('E') | ((uint)('S') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    CHAHA_GURAGE = ((uint)('C') | ((uint)('H') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    CHAMORRO = ((uint)('C') | ((uint)('H') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    CHATTISGARHI = ((uint)('C') | ((uint)('H') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    CHECHEN = ((uint)('C') | ((uint)('H') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    CHEROKEE = ((uint)('C') | ((uint)('H') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    CHEYENNE = ((uint)('C') | ((uint)('H') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    CHICHEWA = ((uint)('C') | ((uint)('H') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    CHIGA = ((uint)('C') | ((uint)('G') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    CHIMILA = ((uint)('C') | ((uint)('B') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    CHIN = ((uint)('Q') | ((uint)('I') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    CHINANTEC = ((uint)('C') | ((uint)('C') << 8) | ((uint)('H') << 16) | ((uint)('N') << 24)),
    CHINESE_PHONETIC = ((uint)('Z') | ((uint)('H') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    CHINESE_SIMPLIFIED = ((uint)('Z') | ((uint)('H') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    CHINESE_TRADITIONAL = ((uint)('Z') | ((uint)('H') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    CHINESE_TRADITIONAL_HONG_KONG = ((uint)('Z') | ((uint)('H') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    CHINESE_TRADITIONAL_MACAO = ((uint)('Z') | ((uint)('H') << 8) | ((uint)('T') << 16) | ((uint)('M') << 24)),
    CHIPEWYAN = ((uint)('C') | ((uint)('H') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    CHITTAGONIAN = ((uint)('C') | ((uint)('T') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    CHOCTAW = ((uint)('C') | ((uint)('H') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    CHUKCHI = ((uint)('C') | ((uint)('H') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    CHURCH_SLAVONIC = ((uint)('C') | ((uint)('S') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    CHUUKESE = ((uint)('C') | ((uint)('H') << 8) | ((uint)('K') << 16) | ((uint)('0') << 24)),
    CHUVASH = ((uint)('C') | ((uint)('H') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    COMORIAN = ((uint)('C') | ((uint)('M') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    COMOX = ((uint)('C') | ((uint)('O') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    COPTIC = ((uint)('C') | ((uint)('O') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    CORNISH = ((uint)('C') | ((uint)('O') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    CORSICAN = ((uint)('C') | ((uint)('O') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    CREE = ((uint)('C') | ((uint)('R') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    CREOLES = ((uint)('C') | ((uint)('P') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    CRIMEAN_TATAR = ((uint)('C') | ((uint)('R') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    CRIOULO = ((uint)('K') | ((uint)('E') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    CROATIAN = ((uint)('H') | ((uint)('R') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    CYPRIOT_ARABIC = ((uint)('A') | ((uint)('C') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    CZECH = ((uint)('C') | ((uint)('S') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    DAGBANI = ((uint)('D') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    DAN = ((uint)('D') | ((uint)('N') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    DANGME = ((uint)('D') | ((uint)('N') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    DANISH = ((uint)('D') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    DARGWA = ((uint)('D') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    DARI = ((uint)('D') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    DAYI = ((uint)('D') | ((uint)('A') << 8) | ((uint)('X') << 16) | ((uint)(' ') << 24)),
    DEFAULT = ((uint)('d') | ((uint)('f') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    DEHONG_DAI = ((uint)('T') | ((uint)('D') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    DHANGU = ((uint)('D') | ((uint)('H') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    DHIVEHI = ((uint)('D') | ((uint)('I') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    DHUWAL = ((uint)('D') | ((uint)('U') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    DIMLI = ((uint)('D') | ((uint)('I') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    DINKA = ((uint)('D') | ((uint)('N') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    DIVEHI = ((uint)('D') | ((uint)('I') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    DJAMBARRPUYNGU = ((uint)('D') | ((uint)('J') << 8) | ((uint)('R') << 16) | ((uint)('0') << 24)),
    DOGRI = ((uint)('D') | ((uint)('G') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    DOGRI_MACROLANGUAGE = ((uint)('D') | ((uint)('G') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    DUNGAN = ((uint)('D') | ((uint)('U') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    DUTCH = ((uint)('N') | ((uint)('L') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    DZONGKHA = ((uint)('D') | ((uint)('Z') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    EASTERN_ABENAKI = ((uint)('A') | ((uint)('A') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    EASTERN_CHAM = ((uint)('C') | ((uint)('J') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    EASTERN_CREE = ((uint)('E') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    EASTERN_MANINKAKAN = ((uint)('E') | ((uint)('M') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    EASTERN_PWO_KAREN = ((uint)('K') | ((uint)('J') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    EBIRA = ((uint)('E') | ((uint)('B') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    EDO = ((uint)('E') | ((uint)('D') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    EFIK = ((uint)('E') | ((uint)('F') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    EMBERA_BAUDO = ((uint)('B') | ((uint)('D') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    EMBERA_CATIO = ((uint)('C') | ((uint)('T') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    EMBERA_CHAMI = ((uint)('C') | ((uint)('M') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    EMBERA_TADO = ((uint)('T') | ((uint)('D') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    ENGLISH = ((uint)('E') | ((uint)('N') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    EPENA = ((uint)('S') | ((uint)('J') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ERZYA = ((uint)('E') | ((uint)('R') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    KB_TEXT_SHAPEANTO = ((uint)('N') | ((uint)('T') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    ESTONIAN = ((uint)('E') | ((uint)('T') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    EVEN = ((uint)('E') | ((uint)('V') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    EVENKI = ((uint)('E') | ((uint)('V') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    EWE = ((uint)('E') | ((uint)('W') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    FALAM_CHIN = ((uint)('H') | ((uint)('A') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    FANG = ((uint)('F') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)('0') << 24)),
    FANTI = ((uint)('F') | ((uint)('A') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    FAROESE = ((uint)('F') | ((uint)('O') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    FEFE = ((uint)('F') | ((uint)('M') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    FIJIAN = ((uint)('F') | ((uint)('J') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    FILIPINO = ((uint)('P') | ((uint)('I') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    FINNISH = ((uint)('F') | ((uint)('I') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    FLEMISH = ((uint)('F') | ((uint)('L') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    FON = ((uint)('F') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    FOREST_ENETS = ((uint)('F') | ((uint)('N') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    FRENCH = ((uint)('F') | ((uint)('R') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    FRENCH_ANTILLEAN = ((uint)('F') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    FRISIAN = ((uint)('F') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    FRIULIAN = ((uint)('F') | ((uint)('R') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    FULAH = ((uint)('F') | ((uint)('U') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    FUTA = ((uint)('F') | ((uint)('T') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    GA = ((uint)('G') | ((uint)('A') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    GAGAUZ = ((uint)('G') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    GALICIAN = ((uint)('G') | ((uint)('A') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    GANDA = ((uint)('L') | ((uint)('U') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    GARHWALI = ((uint)('G') | ((uint)('A') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    GARO = ((uint)('G') | ((uint)('R') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    GARSHUNI = ((uint)('G') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    GEBA_KAREN = ((uint)('K') | ((uint)('V') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    GEEZ = ((uint)('G') | ((uint)('E') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    GEORGIAN = ((uint)('K') | ((uint)('A') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    GEPO = ((uint)('Y') | ((uint)('G') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    GERMAN = ((uint)('D') | ((uint)('E') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    GIKUYU = ((uint)('K') | ((uint)('I') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    GILAKI = ((uint)('G') | ((uint)('L') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    GILBERTESE = ((uint)('G') | ((uint)('I') << 8) | ((uint)('L') << 16) | ((uint)('0') << 24)),
    GILYAK = ((uint)('G') | ((uint)('I') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    GITHABUL = ((uint)('G') | ((uint)('I') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    GOGO = ((uint)('G') | ((uint)('O') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    GONDI = ((uint)('G') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    GREEK = ((uint)('E') | ((uint)('L') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    GREENLANDIC = ((uint)('G') | ((uint)('R') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    GUARANI = ((uint)('G') | ((uint)('U') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    GUINEA = ((uint)('G') | ((uint)('K') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    GUJARATI = ((uint)('G') | ((uint)('U') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    GUMATJ = ((uint)('G') | ((uint)('N') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    GUMUZ = ((uint)('G') | ((uint)('M') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    GUPAPUYNGU = ((uint)('G') | ((uint)('U') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    GUSII = ((uint)('G') | ((uint)('U') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    HAIDA = ((uint)('H') | ((uint)('A') << 8) | ((uint)('I') << 16) | ((uint)('0') << 24)),
    HAITIAN_CREOLE = ((uint)('H') | ((uint)('A') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    HALKOMELEM = ((uint)('H') | ((uint)('U') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    HAMMER_BANNA = ((uint)('H') | ((uint)('B') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    HARARI = ((uint)('H') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    HARAUTI = ((uint)('H') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    HARYANVI = ((uint)('B') | ((uint)('G') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    HAUSA = ((uint)('H') | ((uint)('A') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    HAVASUPAI_WALAPAI_YAVAPAI = ((uint)('Y') | ((uint)('U') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    HAWAIIAN = ((uint)('H') | ((uint)('A') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    HAYA = ((uint)('H') | ((uint)('A') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    HAZARAGI = ((uint)('H') | ((uint)('A') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    HEBREW = ((uint)('I') | ((uint)('W') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    HEILTSUK = ((uint)('H') | ((uint)('E') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    HERERO = ((uint)('H') | ((uint)('E') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    HIGH_MARI = ((uint)('H') | ((uint)('M') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    HILIGAYNON = ((uint)('H') | ((uint)('I') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    HINDI = ((uint)('H') | ((uint)('I') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    HINDKO = ((uint)('H') | ((uint)('N') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    HIRI_MOTU = ((uint)('H') | ((uint)('M') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    HMONG = ((uint)('H') | ((uint)('M') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    HMONG_DAW = ((uint)('M') | ((uint)('W') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    HMONG_SHUAT = ((uint)('H') | ((uint)('M') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    HO = ((uint)('H') | ((uint)('O') << 8) | ((uint)(' ') << 16) | ((uint)(' ') << 24)),
    HUNGARIAN = ((uint)('H') | ((uint)('U') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    IBAN = ((uint)('I') | ((uint)('B') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    IBIBIO = ((uint)('I') | ((uint)('B') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    ICELANDIC = ((uint)('I') | ((uint)('S') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    IDO = ((uint)('I') | ((uint)('D') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    IGBO = ((uint)('I') | ((uint)('B') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    IJO = ((uint)('I') | ((uint)('J') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    ILOKANO = ((uint)('I') | ((uint)('L') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    INARI_SAMI = ((uint)('I') | ((uint)('S') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    INDONESIAN = ((uint)('I') | ((uint)('N') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    INGUSH = ((uint)('I') | ((uint)('N') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    INTERLINGUA = ((uint)('I') | ((uint)('N') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    INTERLINGUE = ((uint)('I') | ((uint)('L') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    INUKTITUT = ((uint)('I') | ((uint)('N') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    INUPIAT = ((uint)('I') | ((uint)('P') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    IPA_PHONETIC = ((uint)('I') | ((uint)('P') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    IRISH = ((uint)('I') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    IRISH_TRADITIONAL = ((uint)('I') | ((uint)('R') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    IRULA = ((uint)('I') | ((uint)('R') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    ITALIAN = ((uint)('I') | ((uint)('T') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    JAMAICAN_CREOLE = ((uint)('J') | ((uint)('A') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    JAPANESE = ((uint)('J') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    JAVANESE = ((uint)('J') | ((uint)('A') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    JENNU_KURUMA = ((uint)('X') | ((uint)('U') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    JUDEO_TAT = ((uint)('J') | ((uint)('D') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    JULA = ((uint)('J') | ((uint)('U') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    KABARDIAN = ((uint)('K') | ((uint)('A') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    KABYLE = ((uint)('K') | ((uint)('A') << 8) | ((uint)('B') << 16) | ((uint)('0') << 24)),
    KACHCHI = ((uint)('K') | ((uint)('A') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    KADIWEU = ((uint)('K') | ((uint)('B') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    KALENJIN = ((uint)('K') | ((uint)('A') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    KALMYK = ((uint)('K') | ((uint)('L') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    KAMBA = ((uint)('K') | ((uint)('M') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    KANAUJI = ((uint)('B') | ((uint)('J') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    KANNADA = ((uint)('K') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    KANURI = ((uint)('K') | ((uint)('N') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    KAQCHIKEL = ((uint)('C') | ((uint)('A') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KARACHAY = ((uint)('K') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    KARAIM = ((uint)('K') | ((uint)('R') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    KARAKALPAK = ((uint)('K') | ((uint)('R') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KARELIAN = ((uint)('K') | ((uint)('R') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    KAREN = ((uint)('K') | ((uint)('R') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    KASHMIRI = ((uint)('K') | ((uint)('S') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    KASHUBIAN = ((uint)('C') | ((uint)('S') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    KATE = ((uint)('K') | ((uint)('M') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    KAZAKH = ((uint)('K') | ((uint)('A') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    KEBENA = ((uint)('K') | ((uint)('E') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    KEKCHI = ((uint)('K') | ((uint)('E') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KHAKASS = ((uint)('K') | ((uint)('H') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    KHAMTI_SHAN = ((uint)('K') | ((uint)('H') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    KHAMYANG = ((uint)('K') | ((uint)('S') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    KHANTY_KAZIM = ((uint)('K') | ((uint)('H') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KHANTY_SHURISHKAR = ((uint)('K') | ((uint)('H') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    KHANTY_VAKHI = ((uint)('K') | ((uint)('H') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    KHASI = ((uint)('K') | ((uint)('S') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    KHENGKHA = ((uint)('X') | ((uint)('K') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    KHINALUG = ((uint)('K') | ((uint)('J') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    KHMER = ((uint)('K') | ((uint)('H') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    KHORASANI_TURKIC = ((uint)('K') | ((uint)('M') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    KHOWAR = ((uint)('K') | ((uint)('H') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    KHUTSURI_GEORGIAN = ((uint)('K') | ((uint)('G') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    KICHE = ((uint)('Q') | ((uint)('U') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    KIKONGO = ((uint)('K') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    KILDIN_SAMI = ((uint)('K') | ((uint)('S') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    KINYARWANDA = ((uint)('R') | ((uint)('U') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    KIRMANJKI = ((uint)('K') | ((uint)('I') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    KISII = ((uint)('K') | ((uint)('I') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    KITUBA = ((uint)('M') | ((uint)('K') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    KODAGU = ((uint)('K') | ((uint)('O') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    KOKNI = ((uint)('K') | ((uint)('K') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    KOMI = ((uint)('K') | ((uint)('O') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    KOMI_PERMYAK = ((uint)('K') | ((uint)('O') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    KOMI_ZYRIAN = ((uint)('K') | ((uint)('O') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    KOMO = ((uint)('K') | ((uint)('M') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    KOMSO = ((uint)('K') | ((uint)('M') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    KONGO = ((uint)('K') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)('0') << 24)),
    KONKANI = ((uint)('K') | ((uint)('O') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KOORETE = ((uint)('K') | ((uint)('R') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    KOREAN = ((uint)('K') | ((uint)('O') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    KOREAO_OLD_HANGUL = ((uint)('K') | ((uint)('O') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    KORYAK = ((uint)('K') | ((uint)('Y') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KOSRAEAN = ((uint)('K') | ((uint)('O') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    KPELLE = ((uint)('K') | ((uint)('P') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    KPELLE_LIBERIA = ((uint)('X') | ((uint)('P') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    KRIO = ((uint)('K') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    KRYMCHAK = ((uint)('J') | ((uint)('C') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    KUANYAMA = ((uint)('K') | ((uint)('U') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    KUBE = ((uint)('K') | ((uint)('G') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    KUI = ((uint)('K') | ((uint)('U') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    KULVI = ((uint)('K') | ((uint)('U') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KUMAONI = ((uint)('K') | ((uint)('M') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    KUMYK = ((uint)('K') | ((uint)('U') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    KURDISH = ((uint)('K') | ((uint)('U') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    KURUKH = ((uint)('K') | ((uint)('U') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    KUY = ((uint)('K') | ((uint)('U') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    KWAKWALA = ((uint)('K') | ((uint)('W') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    KYRGYZ = ((uint)('K') | ((uint)('I') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    L_CREE = ((uint)('L') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    LADAKHI = ((uint)('L') | ((uint)('D') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    LADIN = ((uint)('L') | ((uint)('A') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    LADINO = ((uint)('J') | ((uint)('U') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    LAHULI = ((uint)('L') | ((uint)('A') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    LAK = ((uint)('L') | ((uint)('A') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    LAKI = ((uint)('L') | ((uint)('K') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    LAMBANI = ((uint)('L') | ((uint)('A') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    LAMPUNG = ((uint)('L') | ((uint)('J') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    LAO = ((uint)('L') | ((uint)('A') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    LATIN = ((uint)('L') | ((uint)('A') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    LATVIAN = ((uint)('L') | ((uint)('V') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    LAZ = ((uint)('L') | ((uint)('A') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    LELEMI = ((uint)('L') | ((uint)('E') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    LEZGI = ((uint)('L') | ((uint)('E') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    LIGURIAN = ((uint)('L') | ((uint)('I') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    LIMBU = ((uint)('L') | ((uint)('M') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    LIMBURGISH = ((uint)('L') | ((uint)('I') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    LINGALA = ((uint)('L') | ((uint)('I') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    LIPO = ((uint)('L') | ((uint)('P') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    LISU = ((uint)('L') | ((uint)('I') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    LITHUANIAN = ((uint)('L') | ((uint)('T') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    LIV = ((uint)('L') | ((uint)('I') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    LOJBAN = ((uint)('J') | ((uint)('B') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    LOMA = ((uint)('L') | ((uint)('O') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    LOMBARD = ((uint)('L') | ((uint)('M') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    LOMWE = ((uint)('L') | ((uint)('M') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    LOW_MARI = ((uint)('L') | ((uint)('M') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    LOW_SAXON = ((uint)('N') | ((uint)('D') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    LOWER_SORBIAN = ((uint)('L') | ((uint)('S') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    LU = ((uint)('X') | ((uint)('B') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    LUBA_KATANGA = ((uint)('L') | ((uint)('U') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    LUBA_LULUA = ((uint)('L') | ((uint)('U') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    LULE_SAMI = ((uint)('L') | ((uint)('S') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    LUO = ((uint)('L') | ((uint)('U') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    LURI = ((uint)('L') | ((uint)('R') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    LUSHOOTSEED = ((uint)('L') | ((uint)('U') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    LUXEMBOURGISH = ((uint)('L') | ((uint)('T') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    LUYIA = ((uint)('L') | ((uint)('U') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    MACEDONIAN = ((uint)('M') | ((uint)('K') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    MADURA = ((uint)('M') | ((uint)('A') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    MAGAHI = ((uint)('M') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    MAITHILI = ((uint)('M') | ((uint)('T') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    MAJANG = ((uint)('M') | ((uint)('A') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    MAKASAR = ((uint)('M') | ((uint)('K') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MAKHUWA = ((uint)('M') | ((uint)('A') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    MAKONDE = ((uint)('K') | ((uint)('D') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    MALAGASY = ((uint)('M') | ((uint)('L') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    MALAY = ((uint)('M') | ((uint)('L') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    MALAYALAM = ((uint)('M') | ((uint)('A') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    MALAYALAM_REFORMED = ((uint)('M') | ((uint)('L') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MALE = ((uint)('M') | ((uint)('L') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    MALINKE = ((uint)('M') | ((uint)('L') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MALTESE = ((uint)('M') | ((uint)('T') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    MAM = ((uint)('M') | ((uint)('A') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    MANCHU = ((uint)('M') | ((uint)('C') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    MANDAR = ((uint)('M') | ((uint)('D') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MANDINKA = ((uint)('M') | ((uint)('N') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    MANINKA = ((uint)('M') | ((uint)('N') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    MANIPURI = ((uint)('M') | ((uint)('N') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    MANO = ((uint)('M') | ((uint)('E') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    MANSI = ((uint)('M') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MANX = ((uint)('M') | ((uint)('N') << 8) | ((uint)('X') << 16) | ((uint)(' ') << 24)),
    MAORI = ((uint)('M') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    MAPUDUNGUN = ((uint)('M') | ((uint)('A') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    MARATHI = ((uint)('M') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MARSHALLESE = ((uint)('M') | ((uint)('A') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    MARWARI = ((uint)('M') | ((uint)('A') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    MAYAN = ((uint)('M') | ((uint)('Y') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MAZANDERANI = ((uint)('M') | ((uint)('Z') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MBEMBE_TIGON = ((uint)('N') | ((uint)('Z') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    MBO = ((uint)('M') | ((uint)('B') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    MBUNDU = ((uint)('M') | ((uint)('B') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MEDUMBA = ((uint)('B') | ((uint)('Y') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    MEEN = ((uint)('M') | ((uint)('E') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MENDE = ((uint)('M') | ((uint)('D') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    MERU = ((uint)('M') | ((uint)('E') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MEWATI = ((uint)('W') | ((uint)('T') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    MINANGKABAU = ((uint)('M') | ((uint)('I') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MINJANGBAL = ((uint)('X') | ((uint)('J') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    MIRANDESE = ((uint)('M') | ((uint)('W') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    MIZO = ((uint)('M') | ((uint)('I') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    MOHAWK = ((uint)('M') | ((uint)('O') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    MOKSHA = ((uint)('M') | ((uint)('O') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    MOLDAVIAN = ((uint)('M') | ((uint)('O') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    MON = ((uint)('M') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MONGOLIAN = ((uint)('M') | ((uint)('N') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    MOOSE_CREE = ((uint)('M') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MORISYEN = ((uint)('M') | ((uint)('F') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    MOROCCAN = ((uint)('M') | ((uint)('O') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    MOSSI = ((uint)('M') | ((uint)('P') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    MUNDARI = ((uint)('M') | ((uint)('U') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    MUSCOGEE = ((uint)('M') | ((uint)('U') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    N_CREE = ((uint)('N') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    NAGA_ASSAMESE = ((uint)('N') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    NAGARI = ((uint)('N') | ((uint)('G') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    NAHUATL = ((uint)('N') | ((uint)('A') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    NANAI = ((uint)('N') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    NASKAPI = ((uint)('N') | ((uint)('A') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    NAURUAN = ((uint)('N') | ((uint)('A') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    NAVAJO = ((uint)('N') | ((uint)('A') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    NDAU = ((uint)('N') | ((uint)('D') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    NDEBELE = ((uint)('N') | ((uint)('D') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    NDONGA = ((uint)('N') | ((uint)('D') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    NEAPOLITAN = ((uint)('N') | ((uint)('A') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    NEPALI = ((uint)('N') | ((uint)('E') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    NEWARI = ((uint)('N') | ((uint)('E') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    NGBAKA = ((uint)('N') | ((uint)('G') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    NIGERIAN_FULFULDE = ((uint)('F') | ((uint)('U') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    NIMADI = ((uint)('N') | ((uint)('O') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    NISI = ((uint)('N') | ((uint)('I') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    NIUEAN = ((uint)('N') | ((uint)('I') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    NKO = ((uint)('N') | ((uint)('K') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    NOGAI = ((uint)('N') | ((uint)('O') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    NORFOLK = ((uint)('P') | ((uint)('I') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    NORTH_SLAVEY = ((uint)('S') | ((uint)('C') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    NORTHERN_EMBERA = ((uint)('E') | ((uint)('M') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    NORTHERN_SAMI = ((uint)('N') | ((uint)('S') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    NORTHERN_SOTHO = ((uint)('N') | ((uint)('S') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    NORTHERN_TAI = ((uint)('N') | ((uint)('T') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    NORWAY_HOUSE_CREE = ((uint)('N') | ((uint)('H') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    NORWEGIAN = ((uint)('N') | ((uint)('O') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    NORWEGIAN_NYNORSK = ((uint)('N') | ((uint)('Y') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    NOVIAL = ((uint)('N') | ((uint)('O') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    NUMANGGANG = ((uint)('N') | ((uint)('O') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    NUNAVIK_INUKTITUT = ((uint)('I') | ((uint)('N') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    NUU_CHAH_NULTH = ((uint)('N') | ((uint)('U') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    NYAMWEZI = ((uint)('N') | ((uint)('Y') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    NYANKOLE = ((uint)('N') | ((uint)('K') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    OCCITAN = ((uint)('O') | ((uint)('C') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    ODIA = ((uint)('O') | ((uint)('R') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    OJI_CREE = ((uint)('O') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    OJIBWAY = ((uint)('O') | ((uint)('J') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    OLD_IRISH = ((uint)('S') | ((uint)('G') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    OLD_JAVANESE = ((uint)('K') | ((uint)('A') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    ONEIDA = ((uint)('O') | ((uint)('N') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    ONONDAGA = ((uint)('O') | ((uint)('N') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    OROMO = ((uint)('O') | ((uint)('R') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    OSSETIAN = ((uint)('O') | ((uint)('S') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    PA_O_KAREN = ((uint)('B') | ((uint)('L') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    PALAUAN = ((uint)('P') | ((uint)('A') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    PALAUNG = ((uint)('P') | ((uint)('L') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    PALESTINIAN_ARAMAIC = ((uint)('P') | ((uint)('A') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    PALI = ((uint)('P') | ((uint)('A') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    PALPA = ((uint)('P') | ((uint)('A') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    PAMPANGAN = ((uint)('P') | ((uint)('A') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    PANGASINAN = ((uint)('P') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    PAPIAMENTU = ((uint)('P') | ((uint)('A') << 8) | ((uint)('P') << 16) | ((uint)('0') << 24)),
    PASHTO = ((uint)('P') | ((uint)('A') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    PATTANI_MALAY = ((uint)('M') | ((uint)('F') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    PENNSYLVANIA_GERMAN = ((uint)('P') | ((uint)('D') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    PERSIAN = ((uint)('F') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    PHAKE = ((uint)('P') | ((uint)('J') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    PICARD = ((uint)('P') | ((uint)('C') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    PIEMONTESE = ((uint)('P') | ((uint)('M') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    PILAGA = ((uint)('P') | ((uint)('L') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    PITE_SAMI = ((uint)('S') | ((uint)('J') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    POCOMCHI = ((uint)('P') | ((uint)('O') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    POHNPEIAN = ((uint)('P') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    POLISH = ((uint)('P') | ((uint)('L') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    POLYTONIC_GREEK = ((uint)('P') | ((uint)('G') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    PORTUGUESE = ((uint)('P') | ((uint)('T') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    PROVENCAL = ((uint)('P') | ((uint)('R') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    PUNJABI = ((uint)('P') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    QUECHUA = ((uint)('Q') | ((uint)('U') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    QUECHUA_BOLIVIA = ((uint)('Q') | ((uint)('U') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    QUECHUA_ECUADOR = ((uint)('Q') | ((uint)('V') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    QUECHUA_PERU = ((uint)('Q') | ((uint)('W') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    R_CREE = ((uint)('R') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    RAJASTHANI = ((uint)('R') | ((uint)('A') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    RAKHINE = ((uint)('A') | ((uint)('R') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    RAROTONGAN = ((uint)('R') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    REJANG = ((uint)('R') | ((uint)('E') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    RIANG = ((uint)('R') | ((uint)('I') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    RIPUARIAN = ((uint)('K') | ((uint)('S') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    RITARUNGO = ((uint)('R') | ((uint)('I') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    ROHINGYA = ((uint)('R') | ((uint)('H') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    ROMANIAN = ((uint)('R') | ((uint)('O') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    ROMANSH = ((uint)('R') | ((uint)('M') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    ROMANY = ((uint)('R') | ((uint)('O') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    ROTUMAN = ((uint)('R') | ((uint)('T') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    RUNDI = ((uint)('R') | ((uint)('U') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    RUSSIAN = ((uint)('R') | ((uint)('U') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    RUSSIAN_BURIAT = ((uint)('R') | ((uint)('B') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    RUSYN = ((uint)('R') | ((uint)('S') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    SADRI = ((uint)('S') | ((uint)('A') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    SAKHA = ((uint)('Y') | ((uint)('A') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    SAMOAN = ((uint)('S') | ((uint)('M') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    SAMOGITIAN = ((uint)('S') | ((uint)('G') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    SAN_BLAS_KUNA = ((uint)('C') | ((uint)('U') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    SANGO = ((uint)('S') | ((uint)('G') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    SANSKRIT = ((uint)('S') | ((uint)('A') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    SANTALI = ((uint)('S') | ((uint)('A') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    SARAIKI = ((uint)('S') | ((uint)('R') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    SARDINIAN = ((uint)('S') | ((uint)('R') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    SASAK = ((uint)('S') | ((uint)('A') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    SATERLAND_FRISIAN = ((uint)('S') | ((uint)('T') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    SAYISI = ((uint)('S') | ((uint)('A') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    SCOTS = ((uint)('S') | ((uint)('C') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    SCOTTISH_GAELIC = ((uint)('G') | ((uint)('A') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    SEKOTA = ((uint)('S') | ((uint)('E') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    SELKUP = ((uint)('S') | ((uint)('E') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    SENA = ((uint)('S') | ((uint)('N') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    SENECA = ((uint)('S') | ((uint)('E') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    SERBIAN = ((uint)('S') | ((uint)('R') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    SERER = ((uint)('S') | ((uint)('R') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    SGAW_KAREN = ((uint)('K') | ((uint)('S') << 8) | ((uint)('W') << 16) | ((uint)(' ') << 24)),
    SHAN = ((uint)('S') | ((uint)('H') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    SHONA = ((uint)('S') | ((uint)('N') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    SIBE = ((uint)('S') | ((uint)('I') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    SICILIAN = ((uint)('S') | ((uint)('C') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    SIDAMO = ((uint)('S') | ((uint)('I') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    SILESIAN = ((uint)('S') | ((uint)('Z') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    SILTE_GURAGE = ((uint)('S') | ((uint)('I') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    SINDHI = ((uint)('S') | ((uint)('N') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    SINHALA = ((uint)('S') | ((uint)('N') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    SKOLT_SAMI = ((uint)('S') | ((uint)('K') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    SLAVEY = ((uint)('S') | ((uint)('L') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    SLOVAK = ((uint)('S') | ((uint)('K') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    SLOVENIAN = ((uint)('S') | ((uint)('L') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    SMALL_FLOWERY_MIAO = ((uint)('S') | ((uint)('F') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    SODO_GURAGE = ((uint)('S') | ((uint)('O') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    SOGA = ((uint)('X') | ((uint)('O') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    SOMALI = ((uint)('S') | ((uint)('M') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    SONGE = ((uint)('S') | ((uint)('O') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    SONINKE = ((uint)('S') | ((uint)('N') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    SOUTH_SLAVEY = ((uint)('S') | ((uint)('S') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    SOUTHERN_KIWAI = ((uint)('K') | ((uint)('J') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    SOUTHERN_SAMI = ((uint)('S') | ((uint)('S') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    SOUTHERN_SOTHO = ((uint)('S') | ((uint)('O') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    SPANISH = ((uint)('E') | ((uint)('S') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    STANDARD_MOROCCAN_TAMAZIGHT = ((uint)('Z') | ((uint)('G') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    STRAITS_SALISH = ((uint)('S') | ((uint)('T') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    SUKUMA = ((uint)('S') | ((uint)('U') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    SUNDANESE = ((uint)('S') | ((uint)('U') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    SURI = ((uint)('S') | ((uint)('U') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    SUTU = ((uint)('S') | ((uint)('X') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    SVAN = ((uint)('S') | ((uint)('V') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    SWADAYA_ARAMAIC = ((uint)('S') | ((uint)('W') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    SWAHILI = ((uint)('S') | ((uint)('W') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    SWATI = ((uint)('S') | ((uint)('W') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    SWEDISH = ((uint)('S') | ((uint)('V') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    SYLHETI = ((uint)('S') | ((uint)('Y') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    SYRIAC = ((uint)('S') | ((uint)('Y') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    SYRIAC_EASTERN = ((uint)('S') | ((uint)('Y') << 8) | ((uint)('R') << 16) | ((uint)('N') << 24)),
    SYRIAC_ESTRANGELA = ((uint)('S') | ((uint)('Y') << 8) | ((uint)('R') << 16) | ((uint)('E') << 24)),
    SYRIAC_WESTERN = ((uint)('S') | ((uint)('Y') << 8) | ((uint)('R') << 16) | ((uint)('J') << 24)),
    TABASARAN = ((uint)('T') | ((uint)('A') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    TACHELHIT = ((uint)('S') | ((uint)('H') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    TAGALOG = ((uint)('T') | ((uint)('G') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    TAHAGGART_TAMAHAQ = ((uint)('T') | ((uint)('H') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    TAHITIAN = ((uint)('T') | ((uint)('H') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    TAI_LAING = ((uint)('T') | ((uint)('J') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    TAJIKI = ((uint)('T') | ((uint)('A') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    TALYSH = ((uint)('T') | ((uint)('L') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    TAMASHEK = ((uint)('T') | ((uint)('M') << 8) | ((uint)('H') << 16) | ((uint)(' ') << 24)),
    TAMASHEQ = ((uint)('T') | ((uint)('A') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    TAMAZIGHT = ((uint)('T') | ((uint)('Z') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    TAMIL = ((uint)('T') | ((uint)('A') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    TARIFIT = ((uint)('R') | ((uint)('I') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    TATAR = ((uint)('T') | ((uint)('A') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    TAWALLAMMAT_TAMAJAQ = ((uint)('T') | ((uint)('T') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    TAY = ((uint)('T') | ((uint)('Y') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    TAYART_TAMAJEQ = ((uint)('T') | ((uint)('H') << 8) | ((uint)('Z') << 16) | ((uint)(' ') << 24)),
    TELUGU = ((uint)('T') | ((uint)('E') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    TEMNE = ((uint)('T') | ((uint)('M') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    TETUM = ((uint)('T') | ((uint)('E') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    TH_CREE = ((uint)('T') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    THAI = ((uint)('T') | ((uint)('H') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    THAILAND_MON = ((uint)('M') | ((uint)('O') << 8) | ((uint)('N') << 16) | ((uint)('T') << 24)),
    THOMPSON = ((uint)('T') | ((uint)('H') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    TIBETAN = ((uint)('T') | ((uint)('I') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    TIGRE = ((uint)('T') | ((uint)('G') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    TIGRINYA = ((uint)('T') | ((uint)('G') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    TIV = ((uint)('T') | ((uint)('I') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    TLINGIT = ((uint)('T') | ((uint)('L') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    TOBO = ((uint)('T') | ((uint)('B') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    TODO = ((uint)('T') | ((uint)('O') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    TOK_PISIN = ((uint)('T') | ((uint)('P') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    TOMA = ((uint)('T') | ((uint)('O') << 8) | ((uint)('D') << 16) | ((uint)('0') << 24)),
    TONGA = ((uint)('T') | ((uint)('N') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    TONGAN = ((uint)('T') | ((uint)('G') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    TORKI = ((uint)('A') | ((uint)('Z') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    TSHANGLA = ((uint)('T') | ((uint)('S') << 8) | ((uint)('J') << 16) | ((uint)(' ') << 24)),
    TSONGA = ((uint)('T') | ((uint)('S') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    TSWANA = ((uint)('T') | ((uint)('N') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    TULU = ((uint)('T') | ((uint)('U') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    TUMBUKA = ((uint)('T') | ((uint)('U') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    TUNDRA_ENETS = ((uint)('T') | ((uint)('N') << 8) | ((uint)('E') << 16) | ((uint)(' ') << 24)),
    TURKISH = ((uint)('T') | ((uint)('R') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    TURKMEN = ((uint)('T') | ((uint)('K') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    TUROYO_ARAMAIC = ((uint)('T') | ((uint)('U') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    TUSCARORA = ((uint)('T') | ((uint)('U') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    TUVALU = ((uint)('T') | ((uint)('V') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    TUVIN = ((uint)('T') | ((uint)('U') << 8) | ((uint)('V') << 16) | ((uint)(' ') << 24)),
    TWI = ((uint)('T') | ((uint)('W') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    TZOTZIL = ((uint)('T') | ((uint)('Z') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    UDI = ((uint)('U') | ((uint)('D') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    UDMURT = ((uint)('U') | ((uint)('D') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    UKRAINIAN = ((uint)('U') | ((uint)('K') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    UMBUNDU = ((uint)('U') | ((uint)('M') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    UME_SAMI = ((uint)('S') | ((uint)('J') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    UPPER_SAXON = ((uint)('S') | ((uint)('X') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    UPPER_SORBIAN = ((uint)('U') | ((uint)('S') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    URALIC_PHONETIC = ((uint)('U') | ((uint)('P') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    URDU = ((uint)('U') | ((uint)('R') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    UYGHUR = ((uint)('U') | ((uint)('Y') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    UZBEK = ((uint)('U') | ((uint)('Z') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    VENDA = ((uint)('V') | ((uint)('E') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    VENETIAN = ((uint)('V') | ((uint)('E') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    VIETNAMESE = ((uint)('V') | ((uint)('I') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    VLAX_ROMANI = ((uint)('R') | ((uint)('M') << 8) | ((uint)('Y') << 16) | ((uint)(' ') << 24)),
    VOLAPUK = ((uint)('V') | ((uint)('O') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    VORO = ((uint)('V') | ((uint)('R') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    WA = ((uint)('W') | ((uint)('A') << 8) | ((uint)(' ') << 16) | ((uint)(' ') << 24)),
    WACI_GBE = ((uint)('W') | ((uint)('C') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    WAGDI = ((uint)('W') | ((uint)('A') << 8) | ((uint)('G') << 16) | ((uint)(' ') << 24)),
    WAKHI = ((uint)('W') | ((uint)('B') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    WALLOON = ((uint)('W') | ((uint)('L') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    WARAY_WARAY = ((uint)('W') | ((uint)('A') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    WAYANAD_CHETTI = ((uint)('C') | ((uint)('T') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    WAYUU = ((uint)('G') | ((uint)('U') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    WELSH = ((uint)('W') | ((uint)('E') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
    WENDAT = ((uint)('W') | ((uint)('D') << 8) | ((uint)('T') << 16) | ((uint)(' ') << 24)),
    WEST_CREE = ((uint)('W') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    WESTERN_CHAM = ((uint)('C') | ((uint)('J') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    WESTERN_KAYAH = ((uint)('K') | ((uint)('Y') << 8) | ((uint)('U') << 16) | ((uint)(' ') << 24)),
    WESTERN_PANJABI = ((uint)('P') | ((uint)('N') << 8) | ((uint)('B') << 16) | ((uint)(' ') << 24)),
    WESTERN_PWO_KAREN = ((uint)('P') | ((uint)('W') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    WOLOF = ((uint)('W') | ((uint)('L') << 8) | ((uint)('F') << 16) | ((uint)(' ') << 24)),
    WOODS_CREE = ((uint)('D') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    WUDING_LUQUAN_YI = ((uint)('Y') | ((uint)('W') << 8) | ((uint)('Q') << 16) | ((uint)(' ') << 24)),
    WYANDOT = ((uint)('W') | ((uint)('Y') << 8) | ((uint)('N') << 16) | ((uint)(' ') << 24)),
    XHOSA = ((uint)('X') | ((uint)('H') << 8) | ((uint)('S') << 16) | ((uint)(' ') << 24)),
    Y_CREE = ((uint)('Y') | ((uint)('C') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    YAO = ((uint)('Y') | ((uint)('A') << 8) | ((uint)('O') << 16) | ((uint)(' ') << 24)),
    YAPESE = ((uint)('Y') | ((uint)('A') << 8) | ((uint)('P') << 16) | ((uint)(' ') << 24)),
    YI_CLASSIC = ((uint)('Y') | ((uint)('I') << 8) | ((uint)('C') << 16) | ((uint)(' ') << 24)),
    YI_MODERN = ((uint)('Y') | ((uint)('I') << 8) | ((uint)('M') << 16) | ((uint)(' ') << 24)),
    YIDDISH = ((uint)('J') | ((uint)('I') << 8) | ((uint)('I') << 16) | ((uint)(' ') << 24)),
    YORUBA = ((uint)('Y') | ((uint)('B') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ZAMBOANGA_CHAVACANO = ((uint)('C') | ((uint)('B') << 8) | ((uint)('K') << 16) | ((uint)(' ') << 24)),
    ZANDE = ((uint)('Z') | ((uint)('N') << 8) | ((uint)('D') << 16) | ((uint)(' ') << 24)),
    ZARMA = ((uint)('D') | ((uint)('J') << 8) | ((uint)('R') << 16) | ((uint)(' ') << 24)),
    ZAZAKI = ((uint)('Z') | ((uint)('Z') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ZEALANDIC = ((uint)('Z') | ((uint)('E') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ZHUANG = ((uint)('Z') | ((uint)('H') << 8) | ((uint)('A') << 16) | ((uint)(' ') << 24)),
    ZULU = ((uint)('Z') | ((uint)('U') << 8) | ((uint)('L') << 16) | ((uint)(' ') << 24)),
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_break_flags : uint
{
    DIRECTION = 1 << 0,
    SCRIPT = 1 << 1,
    GRAPHEME = 1 << 2,
    WORD = 1 << 3,
    LINE_SOFT = 1 << 4,
    LINE_HARD = 1 << 5,
    MANUAL = 1 << 6,
    PARAGRAPH_DIRECTION = 1 << 7,
    LINE = LINE_SOFT | LINE_HARD,
    ANY = DIRECTION | SCRIPT | GRAPHEME | WORD | LINE_SOFT | LINE_HARD,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_japanese_line_break_style : byte
{
    STRICT,
    NORMAL,
    LOOSE,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_break_state_flags : uint
{
    STARTED = 1,
    END = 2,
    SAW_R_AFTER_L = 8,
    SAW_AL_AFTER_LR = 0x10,
    LAST_WAS_BRACKET = 0x20,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_shape_context_flags : uint
{
    NONE,
    FONT_PRIORITY_BOTTOM_TO_TOP = (1 << 0),
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_text_format : uint
{
    NONE,
    UTF32,
    UTF8,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_direction : uint
{
    DONT_KNOW,
    LTR,
    RTL,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_orientation : uint
{
    HORIZONTAL,
    VERTICAL,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_shaping_table : uint
{
    GSUB,
    GPOS,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_shape_error : uint
{
    NONE,
    INVALID_FONT,
    GAVE_TEXT_BEFORE_CALLING_BEGIN,
    OUT_OF_MEMORY,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_allocator_op_kind : uint
{
    NONE,
    ALLOCATE,
    FREE,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_blob_table_id : uint
{
    NONE,
    HEAD,
    CMAP,
    GDEF,
    GSUB,
    GPOS,
    HHEA,
    VHEA,
    HMTX,
    VMTX,
    MAXP,
    OS2,
    NAME,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_load_font_error : uint
{
    NONE,
    NEED_TO_CREATE_BLOB,
    INVALID_FONT,
    OUT_OF_MEMORY,
    COULD_NOT_OPEN_FILE,
    READ_ERROR,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_version : uint
{
    _1_X,
    _2_0,
    CURRENT = _2_0,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_blob_version : uint
{
    INVALID,
    INITIAL,
    REMOVED_SUBTABLE_INFOS_ALIGNED_TABLES,
    CURRENT = REMOVED_SUBTABLE_INFOS_ALIGNED_TABLES,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_font_style_flags : uint
{
    NONE,
    REGULAR = (1 << 0),
    ITALIC = (1 << 1),
    BOLD = (1 << 2),
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_font_weight : uint
{
    UNKNOWN,
    THIN,
    EXTRA_LIGHT,
    LIGHT,
    NORMAL,
    MEDIUM,
    SEMI_BOLD,
    BOLD,
    EXTRA_BOLD,
    BLACK,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_font_width : uint
{
    UNKNOWN,
    ULTRA_CONDENSED,
    EXTRA_CONDENSED,
    CONDENSED,
    SEMI_CONDENSED,
    NORMAL,
    SEMI_EXPANDED,
    EXPANDED,
    EXTRA_EXPANDED,
    ULTRA_EXPANDED,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_glyph_flags : uint
{
    ISOL = (1 << 0),
    FINA = (1 << 1),
    FIN2 = (1 << 2),
    FIN3 = (1 << 3),
    MEDI = (1 << 4),
    MED2 = (1 << 5),
    INIT = (1 << 6),
    LJMO = (1 << 7),
    VJMO = (1 << 8),
    TJMO = (1 << 9),
    RPHF = (1 << 10),
    BLWF = (1 << 11),
    HALF = (1 << 12),
    PSTF = (1 << 13),
    ABVF = (1 << 14),
    PREF = (1 << 15),
    NUMR = (1 << 16),
    FRAC = (1 << 17),
    DNOM = (1 << 18),
    CFAR = (1 << 19),
    DO_NOT_DECOMPOSE = (1 << 20),
    FIRST_IN_MULTIPLE_SUBSTITUTION = (1 << 21),
    NO_BREAK = (1 << 22),
    CURSIVE = (1 << 23),
    GENERATED_BY_GSUB = (1 << 24),
    USED_IN_GPOS = (1 << 25),
    STCH_ENDPOINT = (1 << 26),
    STCH_EXTENSION = (1 << 27),
    LIGATURE = (1 << 28),
    MULTIPLE_SUBSTITUTION = (1 << 29),
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_joining_feature : byte
{
    NONE,
    ISOL,
    FINA,
    FIN2,
    FIN3,
    MEDI,
    MED2,
    INIT,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_user_id_generation_mode : uint
{
    CODEPOINT_INDEX,
    SOURCE_INDEX,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_break_config_flags : uint
{
    NONE,
    END_OF_TEXT_GENERATES_HARD_LINE_BREAK = 1,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_font_info_string_id : uint
{
    NONE,
    COPYRIGHT,
    FAMILY,
    SUBFAMILY,
    UID,
    FULL_NAME,
    VERSION,
    POSTSCRIPT_NAME,
    TRADEMARK,
    MANUFACTURER,
    DESIGNER,
    TYPOGRAPHIC_FAMILY,
    TYPOGRAPHIC_SUBFAMILY,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_unicode_joining_type : byte
{
    NONE,
    LEFT,
    DUAL,
    FORCE,
    RIGHT,
    TRANSPARENT,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_unicode_flag : uint
{
    MODIFIER_COMBINING_MARK = (1 << 0),
    DEFAULT_IGNORABLE = (1 << 1),
    OPEN_BRACKET = (1 << 2),
    CLOSE_BRACKET = (1 << 3),
    PART_OF_WORD = (1 << 4),
    DECIMAL_DIGIT = (1 << 5),
    NON_SPACING_MARK = (1 << 6),
    MIRRORED = OPEN_BRACKET | CLOSE_BRACKET,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_unicode_bidirectional_class : uint
{
    NI,
    BN,
    L,
    R,
    NSM,
    AL,
    AN,
    EN,
    ES,
    ET,
    CS,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_line_break_class : uint
{
    Onea,
    Oea,
    Ope,
    BK,
    CR,
    LF,
    NL,
    SP,
    ZW,
    WJ,
    GLnea,
    GLea,
    CLnea,
    CLea,
    CPnea,
    CPea,
    EXnea,
    EXea,
    SY,
    BAnea,
    BAea,
    OPnea,
    OPea,
    QU,
    QUPi,
    QUPf,
    IS,
    NSnea,
    NSea,
    B2,
    CB,
    HY,
    HYPHEN,
    INnea,
    INea,
    BB,
    HL,
    ALnea,
    ALea,
    NU,
    PRnea,
    PRea,
    IDnea,
    IDea,
    IDpe,
    EBnea,
    EBea,
    EM,
    POnea,
    POea,
    JL,
    JV,
    JT,
    H2,
    H3,
    AP,
    AK,
    DOTTED_CIRCLE,
    AS,
    VF,
    VI,
    RI,
    COUNT,
    CM,
    ZWJ,
    CJ,
    SOT,
    EOT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_word_break_class : uint
{
    Onep,
    Oep,
    CR,
    LF,
    NL,
    EX,
    ZWJ,
    RI,
    FO,
    KA,
    HL,
    ALnep,
    ALep,
    SQ,
    DQ,
    MNL,
    ML,
    MN,
    NM,
    ENL,
    WSS,
    SOT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_shaper : uint
{
    DEFAULT,
    ARABIC,
    HANGUL,
    HEBREW,
    INDIC,
    KHMER,
    MYANMAR,
    TIBETAN,
    USE,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_script_tag : uint
{
    DONT_KNOW = ((uint)(' ') | ((uint)(' ') << 8) | ((uint)(' ') << 16) | ((uint)(' ') << 24)),
    ADLAM = ((uint)('a') | ((uint)('d') << 8) | ((uint)('l') << 16) | ((uint)('m') << 24)),
    AHOM = ((uint)('a') | ((uint)('h') << 8) | ((uint)('o') << 16) | ((uint)('m') << 24)),
    ANATOLIAN_HIEROGLYPHS = ((uint)('h') | ((uint)('l') << 8) | ((uint)('u') << 16) | ((uint)('w') << 24)),
    ARABIC = ((uint)('a') | ((uint)('r') << 8) | ((uint)('a') << 16) | ((uint)('b') << 24)),
    ARMENIAN = ((uint)('a') | ((uint)('r') << 8) | ((uint)('m') << 16) | ((uint)('n') << 24)),
    AVESTAN = ((uint)('a') | ((uint)('v') << 8) | ((uint)('s') << 16) | ((uint)('t') << 24)),
    BALINESE = ((uint)('b') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('i') << 24)),
    BAMUM = ((uint)('b') | ((uint)('a') << 8) | ((uint)('m') << 16) | ((uint)('u') << 24)),
    BASSA_VAH = ((uint)('b') | ((uint)('a') << 8) | ((uint)('s') << 16) | ((uint)('s') << 24)),
    BATAK = ((uint)('b') | ((uint)('a') << 8) | ((uint)('t') << 16) | ((uint)('k') << 24)),
    BENGALI = ((uint)('b') | ((uint)('n') << 8) | ((uint)('g') << 16) | ((uint)('2') << 24)),
    BHAIKSUKI = ((uint)('b') | ((uint)('h') << 8) | ((uint)('k') << 16) | ((uint)('s') << 24)),
    BOPOMOFO = ((uint)('b') | ((uint)('o') << 8) | ((uint)('p') << 16) | ((uint)('o') << 24)),
    BRAHMI = ((uint)('b') | ((uint)('r') << 8) | ((uint)('a') << 16) | ((uint)('h') << 24)),
    BUGINESE = ((uint)('b') | ((uint)('u') << 8) | ((uint)('g') << 16) | ((uint)('i') << 24)),
    BUHID = ((uint)('b') | ((uint)('u') << 8) | ((uint)('h') << 16) | ((uint)('d') << 24)),
    CANADIAN_SYLLABICS = ((uint)('c') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('s') << 24)),
    CARIAN = ((uint)('c') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('i') << 24)),
    CAUCASIAN_ALBANIAN = ((uint)('a') | ((uint)('g') << 8) | ((uint)('h') << 16) | ((uint)('b') << 24)),
    CHAKMA = ((uint)('c') | ((uint)('a') << 8) | ((uint)('k') << 16) | ((uint)('m') << 24)),
    CHAM = ((uint)('c') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('m') << 24)),
    CHEROKEE = ((uint)('c') | ((uint)('h') << 8) | ((uint)('e') << 16) | ((uint)('r') << 24)),
    CHORASMIAN = ((uint)('c') | ((uint)('h') << 8) | ((uint)('r') << 16) | ((uint)('s') << 24)),
    CJK_IDEOGRAPHIC = ((uint)('h') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('i') << 24)),
    COPTIC = ((uint)('c') | ((uint)('o') << 8) | ((uint)('p') << 16) | ((uint)('t') << 24)),
    CYPRIOT_SYLLABARY = ((uint)('c') | ((uint)('p') << 8) | ((uint)('r') << 16) | ((uint)('t') << 24)),
    CYPRO_MINOAN = ((uint)('c') | ((uint)('p') << 8) | ((uint)('m') << 16) | ((uint)('n') << 24)),
    CYRILLIC = ((uint)('c') | ((uint)('y') << 8) | ((uint)('r') << 16) | ((uint)('l') << 24)),
    DEFAULT = ((uint)('D') | ((uint)('F') << 8) | ((uint)('L') << 16) | ((uint)('T') << 24)),
    DEFAULT2 = ((uint)('D') | ((uint)('F') << 8) | ((uint)('L') << 16) | ((uint)('T') << 24)),
    DESERET = ((uint)('d') | ((uint)('s') << 8) | ((uint)('r') << 16) | ((uint)('t') << 24)),
    DEVANAGARI = ((uint)('d') | ((uint)('e') << 8) | ((uint)('v') << 16) | ((uint)('2') << 24)),
    DIVES_AKURU = ((uint)('d') | ((uint)('i') << 8) | ((uint)('a') << 16) | ((uint)('k') << 24)),
    DOGRA = ((uint)('d') | ((uint)('o') << 8) | ((uint)('g') << 16) | ((uint)('r') << 24)),
    DUPLOYAN = ((uint)('d') | ((uint)('u') << 8) | ((uint)('p') << 16) | ((uint)('l') << 24)),
    EGYPTIAN_HIEROGLYPHS = ((uint)('e') | ((uint)('g') << 8) | ((uint)('y') << 16) | ((uint)('p') << 24)),
    ELBASAN = ((uint)('e') | ((uint)('l') << 8) | ((uint)('b') << 16) | ((uint)('a') << 24)),
    ELYMAIC = ((uint)('e') | ((uint)('l') << 8) | ((uint)('y') << 16) | ((uint)('m') << 24)),
    ETHIOPIC = ((uint)('e') | ((uint)('t') << 8) | ((uint)('h') << 16) | ((uint)('i') << 24)),
    GARAY = ((uint)('g') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('a') << 24)),
    GEORGIAN = ((uint)('g') | ((uint)('e') << 8) | ((uint)('o') << 16) | ((uint)('r') << 24)),
    GLAGOLITIC = ((uint)('g') | ((uint)('l') << 8) | ((uint)('a') << 16) | ((uint)('g') << 24)),
    GOTHIC = ((uint)('g') | ((uint)('o') << 8) | ((uint)('t') << 16) | ((uint)('h') << 24)),
    GRANTHA = ((uint)('g') | ((uint)('r') << 8) | ((uint)('a') << 16) | ((uint)('n') << 24)),
    GREEK = ((uint)('g') | ((uint)('r') << 8) | ((uint)('e') << 16) | ((uint)('k') << 24)),
    GUJARATI = ((uint)('g') | ((uint)('j') << 8) | ((uint)('r') << 16) | ((uint)('2') << 24)),
    GUNJALA_GONDI = ((uint)('g') | ((uint)('o') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    GURMUKHI = ((uint)('g') | ((uint)('u') << 8) | ((uint)('r') << 16) | ((uint)('2') << 24)),
    GURUNG_KHEMA = ((uint)('g') | ((uint)('u') << 8) | ((uint)('k') << 16) | ((uint)('h') << 24)),
    HANGUL = ((uint)('h') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    HANIFI_ROHINGYA = ((uint)('r') | ((uint)('o') << 8) | ((uint)('h') << 16) | ((uint)('g') << 24)),
    HANUNOO = ((uint)('h') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('o') << 24)),
    HATRAN = ((uint)('h') | ((uint)('a') << 8) | ((uint)('t') << 16) | ((uint)('r') << 24)),
    HEBREW = ((uint)('h') | ((uint)('e') << 8) | ((uint)('b') << 16) | ((uint)('r') << 24)),
    HIRAGANA = ((uint)('k') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    IMPERIAL_ARAMAIC = ((uint)('a') | ((uint)('r') << 8) | ((uint)('m') << 16) | ((uint)('i') << 24)),
    INSCRIPTIONAL_PAHLAVI = ((uint)('p') | ((uint)('h') << 8) | ((uint)('l') << 16) | ((uint)('i') << 24)),
    INSCRIPTIONAL_PARTHIAN = ((uint)('p') | ((uint)('r') << 8) | ((uint)('t') << 16) | ((uint)('i') << 24)),
    JAVANESE = ((uint)('j') | ((uint)('a') << 8) | ((uint)('v') << 16) | ((uint)('a') << 24)),
    KAITHI = ((uint)('k') | ((uint)('t') << 8) | ((uint)('h') << 16) | ((uint)('i') << 24)),
    KANNADA = ((uint)('k') | ((uint)('n') << 8) | ((uint)('d') << 16) | ((uint)('2') << 24)),
    KATAKANA = ((uint)('k') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    KAWI = ((uint)('k') | ((uint)('a') << 8) | ((uint)('w') << 16) | ((uint)('i') << 24)),
    KAYAH_LI = ((uint)('k') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('i') << 24)),
    KHAROSHTHI = ((uint)('k') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('r') << 24)),
    KHITAN_SMALL_SCRIPT = ((uint)('k') | ((uint)('i') << 8) | ((uint)('t') << 16) | ((uint)('s') << 24)),
    KHMER = ((uint)('k') | ((uint)('h') << 8) | ((uint)('m') << 16) | ((uint)('r') << 24)),
    KHOJKI = ((uint)('k') | ((uint)('h') << 8) | ((uint)('o') << 16) | ((uint)('j') << 24)),
    KHUDAWADI = ((uint)('s') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('d') << 24)),
    KIRAT_RAI = ((uint)('k') | ((uint)('r') << 8) | ((uint)('a') << 16) | ((uint)('i') << 24)),
    LAO = ((uint)('l') | ((uint)('a') << 8) | ((uint)('o') << 16) | ((uint)(' ') << 24)),
    LATIN = ((uint)('l') | ((uint)('a') << 8) | ((uint)('t') << 16) | ((uint)('n') << 24)),
    LEPCHA = ((uint)('l') | ((uint)('e') << 8) | ((uint)('p') << 16) | ((uint)('c') << 24)),
    LIMBU = ((uint)('l') | ((uint)('i') << 8) | ((uint)('m') << 16) | ((uint)('b') << 24)),
    LINEAR_A = ((uint)('l') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    LINEAR_B = ((uint)('l') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('b') << 24)),
    LISU = ((uint)('l') | ((uint)('i') << 8) | ((uint)('s') << 16) | ((uint)('u') << 24)),
    LYCIAN = ((uint)('l') | ((uint)('y') << 8) | ((uint)('c') << 16) | ((uint)('i') << 24)),
    LYDIAN = ((uint)('l') | ((uint)('y') << 8) | ((uint)('d') << 16) | ((uint)('i') << 24)),
    MAHAJANI = ((uint)('m') | ((uint)('a') << 8) | ((uint)('h') << 16) | ((uint)('j') << 24)),
    MAKASAR = ((uint)('m') | ((uint)('a') << 8) | ((uint)('k') << 16) | ((uint)('a') << 24)),
    MALAYALAM = ((uint)('m') | ((uint)('l') << 8) | ((uint)('m') << 16) | ((uint)('2') << 24)),
    MANDAIC = ((uint)('m') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('d') << 24)),
    MANICHAEAN = ((uint)('m') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('i') << 24)),
    MARCHEN = ((uint)('m') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('c') << 24)),
    MASARAM_GONDI = ((uint)('g') | ((uint)('o') << 8) | ((uint)('n') << 16) | ((uint)('m') << 24)),
    MEDEFAIDRIN = ((uint)('m') | ((uint)('e') << 8) | ((uint)('d') << 16) | ((uint)('f') << 24)),
    MEETEI_MAYEK = ((uint)('m') | ((uint)('t') << 8) | ((uint)('e') << 16) | ((uint)('i') << 24)),
    MENDE_KIKAKUI = ((uint)('m') | ((uint)('e') << 8) | ((uint)('n') << 16) | ((uint)('d') << 24)),
    MEROITIC_CURSIVE = ((uint)('m') | ((uint)('e') << 8) | ((uint)('r') << 16) | ((uint)('c') << 24)),
    MEROITIC_HIEROGLYPHS = ((uint)('m') | ((uint)('e') << 8) | ((uint)('r') << 16) | ((uint)('o') << 24)),
    MIAO = ((uint)('p') | ((uint)('l') << 8) | ((uint)('r') << 16) | ((uint)('d') << 24)),
    MODI = ((uint)('m') | ((uint)('o') << 8) | ((uint)('d') << 16) | ((uint)('i') << 24)),
    MONGOLIAN = ((uint)('m') | ((uint)('o') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    MRO = ((uint)('m') | ((uint)('r') << 8) | ((uint)('o') << 16) | ((uint)('o') << 24)),
    MULTANI = ((uint)('m') | ((uint)('u') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    MYANMAR = ((uint)('m') | ((uint)('y') << 8) | ((uint)('m') << 16) | ((uint)('2') << 24)),
    NABATAEAN = ((uint)('n') | ((uint)('b') << 8) | ((uint)('a') << 16) | ((uint)('t') << 24)),
    NAG_MUNDARI = ((uint)('n') | ((uint)('a') << 8) | ((uint)('g') << 16) | ((uint)('m') << 24)),
    NANDINAGARI = ((uint)('n') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('d') << 24)),
    NEWA = ((uint)('n') | ((uint)('e') << 8) | ((uint)('w') << 16) | ((uint)('a') << 24)),
    NEW_TAI_LUE = ((uint)('t') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('u') << 24)),
    NKO = ((uint)('n') | ((uint)('k') << 8) | ((uint)('o') << 16) | ((uint)(' ') << 24)),
    NUSHU = ((uint)('n') | ((uint)('s') << 8) | ((uint)('h') << 16) | ((uint)('u') << 24)),
    NYIAKENG_PUACHUE_HMONG = ((uint)('h') | ((uint)('m') << 8) | ((uint)('n') << 16) | ((uint)('p') << 24)),
    OGHAM = ((uint)('o') | ((uint)('g') << 8) | ((uint)('a') << 16) | ((uint)('m') << 24)),
    OL_CHIKI = ((uint)('o') | ((uint)('l') << 8) | ((uint)('c') << 16) | ((uint)('k') << 24)),
    OL_ONAL = ((uint)('o') | ((uint)('n') << 8) | ((uint)('a') << 16) | ((uint)('o') << 24)),
    OLD_ITALIC = ((uint)('i') | ((uint)('t') << 8) | ((uint)('a') << 16) | ((uint)('l') << 24)),
    OLD_HUNGARIAN = ((uint)('h') | ((uint)('u') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    OLD_NORTH_ARABIAN = ((uint)('n') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('b') << 24)),
    OLD_PERMIC = ((uint)('p') | ((uint)('e') << 8) | ((uint)('r') << 16) | ((uint)('m') << 24)),
    OLD_PERSIAN_CUNEIFORM = ((uint)('x') | ((uint)('p') << 8) | ((uint)('e') << 16) | ((uint)('o') << 24)),
    OLD_SOGDIAN = ((uint)('s') | ((uint)('o') << 8) | ((uint)('g') << 16) | ((uint)('o') << 24)),
    OLD_SOUTH_ARABIAN = ((uint)('s') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('b') << 24)),
    OLD_TURKIC = ((uint)('o') | ((uint)('r') << 8) | ((uint)('k') << 16) | ((uint)('h') << 24)),
    OLD_UYGHUR = ((uint)('o') | ((uint)('u') << 8) | ((uint)('g') << 16) | ((uint)('r') << 24)),
    ODIA = ((uint)('o') | ((uint)('r') << 8) | ((uint)('y') << 16) | ((uint)('2') << 24)),
    OSAGE = ((uint)('o') | ((uint)('s') << 8) | ((uint)('g') << 16) | ((uint)('e') << 24)),
    OSMANYA = ((uint)('o') | ((uint)('s') << 8) | ((uint)('m') << 16) | ((uint)('a') << 24)),
    PAHAWH_HMONG = ((uint)('h') | ((uint)('m') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    PALMYRENE = ((uint)('p') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('m') << 24)),
    PAU_CIN_HAU = ((uint)('p') | ((uint)('a') << 8) | ((uint)('u') << 16) | ((uint)('c') << 24)),
    PHAGS_PA = ((uint)('p') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('g') << 24)),
    PHOENICIAN = ((uint)('p') | ((uint)('h') << 8) | ((uint)('n') << 16) | ((uint)('x') << 24)),
    PSALTER_PAHLAVI = ((uint)('p') | ((uint)('h') << 8) | ((uint)('l') << 16) | ((uint)('p') << 24)),
    REJANG = ((uint)('r') | ((uint)('j') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    RUNIC = ((uint)('r') | ((uint)('u') << 8) | ((uint)('n') << 16) | ((uint)('r') << 24)),
    SAMARITAN = ((uint)('s') | ((uint)('a') << 8) | ((uint)('m') << 16) | ((uint)('r') << 24)),
    SAURASHTRA = ((uint)('s') | ((uint)('a') << 8) | ((uint)('u') << 16) | ((uint)('r') << 24)),
    SHARADA = ((uint)('s') | ((uint)('h') << 8) | ((uint)('r') << 16) | ((uint)('d') << 24)),
    SHAVIAN = ((uint)('s') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('w') << 24)),
    SIDDHAM = ((uint)('s') | ((uint)('i') << 8) | ((uint)('d') << 16) | ((uint)('d') << 24)),
    SIGN_WRITING = ((uint)('s') | ((uint)('g') << 8) | ((uint)('n') << 16) | ((uint)('w') << 24)),
    SOGDIAN = ((uint)('s') | ((uint)('o') << 8) | ((uint)('g') << 16) | ((uint)('d') << 24)),
    SINHALA = ((uint)('s') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('h') << 24)),
    SORA_SOMPENG = ((uint)('s') | ((uint)('o') << 8) | ((uint)('r') << 16) | ((uint)('a') << 24)),
    SOYOMBO = ((uint)('s') | ((uint)('o') << 8) | ((uint)('y') << 16) | ((uint)('o') << 24)),
    SUMERO_AKKADIAN_CUNEIFORM = ((uint)('x') | ((uint)('s') << 8) | ((uint)('u') << 16) | ((uint)('x') << 24)),
    SUNDANESE = ((uint)('s') | ((uint)('u') << 8) | ((uint)('n') << 16) | ((uint)('d') << 24)),
    SUNUWAR = ((uint)('s') | ((uint)('u') << 8) | ((uint)('n') << 16) | ((uint)('u') << 24)),
    SYLOTI_NAGRI = ((uint)('s') | ((uint)('y') << 8) | ((uint)('l') << 16) | ((uint)('o') << 24)),
    SYRIAC = ((uint)('s') | ((uint)('y') << 8) | ((uint)('r') << 16) | ((uint)('c') << 24)),
    TAGALOG = ((uint)('t') | ((uint)('g') << 8) | ((uint)('l') << 16) | ((uint)('g') << 24)),
    TAGBANWA = ((uint)('t') | ((uint)('a') << 8) | ((uint)('g') << 16) | ((uint)('b') << 24)),
    TAI_LE = ((uint)('t') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('e') << 24)),
    TAI_THAM = ((uint)('l') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    TAI_VIET = ((uint)('t') | ((uint)('a') << 8) | ((uint)('v') << 16) | ((uint)('t') << 24)),
    TAKRI = ((uint)('t') | ((uint)('a') << 8) | ((uint)('k') << 16) | ((uint)('r') << 24)),
    TAMIL = ((uint)('t') | ((uint)('m') << 8) | ((uint)('l') << 16) | ((uint)('2') << 24)),
    TANGSA = ((uint)('t') | ((uint)('n') << 8) | ((uint)('s') << 16) | ((uint)('a') << 24)),
    TANGUT = ((uint)('t') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    TELUGU = ((uint)('t') | ((uint)('e') << 8) | ((uint)('l') << 16) | ((uint)('2') << 24)),
    THAANA = ((uint)('t') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('a') << 24)),
    THAI = ((uint)('t') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('i') << 24)),
    TIBETAN = ((uint)('t') | ((uint)('i') << 8) | ((uint)('b') << 16) | ((uint)('t') << 24)),
    TIFINAGH = ((uint)('t') | ((uint)('f') << 8) | ((uint)('n') << 16) | ((uint)('g') << 24)),
    TIRHUTA = ((uint)('t') | ((uint)('i') << 8) | ((uint)('r') << 16) | ((uint)('h') << 24)),
    TODHRI = ((uint)('t') | ((uint)('o') << 8) | ((uint)('d') << 16) | ((uint)('r') << 24)),
    TOTO = ((uint)('t') | ((uint)('o') << 8) | ((uint)('t') << 16) | ((uint)('o') << 24)),
    TULU_TIGALARI = ((uint)('t') | ((uint)('u') << 8) | ((uint)('t') << 16) | ((uint)('g') << 24)),
    UGARITIC_CUNEIFORM = ((uint)('u') | ((uint)('g') << 8) | ((uint)('a') << 16) | ((uint)('r') << 24)),
    VAI = ((uint)('v') | ((uint)('a') << 8) | ((uint)('i') << 16) | ((uint)(' ') << 24)),
    VITHKUQI = ((uint)('v') | ((uint)('i') << 8) | ((uint)('t') << 16) | ((uint)('h') << 24)),
    WANCHO = ((uint)('w') | ((uint)('c') << 8) | ((uint)('h') << 16) | ((uint)('o') << 24)),
    WARANG_CITI = ((uint)('w') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('a') << 24)),
    YEZIDI = ((uint)('y') | ((uint)('e') << 8) | ((uint)('z') << 16) | ((uint)('i') << 24)),
    YI = ((uint)('y') | ((uint)('i') << 8) | ((uint)(' ') << 16) | ((uint)(' ') << 24)),
    ZANABAZAR_SQUARE = ((uint)('z') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('b') << 24)),
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_script : uint
{
    DONT_KNOW,
    ADLAM,
    AHOM,
    ANATOLIAN_HIEROGLYPHS,
    ARABIC,
    ARMENIAN,
    AVESTAN,
    BALINESE,
    BAMUM,
    BASSA_VAH,
    BATAK,
    BENGALI,
    BHAIKSUKI,
    BOPOMOFO,
    BRAHMI,
    BUGINESE,
    BUHID,
    CANADIAN_SYLLABICS,
    CARIAN,
    CAUCASIAN_ALBANIAN,
    CHAKMA,
    CHAM,
    CHEROKEE,
    CHORASMIAN,
    CJK_IDEOGRAPHIC,
    COPTIC,
    CYPRIOT_SYLLABARY,
    CYPRO_MINOAN,
    CYRILLIC,
    DEFAULT,
    DEFAULT2,
    DESERET,
    DEVANAGARI,
    DIVES_AKURU,
    DOGRA,
    DUPLOYAN,
    EGYPTIAN_HIEROGLYPHS,
    ELBASAN,
    ELYMAIC,
    ETHIOPIC,
    GARAY,
    GEORGIAN,
    GLAGOLITIC,
    GOTHIC,
    GRANTHA,
    GREEK,
    GUJARATI,
    GUNJALA_GONDI,
    GURMUKHI,
    GURUNG_KHEMA,
    HANGUL,
    HANIFI_ROHINGYA,
    HANUNOO,
    HATRAN,
    HEBREW,
    HIRAGANA,
    IMPERIAL_ARAMAIC,
    INSCRIPTIONAL_PAHLAVI,
    INSCRIPTIONAL_PARTHIAN,
    JAVANESE,
    KAITHI,
    KANNADA,
    KATAKANA,
    KAWI,
    KAYAH_LI,
    KHAROSHTHI,
    KHITAN_SMALL_SCRIPT,
    KHMER,
    KHOJKI,
    KHUDAWADI,
    KIRAT_RAI,
    LAO,
    LATIN,
    LEPCHA,
    LIMBU,
    LINEAR_A,
    LINEAR_B,
    LISU,
    LYCIAN,
    LYDIAN,
    MAHAJANI,
    MAKASAR,
    MALAYALAM,
    MANDAIC,
    MANICHAEAN,
    MARCHEN,
    MASARAM_GONDI,
    MEDEFAIDRIN,
    MEETEI_MAYEK,
    MENDE_KIKAKUI,
    MEROITIC_CURSIVE,
    MEROITIC_HIEROGLYPHS,
    MIAO,
    MODI,
    MONGOLIAN,
    MRO,
    MULTANI,
    MYANMAR,
    NABATAEAN,
    NAG_MUNDARI,
    NANDINAGARI,
    NEWA,
    NEW_TAI_LUE,
    NKO,
    NUSHU,
    NYIAKENG_PUACHUE_HMONG,
    OGHAM,
    OL_CHIKI,
    OL_ONAL,
    OLD_ITALIC,
    OLD_HUNGARIAN,
    OLD_NORTH_ARABIAN,
    OLD_PERMIC,
    OLD_PERSIAN_CUNEIFORM,
    OLD_SOGDIAN,
    OLD_SOUTH_ARABIAN,
    OLD_TURKIC,
    OLD_UYGHUR,
    ODIA,
    OSAGE,
    OSMANYA,
    PAHAWH_HMONG,
    PALMYRENE,
    PAU_CIN_HAU,
    PHAGS_PA,
    PHOENICIAN,
    PSALTER_PAHLAVI,
    REJANG,
    RUNIC,
    SAMARITAN,
    SAURASHTRA,
    SHARADA,
    SHAVIAN,
    SIDDHAM,
    SIGN_WRITING,
    SOGDIAN,
    SINHALA,
    SORA_SOMPENG,
    SOYOMBO,
    SUMERO_AKKADIAN_CUNEIFORM,
    SUNDANESE,
    SUNUWAR,
    SYLOTI_NAGRI,
    SYRIAC,
    TAGALOG,
    TAGBANWA,
    TAI_LE,
    TAI_THAM,
    TAI_VIET,
    TAKRI,
    TAMIL,
    TANGSA,
    TANGUT,
    TELUGU,
    THAANA,
    THAI,
    TIBETAN,
    TIFINAGH,
    TIRHUTA,
    TODHRI,
    TOTO,
    TULU_TIGALARI,
    UGARITIC_CUNEIFORM,
    VAI,
    VITHKUQI,
    WANCHO,
    WARANG_CITI,
    YEZIDI,
    YI,
    ZANABAZAR_SQUARE,
    COUNT,
}

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum kbts_feature_tag : uint
{
    UNREGISTERED = ((uint)(0) | ((uint)(0) << 8) | ((uint)(0) << 16) | ((uint)(0) << 24)),
    isol = ((uint)('i') | ((uint)('s') << 8) | ((uint)('o') << 16) | ((uint)('l') << 24)),
    fina = ((uint)('f') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    fin2 = ((uint)('f') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('2') << 24)),
    fin3 = ((uint)('f') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('3') << 24)),
    medi = ((uint)('m') | ((uint)('e') << 8) | ((uint)('d') << 16) | ((uint)('i') << 24)),
    med2 = ((uint)('m') | ((uint)('e') << 8) | ((uint)('d') << 16) | ((uint)('2') << 24)),
    init = ((uint)('i') | ((uint)('n') << 8) | ((uint)('i') << 16) | ((uint)('t') << 24)),
    ljmo = ((uint)('l') | ((uint)('j') << 8) | ((uint)('m') << 16) | ((uint)('o') << 24)),
    vjmo = ((uint)('v') | ((uint)('j') << 8) | ((uint)('m') << 16) | ((uint)('o') << 24)),
    tjmo = ((uint)('t') | ((uint)('j') << 8) | ((uint)('m') << 16) | ((uint)('o') << 24)),
    rphf = ((uint)('r') | ((uint)('p') << 8) | ((uint)('h') << 16) | ((uint)('f') << 24)),
    blwf = ((uint)('b') | ((uint)('l') << 8) | ((uint)('w') << 16) | ((uint)('f') << 24)),
    half = ((uint)('h') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('f') << 24)),
    pstf = ((uint)('p') | ((uint)('s') << 8) | ((uint)('t') << 16) | ((uint)('f') << 24)),
    abvf = ((uint)('a') | ((uint)('b') << 8) | ((uint)('v') << 16) | ((uint)('f') << 24)),
    pref = ((uint)('p') | ((uint)('r') << 8) | ((uint)('e') << 16) | ((uint)('f') << 24)),
    numr = ((uint)('n') | ((uint)('u') << 8) | ((uint)('m') << 16) | ((uint)('r') << 24)),
    frac = ((uint)('f') | ((uint)('r') << 8) | ((uint)('a') << 16) | ((uint)('c') << 24)),
    dnom = ((uint)('d') | ((uint)('n') << 8) | ((uint)('o') << 16) | ((uint)('m') << 24)),
    cfar = ((uint)('c') | ((uint)('f') << 8) | ((uint)('a') << 16) | ((uint)('r') << 24)),
    aalt = ((uint)('a') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    abvm = ((uint)('a') | ((uint)('b') << 8) | ((uint)('v') << 16) | ((uint)('m') << 24)),
    abvs = ((uint)('a') | ((uint)('b') << 8) | ((uint)('v') << 16) | ((uint)('s') << 24)),
    afrc = ((uint)('a') | ((uint)('f') << 8) | ((uint)('r') << 16) | ((uint)('c') << 24)),
    akhn = ((uint)('a') | ((uint)('k') << 8) | ((uint)('h') << 16) | ((uint)('n') << 24)),
    apkn = ((uint)('a') | ((uint)('p') << 8) | ((uint)('k') << 16) | ((uint)('n') << 24)),
    blwm = ((uint)('b') | ((uint)('l') << 8) | ((uint)('w') << 16) | ((uint)('m') << 24)),
    blws = ((uint)('b') | ((uint)('l') << 8) | ((uint)('w') << 16) | ((uint)('s') << 24)),
    calt = ((uint)('c') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    @case = ((uint)('c') | ((uint)('a') << 8) | ((uint)('s') << 16) | ((uint)('e') << 24)),
    ccmp = ((uint)('c') | ((uint)('c') << 8) | ((uint)('m') << 16) | ((uint)('p') << 24)),
    chws = ((uint)('c') | ((uint)('h') << 8) | ((uint)('w') << 16) | ((uint)('s') << 24)),
    cjct = ((uint)('c') | ((uint)('j') << 8) | ((uint)('c') << 16) | ((uint)('t') << 24)),
    clig = ((uint)('c') | ((uint)('l') << 8) | ((uint)('i') << 16) | ((uint)('g') << 24)),
    cpct = ((uint)('c') | ((uint)('p') << 8) | ((uint)('c') << 16) | ((uint)('t') << 24)),
    cpsp = ((uint)('c') | ((uint)('p') << 8) | ((uint)('s') << 16) | ((uint)('p') << 24)),
    cswh = ((uint)('c') | ((uint)('s') << 8) | ((uint)('w') << 16) | ((uint)('h') << 24)),
    curs = ((uint)('c') | ((uint)('u') << 8) | ((uint)('r') << 16) | ((uint)('s') << 24)),
    cv01 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('1') << 24)),
    cv02 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('2') << 24)),
    cv03 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('3') << 24)),
    cv04 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('4') << 24)),
    cv05 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('5') << 24)),
    cv06 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('6') << 24)),
    cv07 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('7') << 24)),
    cv08 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('8') << 24)),
    cv09 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('0') << 16) | ((uint)('9') << 24)),
    cv10 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('0') << 24)),
    cv11 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('1') << 24)),
    cv12 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('2') << 24)),
    cv13 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('3') << 24)),
    cv14 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('4') << 24)),
    cv15 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('5') << 24)),
    cv16 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('6') << 24)),
    cv17 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('7') << 24)),
    cv18 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('8') << 24)),
    cv19 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('1') << 16) | ((uint)('9') << 24)),
    cv20 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('0') << 24)),
    cv21 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('1') << 24)),
    cv22 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('2') << 24)),
    cv23 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('3') << 24)),
    cv24 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('4') << 24)),
    cv25 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('5') << 24)),
    cv26 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('6') << 24)),
    cv27 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('7') << 24)),
    cv28 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('8') << 24)),
    cv29 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('2') << 16) | ((uint)('9') << 24)),
    cv30 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('0') << 24)),
    cv31 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('1') << 24)),
    cv32 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('2') << 24)),
    cv33 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('3') << 24)),
    cv34 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('4') << 24)),
    cv35 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('5') << 24)),
    cv36 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('6') << 24)),
    cv37 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('7') << 24)),
    cv38 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('8') << 24)),
    cv39 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('3') << 16) | ((uint)('9') << 24)),
    cv40 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('0') << 24)),
    cv41 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('1') << 24)),
    cv42 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('2') << 24)),
    cv43 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('3') << 24)),
    cv44 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('4') << 24)),
    cv45 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('5') << 24)),
    cv46 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('6') << 24)),
    cv47 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('7') << 24)),
    cv48 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('8') << 24)),
    cv49 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('4') << 16) | ((uint)('9') << 24)),
    cv50 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('0') << 24)),
    cv51 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('1') << 24)),
    cv52 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('2') << 24)),
    cv53 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('3') << 24)),
    cv54 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('4') << 24)),
    cv55 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('5') << 24)),
    cv56 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('6') << 24)),
    cv57 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('7') << 24)),
    cv58 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('8') << 24)),
    cv59 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('5') << 16) | ((uint)('9') << 24)),
    cv60 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('0') << 24)),
    cv61 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('1') << 24)),
    cv62 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('2') << 24)),
    cv63 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('3') << 24)),
    cv64 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('4') << 24)),
    cv65 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('5') << 24)),
    cv66 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('6') << 24)),
    cv67 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('7') << 24)),
    cv68 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('8') << 24)),
    cv69 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('6') << 16) | ((uint)('9') << 24)),
    cv70 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('0') << 24)),
    cv71 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('1') << 24)),
    cv72 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('2') << 24)),
    cv73 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('3') << 24)),
    cv74 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('4') << 24)),
    cv75 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('5') << 24)),
    cv76 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('6') << 24)),
    cv77 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('7') << 24)),
    cv78 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('8') << 24)),
    cv79 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('7') << 16) | ((uint)('9') << 24)),
    cv80 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('0') << 24)),
    cv81 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('1') << 24)),
    cv82 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('2') << 24)),
    cv83 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('3') << 24)),
    cv84 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('4') << 24)),
    cv85 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('5') << 24)),
    cv86 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('6') << 24)),
    cv87 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('7') << 24)),
    cv88 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('8') << 24)),
    cv89 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('8') << 16) | ((uint)('9') << 24)),
    cv90 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('0') << 24)),
    cv91 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('1') << 24)),
    cv92 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('2') << 24)),
    cv93 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('3') << 24)),
    cv94 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('4') << 24)),
    cv95 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('5') << 24)),
    cv96 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('6') << 24)),
    cv97 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('7') << 24)),
    cv98 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('8') << 24)),
    cv99 = ((uint)('c') | ((uint)('v') << 8) | ((uint)('9') << 16) | ((uint)('9') << 24)),
    c2pc = ((uint)('c') | ((uint)('2') << 8) | ((uint)('p') << 16) | ((uint)('c') << 24)),
    c2sc = ((uint)('c') | ((uint)('2') << 8) | ((uint)('s') << 16) | ((uint)('c') << 24)),
    dist = ((uint)('d') | ((uint)('i') << 8) | ((uint)('s') << 16) | ((uint)('t') << 24)),
    dlig = ((uint)('d') | ((uint)('l') << 8) | ((uint)('i') << 16) | ((uint)('g') << 24)),
    dtls = ((uint)('d') | ((uint)('t') << 8) | ((uint)('l') << 16) | ((uint)('s') << 24)),
    expt = ((uint)('e') | ((uint)('x') << 8) | ((uint)('p') << 16) | ((uint)('t') << 24)),
    falt = ((uint)('f') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    flac = ((uint)('f') | ((uint)('l') << 8) | ((uint)('a') << 16) | ((uint)('c') << 24)),
    fwid = ((uint)('f') | ((uint)('w') << 8) | ((uint)('i') << 16) | ((uint)('d') << 24)),
    haln = ((uint)('h') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('n') << 24)),
    halt = ((uint)('h') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    hist = ((uint)('h') | ((uint)('i') << 8) | ((uint)('s') << 16) | ((uint)('t') << 24)),
    hkna = ((uint)('h') | ((uint)('k') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    hlig = ((uint)('h') | ((uint)('l') << 8) | ((uint)('i') << 16) | ((uint)('g') << 24)),
    hngl = ((uint)('h') | ((uint)('n') << 8) | ((uint)('g') << 16) | ((uint)('l') << 24)),
    hojo = ((uint)('h') | ((uint)('o') << 8) | ((uint)('j') << 16) | ((uint)('o') << 24)),
    hwid = ((uint)('h') | ((uint)('w') << 8) | ((uint)('i') << 16) | ((uint)('d') << 24)),
    ital = ((uint)('i') | ((uint)('t') << 8) | ((uint)('a') << 16) | ((uint)('l') << 24)),
    jalt = ((uint)('j') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    jp78 = ((uint)('j') | ((uint)('p') << 8) | ((uint)('7') << 16) | ((uint)('8') << 24)),
    jp83 = ((uint)('j') | ((uint)('p') << 8) | ((uint)('8') << 16) | ((uint)('3') << 24)),
    jp90 = ((uint)('j') | ((uint)('p') << 8) | ((uint)('9') << 16) | ((uint)('0') << 24)),
    jp04 = ((uint)('j') | ((uint)('p') << 8) | ((uint)('0') << 16) | ((uint)('4') << 24)),
    kern = ((uint)('k') | ((uint)('e') << 8) | ((uint)('r') << 16) | ((uint)('n') << 24)),
    lfbd = ((uint)('l') | ((uint)('f') << 8) | ((uint)('b') << 16) | ((uint)('d') << 24)),
    liga = ((uint)('l') | ((uint)('i') << 8) | ((uint)('g') << 16) | ((uint)('a') << 24)),
    lnum = ((uint)('l') | ((uint)('n') << 8) | ((uint)('u') << 16) | ((uint)('m') << 24)),
    locl = ((uint)('l') | ((uint)('o') << 8) | ((uint)('c') << 16) | ((uint)('l') << 24)),
    ltra = ((uint)('l') | ((uint)('t') << 8) | ((uint)('r') << 16) | ((uint)('a') << 24)),
    ltrm = ((uint)('l') | ((uint)('t') << 8) | ((uint)('r') << 16) | ((uint)('m') << 24)),
    mark = ((uint)('m') | ((uint)('a') << 8) | ((uint)('r') << 16) | ((uint)('k') << 24)),
    mgrk = ((uint)('m') | ((uint)('g') << 8) | ((uint)('r') << 16) | ((uint)('k') << 24)),
    mkmk = ((uint)('m') | ((uint)('k') << 8) | ((uint)('m') << 16) | ((uint)('k') << 24)),
    mset = ((uint)('m') | ((uint)('s') << 8) | ((uint)('e') << 16) | ((uint)('t') << 24)),
    nalt = ((uint)('n') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    nlck = ((uint)('n') | ((uint)('l') << 8) | ((uint)('c') << 16) | ((uint)('k') << 24)),
    nukt = ((uint)('n') | ((uint)('u') << 8) | ((uint)('k') << 16) | ((uint)('t') << 24)),
    onum = ((uint)('o') | ((uint)('n') << 8) | ((uint)('u') << 16) | ((uint)('m') << 24)),
    opbd = ((uint)('o') | ((uint)('p') << 8) | ((uint)('b') << 16) | ((uint)('d') << 24)),
    ordn = ((uint)('o') | ((uint)('r') << 8) | ((uint)('d') << 16) | ((uint)('n') << 24)),
    ornm = ((uint)('o') | ((uint)('r') << 8) | ((uint)('n') << 16) | ((uint)('m') << 24)),
    palt = ((uint)('p') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    pcap = ((uint)('p') | ((uint)('c') << 8) | ((uint)('a') << 16) | ((uint)('p') << 24)),
    pkna = ((uint)('p') | ((uint)('k') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    pnum = ((uint)('p') | ((uint)('n') << 8) | ((uint)('u') << 16) | ((uint)('m') << 24)),
    pres = ((uint)('p') | ((uint)('r') << 8) | ((uint)('e') << 16) | ((uint)('s') << 24)),
    psts = ((uint)('p') | ((uint)('s') << 8) | ((uint)('t') << 16) | ((uint)('s') << 24)),
    pwid = ((uint)('p') | ((uint)('w') << 8) | ((uint)('i') << 16) | ((uint)('d') << 24)),
    qwid = ((uint)('q') | ((uint)('w') << 8) | ((uint)('i') << 16) | ((uint)('d') << 24)),
    rand = ((uint)('r') | ((uint)('a') << 8) | ((uint)('n') << 16) | ((uint)('d') << 24)),
    rclt = ((uint)('r') | ((uint)('c') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    rkrf = ((uint)('r') | ((uint)('k') << 8) | ((uint)('r') << 16) | ((uint)('f') << 24)),
    rlig = ((uint)('r') | ((uint)('l') << 8) | ((uint)('i') << 16) | ((uint)('g') << 24)),
    rtbd = ((uint)('r') | ((uint)('t') << 8) | ((uint)('b') << 16) | ((uint)('d') << 24)),
    rtla = ((uint)('r') | ((uint)('t') << 8) | ((uint)('l') << 16) | ((uint)('a') << 24)),
    rtlm = ((uint)('r') | ((uint)('t') << 8) | ((uint)('l') << 16) | ((uint)('m') << 24)),
    ruby = ((uint)('r') | ((uint)('u') << 8) | ((uint)('b') << 16) | ((uint)('y') << 24)),
    rvrn = ((uint)('r') | ((uint)('v') << 8) | ((uint)('r') << 16) | ((uint)('n') << 24)),
    salt = ((uint)('s') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    sinf = ((uint)('s') | ((uint)('i') << 8) | ((uint)('n') << 16) | ((uint)('f') << 24)),
    size = ((uint)('s') | ((uint)('i') << 8) | ((uint)('z') << 16) | ((uint)('e') << 24)),
    smcp = ((uint)('s') | ((uint)('m') << 8) | ((uint)('c') << 16) | ((uint)('p') << 24)),
    smpl = ((uint)('s') | ((uint)('m') << 8) | ((uint)('p') << 16) | ((uint)('l') << 24)),
    ss01 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('1') << 24)),
    ss02 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('2') << 24)),
    ss03 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('3') << 24)),
    ss04 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('4') << 24)),
    ss05 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('5') << 24)),
    ss06 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('6') << 24)),
    ss07 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('7') << 24)),
    ss08 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('8') << 24)),
    ss09 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('0') << 16) | ((uint)('9') << 24)),
    ss10 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('0') << 24)),
    ss11 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('1') << 24)),
    ss12 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('2') << 24)),
    ss13 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('3') << 24)),
    ss14 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('4') << 24)),
    ss15 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('5') << 24)),
    ss16 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('6') << 24)),
    ss17 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('7') << 24)),
    ss18 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('8') << 24)),
    ss19 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('1') << 16) | ((uint)('9') << 24)),
    ss20 = ((uint)('s') | ((uint)('s') << 8) | ((uint)('2') << 16) | ((uint)('0') << 24)),
    ssty = ((uint)('s') | ((uint)('s') << 8) | ((uint)('t') << 16) | ((uint)('y') << 24)),
    stch = ((uint)('s') | ((uint)('t') << 8) | ((uint)('c') << 16) | ((uint)('h') << 24)),
    subs = ((uint)('s') | ((uint)('u') << 8) | ((uint)('b') << 16) | ((uint)('s') << 24)),
    sups = ((uint)('s') | ((uint)('u') << 8) | ((uint)('p') << 16) | ((uint)('s') << 24)),
    swsh = ((uint)('s') | ((uint)('w') << 8) | ((uint)('s') << 16) | ((uint)('h') << 24)),
    test = ((uint)('t') | ((uint)('e') << 8) | ((uint)('s') << 16) | ((uint)('t') << 24)),
    titl = ((uint)('t') | ((uint)('i') << 8) | ((uint)('t') << 16) | ((uint)('l') << 24)),
    tnam = ((uint)('t') | ((uint)('n') << 8) | ((uint)('a') << 16) | ((uint)('m') << 24)),
    tnum = ((uint)('t') | ((uint)('n') << 8) | ((uint)('u') << 16) | ((uint)('m') << 24)),
    trad = ((uint)('t') | ((uint)('r') << 8) | ((uint)('a') << 16) | ((uint)('d') << 24)),
    twid = ((uint)('t') | ((uint)('w') << 8) | ((uint)('i') << 16) | ((uint)('d') << 24)),
    unic = ((uint)('u') | ((uint)('n') << 8) | ((uint)('i') << 16) | ((uint)('c') << 24)),
    valt = ((uint)('v') | ((uint)('a') << 8) | ((uint)('l') << 16) | ((uint)('t') << 24)),
    vapk = ((uint)('v') | ((uint)('a') << 8) | ((uint)('p') << 16) | ((uint)('k') << 24)),
    vatu = ((uint)('v') | ((uint)('a') << 8) | ((uint)('t') << 16) | ((uint)('u') << 24)),
    vchw = ((uint)('v') | ((uint)('c') << 8) | ((uint)('h') << 16) | ((uint)('w') << 24)),
    vert = ((uint)('v') | ((uint)('e') << 8) | ((uint)('r') << 16) | ((uint)('t') << 24)),
    vhal = ((uint)('v') | ((uint)('h') << 8) | ((uint)('a') << 16) | ((uint)('l') << 24)),
    vkna = ((uint)('v') | ((uint)('k') << 8) | ((uint)('n') << 16) | ((uint)('a') << 24)),
    vkrn = ((uint)('v') | ((uint)('k') << 8) | ((uint)('r') << 16) | ((uint)('n') << 24)),
    vpal = ((uint)('v') | ((uint)('p') << 8) | ((uint)('a') << 16) | ((uint)('l') << 24)),
    vrt2 = ((uint)('v') | ((uint)('r') << 8) | ((uint)('t') << 16) | ((uint)('2') << 24)),
    vrtr = ((uint)('v') | ((uint)('r') << 8) | ((uint)('t') << 16) | ((uint)('r') << 24)),
    zero = ((uint)('z') | ((uint)('e') << 8) | ((uint)('r') << 16) | ((uint)('o') << 24)),
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__gdef
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__cmap_14
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__gsub_gpos
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__maxp
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__hea
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_shaper_properties
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__feature
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__head
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__langsys
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_shape_config
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_glyph_config
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_shape_context
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_shape_scratchpad
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_allocator_op_allocate
{
    public void* Pointer;

    [NativeTypeName("unsigned int")]
    public uint Size;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_allocator_op_free
{
    public void* Pointer;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_allocator_op
{
    public kbts_allocator_op_kind Kind;

    [NativeTypeName("__AnonymousRecord_kb_text_shape_L3416_C3")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref kbts_allocator_op_allocate Allocate
    {
        get
        {
            return ref Anonymous.Allocate;
        }
    }

    [UnscopedRef]
    public ref kbts_allocator_op_free Free
    {
        get
        {
            return ref Anonymous.Free;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    [GeneratedCode("ClangSharp", "22.1.8.0")]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public kbts_allocator_op_allocate Allocate;

        [FieldOffset(0)]
        public kbts_allocator_op_free Free;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_blob_table
{
    [NativeTypeName("unsigned int")]
    public uint OffsetFromStartOfFile;

    [NativeTypeName("unsigned int")]
    public uint Length;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_load_font_state
{
    public void* FontData;

    [NativeTypeName("unsigned int")]
    public uint FontDataSize;

    [NativeTypeName("kbts_blob_table[13]")]
    public _Tables_e__FixedBuffer Tables;

    [NativeTypeName("unsigned int")]
    public uint LookupCount;

    [NativeTypeName("unsigned int")]
    public uint LookupSubtableCount;

    [NativeTypeName("unsigned int")]
    public uint GlyphCount;

    [NativeTypeName("unsigned int")]
    public uint ScratchSize;

    [NativeTypeName("unsigned int")]
    public uint GlyphLookupMatrixSizeInBytes;

    [NativeTypeName("unsigned int")]
    public uint GlyphLookupSubtableMatrixSizeInBytes;

    [NativeTypeName("unsigned int")]
    public uint TotalSize;

    [InlineArray(13)]
    public partial struct _Tables_e__FixedBuffer
    {
        public kbts_blob_table e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_blob_header
{
    [NativeTypeName("unsigned int")]
    public uint Magic;

    [NativeTypeName("unsigned int")]
    public uint Version;

    [NativeTypeName("unsigned int")]
    public uint LookupCount;

    [NativeTypeName("unsigned int")]
    public uint LookupSubtableCount;

    [NativeTypeName("unsigned int")]
    public uint GlyphCount;

    [NativeTypeName("unsigned int")]
    public uint GposLookupIndexOffset;

    [NativeTypeName("unsigned int")]
    public uint GlyphLookupMatrixOffsetFromStartOfFile;

    [NativeTypeName("unsigned int")]
    public uint GlyphLookupSubtableMatrixOffsetFromStartOfFile;

    [NativeTypeName("unsigned int")]
    public uint LookupSubtableIndexOffsetsOffsetFromStartOfFile;

    [NativeTypeName("unsigned int")]
    public uint SubtableInfosOffsetFromStartOfFile;

    [NativeTypeName("kbts_blob_table[13]")]
    public _Tables_e__FixedBuffer Tables;

    [InlineArray(13)]
    public partial struct _Tables_e__FixedBuffer
    {
        public kbts_blob_table e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_font
{
    [NativeTypeName("kbts_allocator_function *")]
    public delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator;

    public void* AllocatorData;

    public kbts_blob_header* Blob;

    [NativeTypeName("unsigned short *")]
    public ushort* Cmap;

    public kbts__cmap_14* Cmap14;

    [NativeTypeName("kbts__gsub_gpos *[2]")]
    public _ShapingTables_e__FixedBuffer ShapingTables;

    public void* UserData;

    public kbts_load_font_error Error;

    public unsafe partial struct _ShapingTables_e__FixedBuffer
    {
        public kbts__gsub_gpos* e0;
        public kbts__gsub_gpos* e1;

        public ref kbts__gsub_gpos* this[int index]
        {
            get
            {
                fixed (kbts__gsub_gpos** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_font_info
{
    [NativeTypeName("char *[13]")]
    public _Strings_e__FixedBuffer Strings;

    [NativeTypeName("unsigned short[13]")]
    public _StringLengths_e__FixedBuffer StringLengths;

    public kbts_font_style_flags StyleFlags;

    public kbts_font_weight Weight;

    public kbts_font_width Width;

    public unsafe partial struct _Strings_e__FixedBuffer
    {
        public sbyte* e0;
        public sbyte* e1;
        public sbyte* e2;
        public sbyte* e3;
        public sbyte* e4;
        public sbyte* e5;
        public sbyte* e6;
        public sbyte* e7;
        public sbyte* e8;
        public sbyte* e9;
        public sbyte* e10;
        public sbyte* e11;
        public sbyte* e12;

        public ref sbyte* this[int index]
        {
            get
            {
                fixed (sbyte** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    [InlineArray(13)]
    public partial struct _StringLengths_e__FixedBuffer
    {
        public ushort e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_font_info2
{
    [NativeTypeName("unsigned int")]
    public uint Size;

    [NativeTypeName("char *[13]")]
    public _Strings_e__FixedBuffer Strings;

    [NativeTypeName("unsigned short[13]")]
    public _StringLengths_e__FixedBuffer StringLengths;

    public kbts_font_style_flags StyleFlags;

    public kbts_font_weight Weight;

    public kbts_font_width Width;

    public unsafe partial struct _Strings_e__FixedBuffer
    {
        public sbyte* e0;
        public sbyte* e1;
        public sbyte* e2;
        public sbyte* e3;
        public sbyte* e4;
        public sbyte* e5;
        public sbyte* e6;
        public sbyte* e7;
        public sbyte* e8;
        public sbyte* e9;
        public sbyte* e10;
        public sbyte* e11;
        public sbyte* e12;

        public ref sbyte* this[int index]
        {
            get
            {
                fixed (sbyte** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    [InlineArray(13)]
    public partial struct _StringLengths_e__FixedBuffer
    {
        public ushort e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_font_info2_1
{
    public kbts_font_info2 Base;

    [NativeTypeName("unsigned short")]
    public ushort UnitsPerEm;

    public short XMin;

    public short YMin;

    public short XMax;

    public short YMax;

    public short Ascent;

    public short Descent;

    public short LineGap;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_font_info2_2
{
    public kbts_font_info2 Base;

    [NativeTypeName("unsigned short")]
    public ushort UnitsPerEm;

    public short XMin;

    public short YMin;

    public short XMax;

    public short YMax;

    public short Ascent;

    public short Descent;

    public short LineGap;

    public short CapitalHeight;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_feature_override
{
    public kbts_feature_tag Tag;

    public int Value;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_break
{
    public int Position;

    public kbts_break_flags Flags;

    public kbts_direction Direction;

    public kbts_direction ParagraphDirection;

    public kbts_script Script;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_bracket
{
    [NativeTypeName("unsigned int")]
    public uint Codepoint;

    [NativeTypeName("unsigned int")]
    public uint Position;

    [NativeTypeName("unsigned char")]
    public byte Direction;

    [NativeTypeName("unsigned char")]
    public byte Script;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_break_state
{
    [NativeTypeName("kbts_break[8]")]
    public _Breaks_e__FixedBuffer Breaks;

    [NativeTypeName("unsigned int")]
    public uint BreakCount;

    public kbts_direction ParagraphDirection;

    public kbts_direction UserParagraphDirection;

    [NativeTypeName("unsigned int")]
    public uint CurrentPosition;

    [NativeTypeName("unsigned int")]
    public uint ParagraphStartPosition;

    [NativeTypeName("unsigned int")]
    public uint LastScriptBreakPosition;

    [NativeTypeName("unsigned int")]
    public uint LastDirectionBreakPosition;

    [NativeTypeName("unsigned char")]
    public byte LastScriptBreakScript;

    [NativeTypeName("unsigned char")]
    public byte LastDirectionBreakDirection;

    public short ScriptPositionOffset;

    [NativeTypeName("unsigned int")]
    public uint ScriptCount;

    [NativeTypeName("unsigned char[23]")]
    public _ScriptSet_e__FixedBuffer ScriptSet;

    [NativeTypeName("kbts_bracket[64]")]
    public _Brackets_e__FixedBuffer Brackets;

    [NativeTypeName("unsigned int")]
    public uint BracketCount;

    public kbts_break_state_flags Flags;

    [NativeTypeName("unsigned int")]
    public uint FlagState;

    public short PositionOffset2;

    public short PositionOffset3;

    [NativeTypeName("unsigned int")]
    public uint WordBreakHistory;

    [NativeTypeName("unsigned short")]
    public ushort WordBreaks;

    [NativeTypeName("unsigned short")]
    public ushort WordUnbreaks;

    public short WordBreak2PositionOffset;

    [NativeTypeName("unsigned long long")]
    public ulong LineBreaks;

    [NativeTypeName("unsigned long long")]
    public ulong LineUnbreaksAsync;

    [NativeTypeName("unsigned long long")]
    public ulong LineUnbreaks;

    [NativeTypeName("unsigned int")]
    public uint LineBreakHistory;

    public short LineBreak2PositionOffset;

    public short LineBreak3PositionOffset;

    [NativeTypeName("unsigned char")]
    public byte LastDirection;

    [NativeTypeName("unsigned char")]
    public byte BidirectionalClass2;

    [NativeTypeName("unsigned char")]
    public byte BidirectionalClass1;

    public short Bidirectional1PositionOffset;

    public short Bidirectional2PositionOffset;

    public kbts_japanese_line_break_style JapaneseLineBreakStyle;

    public kbts_break_config_flags ConfigFlags;

    [NativeTypeName("unsigned char")]
    public byte GraphemeBreakState;

    [NativeTypeName("unsigned char")]
    public byte LastLineBreakClass;

    [NativeTypeName("unsigned char")]
    public byte LastWordBreakClass;

    [NativeTypeName("unsigned char")]
    public byte LastWordBreakClassIncludingIgnored;

    [InlineArray(8)]
    public partial struct _Breaks_e__FixedBuffer
    {
        public kbts_break e0;
    }

    [InlineArray(23)]
    public partial struct _ScriptSet_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(64)]
    public partial struct _Brackets_e__FixedBuffer
    {
        public kbts_bracket e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_decode
{
    public int Codepoint;

    public int SourceCharactersConsumed;

    public int Valid;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_encode_utf8
{
    [NativeTypeName("char[4]")]
    public _Encoded_e__FixedBuffer Encoded;

    public int EncodedLength;

    public int Valid;

    [InlineArray(4)]
    public partial struct _Encoded_e__FixedBuffer
    {
        public sbyte e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_glyph_classes
{
    [NativeTypeName("unsigned short")]
    public ushort Class;

    [NativeTypeName("unsigned short")]
    public ushort MarkAttachmentClass;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts__bucketed_glyph
{
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_glyph
{
    public kbts_glyph* Prev;

    public kbts_glyph* Next;

    [NativeTypeName("unsigned int")]
    public uint Codepoint;

    [NativeTypeName("unsigned short")]
    public ushort Id;

    [NativeTypeName("unsigned short")]
    public ushort Uid;

    public int UserIdOrCodepointIndex;

    public int OffsetX;

    public int OffsetY;

    public int AdvanceX;

    public int AdvanceY;

    [NativeTypeName("struct kbts_glyph *")]
    public kbts_glyph* AttachGlyph;

    public kbts_glyph_config* Config;

    [NativeTypeName("unsigned long long")]
    public ulong Decomposition;

    public kbts_glyph_classes Classes;

    public kbts_glyph_flags Flags;

    [NativeTypeName("unsigned int")]
    public uint ParentInfo;

    public kbts__bucketed_glyph* Bucketed;

    [NativeTypeName("unsigned int")]
    public uint SortKey;

    [NativeTypeName("unsigned int")]
    public uint SortKeyInterval;

    [NativeTypeName("unsigned short")]
    public ushort BucketedBucketIndex;

    [NativeTypeName("unsigned short")]
    public ushort LigatureUid;

    [NativeTypeName("unsigned short")]
    public ushort LigatureComponentIndexPlusOne;

    [NativeTypeName("unsigned short")]
    public ushort LigatureComponentCount;

    public kbts_joining_feature JoiningFeature;

    public kbts_unicode_joining_type JoiningType;

    [NativeTypeName("unsigned char")]
    public byte UnicodeFlags;

    [NativeTypeName("unsigned char")]
    public byte SyllabicClass;

    [NativeTypeName("unsigned char")]
    public byte SyllabicPosition;

    [NativeTypeName("unsigned char")]
    public byte UseClass;

    [NativeTypeName("unsigned char")]
    public byte CombiningClass;

    [NativeTypeName("unsigned char")]
    public byte MarkOrdering;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_shape_codepoint
{
    public kbts_font* Font;

    public kbts_feature_override* FeatureOverrides;

    public int FeatureOverrideCount;

    public int Codepoint;

    public int UserId;

    public kbts_break_flags BreakFlags;

    public kbts_script Script;

    public kbts_direction Direction;

    public kbts_direction ParagraphDirection;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_shape_codepoint_iterator
{
    public kbts_shape_codepoint* Codepoint;

    public kbts_shape_context* Context;

    [NativeTypeName("unsigned int")]
    public uint EndBlockIndex;

    [NativeTypeName("unsigned int")]
    public uint OnePastLastCodepointIndex;

    [NativeTypeName("unsigned int")]
    public uint BlockIndex;

    [NativeTypeName("unsigned int")]
    public uint CodepointIndex;

    [NativeTypeName("unsigned int")]
    public uint CurrentBlockCodepointCount;

    [NativeTypeName("unsigned int")]
    public uint FlatCodepointIndex;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_glyph_iterator
{
    public kbts_glyph_storage* GlyphStorage;

    public kbts_glyph* CurrentGlyph;

    public int LastAdvanceX;

    public int X;

    public int Y;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_arena_block_header
{
    [NativeTypeName("struct kbts_arena_block_header *")]
    public kbts_arena_block_header* Prev;

    [NativeTypeName("struct kbts_arena_block_header *")]
    public kbts_arena_block_header* Next;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_arena
{
    [NativeTypeName("kbts_allocator_function *")]
    public delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator;

    public void* AllocatorData;

    public kbts_arena_block_header BlockSentinel;

    public kbts_arena_block_header FreeBlockSentinel;

    public int Error;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_glyph_storage
{
    public kbts_arena Arena;

    public kbts_glyph GlyphSentinel;

    public kbts_glyph FreeGlyphSentinel;

    public int Error;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct kbts_glyph_parent
{
    [NativeTypeName("unsigned int")]
    public uint Codepoint;

    [NativeTypeName("unsigned int")]
    public uint Codepoint1;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_font_coverage_test
{
    public kbts_font* Font;

    [NativeTypeName("unsigned int")]
    public uint BaseCodepoint;

    public int CurrentBaseError;

    public int Error;

    [NativeTypeName("kbts_glyph_parent[19]")]
    public _BaseParents_e__FixedBuffer BaseParents;

    [NativeTypeName("unsigned int")]
    public uint BaseParentCount;

    [InlineArray(19)]
    public partial struct _BaseParents_e__FixedBuffer
    {
        public kbts_glyph_parent e0;
    }
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public unsafe partial struct kbts_run
{
    public kbts_font* Font;

    public kbts_script Script;

    public kbts_direction ParagraphDirection;

    public kbts_direction Direction;

    public kbts_break_flags Flags;

    public kbts_glyph_iterator Glyphs;
}

[GeneratedCode("ClangSharp", "22.1.8.0")]
public static unsafe partial class KbTextShape
{
    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_SizeOfShapeContext();

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_context* kbts_PlaceShapeContext2([NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData, void* Memory, kbts_shape_context_flags Flags);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_context* kbts_PlaceShapeContext([NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData, void* Memory);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_context* kbts_PlaceShapeContextFixedMemory2(void* Memory, int Size, kbts_shape_context_flags Flags);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_context* kbts_PlaceShapeContextFixedMemory(void* Memory, int Size);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_context* kbts_CreateShapeContext2([NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData, kbts_shape_context_flags Flags);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_context* kbts_CreateShapeContext([NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_DestroyShapeContext(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_font* kbts_ShapePushFontFromFile(kbts_shape_context* Context, [NativeTypeName("const char *")] sbyte* FileName, int FontIndex);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_font* kbts_ShapePushFontFromMemory(kbts_shape_context* Context, void* Memory, int Size, int FontIndex);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_font* kbts_ShapePushFont(kbts_shape_context* Context, kbts_font* Font);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_font* kbts_ShapePopFont(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeBegin(kbts_shape_context* Context, kbts_direction ParagraphDirection, kbts_language Language);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeEnd(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_ShapeRun(kbts_shape_context* Context, kbts_run* Run);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapePushFeature(kbts_shape_context* Context, [NativeTypeName("unsigned int")] uint FeatureTag, int Value);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_ShapePopFeature(kbts_shape_context* Context, [NativeTypeName("unsigned int")] uint FeatureTag);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeCodepoint(kbts_shape_context* Context, int Codepoint);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeCodepointWithUserId(kbts_shape_context* Context, int Codepoint, int UserId);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeUtf32(kbts_shape_context* Context, int* Utf32, int Length);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeUtf32WithUserId(kbts_shape_context* Context, int* Utf32, int Length, int UserId, int UserIdIncrement);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeUtf8(kbts_shape_context* Context, [NativeTypeName("const char *")] sbyte* Utf8, int Length, kbts_user_id_generation_mode UserIdGenerationMode);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeUtf8WithUserId(kbts_shape_context* Context, [NativeTypeName("const char *")] sbyte* Utf8, int Length, int UserId, kbts_user_id_generation_mode UserIdGenerationMode);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_error kbts_ShapeError(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeBeginManualRuns(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeNextManualRun(kbts_shape_context* Context, kbts_direction Direction, kbts_script Script);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeEndManualRuns(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ShapeManualBreak(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_codepoint_iterator kbts_ShapeCurrentCodepointsIterator(kbts_shape_context* Context);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_ShapeCodepointIteratorIsValid(kbts_shape_codepoint_iterator* It);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_ShapeCodepointIteratorNext(kbts_shape_codepoint_iterator* It, kbts_shape_codepoint* Codepoint, int* CodepointIndex);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_ShapeGetShapeCodepoint(kbts_shape_context* Context, int CodepointIndex, kbts_shape_codepoint* Codepoint);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_error kbts_ShapeDirect(kbts_shape_scratchpad* Scratchpad, kbts_glyph_storage* Storage, kbts_direction RunDirection, kbts_glyph_iterator* Output);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_font kbts_FontFromFile([NativeTypeName("const char *")] sbyte* FileName, int FontIndex, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData, void** FileData, int* FileSize);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_FontCount(void* FileData, int FileSize);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_font kbts_FontFromMemory(void* FileData, int FileSize, int FontIndex, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_FreeFont(kbts_font* Font);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_FontIsValid(kbts_font* Font);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_load_font_error kbts_LoadFont(kbts_font* Font, kbts_load_font_state* State, void* FontData, int FontDataSize, int FontIndex, int* ScratchSize_, int* OutputSize_);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_load_font_error kbts_PlaceBlob(kbts_font* Font, kbts_load_font_state* State, void* ScratchMemory, void* OutputMemory);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_GetFontInfo(kbts_font* Font, kbts_font_info* Info);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_GetFontInfo2(kbts_font* Font, kbts_font_info2* Info);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_SizeOfShapeConfig(kbts_font* Font, kbts_script Script, kbts_language Language);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_config* kbts_PlaceShapeConfig(kbts_font* Font, kbts_script Script, kbts_language Language, void* Memory);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_config* kbts_CreateShapeConfig(kbts_font* Font, kbts_script Script, kbts_language Language, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_DestroyShapeConfig(kbts_shape_config* Config);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_InitializeGlyphStorage(kbts_glyph_storage* Storage, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_InitializeGlyphStorageFixedMemory(kbts_glyph_storage* Storage, void* Memory, int MemorySize);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_glyph* kbts_PushGlyph(kbts_glyph_storage* Storage, kbts_font* Font, int Codepoint, kbts_glyph_config* Config, int UserId);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_ClearActiveGlyphs(kbts_glyph_storage* Storage);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_FreeAllGlyphs(kbts_glyph_storage* Storage);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_glyph kbts_CodepointToGlyph(kbts_font* Font, int Codepoint, kbts_glyph_config* Config, int UserId);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_CodepointToGlyphId(kbts_font* Font, int Codepoint);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_glyph_iterator kbts_ActiveGlyphIterator(kbts_glyph_storage* Storage);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_SizeOfGlyphConfig(kbts_shape_config* ShapeConfig, kbts_feature_override* Overrides, int OverrideCount);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_glyph_config* kbts_PlaceGlyphConfig(kbts_shape_config* ShapeConfig, kbts_feature_override* Overrides, int OverrideCount, void* Memory);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_glyph_config* kbts_CreateGlyphConfig(kbts_shape_config* ShapeConfig, kbts_feature_override* Overrides, int OverrideCount, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_DestroyGlyphConfig(kbts_glyph_config* Config);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong kbts_SizeOfShapeScratchpad(kbts_shape_config* Config);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_scratchpad* kbts_PlaceShapeScratchpad(kbts_shape_config* Config, void* Memory, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_scratchpad* kbts_PlaceShapeScratchpadFixedMemory(kbts_shape_config* Config, void* Memory, int Size);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_shape_scratchpad* kbts_CreateShapeScratchpad(kbts_shape_config* Config, [NativeTypeName("kbts_allocator_function *")] delegate* unmanaged[Cdecl]<void*, kbts_allocator_op*, void> Allocator, void* AllocatorData);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_DestroyShapeScratchpad(kbts_shape_scratchpad* Scratchpad);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_GlyphIteratorNext(kbts_glyph_iterator* It, kbts_glyph** Glyph);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_GlyphIteratorIsValid(kbts_glyph_iterator* It);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_GuessTextProperties(void* Text, int TextSizeInBytes, kbts_text_format Format, kbts_direction* Direction, kbts_script* Script);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_GuessTextPropertiesUtf32([NativeTypeName("const int *")] int* Utf32, int Utf32Count, kbts_direction* Direction, kbts_script* Script);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_GuessTextPropertiesUtf8([NativeTypeName("const char *")] sbyte* Utf8, int Utf8Length, kbts_direction* Direction, kbts_script* Script);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_BreakBegin(kbts_break_state* State, kbts_direction ParagraphDirection, kbts_japanese_line_break_style JapaneseLineBreakStyle, kbts_break_config_flags ConfigFlags);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_BreakAddCodepoint(kbts_break_state* State, int Codepoint, int PositionIncrement, int EndOfText);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_BreakEnd(kbts_break_state* State);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_Break(kbts_break_state* State, kbts_break* Break);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_BreakEntireString(kbts_direction Direction, kbts_japanese_line_break_style JapaneseLineBreakStyle, kbts_break_config_flags ConfigFlags, [NativeTypeName("const void *")] void* Input, int InputSizeInBytes, kbts_text_format InputFormat, kbts_break* Breaks, int BreakCapacity, int* BreakCount, kbts_break_flags* BreakFlags, int BreakFlagCapacity, int* BreakFlagCount);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_BreakEntireStringUtf32(kbts_direction Direction, kbts_japanese_line_break_style JapaneseLineBreakStyle, kbts_break_config_flags ConfigFlags, [NativeTypeName("const int *")] int* Utf32, int Utf32Count, kbts_break* Breaks, int BreakCapacity, int* BreakCount, kbts_break_flags* BreakFlags, int BreakFlagCapacity, int* BreakFlagCount);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_BreakEntireStringUtf8(kbts_direction Direction, kbts_japanese_line_break_style JapaneseLineBreakStyle, kbts_break_config_flags ConfigFlags, [NativeTypeName("const char *")] sbyte* Utf8, int Utf8Length, kbts_break* Breaks, int BreakCapacity, int* BreakCount, kbts_break_flags* BreakFlags, int BreakFlagCapacity, int* BreakFlagCount);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_FontCoverageTestBegin(kbts_font_coverage_test* Test, kbts_font* Font);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void kbts_FontCoverageTestCodepoint(kbts_font_coverage_test* Test, int Codepoint);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_FontCoverageTestEnd(kbts_font_coverage_test* Test);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_decode kbts_DecodeUtf8([NativeTypeName("const char *")] sbyte* Utf8, [NativeTypeName("unsigned long long")] ulong Length);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_encode_utf8 kbts_EncodeUtf8(int Codepoint);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_direction kbts_ScriptDirection(kbts_script Script);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int kbts_ScriptIsComplex(kbts_script Script);

    [DllImport("kb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern kbts_script kbts_ScriptTagToScript(kbts_script_tag Tag);

    [NativeTypeName("#define KB_TEXT_SHAPE_POINTER_SIZE 8")]
    public const int KB_TEXT_SHAPE_POINTER_SIZE = 8;

    [NativeTypeName("#define KBTS_MAXIMUM_RECOMPOSITION_PARENTS 19")]
    public const int KBTS_MAXIMUM_RECOMPOSITION_PARENTS = 19;

    [NativeTypeName("#define KBTS_MAXIMUM_CODEPOINT_SCRIPTS 23")]
    public const int KBTS_MAXIMUM_CODEPOINT_SCRIPTS = 23;
}

/// <summary>Defines the type of a member as it was used in the native signature.</summary>
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class NativeTypeNameAttribute : Attribute
{
    private readonly string _name;

    /// <summary>Initializes a new instance of the <see cref="NativeTypeNameAttribute" /> class.</summary>
    /// <param name="name">The name of the type that was used in the native signature.</param>
    public NativeTypeNameAttribute(string name)
    {
        _name = name;
    }

    /// <summary>Gets the name of the type that was used in the native signature.</summary>
    public string Name => _name;
}

/// <summary>Defines the annotation found in a native declaration.</summary>
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
[Conditional("DEBUG")]
internal sealed partial class NativeAnnotationAttribute : Attribute
{
    private readonly string _annotation;

    /// <summary>Initializes a new instance of the <see cref="NativeAnnotationAttribute" /> class.</summary>
    /// <param name="annotation">The annotation that was used in the native declaration.</param>
    public NativeAnnotationAttribute(string annotation)
    {
        _annotation = annotation;
    }

    /// <summary>Gets the annotation that was used in the native declaration.</summary>
    public string Annotation => _annotation;
}
