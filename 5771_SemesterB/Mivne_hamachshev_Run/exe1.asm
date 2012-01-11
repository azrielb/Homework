.text
# $16	f
# $17	g
# $18	h
# $19	i
# $20	j

beq $19,$20,ij # if (i == j) goto ij; else - continue;

sub $16,$17,$18 # f=g-h;
j endif1 # end if

ij: add $16,$17,$18 # f=g+h;
endif1: # end if


#for(int i=0;i<5;i++) g++;
li $19,0 # i = 0;

myfor1: # for start
bge $19,5,endfor1 # if (i>=5) goto endfor1
addi $17,$17,1 # g++
addi $19,$19,1 # i++
j myfor1 # loop
endfor1: # end for

li $18,20 # h=20;
li $17,13 # g=13;
# for(int i=0;i<5;i++)
add $19,$zero,$zero # i = 0;

myfor2: # for start
bge $19,5,endfor2 # if (i>=5) goto endfor1
addi $17,$17,1 # g++
sub $20,$18,$17 # j = h-g
beq $20,10,endfor2 # if(j == 10 ) break;
addi $19,$19,1 # i++
j myfor2 # loop
endfor2: # end for
