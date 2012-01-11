.text
start:
li $v0, 4  # Writes string to stantart output
la $a0, endl
syscall
la $a0, msg1
syscall

li $v0, 5 # Reads int from stantart input
syscall
beqz $v0, start
move $t0, $v0 # $t0 = n

li $t1, 1 # int i = 1 - this line must be before the label of for-start
li $t2, 0 # $t2 = offset (in the array)

for1: #for (int i = 1; i <= n; ++i)
li $v0, 4
la $a0, msg2part1
syscall
li $v0, 1 # Writes integer to standart output
move $a0, $t1 # t1 is i
syscall
li $v0, 4
la $a0, msg2part2
syscall
li $v0, 1 # Writes integer to standart output
move $a0, $t0 # t0 is n
syscall
li $v0, 4
la $a0, msg2part3
syscall

li $v0, 5 # Reads int from stantart input
syscall
sw $v0, numbers($t2)# $t2 is the offset

addi $t1, $t1, 1 # ++i
addi $t2, $t2, 4 # offset += 4
ble $t1, $t0, for1 # end for

#bubble-sort
li $t2, -4 # $t2 is the offset

subi $t1,$t0,1 # now $t1 is (n-1)

#for ($t1 = $t0 - 1; $t1 > 0; --$t1)
loop1:
li $t3,0

#for ($t3 = 0; $t3 > $t1; ++$t3)
loop2:
addi $t2,$t2,4 # offset += 4
lw  $t6,numbers($t2)
addi $t5,$t2,4 # the next item
lw $t7 ,numbers($t5)
ble $t6,$t7,Nswap # if $t6 <= $t7 then don't swap!

#swap
sw $t6 numbers($t5)
sw $t7 numbers($t2)
Nswap:

addi $t3,$t3,1
bne $t3,$t1 loop2 #end for (loop2)

subi $t1,$t1,1
li $t2,-4
bnez $t1,loop1 #end for (loop1)

#the sort is finished 

#print the biggest number
la $a0, msg3
li $v0, 4
syscall
mult $t0,$v0 # HI+LO = $t0 * 4 (I used $v0 since its value is 4)
mflo $t3
subi $t3,$t3,4
lw $a0 numbers($t3)
li $v0, 1
syscall

#print the sorted numbers
la $a0, msg4
li $v0, 4
syscall

for2: #for ($t1 = 0; $t1 <= $t3; $t1 += 4)
li $v0, 4
la $a0, revach
syscall
li $v0, 1 # Writes integer to standart output
lw $a0 numbers($t1)
syscall

addi $t1, $t1, 4 # offset += 4
ble $t1, $t3, for2 # end for

.data
.asciiz
msg1: "How much nubmers do you have? "
msg2part1: "Please insert number "
msg2part2: " of "
msg2part3: ": "
msg3: "\nThe biggest number is "
msg4: "\n\nThe sorted numbers are:"
revach: " "
endl: "\n"
.word
numbers: 0
