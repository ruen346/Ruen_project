for (var h=0; h<7; h+=1)
    {for (var w=0; w<4; w+=1)
        {if(inven_setting1.equ_slot3_[w,h] = 0)
        {inven_setting1.equ_slot3_[w,h] = item_num;
        instance_destroy(); exit;}
        };
    };
