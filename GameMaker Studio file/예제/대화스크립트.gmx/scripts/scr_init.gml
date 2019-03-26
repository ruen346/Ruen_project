line=0; //몇번째 라인인가? (불러오기 같은데 써먹으면 됨.)
str="0"; //기본 대사.
str_og="0" //움직이는 대사.
name="0"; //이름.
type=0; // /0 거르기 
ongoing=false; //움직이고 있는가?
char=0; //움직이는 대사수.


time=1; //클릭 딜레이.
alarm0=0; //딜레이를 위한 변수. (알람 대용.)

file=file_text_open_read("source.txt");
