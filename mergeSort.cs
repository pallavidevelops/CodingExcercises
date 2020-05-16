using System;
namespace CodingExercises{
public class MergeSort{
public void MergeSortExample(){
    var firstArray = new int[]{1,3,4,6,9};
    var secondArray = new int[]{5,6,8,11,12};
    PrintArray(firstArray);
    PrintArray(secondArray);
    var result = MergeSortedArrays(firstArray, secondArray);
    PrintArray(result);
}
private int[] MergeSortedArrays(int[] firstArray, int[] secondArray){
    int firstArrayLength = firstArray.Length, secondArrayLength = secondArray.Length;
    int [] resultArray = new int[firstArrayLength + secondArrayLength];
    if(firstArrayLength == 0 && secondArrayLength == 0){
        return resultArray;
    }
    if(firstArrayLength == 0){
        return secondArray;
    }
    if(secondArrayLength == 0){
        return firstArray;
    }
    int resultArrayIndex = resultArray.Length - 1;
    firstArrayLength--;
    secondArrayLength--;
    while(firstArrayLength >= 0 || secondArrayLength >= 0){
        if(firstArrayLength >= 0 && secondArrayLength >= 0 ){
                if(firstArray[firstArrayLength] > secondArray[secondArrayLength]){
                resultArray[resultArrayIndex] = firstArray[firstArrayLength];
                firstArrayLength--;
                }
                else { 
                    resultArray[resultArrayIndex] = secondArray[secondArrayLength];
                    secondArrayLength--;
                }
        }
       else{
           if(firstArrayLength >= 0 && secondArrayLength < 0){
            resultArray[resultArrayIndex] = firstArray[firstArrayLength];
            firstArrayLength--;
        }
        if(secondArrayLength >= 0 && firstArrayLength < 0){
            resultArray[resultArrayIndex] = secondArray[secondArrayLength];
            secondArrayLength--;
        }
       } 
        PrintArray(resultArray);
        resultArrayIndex--; 
    }
    return resultArray;
}                           
public int[] RecursiveMergeSort(int[] arrayToSort){
     Console.WriteLine("<--------------------Input Array------------------->");
    PrintArray(arrayToSort);
    if(arrayToSort.Length == 1){
        return arrayToSort;
    }
    int midArrayIndex = arrayToSort.Length / 2;
    var leftArray = new int[midArrayIndex];
    int[] rightArray;
    if(arrayToSort.Length % 2 == 0){
        rightArray = new int[midArrayIndex];
    }
    else{
        rightArray = new int[midArrayIndex + 1];
    }

    for(int i = 0; i < midArrayIndex; i++){
        leftArray[i] = arrayToSort[i];
    }
    int j = 0;
    for(int i = midArrayIndex; i < arrayToSort.Length ; i++ ){

        rightArray[j] = arrayToSort[i];
        j++;
    }
    Console.WriteLine("<---------------Left Array-------------->");
    PrintArray(leftArray);
    Console.WriteLine("<--------------Right Array-------------->");
    PrintArray(rightArray);

    leftArray = RecursiveMergeSort(leftArray);
    rightArray = RecursiveMergeSort(rightArray);
    return MergeSortedArrays(leftArray, rightArray);
    
}
static void PrintArray(int[] array){
            if(array == null)  Console.WriteLine("Empty Array");
            int arrayLength = array.Length;
                for(int k = 0; k < arrayLength; k++){
                Console.Write(" {0} ", array[k]);
            }
            Console.WriteLine();
    
    }


    
private static int temp{get; set;}
public int[] MergeReversedSegmentsInArray(int[] array, int segmentLength, int startIndex, int endIndex){
            // int n = 2;
                        //         10 20 30 40 50 60 70
                        //         20 10 40 30 60 50 70
                        //         1  0  3  2  5  4
            // startIndex = 0 , endIndex = segmentLength - 1
             Console.WriteLine($"<--------------------{startIndex}, {endIndex}-------------------->");
            int midSegmentIndex = (startIndex + endIndex)/2;
            int count= 0;
            for(int i = startIndex; i <= midSegmentIndex; i++){
                temp = array[i];
                array[i] = array[endIndex- count];
                array[endIndex -count] = temp;
                count++;
                Console.WriteLine($"<-----------------{startIndex}, {endIndex}----------------->");
                PrintArray(array);
            }
            
            startIndex = endIndex + 1;
            if(startIndex >= array.Length){ //array is rearranged
                return array;
            }
            endIndex = startIndex + segmentLength -1;
            if(endIndex >= array.Length){
                endIndex = array.Length -1;
            }
            return MergeReversedSegmentsInArray(array, segmentLength, startIndex, endIndex);

        }



}

}