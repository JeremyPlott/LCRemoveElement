public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {

        //we are going to use this as a pointer for the index of the original array and overwrite with it.
        //it also functions as a tally for the number of digits that aren't the exclude value.
        var arrayWriter = 0;

        //we will iterate through the array
        for (int index = 0; index < nums.Length; index++)
        {
            //and skip to the next number if it is the exclude value
            if (nums[index] == val)
            {
                continue;
            }

            //if it gets here, it isn't the exclude value, so we need to write it to the array.
            nums[arrayWriter] = nums[index];

            //once we have written a value, we need the overwrite pointer to move to the next spot.
            arrayWriter++;
        }

        //the tally is equal to the number of non-excluded digits, so we can just return it
        return arrayWriter;
    }
}