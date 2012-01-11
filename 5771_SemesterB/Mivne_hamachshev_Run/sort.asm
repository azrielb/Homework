.text 

#מיון בועות

li $15,0 
li $14,4  
li $19,0 
li $18 , 0 
li $21 ,0  
#li $22,0 


lw $16,arry($15)
subi $16,$16,1 
#addi $15,$15,4 

loop1:
#li $17,4
li $22,0

loop2:
addi $15,$15,4
lw  $18,arry($15)
addi $20,$15,4
lw $21 ,arry($20)
slt $19,$18,$21
bnez $19 Nswap

sw $18 arry($20)
sw $21 arry($15)

Nswap:
#li $14,4

#addi $15,$15,4
addi $22,$22,1
bne $22,$16 loop2

subi $16,$16,1
li $15,0 
bnez $16,loop1

.data arry
arry:
.word
4,9,6,7,8
