/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        int x = Rand7() + ((Rand7() - 1) * 7); // 1 - 49

        if(x >= 41){
            return Rand10();
        }

        return (x % 10) + 1;
    }
}