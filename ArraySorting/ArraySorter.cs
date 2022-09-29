using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting {
    public class ArraySorter {

        int[] nums = { 10, 2, 3, 70, 200, 1, 0, 7, 4, 100};
        public void Sort() {
            for (int i=0 ;i< nums.Length; i++) {
                for (int a =i+1; a<nums.Length; a++) {
                    if (nums[i] > nums[a]) {
                        int temp = nums[a];
                        nums[a] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }

        

        public void Print() {
            for(int i = 0; i<nums.Length; i++) {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine();
        }

    }
}
