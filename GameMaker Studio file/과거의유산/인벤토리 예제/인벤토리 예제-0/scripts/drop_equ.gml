for (var h=0; h<4; h+=1)
    {for (var w=0; w<6; w+=1)
        {if(obj_inventory.equ_slot_[w,h] = 0)
        {obj_inventory.equ_slot_[w,h] = item_num;
        instance_destroy(); exit;}
        };
    };
