for (var h=0; h<4; h+=1)
    {for (var w=0; w<6; w+=1)
        {if(start_setting.con_slot_[w,h]=item_num && start_setting.con_numb_[w,h]<10)
        {start_setting.con_numb_[w,h] += 1;
        instance_destroy(); exit;}
        };
    };
for (var h=0; h<4; h+=1)
    {for (var w=0; w<6; w+=1)
        {if(start_setting.con_slot_[w,h] = 0)
        {start_setting.con_slot_[w,h] = item_num;
        instance_destroy(); exit;}
        };
    };
