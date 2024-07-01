//*****************************************************************************
//** 1413. Minimum Value to Get Positive Step by Step Sum leetcode           **
//** My first approace was to have several if statements to modify the       **
//** value, after that didn't work out, I just went with a simple loop that  **
//** would restart and increment the starting value to find the first value  **
//** that would produce a positive result                -Dan                **
//*****************************************************************************


int minStartValue(int* nums, int numsSize) {
    int retNum = 1;
    int totVal = 1;
    totVal = retNum;
    for(int i = 0; i < numsSize; i++)
    {
        totVal = totVal + nums[i];
//        printf("nums[%d] = %d and total = %d\n",i,nums[i],totVal);
        if(totVal < 1)
        {
//            printf("Total Value is %d, which is less than 1\n",totVal);
            i = -1;
            retNum++;
            totVal = retNum;
        }
//        printf("totval at i = %d is %d and current return is %d\n",i,totVal,retNum);
    }
    return retNum;
}