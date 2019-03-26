if global.__char_pos[argument0]!=argument1&&global.__char_pos[argument0]!=0
{
    global.__char_move[argument0]=-32
    global.__char_pos_in[argument0]=argument1
}
else
{
    global.__char_pos_sub[argument0]=argument1
    global.__char_move[argument0]=32
}
