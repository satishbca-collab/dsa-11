class Solution {
    public static int minCost(int[] arr) {
        // code here
        PriorityQueue<Integer> minHeap = new PriorityQueue<>();
        
        for(int rope : arr){
            minHeap.add(rope);
        }
        
        int totalCost = 0;
        while(minHeap.size() > 1){
            int first = minHeap.poll();
            int second = minHeap.poll();
            int sum = first + second;
            totalCost += sum;
            minHeap.add(sum);
        }
        return totalCost;
    }
}