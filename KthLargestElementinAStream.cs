public class KthLargest {

    //https://www.geeksforgeeks.org/c-sharp/c-priorityqueue/
    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.priorityqueue-2?view=net-10.0
    PriorityQueue<int,int> queue = new PriorityQueue<int, int>();
    int kth = 1;
    public KthLargest(int k, int[] nums) {
        kth = k;
        foreach (var item in nums)
        {
            Add(item);
        }


    }
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if(queue.Count > kth)
        {
            queue.Dequeue();
        }
    return queue.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */