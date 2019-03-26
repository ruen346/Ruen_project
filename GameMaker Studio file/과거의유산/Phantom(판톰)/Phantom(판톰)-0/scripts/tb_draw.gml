draw_set_font(font0)
if speaker_place= 1 {draw_sprite_ext(speaker_sx,speaker_ix,80*room_width/640,1/2*room_height-100*room_height/480,1,1,0,c_white,1)}
if speaker_place= 2 {draw_sprite_ext(speaker_sx,speaker_ix,260*room_width/640,1/2*room_height-100*room_height/480,1,1,0,c_white,1)}
if speaker_place= 3 {draw_sprite_ext(speaker_sx,speaker_ix,440*room_width/640,1/2*room_height-100*room_height/480,1,1,0,c_white,1)}
if speaker_place= 4 {draw_sprite_ext(speaker_sx,speaker_ix,620*room_width/640,1/2*room_height-100*room_height/480,1,1,0,c_white,1)}

draw_sprite_ext(talkbox_sp,0,1/2*room_width,1/2*room_height+120*room_height/480,1,1,0,talk_box_col,talk_box_a)

if itext_length < itext_max_length {itext_length+= 1}
  
draw_text_ext_transformed_colour(32*room_width/640,1/2*room_height+100*room_height/480,string_copy(itext,itext_cut_til,itext_length),font_get_size(font0)+4,font_get_size(font0)*letter_limit,1,1,0,itext_col,itext_col,itext_col,itext_col,itext_a)

if speaker_number = 1
{
draw_sprite_ext(speakbox_sp,speaker_box1_on,78*room_width/640,1/2*room_height,room_width/640,room_height/480,0,talk_box_col,talk_box_a)
}

if speaker_number = 2
{
draw_sprite_ext(speakbox_sp,speaker_box1_on,78*room_width/640,1/2*room_height,room_width/640,room_height/480,0,talk_box_col,talk_box_a)
draw_sprite_ext(speakbox_sp,speaker_box2_on,258*room_width/640,1/2*room_height,room_width/640,room_height/480,0,speaker_box_col,speaker_box_a)
}

if speaker_number = 3
{
draw_sprite_ext(speakbox_sp,speaker_box1_on,78*room_width/640,1/2*room_height,room_width/640,room_height/480,0,talk_box_col,talk_box_a)
draw_sprite_ext(speakbox_sp,speaker_box2_on,258*room_width/640,1/2*room_height,room_width/640,room_height/480,0,speaker_box_col,speaker_box_a)
draw_sprite_ext(speakbox_sp,speaker_box3_on,438*room_width/640,1/2*room_height,room_width/640,room_height/480,0,speaker_box_col,speaker_box_a)
}

if speaker_number = 4
{
draw_sprite_ext(speakbox_sp,speaker_box1_on,78*room_width/640,1/2*room_height,room_width/640,room_height/480,0,talk_box_col,talk_box_a)
draw_sprite_ext(speakbox_sp,speaker_box2_on,258*room_width/640,1/2*room_height,room_width/640,room_height/480,0,speaker_box_col,speaker_box_a)
draw_sprite_ext(speakbox_sp,speaker_box3_on,438*room_width/640,1/2*room_height,room_width/640,room_height/480,0,speaker_box_col,speaker_box_a)
draw_sprite_ext(speakbox_sp,speaker_box4_on,618*room_width/640,1/2*room_height,room_width/640,room_height/480,0,speaker_box_col,speaker_box_a)
}

if speaker_place=1 {draw_text_colour(78*room_width/640,1/2*room_height-4,speaker_name,s_n_col,s_n_col,s_n_col,s_n_col,s_n_a)}
if speaker_place=2 {draw_text_colour(258*room_width/640,1/2*room_height-4,speaker_name,s_n_col,s_n_col,s_n_col,s_n_col,s_n_a)}
if speaker_place=3 {draw_text_colour(438*room_width/640,1/2*room_height-4,speaker_name,s_n_col,s_n_col,s_n_col,s_n_col,s_n_a)}
if speaker_place=4 {draw_text_colour(618*room_width/640,1/2*room_height-4,speaker_name,s_n_col,s_n_col,s_n_col,s_n_col,s_n_a)}
