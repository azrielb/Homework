#vowel?
#Dec. ascii of the small-vowels: a - 97, e - 101, i - 105, o - 111, u - 117
#Dec. ascii of '0' is 48
.text
start:
li $v0, 4  # Writes string to stantart output
la $a0, endl
syscall
la $a0, msg1

#while ($v0 != '0')
while1:
syscall
la $a0, msg2
syscall
li $v0 12 # Reads one character to $v0
syscall
move $t0, $v0 # This lime saves the character in $t0 before we're change $v0
li $v0, 4  # Anyway we need it to print a string.

beq $t0,  48, finish1 # if ($t0 == '0') goto finish1

beq $t0,  97, vowel #	if ($t0 == 'a') goto vowel
beq $t0, 101, vowel #	if ($t0 == 'e') goto vowel
beq $t0, 105, vowel #	if ($t0 == 'i') goto vowel
beq $t0, 111, vowel #	if ($t0 == 'o') goto vowel
beq $t0, 117, vowel #	if ($t0 == 'u') goto vowel

la $a0, msg3
b while1 #End while

vowel:
la $a0, msg4
b while1 #End while

finish1:
la $a0, msg5
syscall

.data
.asciiz
msg1: "Hello my friend!\nPlease insert letters, and I'll say you if it's a vowel.\nInsert '0' (zero) for end."
msg2: "\nPlease insert letter: "
msg3: "\nNo. This is not a vowel.\n"
msg4: "\nYes. This is a vowel.\n"
msg5: "\n\nGood bye!"
revach: " "
endl: "\n"
