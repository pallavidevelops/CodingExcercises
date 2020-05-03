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
        private void PrintArray(int[] array){
            foreach(var item in array){
                Console.Write("     {0}",item.ToString());
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
                else{
                    startIndex = startIndex + 1;
                    endIndex = midIndex - 1;
                }
            
                  //PrintArray(searchArray[startIndex..endIndex]);
                return Search(startIndex, endIndex, searchItem, searchArray);

        }
    }
}