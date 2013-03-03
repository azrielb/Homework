/*
father(X, Y).
mother(X, Y).
married(X, Y).
*/

diff(X, Y) :- female(X), male(Y).
diff(X, Y) :- male(X), female(Y).
male(X)  :- father(X, _).
female(X) :- mother(X, _).
parent(X, Y) :- father(X, Y).
parent(X, Y) :- mother(X, Y).

motherInLaw(X, Y) :- mother(X, Z), married(Z, Y), male(Y).
bendod(X, Y) :- male(X), father(Z, X), parent(A, Z), parent(A, B), diff(Z, B), parent(B, Y).
cousin(X, Y) :- parent(Z, X), parent(A, Z), parent(A, B), diff(Z, B), parent(B, Y).
cousin3(X, Y) :- parent(A, X), parent(B, A), cousin(B, C), parent(C, D), parent(D, Y).
brotherInLaw(X, Y) :- male(X), parent(A, X), parent(A, Z), diff(X, Z), married(Z, Y).
brotherInLaw(X, Y) :- male(X), married(X, Z), parent(A, Y), parent(A, Z), diff(Y, Z).
brotherInLaw(X, Y) :- male(X), married(X, Z), parent(A, Z), parent(A, B), diff(A, B), married(B, Y).

diff(rachel, leah).
diff(leah, rachel).
diff(eisav, yaakov).
diff(yaakov, eisav).
father(bethuel, lavan).
father(bethuel, rivka).
father(lavan, leah).
father(lavan, rachel).
father(yaakov, dina).
father(yaakov, yosef).
father(yosef, menashe).
father(eisav, elifaz).
mother(dina, osnath).
mother(leah, dina).
mother(osnath, menashe).
mother(rachel, yosef).
mother(rivka, eisav).
mother(rivka, yaakov).
male(menashe).
married(osnath, yosef).
married(yosef, osnath).
married(yaakov, rachel).
married(yaakov, leah).
married(rachel, yaakov).
married(leah, yaakov).
married(eisav, bosmat).
married(bosmat, eisav).
