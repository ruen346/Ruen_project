if have_equ2_ob.index=0
{
switch (inven_setting1.equ_slot2_[slot_w,slot_h])
{
case 1:
have_equ2_ob.index=1;
break;

case 2:
have_equ2_ob.index=2;
break;

case 3:
break;
};
inven_setting1.equ_slot2_[slot_w,slot_h] = 0; //장비 장착시 0
}
