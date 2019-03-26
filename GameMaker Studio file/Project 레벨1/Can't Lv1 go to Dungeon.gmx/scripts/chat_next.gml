if not (global.chat_e=global.chat_o) {
if global.chat_o>-1 {
if string_length(global.chat_c[global.chat_o]) > global.chat_t {
    global.chat_t=string_length(global.chat_c[global.chat_o])
}
else {
    global.chat_o+=1
    global.chat_t=0
}
}
else {
    global.chat_o+=1
    global.chat_t=0
}
}
