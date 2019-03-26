if time                                                                     
{
    if mouse_check_button_pressed(mb_left) xor keyboard_check_pressed(vk_space)    
    {
        if ongoing
        {
            ongoing=false;
            char=-1;
        }
        else if !ongoing
        {
             var tmp=file_text_read_string(file);                                      
            file_text_readln(file);                                                 
            if (tmp=='/e')                                                         
            {
                game_end();
                exit;
            }
            else if (tmp=='/n')                                                  
                type=1;
            else                                                                       
                type=0;    
        
            if type
            {
                name=file_text_read_string(file);
                file_text_readln(file);
                line++;
                str=file_text_read_string(file);
                file_text_readln(file);
                line++;
            }
            else if !type
            {
                str=tmp;
                line++;
            }
            ongoing=true;
        }
            
        time=0;
        alarm0=7; // 딜레이를 조정하려면 이 값을 조정하시면 됩니다. 
    }
}

if ongoing
{
    str_og=string_copy(str,1,char);
    if (char<string_length(str))
    {
        char++;
    }
    else
    {
        ongoing=false;
        char=-1;
    }    
}

if (alarm0>0)
    alarm0--;
    
if (alarm0==0)
    time=1;
