public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Create/initialize a new double array with a size equal to numberOfMultiples.
    double[] multiples = new double[numberOfMultiples];

    // Step 2: Set up a loop to iterate through each index from 0 up to numberOfMultiples - 1.
    for (int i = 0; i < numberOfMultiples; i++)
    {
        // Step 3: Calculate the multiple for the current position. 
        // Multiplying the starting number by (i + 1) scales the index perfectly (e.g., 1st item = 1 * start, 2nd = 2 * start).
        multiples[i] = startingNumber * (i + 1);
    }

        return []multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
    {
    // Step 1: Check if the list is empty or if the rotation amount matches the total count.
    // If either condition is true, rotating changes nothing, so we can return early.
    if (data == null || data.Count <= 1 || amount == data.Count)
    {
        return;
    }

    // Step 2: Calculate the split index where the list breaks.
    // The items moving to the front are the last 'amount' elements of the list.
    int splitIndex = data.Count - amount;

    // Step 3: Use GetRange to copy the segment of numbers from the back that need to move to the front.
    List<int> backSegment = data.GetRange(splitIndex, amount);

    // Step 4: Use RemoveRange to erase those extracted back elements from their original positions at the end of the list.
    data.RemoveRange(splitIndex, amount);

    // Step 5: Use InsertRange to inject the saved backSegment directly back into the very beginning (index 0) of the list.
    data.InsertRange(0, backSegment);
}
    
}
