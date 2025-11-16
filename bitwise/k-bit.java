class CheckBit {
    static boolean checkKthBit(int n, int k) {
        // code here
        return ((1 << k) & n) != 0;
        // return ((n >> k) & 1) != 0;
    }
}