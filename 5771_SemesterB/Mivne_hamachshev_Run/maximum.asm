.text 

li $17,0 
li $18,0  # maximum
li $19,0 
li $20,0

lw $16,arry($17)

loop:
addi $17,$17,4
lw $20,arry($17)
slt $19,$18,$20
beqz $19,continue

add $18,$zero,$20

continue:
subi $16,$16,1
bnez $16,loop

.data arry
arry:
.word
4,8,8,2,9



