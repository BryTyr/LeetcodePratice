<h2>Question</h2>

<p>1365. (Easy) How Many Numbers Are Smaller Than the Current Number</p>

<h2>Description</h2>

<p>Given the array nums, for each nums[i] find out how many numbers in the array are smaller 
than it. That is, for each nums[i] you have to count the number of valid j's such that j != i 
and nums[j] < nums[i].

Return the answer in an array.</p>

<h2>Initial thoughts</h2>

<p>A double/inner for loop is the first thing that comes to mind. Easy but O(n^2) complexity so must be a better way.
After thinking, a single loop with some sort of running count should be possible.</p>

<h2>My Solution</h2>

<p>Final solution consisted of two indidual loops.
1. First loop adds array value as key to sortedDictionary and adds the index to a list as the value in the dict.
2. Second loop keeps a running count of values for each key in the dictionary and places the running count in each index in the array.</p>

<h2>My Solution - Runtime/Space</h2>

<h3>LeetCode Rank</h3>

<p>248ms - faster than 70.69%</p>
<p>33.4 MB - less than 5.75% of others</p>

<h3>My estimated Complexity</h3>

<p>O(n) + O(n) = O(2n) runtime ~ O(n)</p>
<p>O(n) space complexity</p>

<h2>Best Discussion Solution</h2>

<p>Counting sort seemed to be a popular solution. But its limitation is you need a fixed length for the input array e.g. <=100. very fast though.</p>

<h2>Notes</h2>

<p>N/A</p>