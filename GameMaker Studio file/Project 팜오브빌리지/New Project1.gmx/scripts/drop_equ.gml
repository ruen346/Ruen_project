for (var h=0; h<4; h+=1)
    {for (var w=0; w<8; w+=1)
        {if(start_setting.equ_slot_[w,h] = 0)
        {start_setting.equ_slot_[w,h] = item_num;
        instance_destroy(); exit;}
        };
    };
