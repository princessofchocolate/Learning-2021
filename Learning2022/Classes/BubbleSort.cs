using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2022.Classes {
    public class BubbleSort {
        int[] data;

        public BubbleSort(int[] data) {
            this.data = data;
        }
        public void Print() {
            for (int i = 0; i < data.Length; i++) {
                System.Diagnostics.Debug.Write(data[i] + ", ");
            }
            System.Diagnostics.Debug.WriteLine("");
        }
        public void Modify(int startIndex, int endIndex) {

            if ((startIndex > data.Length) ||
                (startIndex > endIndex) ||
                (startIndex < 0) ||
                (endIndex > data.Length) ||
                (endIndex < 0)) {
                System.Diagnostics.Debug.WriteLine("error");
                return;
            }
            for (int i = startIndex; i < endIndex; i++) {
                if (data[i] > data[i + 1]) {
                    int temp = data[i];
                    data[i] = data[i + 1];
                    data[i + 1] = temp;
                }
                System.Diagnostics.Debug.Write("\t\t\t");
                Print();
            }
        }

        public void MultiModify() {
            for (int i = 0; i<data.Length - 1; i++) {
                Modify(0, data.Length - i - 1);
                System.Diagnostics.Debug.Write("\t");
                Print();
            }
        }

        public void Sort() {

            for (int i = 0; i < data.Length - 1; i++) {

                for (int j = 0; j < data.Length - i - 1; j++) {

                    if (data[j] > data[j + 1]) {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                    
                }
                
            }
        }
    }
}
