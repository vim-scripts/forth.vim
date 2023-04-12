( This file tests Forth syntax highlighting.
  The goal is that it will test all functionality.
  Please add to it as you make changes. )

\ --- Comments

\ comments are highlighted like this...
( ...or this... )
( ...multi-line comments
  are fine too! )

\ --- Strings

\ Verify that strings have their own color.
s" s-quote"
c" c-quote"
\" a string, too" ( What is \" ? )
s\" s-backslash-quote"

\ Verify that escaped characters have their own color.
s\" \a\b\e\f\l\m\n\q\r\t\v\z\"\xff\x00\\"

\ --- Spell Checking

( activate spell checking by
   :setlocal spell spelllang=en_us
then, verify that the below "mispelt"
words are highlighted. )
s" mispelt"
c" mispelt"
( mispelt )
\ mispelt
s\" mispelt"
