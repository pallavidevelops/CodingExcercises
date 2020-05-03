using System;

namespace CodingExercises
{
    public class Node {
        public int Value{get; set;}
        public Node Next{get; set;}

        public Node(int value){
            this.Value = value;
        }

        public static void PrintNodes(Node node){

            while(node != null)
            {
                  Console.Write($"-->{node.Value}");
                  node = node.Next;
            }
            Console.WriteLine();          
        }
         public static Node CreateLinkedList(int count){
             Random random = new Random();
             Node nextNode = null;
             Node node;
             while(count > 0){
                node = new Node(random.Next(1,100));
                node.Next = nextNode ?? null;
                nextNode = node;                 
                count--;
                if(count == 1) {
                    PrintNodes(node);
                    return node;
                }
             }
             return null;
    }
    public static int CountNodes(Node node){
        int counter = 0;
        while(node != null){
            counter++;
            node = node.Next;
        }
        return counter;
    }
    public static void SortedLinkedList(Node node){
        int max = Int32.MinValue;
        Node maxNode = node;
        Node headNode = node;
        Node previousNode = null;
        Node currentNode = node;
        while(node != null){
            //if max < node.value > max = node.value; 
                    //update the previous node pointer = node.next pointer
                    //update this nodes next pointer to head node, update headNode
                            //if max node is head node--> do nothing
                    //update node= Node.next, prev node

            currentNode = node; 
            if(max < node.Value && maxNode != headNode){
                
                max = node.Value;
                previousNode.Next = node.Next;
                node.Next = headNode;

            }
            previousNode = node;
            node = currentNode.Next;
            Console.WriteLine("Inside loop");
            PrintNodes(headNode);
        }
        PrintNodes(headNode);
    }
    

    }

   
    
}