#!/usr/bin/env sh

CLANG21_RESOURCE_DIR=${1:?}
FREETYPE_INCLUDE_DIR=${2:?}

rm -rf FreeType

ClangSharpPInvokeGenerator \
    -rd $CLANG21_RESOURCE_DIR \
    -I $FREETYPE_INCLUDE_DIR \
    --file $FREETYPE_INCLUDE_DIR/freetype/freetype.h \
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
    --traverse $FREETYPE_INCLUDE_DIR/freetype/fterrdef.h \
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
    --traverse $FREETYPE_INCLUDE_DIR/freetype/ftmac.h \
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
    FT_FaceRec*=FT_Face

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

fix_opaque FT_Driver
fix_opaque FT_Face_Internal
fix_opaque FT_Library
fix_opaque FT_Memory
fix_opaque FT_Module
fix_opaque FT_Raster
fix_opaque FT_Renderer
fix_opaque FT_Size_Internal
fix_opaque FT_Slot_Internal
fix_opaque FT_SubGlyph

add_opaque FT_Face


