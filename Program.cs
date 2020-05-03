using System;
using System.Collections.Generic;
using CodingExercises;

namespace CodingExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
             #region  Binary search Sorted Array
                var bs = new BinarySearchArray();
                var primes = new int[]{2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47};
                bs.SearchNumberInArray(17, primes);
            #endregion
             #region merge Two Sorted Arrays
                // var llops = new LLOperations();
                // llops.AddLinkedListsWithCarry();
            #endregion
            #region merge Two Sorted Arrays
                // var mergeSort = new MergeSort();
                // mergeSort.MergeSortExample();
            #endregion
            #region merge Two Sorted Arrays  - Merge Sort Recursive
                // var mergeSort = new MergeSort();
                // int[] a = {3,56,6,2,6,3,45,63,5};
                // mergeSort.RecursiveMergeSort(a);
            #endregion
            #region fibonacii
            // int seriesLength = 2;
            // Int32.TryParse(args[0], out seriesLength);
            // RecursiveFS(seriesLength);
            // Console.ReadKey();      
            #endregion

            #region  Occurrences
            //Count Occurrences - how many times a number can be divided by 2
            // int numberInput = 2;
            // Int32.TryParse(args[0], out numberInput);
            // int i= 0;
            // for(; numberInput > 1; numberInput = numberInput / 2, i++){
            // }
            // Console.WriteLine("Number of times the given number is divisible by 2 is {0}", i);
            // Console.ReadKey();
            // MaxOccurrencesInAnArray();
            #endregion

            #region 1. find maximum consecutive repeating character in string.  Input : str = "aaaaaabbcbbbbbcbbbb"  Output :a
            // MaxConsecutiveOccurrence();
            #endregion

            #region 2. Merge two sorted arrays into one sorted array   int[] A = {1,5,7,12,18,32}  int[] B = {2,4,9,16,27,76,98}
            /*           
                int[] a = {1,5,7,12,18,32,32};
                int[] b = {2,4,9,16,27,76,98};
                Merge2SortedArraysInto1(a,b); Console.ReadKey();
            */
            #endregion

            #region 3. Write a small method  to do the below task.. this is not in sorted order.. all negative characters in left and positive on the right..  input = { 4, -3, 2, -5, 5, -1, 3}  output= {-3,-5, -1, 4, 2, 5, 3}
            // int[] array = {4, -3, 2, -5, 5, -1, 3};
            //NegLeftPosRight(array); Console.ReadKey();        
            #endregion

            #region 4. Segregate 0s on left side and 1s on right side of the array. Traverse array only once. Input array   =  [0, 1, 0, 1, 0, 0, 1, 1, 1, 0] Output array =  [0, 0, 0, 0, 0, 1, 1, 1, 1, 1]
            //SegregateZerosAndOnes();
            #endregion

            #region 18. Tow Sum Problem, 5. Given an unsorted array and a number n, find if there exists a pair of elements in the array whose difference is n. Examples:  Input: arr[] = {9, 29,10, 2, 50, 24, 100}, n = 50  Output: Pair Found: (50, 100)
                //var resultArray = DiffArray_O_n_2(); PrintArray(resultArray);
                //  PairsInArrayUsingDictionary_O_n();  Console.Read();
                //var tuple = PairInArrayUsingDictionary_O_n(); Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
            #endregion

            #region 6. Write a simple code for finding the most repeated character in given string, 14. Most Frequent Element in an array, 17. Most frequent number in an array, 19. Most frequent element in an array
                              
            //   int count = CountOccurrencesInAString(args[0], 'a');
            //   Console.WriteLine("Number of times the given character is seen in the string is {0}", count);
            //   Console.ReadKey();
            #endregion

            #region 7.  write a simple function to check if the Binary Tree is a Binary Search Tree.

            #endregion
    
            #region 8. Tic tac toe 3x3 solving

            #endregion

            #region 9. Tic tac toe check winner
            //TicTacToe tictac = new TicTacToe();
            //TicTacToe.PlayTicTacToe();
            //CheckTicTacWinner();// using inner method

            #endregion

            #region 10. Write a helper function to return input array data in small chunks by replacing \n with \r\n.

            #endregion

            #region 11. Combination of 3 numbers to match sum in array
            #endregion

            #region 12. Write a function to reverse the order of words in a string ?
            #endregion

            #region 13. Write a function to check if two strings are anagrams or not ?
            #endregion

            #region 16. Function to print the Factorial of a given number
            #endregion

            #region 20. Check whether the string is unique or not.
            #endregion

            #region 21. Swap numbers without addl variable
            #endregion

            #region 22. consider there is a large array
                // char[] Input = new char[10000]; {a,b,\n,c,d,e,\n,f,g,\n,h,\n.........}
                // char[] output = new char[4];
                // When the input array has '/n' we should return it as '\r ' '\n' as two separate characters.
            #endregion

            #region 23. find the length of the longest substring without repeating characters, input string s = "abcabcbb", output abc
            #endregion

            #region 27. Write a function that parses an input buffer and sends output of the size of output array. We should also return the position of the input buffer and the size used in the output array.
            #endregion

            // var node1 = new Node(14);
            // var node2 = new Node(1);

            // node1.Next = node2;
            
            // var node3 = new Node(23);

            // node2.Next = node3;

            // var node4 = new Node(3);

            // node3.Next = node4;

            // Node.PrintNodes(node1);

        //    Node node1 = Node.CreateLinkedList(10);
        //    Node node2 = Node.CreateLinkedList(8);

        //    MergeTwoLinkedLists(node1, node2);

        //    BubbleSort_LinkedList(node1);



        }

        private static void BubbleSort_LinkedList(Node node1)
        {
        //     int counter = Node.CountNodes(node1);
        //    Node.SortedLinkedList(node1);
        }

        private static void MergeTwoLinkedLists(Node node1, Node node2)
        {
            Node newHead = node1;
            Node lastNode = null;
           while(node1 != null){
               lastNode = node1;
               node1 = node1.Next;
           }
           lastNode.Next = node2;

           Node.PrintNodes(newHead);
        }

        static void RecursiveFibonacciSeries( int counter, int lastNumber = 1, int currentNumber = 0)
        {
            if(counter == 0){
                return;
            }
            int temp = lastNumber;  
            lastNumber = currentNumber;
            currentNumber = temp + currentNumber;
            Console.WriteLine(" {0} - {1}", currentNumber, counter);
            counter--;
            RecursiveFibonacciSeries(counter, lastNumber, currentNumber);
        }
        private static void MaxConsecutiveOccurrence()
        {
            String str = "aaaaaabbcbbbbbcbbbb";
            Char[] charArray = str.ToCharArray();
                int length = charArray.Length;
                int count = 1;
                Dictionary<Char, int> charCountDict = new Dictionary<Char, int>();
            for(int i = 0; i < length-1; i++){
                if(charArray[i] == charArray[i+1]){
                    count++;
                    if(charCountDict.ContainsKey(charArray[i])){
                        if(charCountDict[charArray[i]] < count){
                            charCountDict[charArray[i]] = count;
                        }
                    }
                    else{
                        charCountDict.Add(charArray[i],count);
                    }
                }
                else{
                    count = 1;
                }
            }
        //    PrintDictionary(charCountDict);

            int max = 0;
            Char char1 = Char.MinValue;
            foreach(var item in charCountDict){
                if(item.Value > max){
                        max = item.Value;
                        char1 = item.Key;               
                }               
            }
            Console.WriteLine($"The max consecutive repeated character is {char1} and repeated {max} times.");
            
        }
        private static void PrintDictionary(Dictionary<char, int> charintDict)
        {
            foreach(var item in charintDict){
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void PairsInArrayUsingDictionary_O_n(){
                int[] array = new int[]{0,9,29,10,2,50,24,100};
                int diff = 50, arrayLength = array.Length;
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                List<Tuple<int, int>> resultPairs = new List<Tuple<int,int>>();

                for(int i = 0; i < arrayLength; i++){
                    if(dictionary.ContainsKey(array[i])){
                        resultPairs.Add(new Tuple<int, int>(array[i],dictionary[array[i]]));
                        dictionary.Add(array[i] + diff, array[i]);
                    }
                    else{
                        dictionary.Add(array[i] + diff, array[i]);
                    }
                }
                PrintTupleList(resultPairs);
        }
        public static Tuple<int, int> PairInArrayUsingDictionary_O_n(){
                int[] array = new int[]{9,29,10,2,50,24,100};
                int diff = 50, arrayLength = array.Length;
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                Tuple<int, int> resultPair =  new Tuple<int, int>(0,0);

                for(int i = 0; i < arrayLength; i++){
                    if(dictionary.ContainsKey(array[i])){
                        resultPair = new Tuple<int, int>(array[i], dictionary[array[i]]);                       
                    }
                    else{
                        dictionary.Add(array[i] + diff, array[i]);                        
                    }                 
                }
                return resultPair;
                
        }
        public static void PrintTupleList(List<Tuple<int, int>> result){
            foreach(var item in result){
                Console.WriteLine("{0} - {1}", item.Item1, item.Item2);
            }
        }

        private static int[] PairsInArray_O_n_2()
        {
            int[] array = { 9, 29, 10, 2, 50, 24, 100 };
            int arrayLength = array.Length, diff = 50;
            int[] pairWithdiff = new int[2];
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (i != j && Math.Abs(array[i] - array[j]) == diff)
                    {
                        pairWithdiff = new int[] { array[i], array[j] };
                        return pairWithdiff;
                    }                  
                }
            }
            return pairWithdiff;
        }

        private static void SegregateZerosAndOnes()
        {
            int[] array = { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0 };

            int currentIndex = 0, zeroIndex = 0, arrayLength = array.Length, temp;
            PrintArray(array);
            while (currentIndex < arrayLength)
            {
                if (array[currentIndex] == 0)
                {
                    //swap current index with zero index item
                    //increment zeroIndex
                    temp = array[currentIndex];
                    array[currentIndex] = array[zeroIndex];
                    array[zeroIndex] = temp;
                    zeroIndex++;
                }
                PrintArray(array);

                currentIndex++;
            }
        }

        static void NegLeftPosRight(int[] array)
        {
            NegLeftPosRightUsingStack(array);
            NegLeftPosRightUsingSwapping(array);
            NegLeftPosRightUsingSwapping0n2(array);
            // int[] array = {4, -3, 2, -5, 5, -1, 3};
            // int[] resultArray = {-3,-5, -1, 4, 2, 5, 3};
            // int temp;

            //NOT WORKING
            //NegLeftPosRightUsingLinkedList(array);

        }

        private static void NegLeftPosRightUsingLinkedList(int[] array)
        {
            // var linkedList = new LinkedList<int>(array);
            // LinkedListNode<int> negNode = linkedList.First;            
            // var headNode = linkedList.First;
            // var currentNode = linkedList.First;
            // var tempPrev, tempNext, tempValue;

            // int[] array = {4, -3, 2, -5, 5, -1, 3};
            // int[] resultArray = {-3,-5, -1, 4, 2, 5, 3};
            // 4-->-3--> 2--> -5--> 5--> -1 --> 3
            // while (currentNode != null)
            // {
                // if(currentNode.Value < 0){
                //     if(currentNode != headNode) {
                            
                //              tempPrev = currentNode.Previous;
                //              tempValue = currentNode.Value;
                //              tempNext = currentNode.Next;

                //        //swap neg node and current node by updating links
                //         currentNode. = negNode.Previous;
                //         currentNode.Value = negNode.Value;
                //         currentNode.Next = negNode.Next;
                // }
                // currentNode = currentNode.Next;
                // PrintLinkedList(linkedList);
        // }
        }

        private static void NegLeftPosRightUsingSwapping0n2(int[] array)
        {   int arrayLength = array.Length;
            int temp;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        PrintArray(array);
                        break;
                    }
                }
            }
        }

        private static void NegLeftPosRightUsingSwapping(int[] array)
        {
            // O(n)
            int arrayLength = array.Length;
            int arrayIndex = 1, negIndex = 0;
            int temp;
            while (arrayIndex < arrayLength)
            {
                if (array[arrayIndex] < 0)
                {
                    temp = array[negIndex];
                    array[negIndex] = array[arrayIndex];
                    array[arrayIndex] = temp;
                    negIndex++;
                    PrintArray(array);
                }
                arrayIndex++;
            }
        }

        private static void NegLeftPosRightUsingStack(int[] array)
        {
            int arrayLength = array.Length;
            var stack = new Stack<int>();
            int arrayIndex = arrayLength -1;
            
            while( arrayIndex >= 0)
            {
                if(array[arrayIndex]> 0){
                stack.Push(array[arrayIndex]);              
                }               
                PrintStack(stack);
                arrayIndex--;
            }
            arrayIndex = arrayLength - 1;
            while( arrayIndex >= 0)
            {
                if(array[arrayIndex]<0){
                stack.Push(array[arrayIndex]);
                }               
                PrintStack(stack);
                arrayIndex--;
            }
            PrintStack(stack);
        }

        private static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item.ToString()+ " ");
            }
            Console.WriteLine();
        }

        private static void PrintLinkedList(LinkedList<int> linkedList)
        {
            foreach(var item in linkedList){
                Console.Write(item.ToString());
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] array){
            if(array == null)  Console.WriteLine("Empty Array");
            int arrayLength = array.Length;
                for(int k = 0; k < arrayLength; k++){
                Console.Write(" {0} ", array[k]);
            }
            Console.WriteLine();
        }

        static void Merge2SortedArraysInto1(int[] a, int[] b)
        {
            
            int aIndex=0, bIndex=0, cIndex = 0;
            int aLength = a.Length, bLength = b.Length;
            int[] c = new int[aLength + bLength];
    //check if a and b index are lesser than their lengths
            while(aIndex < aLength && bIndex < bLength){
            // check if a[aI] < b[bI] update c[cI] = a[aI] then increment aI and cI
            //else  c[cI] = b[bI] increment bI and cI        
                if(a[aIndex] < b[bIndex]) {
                    c[cIndex] = a[aIndex];
                    cIndex++;
                    aIndex++;
                }  
                else{
                    c[cIndex] = b[bIndex];
                    cIndex++;
                    bIndex++;
                }  
            }
            while(aIndex < aLength){
                c[cIndex] = a[aIndex];
                cIndex++;
                aIndex++;
            }
            while(bIndex < bLength){
                c[cIndex] = b[bIndex];
                cIndex++;
                bIndex++;
            }
            foreach(int i in c){
                Console.WriteLine(" {0} ", i);
            }
        }

        static int CountOccurrencesInAString(string inputString, char character){
            
            var stringArray = inputString.ToCharArray();
            int count = 0;
            for(int i = 0; i < stringArray.Length ; i++){
                if((char)stringArray[i] == (char)character){
                    count = count +1;
                }
            }
            return count;
        }

        static void MaxOccurrencesInAnArray()
        {
            var array = new []{2,1,4,67,2,12,1,3,1,2};
            var arrayLength = array.Length;
            var countSequence = new Dictionary<int, int>();
                for(int i = 0; i < arrayLength; i++){
                    if(countSequence.ContainsKey(array[i]))
                    {
                        countSequence[array[i]]++;
                    }
                    else{
                        countSequence.Add(array[i],1);
                    }
                }
            int maxCountKey = Int32.MinValue;
            var maxCountValue  = 0;
            
                foreach(var keyValue in countSequence){
                    if(keyValue.Value > maxCountValue){
                            maxCountKey = keyValue.Key;
                            maxCountValue = keyValue.Value;
                    }
                }
                Console.WriteLine("The max occurrences of {0} is {1} times", maxCountKey ,maxCountValue);
                Console.ReadKey();
        }
    }
}
