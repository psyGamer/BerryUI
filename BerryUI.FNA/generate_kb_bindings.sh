#!/usr/bin/env sh

CLANG21_RESOURCE_DIR=${1:?}
KB_TEXT_SHAPE_INCLUDE_DIR=${2:?}

rm KbTextShape.cs

ClangSharpPInvokeGenerator \
    -rd $CLANG21_RESOURCE_DIR \
    -I $KB_TEXT_SHAPE_INCLUDE_DIR \
    --file $KB_TEXT_SHAPE_INCLUDE_DIR/kb_text_shape.h \
    --traverse $KB_TEXT_SHAPE_INCLUDE_DIR/kb_text_shape.h \
    --method-class-name KbTextShape \
    --library-path kb \
    --namespace BerryUI.FNA \
    --output KbTextShape.cs \
    --with-enum-member-strip kbts_*=common-prefix \
    --with-type kbts_japanese_line_break_style_enum=byte \
    --with-type kbts_joining_feature_enum=byte \
    --with-type kbts_unicode_joining_type_enum=byte \
    --config \
    file=single \
    --generate \
    file-scoped-namespaces \
    helper-types \
    macro-bindings \
    generated-code=type \
    enum-member-type-name=false \
    --log \
    potential-typedef-remappings \
    --remap \
    kbts_japanese_line_break_style_enum=kbts_japanese_line_break_style \
    kbts_japanese_line_break_style=kbts_japanese_line_break_style \
    kbts_joining_feature_enum=kbts_joining_feature \
    kbts_joining_feature=kbts_joining_feature \
    kbts_unicode_joining_type_enum=kbts_unicode_joining_type \
    kbts_unicode_joining_type=kbts_unicode_joining_type \
    kbts_language_enum=kbts_language \
    kbts_language=kbts_language \
    kbts_break_flags_enum=kbts_break_flags \
    kbts_break_flags=kbts_break_flags \
    kbts_break_state_flags_enum=kbts_break_state_flags \
    kbts_break_state_flags=kbts_break_state_flags \
    kbts_shape_context_flags_enum=kbts_shape_context_flags \
    kbts_shape_context_flags=kbts_shape_context_flags \
    kbts_text_format_enum=kbts_text_format \
    kbts_text_format=kbts_text_format \
    kbts_direction_enum=kbts_direction \
    kbts_direction=kbts_direction \
    kbts_orientation_enum=kbts_orientation \
    kbts_orientation=kbts_orientation \
    kbts_shaping_table_enum=kbts_shaping_table \
    kbts_shaping_table=kbts_shaping_table \
    kbts_shape_error_enum=kbts_shape_error \
    kbts_shape_error=kbts_shape_error \
    kbts_allocator_op_kind_enum=kbts_allocator_op_kind \
    kbts_allocator_op_kind=kbts_allocator_op_kind \
    kbts_blob_table_id_enum=kbts_blob_table_id \
    kbts_blob_table_id=kbts_blob_table_id \
    kbts_load_font_error_enum=kbts_load_font_error \
    kbts_load_font_error=kbts_load_font_error \
    kbts_version_enum=kbts_version \
    kbts_version=kbts_version \
    kbts_blob_version_enum=kbts_blob_version \
    kbts_blob_version=kbts_blob_version \
    kbts_font_style_flags_enum=kbts_font_style_flags \
    kbts_font_style_flags=kbts_font_style_flags \
    kbts_font_weight_enum=kbts_font_weight \
    kbts_font_weight=kbts_font_weight \
    kbts_font_width_enum=kbts_font_width \
    kbts_font_width=kbts_font_width \
    kbts_glyph_flags_enum=kbts_glyph_flags \
    kbts_glyph_flags=kbts_glyph_flags \
    kbts_user_id_generation_mode_enum=kbts_user_id_generation_mode \
    kbts_user_id_generation_mode=kbts_user_id_generation_mode \
    kbts_break_config_flags_enum=kbts_break_config_flags \
    kbts_break_config_flags=kbts_break_config_flags \
    kbts_font_info_string_id_enum=kbts_font_info_string_id \
    kbts_font_info_string_id=kbts_font_info_string_id \
    kbts_unicode_flag_enum=kbts_unicode_flag \
    kbts_unicode_flag=kbts_unicode_flag \
    kbts_unicode_bidirectional_class_enum=kbts_unicode_bidirectional_class \
    kbts_unicode_bidirectional_class=kbts_unicode_bidirectional_class \
    kbts_line_break_class_enum=kbts_line_break_class \
    kbts_line_break_class=kbts_line_break_class \
    kbts_word_break_class_enum=kbts_word_break_class \
    kbts_word_break_class=kbts_word_break_class \
    kbts_shaper_enum=kbts_shaper \
    kbts_shaper=kbts_shaper \
    kbts_script_tag_enum=kbts_script_tag \
    kbts_script_tag=kbts_script_tag \
    kbts_script_enum=kbts_script \
    kbts_script=kbts_script \
    kbts_feature_tag_enum=kbts_feature_tag \
    kbts_feature_tag=kbts_feature_tag \

sed -i 's/case =/@case =/' KbTextShape.cs


