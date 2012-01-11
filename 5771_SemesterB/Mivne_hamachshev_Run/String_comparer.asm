#   amiel cohen 300639093
#   azriel berger 

.data
.asciiz
string_1: "amico"
string_2: "amico"
string_3: "ba"
string_4: "ba1"
no_string: "the strings are not equal"
yes_string: "the strings equal"

#######################

.text
j start #jup to start 

str_cmp: #compare function

for:
lb $t2,($a0) # we are load only 1 byte (no word)
lb $t3,($a1) 

bne $t2,$t3, not_equal # if the bit of 1 str no equal to 2 str go to no_enal function 

beqz $t2, equal # if the bit equal go to equal 

addi $a0,$a0,1 # primote to load next word 
addi $a1,$a1,1
j for

not_equal: 
li $t0,0 # define $to = falg  falg = false 
jr $ra

equal:
li $t0,1 # falg = true
jr $ra


start:
la $a0,string_1 #load string 
la,$a1,string_2

jal str_cmp # go to compare function and save link

beqz  $t0 , not_eq # if (! flag   )  go to no 

la $a0,string_3
la,$a1,string_4

jal str_cmp

beqz  $t0 , not_eq # if (! flag   )  go to no 

li $v0 ,4 # else = if (! flag ) print syscall yes : 
la $a0, yes_string
syscall
 j exit


not_eq:  # print syscal not : 
li $v0 ,4
la $a0, no_string
syscall

exit:







