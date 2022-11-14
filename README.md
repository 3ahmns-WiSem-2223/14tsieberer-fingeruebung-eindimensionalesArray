# 14tsieberer-fingeruebung-eindimensionalesArray
Ein Array ist eine Datenstruktur, deren Elemente alle vom gleichen Typ sind. Die einzelnen Elemente sind in einer festliegenden Reihenfolge angeordnet und werden über einen Index angesprochen. Die Abspeicherung eines Arrays erfolgt in einem zusammenhängenden Speicherblock; die einzelnen Array-elemente sind in aufeinanderfolgenden Speicherplätzen abgelegt und mit einem Index gekennzeichnet.


Wie greife ich auf (n-1) zu und was ist n?

n …Anzahl der Elemente im Array

(n-1) …letzte Stelle im Array

0 …erste Stelle im Array


Auf eine Array-Komponente wird folgendermaßen zugegriffen:
Angabe des Index (als int-Ausdruck) in eckigen Klammern nach dem Array-Variablennamen. Zum Beispiel: a[3] oder auch b[i+2*j]


Also kann auf n-1 folgendermaßen zugegriffen werden:

testArray[testArray.Length - 1]

…wobei Array.Length die Anzahl der Elemente im Array angibt, also praktisch n.

![IMG_0455](https://user-images.githubusercontent.com/114923448/201669210-efb81e44-71c1-4cb2-9c3a-1bf9a6899ff1.jpg)
