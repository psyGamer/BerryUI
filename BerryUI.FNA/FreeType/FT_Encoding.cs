using System.CodeDom.Compiler;

namespace BerryUI.FNA.FreeType;

[NativeTypeName("unsigned int")]
[GeneratedCode("ClangSharp", "22.1.8.0")]
public enum FT_Encoding : uint
{
    NONE = (((uint)((byte)(0)) << 24) | ((uint)((byte)(0)) << 16) | ((uint)((byte)(0)) << 8) | (uint)((byte)(0))),
    MS_SYMBOL = (((uint)((byte)('s')) << 24) | ((uint)((byte)('y')) << 16) | ((uint)((byte)('m')) << 8) | (uint)((byte)('b'))),
    UNICODE = (((uint)((byte)('u')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('c'))),
    SJIS = (((uint)((byte)('s')) << 24) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('s'))),
    PRC = (((uint)((byte)('g')) << 24) | ((uint)((byte)('b')) << 16) | ((uint)((byte)(' ')) << 8) | (uint)((byte)(' '))),
    BIG5 = (((uint)((byte)('b')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('g')) << 8) | (uint)((byte)('5'))),
    WANSUNG = (((uint)((byte)('w')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('s'))),
    JOHAB = (((uint)((byte)('j')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('h')) << 8) | (uint)((byte)('a'))),
    GB2312 = PRC,
    MS_SJIS = SJIS,
    MS_GB2312 = PRC,
    MS_BIG5 = BIG5,
    MS_WANSUNG = WANSUNG,
    MS_JOHAB = JOHAB,
    ADOBE_STANDARD = (((uint)((byte)('A')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('O')) << 8) | (uint)((byte)('B'))),
    ADOBE_EXPERT = (((uint)((byte)('A')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('B')) << 8) | (uint)((byte)('E'))),
    ADOBE_CUSTOM = (((uint)((byte)('A')) << 24) | ((uint)((byte)('D')) << 16) | ((uint)((byte)('B')) << 8) | (uint)((byte)('C'))),
    ADOBE_LATIN_1 = (((uint)((byte)('l')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('t')) << 8) | (uint)((byte)('1'))),
    OLD_LATIN_2 = (((uint)((byte)('l')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('t')) << 8) | (uint)((byte)('2'))),
    APPLE_ROMAN = (((uint)((byte)('a')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('m')) << 8) | (uint)((byte)('n'))),
}
