#!/usr/bin/env sh

CLANG21_RESOURCE_DIR=${1:?}
FREETYPE_INCLUDE_DIR=${2:?}

rm -rf FreeType

cat >/tmp/freetype.h <<EOL
#include <freetype/freetype.h>
#include <freetype/ftadvanc.h>
#include <freetype/ftbbox.h>
#include <freetype/ftbdf.h>
#include <freetype/ftbitmap.h>
#include <freetype/ftbzip2.h>
#include <freetype/ftcache.h>
#include <freetype/ftchapters.h>
#include <freetype/ftcid.h>
#include <freetype/ftcolor.h>
#include <freetype/ftdriver.h>
#include <freetype/fterrors.h>
#include <freetype/ftfntfmt.h>
#include <freetype/ftgasp.h>
#include <freetype/ftglyph.h>
#include <freetype/ftgxval.h>
#include <freetype/ftgzip.h>
#include <freetype/ftimage.h>
#include <freetype/ftincrem.h>
#include <freetype/ftlcdfil.h>
#include <freetype/ftlist.h>
#include <freetype/ftlogging.h>
#include <freetype/ftlzw.h>
#include <freetype/ftmm.h>
#include <freetype/ftmodapi.h>
#include <freetype/ftmoderr.h>
#include <freetype/ftotval.h>
#include <freetype/ftoutln.h>
#include <freetype/ftparams.h>
#include <freetype/ftpfr.h>
#include <freetype/ftrender.h>
#include <freetype/ftsizes.h>
#include <freetype/ftsnames.h>
#include <freetype/ftstroke.h>
#include <freetype/ftsynth.h>
#include <freetype/ftsystem.h>
#include <freetype/fttrigon.h>
#include <freetype/fttypes.h>
#include <freetype/ftwinfnt.h>
#include <freetype/otsvg.h>
#include <freetype/t1tables.h>
#include <freetype/ttnameid.h>
#include <freetype/tttables.h>
#include <freetype/tttags.h>
EOL

