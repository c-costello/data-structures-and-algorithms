# Is Ancestor (SnowDay)

## Challenge
Given integers A and B, and a Node root, determine if A is an ancestor of B in the Binary Tree root references

## Approach & Efficiency
- Space and Time:
	- Time: O(n) - We step through the entire binary tree
	- Space: O(W) - We use a queue, so worst case, we must make space in the queue for the max width of the tree.
- Approach:
	- Create two queues, q1 and q2
	- Use bredth first traversal of the binary tree, enqueueing and dequeing into q1 until integer A is found, or until q1 is emppty.
	- if integer A is found, enqueue the node into Q2. Traverse the rest of the tree in Q2, if B is found, return true.

## Solution

![Whiteboard](../../Assets/snowday_whiteboard_2)
