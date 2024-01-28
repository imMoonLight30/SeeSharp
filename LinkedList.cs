using System;
using System.Text;
namespace SeeSharp{
    internal class LinkedList{
        ListNode head;
        ListNode tail;

        public void Add(object value){
            if(head == null){
                ListNode node = new ListNode(value);
                head = node;
                tail = node;
            }else{
                ListNode node = new ListNode(value);
                node.prev = tail;
                tail.next = node;
                tail = tail.next;
            }
        }

        public void Remove(object value){
            if(head == null){
                throw new Exception("Empty Linked List");
            }else{
                ListNode temp = head;
                while(temp != null && temp.val != value){
                    temp =temp.next;
                }
                if(temp == null ){
                    throw new Exception(value+" is not present");
                }
                ListNode previous = temp.prev;
                previous.next = temp.next;
            }
        }

        public object First(){
            if(head == null){
                throw new Exception("List is empty");
            }
            return head.val;
        }
        public object Last(){
            if(tail == null){
                throw new Exception("List is empty");
            }
            return tail.val;
        }

        public override string ToString(){
            StringBuilder builder = new StringBuilder();
            if(head == null){
                return string.Empty;
            }
            ListNode temp = head;
            while(temp != null){
                builder.Append(temp.val.ToString()+" \r\n");
                temp = temp.next;
            }
            return builder.ToString();
        }
    }
}