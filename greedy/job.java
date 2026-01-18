class Solution {
    public ArrayList<Integer> jobSequencing(int[] deadline, int[] profit) {
        // code here
        int n = deadline.length;
        Job[] jobs = new Job[n];
        
        for(int i = 0; i < n; i++){
            jobs[i] = new Job(deadline[i], profit[i]);
        }
        
        Arrays.sort(jobs, (a,b) -> b.profit - a.profit);
        
        boolean[] slots = new boolean[n];
        int totalProfit = 0, jobCount = 0;
        
        for(Job job: jobs){
            for(int j = job.deadline-1; j >= 0; j--){
                if(!slots[j]){
                    slots[j] = true;
                    totalProfit += job.profit;
                    jobCount++;
                    break;
                }
            }
        }
        return new ArrayList<>(Arrays.asList(jobCount, totalProfit));
    }
}

class Job {
    int deadline, profit;
    
    Job(int deadline, int profit){
        this.deadline = deadline;
        this.profit = profit;
    }
}

// sort by profit in desc
// maintain a slot array of size n
// accumulate profit from the jobs and reject jobs that cannot
// scheduled