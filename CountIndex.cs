namespace AssignmentC;

public class CountIndex
{
    public int countString(string input, string searchWord)
    {
        int count = 0;
        int startIndex = 0;
        while ((startIndex = input.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            startIndex += searchWord.Length;
        }

        return count;
    }
}