# Breadth First Traversal

## Challenge
Create a method, BreadthFirstTraversal, that traverses a binary tree using breadth first traversal.

## Approach and Efficiency
- Big O
	- Time O(n) because we go through the entire tree
	- Space O(w) where w is the width of the tree because worst case we have to make space for the max width of the tree

- Approach
	- Create an empty lsit
	- Create a queue
	- enqueue the tree's root
	- Enqueue the front's left and right child (if they exist)
	- Dequeue the front and add it to the list
	- repeat the above to steps until the queue is empty
	- Convert the list to an array and return it


## Solution
![WhiteBoarD](assets/whiteboard.jpg)