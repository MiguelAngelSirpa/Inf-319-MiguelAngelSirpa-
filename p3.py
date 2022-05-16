# -*- coding: utf-8 -*-
"""
Created on Mon May 16 03:44:45 2022

@author: Cliente
"""
from  pyswip  import  Prolog
prolog = Prolog()

#prolog.assertz( "padre(juan,maria)" )
#prolog.assertz( "padre(pablo,juan)" )
#prolog.assertz( "padre(pablo,marcela)" )
#prolog.assertz( "padre(carlos,débora)" )

list( prolog.query( "padre(juan,X)" )) == [{ 'X' : 'maria' },{ 'X' , 'juan' },{ 'X' , 'marcela' },{ 'X' , 'débora' }]
list( prolog.query( "padre(pablo,X)" )) == [{ 'X' : 'maria' },{ 'X' , 'juan' },{ 'X' , 'marcela' },{ 'X' , 'débora' }]
list( prolog.query( "padre(carlos,X)" )) == [{ 'X' : 'maria' },{ 'X' , 'juan' },{ 'X' , 'marcela' },{ 'X' , 'débora' }]
for elemento  in  prolog.query( "padre(X,Y)" ):
           print( elemento [ "X" ], "es el padre de" , elemento [ "Y" ])