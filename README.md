This program is for educational purposes and shows the process behind simple CS built in methods.

We created this package to educate users and educate ourselves while making these seemingly simple methods
that we take for granted.



StringUtils:

ToUpper:

This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
EX) StringUtils.ToUpper("banana") returns "BANANA"

ToLower:

This method will take in 1 string as a parameter and return the string int the arguments lowercase form.
EX) StringUtils.ToLower("BANANA") returns "banana"

Length:

This method will take in 1 string as a parameter and return a int which represents the length of the string. 
Ex)  StringUtils.Length("Gavin") returns 5

Reverse:
This method will take in 1 string as a parameter and return a string in the arguments reverse form
Ex) StringUtils.Reverse("Emir") returns "rimE"

CountVowels:
This method will take in 1 string as a parameter and return a int which represents the amount of vowels in the string
Ex) StringUtils.CountVowels("Gavin") returns 2

CountConsonants:
This method will take in 1 string as a parameter and return a int which represents the amount of consonants in the string
Ex) StringUtils.CountConsonants("Gavin") returns 3

HasLetter:
This method will take in a string and a char and return a bool, will return true if char input is in string input and vice versa
Ex) StringUtils.HasLetter("Hotdog" , 'd') returns true

spaceOut:
This method will take in a string and return a string with spaces between the letters of the string
Ex) StringUtils.spaceOut("Arthur") returns  "A r t h u r"

EndsWith:
This method takes in a string and a char and returns a bool, if char input is equal to the letter at end of the string returns true and vice versa
Ex) StringUtils.EndsWith("Morgan" , 'n') returns true

Compare:
This method takes in 2 strings and returns a bool, if both strings are equal to eachother true is returned and vice versa
Ex) StringUtils.Compare("Love", "Love") returns true

Remove:
This method takes in a string and a char and returns a string without the letter that you inputed in char
Ex) StringUtils.Remove("Martinez", 'n') returns "Martiez"



ArrayUtils:

Average:
It takes in an array, adds every number and finds the average of it 
Ex) [1, 3, 5] It returns 3.

Max:
It takes in an array, compares every number and returns the max
Ex) [1, 3, 5] It returns 5. 

Min:
It takes in an array, compares every number and returns the minimum
Ex) [1, 3, 5] It returns 1. 

Sum:
It takes in an array, and then adds all the numbers in it 
Ex) [1, 3, 5] It returns 9. 

Product:
It takes in an array, and then multiplies all the numbers together
Ex) [1, 3, 5] It returns 15.

SortAscend:
It takes in an array, and then sorts lowest to greatest
Ex) [7, 5, 9, 13] ===> [5, 7, 9, 13]

SortDescend:
It takes in an array, and then sorts greatest to lowest. 
Ex) [7, 5, 9, 13] ===> [13, 9, 7, 5]

GetArrayLength:
Returns the length of the array 
Ex) [2, 10, 18] It returns 3. 

Copy:
Copies to a new array and returns the new array back to you. 
Ex) [2, 10, 18] ===> [newArray] [newArray] = [2, 10, 18]

Reverse:
Reverses the array you put in 
Ex) [5, 10, 13, 7, 1] ===> [1, 7, 13, 10, 5]

Clear:
Clears the array you input
Ex) [26, 9, 7, 20] ==> [0, 0, 0, 0]



MathUtils:

Min:
This method will take in two numbers and find the minimum of the two 
Ex) (2, 7) It returns 2. 

Max:
This method will take in two numbers and find the maximum of the two 
Ex) (2, 7) It returns 7.

Add:
This method will take in two numbers and add them
Ex) (2, 7) It returns 9.

Subtract:
This method will take in two numbers and add them
Ex) (2, 7) It returns -5.

Multiply:
This method will take in two numbers and multiply them. 
Ex) (2, 7) It returns 14. 

Divide:
This method will take in two numbers and divide them.
Ex) (8, 2) It returns 4. 

AbsValue:
This method takes in a value and finds the absolute value
Ex) (-8) It returns 8.

Power:
This method takes in two numbers. It applies the power to the first number. 
Ex) (2, 4) It returns 16. 

Round:
This method takes in a number and rounds it up or down.
Ex) (4.7) returns 5.

Sqrt:
This method takes in one value that it square roots. 
Ex) (16) It returns 4. 

Floor:
It takes any number with decimals and rounds down 
Ex) (4.9) It returns 4. 

Ceiling:
It takes any number with decimals and round up.
Ex) (4.1) It returns 5.

Square:
It takes in any number and squares it. 
Ex) (4) It returns 16.

Cube:
It takes in any number and cubes it. 
Ex) (3) It returns 27.




License: MIT
