L9. Palindrome Number
Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
//My incorrect solution:

public class Solution {
    public bool IsPalindrome(int x) {
        if(x > 0){ 
            string[] charArray = x.ToArray();  
            if(charArray == Array.Reverse(charArray)){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
Thought Process:
Originally, I wanted to read through every character in the integer to and compare first to last. Then I realize upon looking at the examples that it would be quicker to compare the input to the reverse of the input. 

I wanted to take each character in the input and place them in an array. Then if I compare the array to the reverse, I can see if it is a palandrome

Solution:

public class Solution {
    public bool IsPalindrome(int x) {
            string s = x.ToString(); // must convert int to string first
            var y = s.ToArray();  // set up string into array
            Array.Reverse(y); // reverse array
            string z = new string(y); convert array into string again
            
            if(s == z){ //then compare
                return true;
            }
            else{
                return false;
            }
    }
}
Solution 2 to go though every character

public class Solution {
    public bool IsPalindrome(int x) {
        string k = x.ToString();        
        
        for(int i=0;i<k.Length/2;i++)   
        {
            if(k[i] != k[k.Length-1-i]) 
            {
                return false;           // if any char not the same, return false
            }
        }
        return true;                    
    }
}

