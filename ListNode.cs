namespace SeeSharp{
    internal class ListNode{
        public object val;
        public ListNode next;
        public ListNode prev;

        public ListNode(object val){
            this.val = val;
            next = null;
            prev = null;
        }
    }
}