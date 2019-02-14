# Insertion Sort

## Challenge
Given an unordered array, Write a Method that returns the array sorted using insertion sort.

## Approach and Efficiency
- Big O
	- Space: O(1) we do not create anything signifigant when calling this method. We create a temp variable to assist in sorting, but it is not of consiquence.
	- Time: O(n^2) When we sort our array, we run nested loops, giving us an Big O of n squared.
- Approach
	- Start a for loop starting at 1 and running to the length of the array.
	- Insidethe for loop, establish a temp variable thatis the current value of the array, and a variable j that is one less than our current index.
	- Inside the for loop, start a while loop that runs so long as j is greater than 0, AND temp is less than the array at j. Set the array at j + 1 to equal the array at j. Deincrement j by one. In otherwords, while array[j] exists and is greater than our defined temp, move array[j] down the array.
	- Outside the while loop, but inside the for loop, set array[j+1] equal to our defined temp array.
	- Repeat until the entire array has been gone through.
	- Return the array 
	
