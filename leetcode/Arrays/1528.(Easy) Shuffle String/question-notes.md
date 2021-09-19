<h2>Question</h2>

<p>1528.(Easy) Shuffle String</p>

<h2>Description</h2>

<p>Given a string s and an integer array indices of the same length.

The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.

Return the shuffled string.</p>

<h2>Initial thoughts</h2>

<p>Thought about sorting the index aray and replacing from lasrgest to smallest but no need to overcomplicate things. Use soem extra memory with an output array and copy to the correct index.</p>

<h2>My Solution</h2>

<p> 
1. Split the string to characters.
2. for each index get the character vale
3. go through sorted char array and create output string.


</p>

<h2>My Solution - Runtime/Space</h2>

<h3>LeetCode Rank</h3>

<p>I actually for a bug in the testcase which I reported (100 good developer karma points) https://github.com/LeetCode-Feedback/LeetCode-Feedback/issues/4830 so I couldnt get a solution speed.</p>

<h3>My estimated Complexity</h3>

<p>
O(3n) ~ O(n). £ single for loops in the solution.
O(2n) ~ o(n) space for increasing space of sortedArr and charecterArr
</p>

<h2>Best Discussion Solution</h2>

<p>Cyclic Sort with O(1) SPACE and O(N) Time complexity</p>

<h2>Notes</h2>

<p></p>