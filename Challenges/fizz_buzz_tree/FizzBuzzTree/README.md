## FizzBuzzTree

## Challenge:
Given a tree, traverse the tree, replacing any number divisible by three with the word "Fizz" any number divisible by five with the word "Buzz", and any word divisible by three and five with the word "FizzBuzz". Return the tree. 

## Approach and Efficients
- Big O
	- Time: O(n) we go through each element of the tree once
	- Space O(h) Because we use depth first traversal to go through the tree, we have a worst case scenario of having to make space for the height of the tree.
- Approach
	Using recurision, we first go through all of the left children, then all of the right children, of each Root. We check the value of each node for divisibilty against 15, 3, and 5. If it is divisible, we replace that node with a node with a value of "FizzBuzz", "Fizz", or "Buzz", respectively. 
## Solution 

![WhiteBoard](assets/whiteboard.jpg)