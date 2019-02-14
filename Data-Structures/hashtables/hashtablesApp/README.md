# Hashtables

## Challenge
Implement a Hashtable with the following methods:
- add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
- get: takes in the key and returns the value from the table.
- contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
- hash: takes in an arbitrary key and returns an index in the collection.

## Approach and Efficiency
#### Big O
- Add
	- Time: O(1) - Because we are adding by index, we have a time of O(1) 
	- Space: O(1) - Because we are only creating one thing, the space is O(1)
- Get
	- Time: O(1) - Because we are getting by index, we have a time of O(1)
	- Space: O(1) - Because we are not creating anything new, the space is O(1)
- Contains 
	- Time: O(1) - Because weare accessing the array by index, we have a time of O(1)
	- Space: O(1) - Because we are not creating anything, the space is O(1)
- Hash 
	- Time: O(1) - We are simply doing math calculations on the given value, so the time is O(1)
	- Space: O(1) - We are only creating one new things, so the space is O(1)

### Approach
- Add
	- Hash the Key
	- If the value of the hashed key is an empty index, add the key value pair to the array at that index
	- If there is a collision, add the key value pair to the end of the link list.
- Get
	- Hash the key
	- Got to the corresponding index in the array. If there is KeyValuePair, return the value of that pair. If there is more than one, iterate through the link list, checking the keys until the proper key is found. Return that key's value.
- Contains 
	- Hash the key. If something exists at that value in the array, check if there is one or many key value pairs in that bucket. If there is nothing at that value,return false.
	- If there is only one key value pair in the bucket, return true.
	- If there is more than one key value pair in the bucket, iterate throught the link list checking the keys against the given key. If one matches, return true.
	- Else return false.
- Hash 
	- Given a word, convert each character to it's ASCII value. Multiply each value by the characters position in the word.
	- Add all those values together.
	- Return the sum of those values modulous the length of the hashtable. 
	





