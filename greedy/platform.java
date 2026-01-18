class Solution {
    public int minPlatform(int arr[], int dep[]) {
        //  code here
        Arrays.sort(arr);
        Arrays.sort(dep);
        
        int n = arr.length;
        int platformsNeeded = 1, maxPlatforms = 1;
        int arrIndex = 1, depIndex = 0;
        
        while(arrIndex < n && depIndex < n){
            if(arr[arrIndex] <= dep[depIndex]){
                platformsNeeded++;
                arrIndex++;
            }
            else {
                platformsNeeded--;
                depIndex++;
            }
            maxPlatforms = Math.max(maxPlatforms, platformsNeeded);
        }
        
        return maxPlatforms;
    }
}