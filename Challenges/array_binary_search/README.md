# Binary Search

## Challenge
Write a function called BinarySearch which takes in an array and a value to search for. Without utilizing any of the built-in methods available to your language, return the index of the value in the array or -1 if the value is not in the array.
## Approach & Efficiency
-Space and Time:
	- Time: O(n) - we potentially iterate through the array
	- Space: O(1) - We do not have to create anything new to take up space
- Approach:
	- We used a loop to work through our search. At each point we check the midpoint value against the value of the given number. If they are the same, we return the midpoint value. If it is greater, we replace the midpoint with a new index halfway between the old midpoint and the end of the array and re-run the loop. If the value is less than the value at the midpoint, we reset the midpoint to be halfway between the old midpoint and the beginning of the array. 

## Solution

![Whiteboard](../../Assets/whiteboard_03.PNG)