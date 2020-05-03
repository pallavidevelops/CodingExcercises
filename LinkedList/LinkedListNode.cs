
using System;

namespace CodingExcercises{
    public class LLNode{
        public int Value{get; set;}
        public LLNode Next{get; set;}
        public LLNode(int value){
            this.Value = value;
        }
        public LLNode(){

        }
        public static LLNode AddNode(int value, ref LLNode head){
            Console.WriteLine("ADDING node {0} ", value.ToString());
            if(head == null){
                return new LLNode(value);
            }
            var currentNode = head;
            var previousNode = head;
            while(currentNode != null){
                previousNode = currentNode;
               currentNode = currentNode.Next;
            }
            
            previousNode.Next = new LLNode(value); 
            return head;

        }
        
    }
    

    public class LLOperations{
        /*https://leetcode.com/problems/add-two-numbers/
        You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
        You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
        */

        //create two linked lists
    
        public void AddLinkedListsWithCarry(){
            var ll1Node1 = new LLNode(2);
            var ll1Node2 = new LLNode(4);
            ll1Node1.Next = ll1Node2;
            var ll1Node3 = new LLNode(3);
            ll1Node2.Next = ll1Node3;

            var ll2Node1 = new LLNode(5);
            var ll2Node2 = new LLNode(6);
            ll2Node1.Next = ll2Node2;
            var ll2Node3 = new LLNode(4);
            ll2Node2.Next = ll2Node3;

            var head1 = ll1Node1;
            var head2 = ll2Node1;
            int carry = 0;
            int sum = 0;

            PrintNodes(head1);
            PrintNodes(head2);

           var ll3Node1 = new LLNode();
           LLNode head3 = null;
           
        //Add two lls
        while(head1 != null || head2 != null){
            sum = head1.Value + head2.Value + carry;
            if(sum > 9){
                carry = 1;
                sum = sum % 10;
            }
            else{
                carry = 0;
            }
            if(head3 == null){
              head3 = new LLNode(sum);
            }
            else{
                PrintNodes(head3);
                LLNode.AddNode(sum,ref head3);
            }
            head1 = head1.Next;
            head2 = head2.Next;
        }
        PrintNodes(head3);

        }


         public static void PrintNodes(LLNode node){

            while(node != null)
            {
                  Console.Write($"-->{node.Value}");
                  node = node.Next;
            }
            Console.WriteLine();          
        }

    }

}