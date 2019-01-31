# Find Max Value

## Challenge:
Given a Binary Tree, navigate through the tree, find the maximum value of the nodes in the tree, and return that value.  

## Approach and Efficiency
- Big O
	- Time: O(n) we go through the entire tree.
	- Space: O(h) where h is the height of the tree, because at the most we have the height of the tree in our stack.
- Approach
	- Create the method GetMaximumValue that takes in a tree. Overload the method so it can also take in a root and the max value.
	- Define int maxValue to be the minimum possible value, in case there are negative numbers.
	- If the root of the tree is greater than the maxValue, set maxValue equal to the value of root.
	- Using recursion, traverse through each node, checking maxValue against the nodes value.
	- Return the max value


## Solution
![Whiteboard](assets/whiteboard_17.jpg)