ClangSharpPInvokeGenerator \
    -rd $CLANG21_RESOURCE_DIR \
    -I $FREETYPE_INCLUDE_DIR \
    --file /tmp/freetype.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/freetype.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftadvanc.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftbbox.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftbdf.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftbitmap.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftbzip2.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftcache.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftchapters.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftcid.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftcolor.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftdriver.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/fterrors.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftfntfmt.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftgasp.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftglyph.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftgxval.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftgzip.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftimage.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftincrem.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftlcdfil.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftlist.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftlogging.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftlzw.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftmm.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftmodapi.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftmoderr.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftotval.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftoutln.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftparams.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftpfr.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftrender.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftsizes.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftsnames.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftstroke.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftsynth.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftsystem.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/fttrigon.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/fttypes.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftwinfnt.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/otsvg.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/t1tables.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ttnameid.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/tttables.h \
    --traverse $FREETYPE_INCLUDE_DIR/freetype/tttags.h \
    --method-class-name FreeType \
    --library-path freetype \
    --namespace BerryUI.FNA.FreeType \
    --output FreeType \
    --with-constant-folded-value FT_Glyph_Format_.* \
    --with-enum-member-strip FT_*=common-prefix \
    --config \
    file=multi \
    --generate \
    file-scoped-namespaces \
    helper-types \
    macro-bindings \
    generated-code=type \
    enum-member-type-name=false \
    --log \
    potential-typedef-remappings \
    --remap \
    FT_StreamRec_=FT_StreamRec \
    FT_StreamDesc_=FT_StreamDesc \
    FT_Vector_=FT_Vector \
    FT_BBox_=FT_BBox \
    FT_Pixel_Mode_=FT_Pixel_Mode \
    FT_Bitmap_=FT_Bitmap \
    FT_Outline_=FT_Outline \
    FT_Outline_Funcs_=FT_Outline_Funcs \
    FT_Glyph_Format_=FT_Glyph_Format \
    FT_Span_=FT_Span \
    FT_Raster_Params_=FT_Raster_Params \
    FT_Raster_Funcs_=FT_Raster_Funcs \
    FT_UnitVector_=FT_UnitVector \
    FT_Matrix_=FT_Matrix \
    FT_Data_=FT_Data \
    FT_Generic_=FT_Generic \
    FT_ListNodeRec_=FT_ListNodeRec \
    FT_ListRec_=FT_ListRec \
    FT_Glyph_Metrics_=FT_Glyph_Metrics \
    FT_Bitmap_Size_=FT_Bitmap_Size \
    FT_Encoding_=FT_Encoding \
    FT_CharMapRec_=FT_CharMapRec \
    FT_FaceRec_=FT_FaceRec \
    FT_Size_Metrics_=FT_Size_Metrics \
    FT_SizeRec_=FT_SizeRec \
    FT_GlyphSlotRec_=FT_GlyphSlotRec \
    FT_Parameter_=FT_Parameter \
    FT_Open_Args_=FT_Open_Args \
    FT_Size_Request_Type_=FT_Size_Request_Type \
    FT_Size_RequestRec_=FT_Size_RequestRec \
    FT_Render_Mode_=FT_Render_Mode \
    FT_Kerning_Mode_=FT_Kerning_Mode \
    BDF_PropertyType_=BDF_PropertyType \
    BDF_PropertyRec_=BDF_PropertyRec \
    FT_Color_=FT_Color \
    FT_Palette_Data_=FT_Palette_Data \
    FT_LayerIterator_=FT_LayerIterator \
    FT_PaintFormat_=FT_PaintFormat \
    FT_ColorStopIterator_=FT_ColorStopIterator \
    FT_ColorIndex_=FT_ColorIndex \
    FT_ColorStop_=FT_ColorStop \
    FT_PaintExtend_=FT_PaintExtend \
    FT_ColorLine_=FT_ColorLine \
    FT_Affine_23_=FT_Affine23 \
    FT_Composite_Mode_=FT_Composite_Mode \
    FT_Opaque_Paint_=FT_OpaquePaint \
    FT_PaintColrLayers_=FT_PaintColrLayers \
    FT_PaintSolid_=FT_PaintSolid \
    FT_PaintLinearGradient_=FT_PaintLinearGradient \
    FT_PaintRadialGradient_=FT_PaintRadialGradient \
    FT_PaintSweepGradient_=FT_PaintSweepGradient \
    FT_PaintGlyph_=FT_PaintGlyph \
    FT_PaintColrGlyph_=FT_PaintColrGlyph \
    FT_PaintTransform_=FT_PaintTransform \
    FT_PaintTranslate_=FT_PaintTranslate \
    FT_PaintScale_=FT_PaintScale \
    FT_PaintRotate_=FT_PaintRotate \
    FT_PaintSkew_=FT_PaintSkew \
    FT_PaintComposite_=FT_PaintComposite \
    FT_COLR_Paint_=FT_COLR_Paint \
    FT_Color_Root_Transform_=FT_Color_Root_Transform \
    FT_ClipBox_=FT_ClipBox \
    FT_Glyph_Class_=FT_Glyph_Class \
    FT_GlyphRec_=FT_GlyphRec \
    FT_BitmapGlyphRec_=FT_BitmapGlyphRec \
    FT_OutlineGlyphRec_=FT_OutlineGlyphRec \
    FT_SvgGlyphRec_=FT_SvgGlyphRec \
    FT_Glyph_BBox_Mode_=FT_Glyph_BBox_Mode \
    FTC_ScalerRec_=FTC_ScalerRec \
    FTC_ImageTypeRec_=FTC_ImageTypeRec \
    FTC_SBitRec_=FTC_SBitRec \
    FT_Prop_GlyphToScriptMap_=FT_Prop_GlyphToScriptMap \
    FT_Prop_IncreaseXHeight_=FT_Prop_IncreaseXHeight \
    FT_Incremental_MetricsRec_=FT_Incremental_MetricsRec \
    FT_Incremental_FuncsRec_=FT_Incremental_FuncsRec \
    FT_Incremental_InterfaceRec_=FT_Incremental_InterfaceRec \
    FT_LcdFilter_=FT_LcdFilter \
    FT_MM_Axis_=FT_MM_Axis \
    FT_Multi_Master_=FT_Multi_Master \
    FT_Var_Axis_=FT_Var_Axis \
    FT_Var_Named_Style_=FT_Var_Named_Style \
    FT_MM_Var_=FT_MM_Var \
    FT_Module_Class_=FT_Module_Class \
    FT_TrueTypeEngineType_=FT_TrueTypeEngineType \
    FT_Orientation_=FT_Orientation \
    FT_Renderer_Class_=FT_Renderer_Class \
    FT_SfntName_=FT_SfntName \
    FT_SfntLangTag_=FT_SfntLangTag \
    FT_Stroker_LineJoin_=FT_Stroker_LineJoin \
    FT_Stroker_LineCap_=FT_Stroker_LineCap \
    FT_StrokerBorder_=FT_StrokerBorder \
    FT_WinFNT_HeaderRec_=FT_WinFNT_HeaderRec \
    SVG_RendererHooks_=SVG_RendererHooks \
    FT_SVG_DocumentRec_=FT_SVG_DocumentRec \
    PS_FontInfoRec_=PS_FontInfoRec \
    PS_PrivateRec_=PS_PrivateRec \
    T1_Blend_Flags_=T1_Blend_Flags \
    CID_FaceDictRec_=CID_FaceDictRec \
    CID_FaceInfoRec_=CID_FaceInfoRec \
    T1_EncodingType_=T1_EncodingType \
    PS_Dict_Keys_=PS_Dict_Keys \
    TT_Header_=TT_Header \
    TT_HoriHeader_=TT_HoriHeader \
    TT_VertHeader_=TT_VertHeader \
    TT_OS2_=TT_OS2 \
    TT_Postscript_=TT_Postscript \
    TT_PCLT_=TT_PCLT \
    TT_MaxProfile_=TT_MaxProfile \
    FT_Sfnt_Tag_=FT_Sfnt_Tag \
    FT_Driver=FT_Driver \
    FT_Face_Internal=FT_Face_Internal \
    FT_Library=FT_Library \
    FT_Memory=FT_Memory \
    FT_Module=FT_Module \
    FT_Raster=FT_Raster \
    FT_Renderer=FT_Renderer \
    FT_Size_Internal=FT_Size_Internal \
    FT_Slot_Internal=FT_Slot_Internal \
    FT_SubGlyph=FT_SubGlyph \
    FT_FaceRec*=FT_Face \
    FT_Pos=@long \
    FT_F26Dot6=@long \
    __va_list_tag*=@void*

