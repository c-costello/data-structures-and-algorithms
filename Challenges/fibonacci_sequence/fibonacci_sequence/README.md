# Fibonacci Sequence

## Challenge
Write a method that takes in a number (n) and returns the nth term of the fibonacci sequence. 

## Approach & Efficiency
-Space and Time:
	- Time: O(n) - we create an array the length of n and iterate all the way through
	- Space: O(n) - we create an array the length of n 
- Approach:
	- We create an array with a length of our given number (called n after this)
	- We define the first two terms of the array to equal 0 and 1 respectively
	- We iterate through the currently empty array, starting at the 3rd term
	- We set the third term to be equal to the first and second term
	- We go through the array, setting each term (t) to equal the two terms before it (t-1) + (t-2)
	- When we reach n, the loop breaks. We return the nth term.



