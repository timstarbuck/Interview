#!/bin/bash

echo -n 'How many sequences: '
read -r loops

i=0
j=1
for (( c=0; c<loops; c++ )) ; do
    (( n=i+j ))
    (( i=j ))
    (( j=n ))
    echo $i
done