rm /tmp/freetype.h

function fix_opaque() {
    HANDLE_NAME=${1:?}
    echo "global using unsafe $HANDLE_NAME = BerryUI.FNA.FreeType.${HANDLE_NAME}Rec_*;" >> FreeType/GlobalUsings.cs
    
    for f in FreeType/*.cs; do
        sed -i "s/public $HANDLE_NAME/public unsafe $HANDLE_NAME/g" $f
    done
}
function add_opaque() {
    HANDLE_NAME=${1:?}
    echo "global using unsafe $HANDLE_NAME = BerryUI.FNA.FreeType.${HANDLE_NAME}Rec*;" >> FreeType/GlobalUsings.cs
    
    for f in FreeType/*.cs; do
        sed -i "s/public $HANDLE_NAME/public unsafe $HANDLE_NAME/g" $f
    done
}

fix_opaque FTC_CMapCache
fix_opaque FTC_ImageCache
fix_opaque FTC_Manager
fix_opaque FTC_Node
fix_opaque FTC_SBitCache
fix_opaque FT_Driver
fix_opaque FT_Face_Internal
fix_opaque FT_Incremental
fix_opaque FT_Library
fix_opaque FT_Memory
fix_opaque FT_Module
fix_opaque FT_Raster
fix_opaque FT_Renderer
fix_opaque FT_Size_Internal
fix_opaque FT_Slot_Internal
fix_opaque FT_Stroker
fix_opaque FT_SubGlyph

add_opaque BDF_Property
add_opaque CID_FaceDict
add_opaque CID_FaceInfo
add_opaque FT_BitmapGlyph
add_opaque FT_CharMap
add_opaque FTC_ImageType
add_opaque FTC_SBit
add_opaque FTC_Scaler
add_opaque FT_Face
add_opaque FT_Glyph
add_opaque FT_GlyphSlot
add_opaque FT_Incremental_Funcs
add_opaque FT_Incremental_Interface
add_opaque FT_Incremental_Metrics
add_opaque FT_ListNode
add_opaque FT_List
add_opaque FT_OutlineGlyph
add_opaque FT_Size
add_opaque FT_Size_Request
add_opaque FT_Stream
add_opaque FT_SVG_Document
add_opaque FT_SvgGlyph
add_opaque FT_WinFNT_Header
add_opaque PS_FontInfo
add_opaque PS_Private


