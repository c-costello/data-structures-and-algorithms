# No Duplicates
Given a string, check if all the characters are unique.

##Approach and Efficiency
Big O
- Time: O(n) - We iterate through the entire array
- Space: O(1) - There is a fixed number of characters that could possibly exist. The worst case Space cannot exceed that number, and therefore space is not dependented on the length of the string. 

Approach
- Create a hash table
- Iterate through the string
- At each character, check if the character is contained in the hashtable. 
- If it is, return false.
- If it is not, add that character to the hashtable.
- After the for loop return true
