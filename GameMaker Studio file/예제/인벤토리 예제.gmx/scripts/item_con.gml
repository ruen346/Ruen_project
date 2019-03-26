switch (obj_inventory.con_slot_[slot_w,slot_h])
{
case 1://여기에는 아이템에 따라 mp나 hp를 회복 하는 코드를 넣어주시면 됩니다.
case 2:
case 3:
};

if (obj_inventory.con_numb_[slot_w,slot_h] > 1)
    {obj_inventory.con_numb_[slot_w,slot_h] -= 1;}//아이템이 여러개라면 갯수를 하나 뺍니다.
else
    {obj_inventory.con_slot_[slot_w,slot_h] = 0;}//아이템이 하나 뿐이라면 슬롯을 비웁니다.
