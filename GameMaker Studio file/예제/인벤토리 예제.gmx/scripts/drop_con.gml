for (var h=0; h<4; h+=1)
    {for (var w=0; w<6; w+=1)
        {if(obj_inventory.con_slot_[w,h]=item_num && obj_inventory.con_numb_[w,h]<10)
        {obj_inventory.con_numb_[w,h] += 1;
        instance_destroy(); exit;}
        };
    };
for (var h=0; h<4; h+=1)
    {for (var w=0; w<6; w+=1)
        {if(obj_inventory.con_slot_[w,h] = 0)
        {obj_inventory.con_slot_[w,h] = item_num;
        instance_destroy(); exit;}
        };
    };
