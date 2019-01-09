# Insert and Shift an Array

## Challenge
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

## Approach & Efficiency
- Space and Time:
	- Time: O(n) - Our for loop iterates through the entire array
	- Space: O(n) - We had to create a new array
- Approach:
	- We used two for loops to iterate through the front half and back half of the given array, with a break at the midpoint to set the new array's midpoint equal to the given number.

## Solution

![Whiteboard](../../Assets/whiteboard_02.JPG)
