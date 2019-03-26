if not (global.chat_e=global.chat_o) {
if global.chat_o>-1 
{
draw_sprite(talkbox_sp,-9,128,400)
draw_sprite(speakbox_sp,-8,154,380)
draw_text(view_xview+170,view_yview+396,string(global.chat_n))
draw_text(view_xview+150,view_yview+422,"#"+string_copy(global.chat_c[global.chat_o],1,global.chat_t))
}}
