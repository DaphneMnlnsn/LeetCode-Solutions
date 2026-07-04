public class Solution {
    public bool IsValid(string s) {
        char[] parentheses = s.ToArray();
        char[] opening = ['[','{','('];
        char[] closing = [']','}',')'];
        
        Stack<char> list = new Stack<char>();

        foreach(char parenthesis in parentheses){
            if(opening.Contains(parenthesis)){
                list.Push(parenthesis);
            }
            if(closing.Contains(parenthesis)){
                int index = closing.IndexOf(parenthesis);
                if(list.Count != 0){
                    if(opening.IndexOf(list.Peek()) == index){
                        list.Pop();
                    }
                    else{
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
        }

        if(list.Count != 0){
            return false;
        }
        else{
            return true;
        }
    }
}