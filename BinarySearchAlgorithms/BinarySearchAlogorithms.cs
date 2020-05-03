using System;
namespace CodingExercises
{
    public  class BinarySearchArray{
        public void SearchNumberInArray(int searchItem, int[] searchArray){
            PrintArray(searchArray);
            Console.WriteLine("The search Item is {0}", searchItem.ToString());
            int searchItemIndex = Search(0, searchArray.Length - 1, searchItem, searchArray);
            Console.WriteLine("Item found at index {0}", searchItemIndex);
        }
        public void PrintArray(int[] array){
            int i= 0;
            foreach(var item in array){
                Console.Write("     {0}/[{1}]",item.ToString(), i.ToString());
                i++;
            }
            Console.WriteLine();
        }

        public int Search(int startIndex, int endIndex, int searchItem, int[] searchArray){
            Console.WriteLine("########################### Searching within array indices {0}, {1} ###########################",startIndex.ToString(), endIndex.ToString());
            if(startIndex == endIndex || startIndex > endIndex) return -1;
            if(searchArray[startIndex] == searchItem) return startIndex;
            if(searchArray[endIndex] == searchItem) return endIndex;
            int midIndex = 0;
            if(searchArray[startIndex] < searchItem && searchArray[endIndex] > searchItem){
                midIndex = (startIndex + endIndex) / 2;
                }
                if(searchArray[midIndex] == searchItem) return midIndex;

                if(searchArray[midIndex] < searchItem){
                    startIndex = midIndex + 1;
                    endIndex = endIndex - 1;
                }
                else if(midIndex >= 1){
                    startIndex = startIndex + 1;
                    endIndex = midIndex - 1;
                }
            
                //PrintArray(searchArray[startIndex..endIndex]);
                return Search(startIndex, endIndex, searchItem, searchArray);

        }
        public int FindPivotRotatedSortedArray(int startIndex, int endIndex, int[] rotatedArray){
            // 43/[0]     47/[1]     2/[2]     3/[3]     5/[4]     7/[5]     11/[6]     13/[7]     17/[8]     19/[9]     23/[10]     29/[11]     31/[12] 
            // 13/[0]     17/[1]     19/[2]     23/[3]     29/[4]     31/[5]     37/[6]     41/[7]     43/[8]     47/[9]     2/[10]     3/[11]     5/[12]     7/[13]     11/[14]
            //midIndex is changed after every comparision . Pivot is index where rotatedArray[midIndex +1] < rotatedArray[midIndex]
           // I will check the midpoint. if rotatedArray[startIndex] > rotatedArray[midIndex -1] then findpivot in startIndex, mid - 1 range
           //else find in range midIndex + 1, endINDEX
           Console.WriteLine("########################### Searching within array indices {0}, {1} ###########################",startIndex.ToString(), endIndex.ToString());

                    if(startIndex > endIndex) return -1;
                    if(startIndex == endIndex) return startIndex;
                    int midIndex = (startIndex + endIndex) / 2;

                    if(rotatedArray[midIndex] > rotatedArray[midIndex + 1]){
                        return midIndex;
                    }
                    if(rotatedArray[startIndex] > rotatedArray[midIndex]){
                      return  FindPivotRotatedSortedArray(startIndex, midIndex -1, rotatedArray);
                    }
                    return FindPivotRotatedSortedArray(midIndex +1, endIndex, rotatedArray);
        }
    }
}