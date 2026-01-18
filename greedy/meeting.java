class Solution {
    // Function to find the maximum number of meetings that can
    // be performed in a meeting room.
    public int maxMeetings(int start[], int end[]) {
        // add your code here
        int n = start.length;
        
        int[][] meetings = new int[n][2];
        for(int i = 0; i < n; i++){
            meetings[i][0] = start[i];
            meetings[i][1] = end[i];
        }
        
        Arrays.sort(meetings, Comparator.comparingInt(a -> a[1]));
        
        int count = 0;
        int lastEndTime = -1;
        
        for(int[] meeting: meetings){
            if(meeting[0] > lastEndTime){
                count++;
                lastEndTime = meeting[1];
            }
        }
        
        return count;
    }
}