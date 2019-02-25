# Graphs

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods: AddNode(), AddEdge(), GetNodes(), GetNeighbors(), and Size().

## Efficiency and Approach
Big O
- AddNode
	- Time: O(1)
	- Space: O(1)
- AddEdge()
	- Time: O(N)
	- Space: O(1)
- GetNodes()
	- Time: O(N^2)
	- Space: O(N)
- GetNeightbors()
	- Time: O(N^2)
	- Space: O(N)
- Size
	- Time: O(N^2);
	- Space: O(N) - Could be refacotred to O(1) space, but the time would be doubled. 