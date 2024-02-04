using System;
using System.Text;
namespace SeeSharp{
    internal class LinkedList{
        ListNode head;
        ListNode tail;
        private int Capacity = 100;
        public string Name{set; get;}
        public int Count{
            get{
                int _count = 0;
                ListNode temp = head;
                while(temp != null){
                    _count++;
                    temp = temp.next;
                }
                return _count;
            }
        }

        public void Add(object value){
            if(Count == Capacity){
                throw new Exception("List Capacity Reached Maximum");
            }
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

        public void Remove(int value_int){
            object item = this[value_int];
            Remove(item);
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

        public virtual object this[int i]{
            get{
            ListNode temp = head;
            for(int x = 0 ; temp != null && x<i ; x++){
                temp = temp.next;
            }
            if(temp==null)
                throw new Exception("Wrong index: ");
            return temp.val;
            }
            set{
                this.Add(value);
                /*
                ListNode temp = tail;
                ListNode node = new ListNode(value);
                temp.next = node;
                node.prev = temp;
                tail = tail.next;
                */
            }
        }
    }
}